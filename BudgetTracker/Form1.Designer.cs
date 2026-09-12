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
            SuspendLayout();
            // 
            // lblIncome
            // 
            lblIncome.AutoSize = true;
            lblIncome.Location = new Point(64, 31);
            lblIncome.Margin = new Padding(2, 0, 2, 0);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(88, 15);
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
            lstBills.Margin = new Padding(2);
            lstBills.Name = "lstBills";
            lstBills.ScrollAlwaysVisible = true;
            lstBills.Size = new Size(312, 199);
            lstBills.TabIndex = 3;
            // 
            // txtIncome
            // 
            txtIncome.Location = new Point(64, 56);
            txtIncome.Margin = new Padding(2);
            txtIncome.Name = "txtIncome";
            txtIncome.Size = new Size(106, 23);
            txtIncome.TabIndex = 4;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(405, 162);
            txtAmount.Margin = new Padding(2);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(106, 23);
            txtAmount.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(544, 165);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 20);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(418, 434);
            btnCalculate.Margin = new Padding(2);
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
            txtCalculate.Margin = new Padding(2);
            txtCalculate.Multiline = true;
            txtCalculate.Name = "txtCalculate";
            txtCalculate.ReadOnly = true;
            txtCalculate.Size = new Size(311, 199);
            txtCalculate.TabIndex = 8;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(146, 434);
            btnClear.Margin = new Padding(2);
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
            btnRemove.Margin = new Padding(2);
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
            lblAmount.Location = new Point(405, 129);
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
            txtDescription.Margin = new Padding(2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(106, 23);
            txtDescription.TabIndex = 13;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(187, 162);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(200, 23);
            dtpDueDate.TabIndex = 15;
            // 
            // BudgetTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2109, 1000);
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
            Controls.Add(lblIncome);
            Margin = new Padding(2);
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
    }
}
