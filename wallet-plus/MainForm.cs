using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace wallet_plus
{
    public partial class MainForm : Form
    {
        private readonly Dictionary<string, decimal> expenses = new Dictionary<string, decimal>();

        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(incomeTextBox.Text, out decimal income) || income <= 0)
            {
                MessageBox.Show(@"Введите корректный доход.");
                return;
            }

            expenses.Clear();
            foreach (DataGridViewRow row in expenseDataGridView.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    string category = row.Cells[0].Value.ToString().Trim();

                    if (string.IsNullOrEmpty(category))
                    {
                        MessageBox.Show(@"Категория не должна быть пустой.");
                        continue;
                    }

                    if (decimal.TryParse(row.Cells[1].Value.ToString(), out decimal amount) && amount > 0)
                    {
                        expenses[category] = amount;
                    }
                }
            }

            decimal totalExpenses = expenses.Values.Sum();
            decimal freeFunds = income - totalExpenses;

            StringBuilder reportBuilder = new StringBuilder();

            reportBuilder.AppendLine(totalExpenses > income * 0.8m
                ? "Ваши расходы составляют более 80% дохода! Рекомендуется сократить затраты."
                : "Ваши расходы в норме.");

            foreach (var kvp in expenses)
            {
                if (kvp.Value > income * 0.3m)
                {
                    reportBuilder.AppendLine(
                        $"В категории \"{kvp.Key}\" расходы составляют {kvp.Value}, что более 30% от дохода. Подумайте об оптимизации.");
                }
            }

            reportBuilder.AppendLine($"Свободные средства: {freeFunds}");

            reportTextBox.Text = reportBuilder.ToString();
            ShowExpenseChart(freeFunds);
            SaveData();
        }

        private void ShowExpenseChart(decimal freeFunds)
        {
            expenseChart.Series.Clear();

            if (expenseChart.ChartAreas.Count == 0)
            {
                expenseChart.ChartAreas.Add(new ChartArea());
            }

            var series = expenseChart.Series.Add("Расходы");
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true;

            foreach (var kvp in expenses)
            {
                series.Points.AddXY(kvp.Key, kvp.Value);
            }

            series.Points.AddXY("Свободные средства", freeFunds);

            foreach (var point in series.Points)
            {
                point.Label = point.AxisLabel + ": " + point.YValues[0];
            }
        }

        private void SaveData()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("budgetData.txt"))
                {
                    writer.WriteLine(incomeTextBox.Text);
                    foreach (var kvp in expenses)
                    {
                        writer.WriteLine($"{kvp.Key};{kvp.Value}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Ошибка сохранения данных: {ex.Message}");
            }
        }

        private void LoadData()
        {
            try
            {
                if (File.Exists("budgetData.txt"))
                {
                    using (StreamReader reader = new StreamReader("budgetData.txt"))
                    {
                        incomeTextBox.Text = reader.ReadLine();
                        expenses.Clear();
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            var parts = line.Split(';');
                            if (parts.Length == 2 && decimal.TryParse(parts[1], out decimal amount))
                            {
                                expenses[parts[0]] = amount;
                            }
                        }

                        expenseDataGridView.Rows.Clear();
                        foreach (var kvp in expenses)
                        {
                            expenseDataGridView.Rows.Add(kvp.Key, kvp.Value);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Ошибка загрузки данных: {ex.Message}");
            }
        }
    }
}