namespace BudgetTracker
{
    public partial class BudgetTracker : Form
    {
        //List to store the bills entered by the user
        List<Bill> bills = new List<Bill>();
        public BudgetTracker()
        {
            InitializeComponent();
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
                    bills.Add(new Bill { Amount = bill, Description = txtDescription.Text });
                    lstBills.Items.Add($"{txtDescription.Text} - {bill.ToString("C")}");
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
            //This method calculates the total bills and subtracts it from the income to get the leftover amount
            decimal income;
            decimal totalBills = 0;
            decimal leftOver;
            if (decimal.TryParse(txtIncome.Text, out income))
            {
                foreach (Bill bill in bills)
                {
                    totalBills += bill.Amount;
                }
                leftOver = income - totalBills;
                txtCalculate.Text = leftOver.ToString("C");
            }
            else
            {
                MessageBox.Show("Please enter a valid income amount.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstBills.SelectedIndex;
            if (selectedIndex != -1)
            {
                bills.RemoveAt(selectedIndex);
                lstBills.Items.RemoveAt(selectedIndex);
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
            MessageBox.Show("Everything has been cleared.");
        }
    }
}
