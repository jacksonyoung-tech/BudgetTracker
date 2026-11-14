namespace BudgetTracker
{
    partial class BudgetTracker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblIncome = new Label();
            lblWeeklyBills = new Label();
            lblBills = new Label();
            lstBills = new ListBox();
            txtIncome = new TextBox();
            txtAmount = new TextBox();
            btnAdd = new Button();
            btnCalculate = new Button();
            txtCalculate = new TextBox();
            btnClear = new Button();
            btnRemove = new Button();
            lblAmount = new Label();
            lblDescription = new Label();
            txtDescription = new TextBox();
            dtpDueDate = new DateTimePicker();
            lblIncomeAmount = new Label();
            lblPayFrequency = new Label();
            cmbPayFrequency = new ComboBox();
            lblPayDate = new Label();
            dtpPayDate = new DateTimePicker();
            lblDueDate = new Label();
            cmbBillFrequency = new ComboBox();
            lblBillFrequency = new Label();
            SuspendLayout();
            // 
            // lblIncome
            // 
            lblIncome.AutoSize = true;
            lblIncome.Location = new Point(91, 52);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(132, 25);
            lblIncome.TabIndex = 0;
            lblIncome.Text = "Weekly Income";
            // 
            // lblWeeklyBills
            // 
            lblWeeklyBills.AutoSize = true;
            lblWeeklyBills.Location = new Point(64, 100);
            lblWeeklyBills.Margin = new Padding(2, 0, 2, 0);
            lblWeeklyBills.Name = "lblWeeklyBills";
            lblWeeklyBills.Size = new Size(69, 15);
            lblWeeklyBills.TabIndex = 1;
            lblWeeklyBills.Text = "Weekly Bills";
            // 
            // lblBills
            // 
            lblBills.AutoSize = true;
            lblBills.Location = new Point(65, 204);
            lblBills.Margin = new Padding(2, 0, 2, 0);
            lblBills.Name = "lblBills";
            lblBills.Size = new Size(28, 15);
            lblBills.TabIndex = 2;
            lblBills.Text = "Bills";
            lblBills.Click += label3_Click;
            // 
            // lstBills
            // 
            lstBills.FormattingEnabled = true;
            lstBills.HorizontalScrollbar = true;
            lstBills.Location = new Point(64, 231);
            lstBills.Margin = new Padding(2, 2, 2, 2);
            lstBills.Name = "lstBills";
            lstBills.ScrollAlwaysVisible = true;
            lstBills.Size = new Size(312, 199);
            lstBills.TabIndex = 3;
            // 
            // txtIncome
            // 
            txtIncome.Location = new Point(64, 56);
            txtIncome.Margin = new Padding(2, 2, 2, 2);
            txtIncome.Name = "txtIncome";
            txtIncome.Size = new Size(106, 23);
            txtIncome.TabIndex = 4;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(593, 162);
            txtAmount.Margin = new Padding(2, 2, 2, 2);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(106, 23);
            txtAmount.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(722, 162);
            btnAdd.Margin = new Padding(2, 2, 2, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(418, 434);
            btnCalculate.Margin = new Padding(2, 2, 2, 2);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(78, 20);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtCalculate
            // 
            txtCalculate.Location = new Point(418, 231);
            txtCalculate.Margin = new Padding(2, 2, 2, 2);
            txtCalculate.Multiline = true;
            txtCalculate.Name = "txtCalculate";
            txtCalculate.ReadOnly = true;
            txtCalculate.Size = new Size(311, 199);
            txtCalculate.TabIndex = 8;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(146, 434);
            btnClear.Margin = new Padding(2, 2, 2, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(78, 20);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(64, 434);
            btnRemove.Margin = new Padding(2, 2, 2, 2);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(78, 20);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "Remove Bill";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(581, 129);
            lblAmount.Margin = new Padding(2, 0, 2, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(51, 15);
            lblAmount.TabIndex = 11;
            lblAmount.Text = "Amount";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(65, 129);
            lblDescription.Margin = new Padding(2, 0, 2, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 12;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(64, 162);
            txtDescription.Margin = new Padding(2, 2, 2, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(106, 23);
            txtDescription.TabIndex = 13;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(194, 162);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(206, 23);
            dtpDueDate.TabIndex = 15;
            // 
            // lblIncomeAmount
            // 
            lblIncomeAmount.AutoSize = true;
            lblIncomeAmount.Location = new Point(64, 23);
            lblIncomeAmount.Margin = new Padding(2, 0, 2, 0);
            lblIncomeAmount.Name = "lblIncomeAmount";
            lblIncomeAmount.Size = new Size(94, 15);
            lblIncomeAmount.TabIndex = 16;
            lblIncomeAmount.Text = "Income Amount";
            // 
            // lblPayFrequency
            // 
            lblPayFrequency.AutoSize = true;
            lblPayFrequency.Location = new Point(202, 23);
            lblPayFrequency.Margin = new Padding(2, 0, 2, 0);
            lblPayFrequency.Name = "lblPayFrequency";
            lblPayFrequency.Size = new Size(84, 15);
            lblPayFrequency.TabIndex = 17;
            lblPayFrequency.Text = "Pay Frequency";
            // 
            // cmbPayFrequency
            // 
            cmbPayFrequency.FormattingEnabled = true;
            cmbPayFrequency.Location = new Point(187, 56);
            cmbPayFrequency.Margin = new Padding(2, 2, 2, 2);
            cmbPayFrequency.Name = "cmbPayFrequency";
            cmbPayFrequency.Size = new Size(145, 23);
            cmbPayFrequency.TabIndex = 18;
            cmbPayFrequency.Text = "-- Select Frequency --";
            // 
            // lblPayDate
            // 
            lblPayDate.AutoSize = true;
            lblPayDate.Location = new Point(347, 23);
            lblPayDate.Margin = new Padding(2, 0, 2, 0);
            lblPayDate.Name = "lblPayDate";
            lblPayDate.Size = new Size(53, 15);
            lblPayDate.TabIndex = 19;
            lblPayDate.Text = "Pay Date";
            // 
            // dtpPayDate
            // 
            dtpPayDate.Location = new Point(347, 57);
            dtpPayDate.Name = "dtpPayDate";
            dtpPayDate.Size = new Size(206, 23);
            dtpPayDate.TabIndex = 20;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(187, 129);
            lblDueDate.Margin = new Padding(2, 0, 2, 0);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(55, 15);
            lblDueDate.TabIndex = 21;
            lblDueDate.Text = "Due Date";
            // 
            // cmbBillFrequency
            // 
            cmbBillFrequency.FormattingEnabled = true;
            cmbBillFrequency.Location = new Point(427, 162);
            cmbBillFrequency.Margin = new Padding(2);
            cmbBillFrequency.Name = "cmbBillFrequency";
            cmbBillFrequency.Size = new Size(145, 23);
            cmbBillFrequency.TabIndex = 22;
            cmbBillFrequency.Text = "-- Select Frequency --";
            // 
            // lblBillFrequency
            // 
            lblBillFrequency.AutoSize = true;
            lblBillFrequency.Location = new Point(427, 129);
            lblBillFrequency.Margin = new Padding(2, 0, 2, 0);
            lblBillFrequency.Name = "lblBillFrequency";
            lblBillFrequency.Size = new Size(81, 15);
            lblBillFrequency.TabIndex = 23;
            lblBillFrequency.Text = "Bill Frequency";
            // 
            // BudgetTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 702);
            Controls.Add(lblBillFrequency);
            Controls.Add(cmbBillFrequency);
            Controls.Add(lblDueDate);
            Controls.Add(dtpPayDate);
            Controls.Add(lblPayDate);
            Controls.Add(cmbPayFrequency);
            Controls.Add(lblPayFrequency);
            Controls.Add(lblIncomeAmount);
            Controls.Add(dtpDueDate);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(lblAmount);
            Controls.Add(btnRemove);
            Controls.Add(btnClear);
            Controls.Add(txtCalculate);
            Controls.Add(btnCalculate);
            Controls.Add(btnAdd);
            Controls.Add(txtAmount);
            Controls.Add(txtIncome);
            Controls.Add(lstBills);
            Controls.Add(lblBills);
            Controls.Add(lblWeeklyBills);
            Margin = new Padding(2, 2, 2, 2);
            Name = "BudgetTracker";
            Text = "Budget Tracker";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIncome;
        private Label lblWeeklyBills;
        private Label lblBills;
        private ListBox lstBills;
        private TextBox txtIncome;
        private TextBox txtAmount;
        private Button btnAdd;
        private Button btnCalculate;
        private TextBox txtCalculate;
        private Button btnClear;
        private Button btnRemove;
        private Label lblAmount;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblDate;
        private DateTimePicker dtpDueDate;
        private Label lblIncomeAmount;
        private Label lblPayFrequency;
        private ComboBox cmbPayFrequency;
        private Label lblPayDate;
        private DateTimePicker dtpPayDate;
        private Label lblDueDate;
        private ComboBox cmbBillFrequency;
        private Label lblBillFrequency;
    }
}
