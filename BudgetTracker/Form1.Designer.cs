namespace BudgetTracker
{
    partial class Form1
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
            txtBills = new TextBox();
            btnAdd = new Button();
            btnCalculate = new Button();
            txtCalculate = new TextBox();
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
            lblBills.Location = new Point(92, 290);
            lblBills.Name = "lblBills";
            lblBills.Size = new Size(42, 25);
            lblBills.TabIndex = 2;
            lblBills.Text = "Bills";
            lblBills.Click += label3_Click;
            // 
            // lstBills
            // 
            lstBills.FormattingEnabled = true;
            lstBills.Location = new Point(92, 340);
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
            // txtBills
            // 
            txtBills.Location = new Point(92, 212);
            txtBills.Name = "txtBills";
            txtBills.Size = new Size(150, 31);
            txtBills.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(318, 212);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(318, 285);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 34);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // txtCalculate
            // 
            txtCalculate.Location = new Point(318, 340);
            txtCalculate.Multiline = true;
            txtCalculate.Name = "txtCalculate";
            txtCalculate.ReadOnly = true;
            txtCalculate.Size = new Size(180, 129);
            txtCalculate.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 490);
            Controls.Add(txtCalculate);
            Controls.Add(btnCalculate);
            Controls.Add(btnAdd);
            Controls.Add(txtBills);
            Controls.Add(txtIncome);
            Controls.Add(lstBills);
            Controls.Add(lblBills);
            Controls.Add(lblWeeklyBills);
            Controls.Add(lblIncome);
            Name = "Form1";
            Text = "Form1";
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
        private TextBox txtBills;
        private Button btnAdd;
        private Button btnCalculate;
        private TextBox txtCalculate;
    }
}
