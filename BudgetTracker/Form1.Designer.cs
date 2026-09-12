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
            SuspendLayout();
            // 
            // lblIncome
            // 
            lblIncome.AutoSize = true;
            lblIncome.Location = new Point(92, 51);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(132, 25);
            lblIncome.TabIndex = 0;
            lblIncome.Text = "Weekly Income";
            // 
            // lblWeeklyBills
            // 
            lblWeeklyBills.AutoSize = true;
            lblWeeklyBills.Location = new Point(92, 167);
            lblWeeklyBills.Name = "lblWeeklyBills";
            lblWeeklyBills.Size = new Size(103, 25);
            lblWeeklyBills.TabIndex = 1;
            lblWeeklyBills.Text = "Weekly Bills";
            // 
            // lblBills
            // 
            lblBills.AutoSize = true;
            lblBills.Location = new Point(93, 331);
            lblBills.Name = "lblBills";
            lblBills.Size = new Size(42, 25);
            lblBills.TabIndex = 2;
            lblBills.Text = "Bills";
            lblBills.Click += label3_Click;
            // 
            // lstBills
            // 
            lstBills.FormattingEnabled = true;
            lstBills.Location = new Point(92, 385);
            lstBills.Name = "lstBills";
            lstBills.ScrollAlwaysVisible = true;
            lstBills.Size = new Size(180, 129);
            lstBills.TabIndex = 3;
            // 
            // txtIncome
            // 
            txtIncome.Location = new Point(92, 94);
            txtIncome.Name = "txtIncome";
            txtIncome.Size = new Size(150, 31);
            txtIncome.TabIndex = 4;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(280, 270);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(150, 31);
            txtAmount.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(280, 326);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(433, 326);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 34);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtCalculate
            // 
            txtCalculate.Location = new Point(433, 385);
            txtCalculate.Multiline = true;
            txtCalculate.Name = "txtCalculate";
            txtCalculate.ReadOnly = true;
            txtCalculate.Size = new Size(180, 129);
            txtCalculate.TabIndex = 8;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(210, 538);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(92, 538);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(112, 34);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "Remove Bill";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(280, 215);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(77, 25);
            lblAmount.TabIndex = 11;
            lblAmount.Text = "Amount";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(93, 215);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(102, 25);
            lblDescription.TabIndex = 12;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(92, 270);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(150, 31);
            txtDescription.TabIndex = 13;
            // 
            // BudgetTracker
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 740);
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
    }
}
