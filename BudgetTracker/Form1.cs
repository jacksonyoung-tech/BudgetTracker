using Microsoft.VisualBasic;

namespace BudgetTracker
{
    public partial class BudgetTracker : Form
    {
        //List to store the bills entered by the user
        List<Bill> bills = new List<Bill>();
        private void CalculateBudget()
        {
            //This method calculates the total bills and subtracts it from the income to get the leftover amount
            decimal income;
            decimal totalBills = 0;
            decimal leftOver;
            decimal savingsAllocation = 0.5m; // 50% of leftover amount for savings
            decimal personalAllocation = 0.3m; // 30% of leftover amount for personal spending
            decimal emergencyAllocation = 0.2m; // 20% of leftover amount for emergency fund
            decimal savings;
            decimal personal;
            decimal emergency;
            if (decimal.TryParse(txtIncome.Text, out income))
            {
                if (cmbPayFrequency.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a pay frequency.");
                    return;
                }
                else  
                {
                    IncomeFrequency pay = (IncomeFrequency)cmbPayFrequency.SelectedItem;
                    if (pay == IncomeFrequency.Weekly)
                    {
                        income *= 4; // Convert weekly income to monthly
                    }
                    else if (pay == IncomeFrequency.Fortnightly)
                    {
                        income *= 2; // Convert fortnightly income to monthly
                    }
                    else if (pay == IncomeFrequency.Monthly)
                    {
                        // No conversion needed for monthly income
                    }
                }
                
                foreach (Bill bill in bills)
                {
                    totalBills += bill.Amount;
                }
                leftOver = income - totalBills;
                if (leftOver < 0)
                {
                    txtCalculate.Text = $"You are over budget by {Math.Abs(leftOver).ToString("C")}. Please review your bills.";
                }
                else
                {
                    savings = leftOver * savingsAllocation;
                    personal = leftOver * personalAllocation;
                    emergency = leftOver * emergencyAllocation;
                    txtCalculate.Text = $"Remaining Money: {leftOver.ToString("C")}{Environment.NewLine}Savings: {savings.ToString("C")}{Environment.NewLine}Personal: {personal.ToString("C")}{Environment.NewLine}Emergency: {emergency.ToString("C")}";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid income amount.");
            }
        }
        public BudgetTracker()
        {
            InitializeComponent();
            
            cmbPayFrequency.Text = "-- Select Frequency --";
            cmbPayFrequency.Items.Add(IncomeFrequency.Weekly);
            cmbPayFrequency.Items.Add(IncomeFrequency.Fortnightly);
            cmbPayFrequency.Items.Add(IncomeFrequency.Monthly);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal bill;
            //If statement to check if the amount entered is a valid decimal number
            if (decimal.TryParse(txtAmount.Text, out bill))
            {
                /*Nested if statement to check if the description is not empty or whitespace.
                 If it is not empty, it will capitalize the first letter of the description and add the bill to the list*/
                if (!string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    txtDescription.Text = txtDescription.Text.Substring(0, 1).ToUpper() + txtDescription.Text.Substring(1);
                    bills.Add(new Bill { Amount = bill, Description = txtDescription.Text, DueDate = dtpDueDate.Value.Date });
                    lstBills.Items.Add($"Bill: {txtDescription.Text} | Due Date: {dtpDueDate.Value.Date.ToString("d")} | Amount: {bill.ToString("C")}");
                    txtAmount.Clear();
                    txtDescription.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a valid description.");
                    txtDescription.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
                txtAmount.Clear();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateBudget(); // Call the method to calculate the budget when the button is clicked
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstBills.SelectedIndex;
            if (selectedIndex != -1)
            {
                bills.RemoveAt(selectedIndex);
                lstBills.Items.RemoveAt(selectedIndex);

                CalculateBudget(); // Recalculate the budget after removing a bill

                MessageBox.Show("Bill removed successfully.");

            }
            else
            {
                MessageBox.Show("Please select a bill to remove.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstBills.Items.Clear();
            bills.Clear();
            txtCalculate.Clear();
            txtIncome.Clear();
            txtAmount.Clear();
            txtDescription.Clear();

            MessageBox.Show("Everything has been cleared.");
        }
    }

}