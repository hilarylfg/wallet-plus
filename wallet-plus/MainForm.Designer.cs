namespace wallet_plus
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            incomeTextBox = new System.Windows.Forms.TextBox();
            expenseDataGridView = new System.Windows.Forms.DataGridView();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            calculateButton = new System.Windows.Forms.Button();
            reportTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            expenseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)expenseDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)expenseChart).BeginInit();
            SuspendLayout();
            // 
            // incomeTextBox
            // 
            incomeTextBox.Location = new System.Drawing.Point(117, 23);
            incomeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            incomeTextBox.Name = "incomeTextBox";
            incomeTextBox.Size = new System.Drawing.Size(233, 23);
            incomeTextBox.TabIndex = 0;
            // 
            // expenseDataGridView
            // 
            expenseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            expenseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            expenseDataGridView.Location = new System.Drawing.Point(23, 69);
            expenseDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            expenseDataGridView.Name = "expenseDataGridView";
            expenseDataGridView.Size = new System.Drawing.Size(467, 231);
            expenseDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Категория";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Сумма";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // calculateButton
            // 
            calculateButton.Location = new System.Drawing.Point(23, 323);
            calculateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new System.Drawing.Size(467, 35);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Рассчитать";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // reportTextBox
            // 
            reportTextBox.Location = new System.Drawing.Point(23, 381);
            reportTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            reportTextBox.Multiline = true;
            reportTextBox.Name = "reportTextBox";
            reportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            reportTextBox.Size = new System.Drawing.Size(467, 172);
            reportTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(23, 27);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 15);
            label1.TabIndex = 4;
            label1.Text = "Доход:";
            // 
            // expenseChart
            // 
            expenseChart.Location = new System.Drawing.Point(538, 69);
            expenseChart.Name = "expenseChart";
            expenseChart.Size = new System.Drawing.Size(400, 484);
            expenseChart.TabIndex = 5;
            expenseChart.Text = "Расходы по категориям";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(971, 577);
            Controls.Add(label1);
            Controls.Add(reportTextBox);
            Controls.Add(calculateButton);
            Controls.Add(expenseDataGridView);
            Controls.Add(incomeTextBox);
            Controls.Add(expenseChart);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Text = "Wallet+";
            ((System.ComponentModel.ISupportInitialize)expenseDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)expenseChart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox incomeTextBox;
        private System.Windows.Forms.DataGridView expenseDataGridView;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox reportTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart expenseChart;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}