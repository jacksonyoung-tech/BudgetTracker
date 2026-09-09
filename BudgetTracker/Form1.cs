namespace BudgetTracker
{
    public partial class BudgetTracker : Form
    {
        List<decimal> bills = new List<decimal>();
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
            if (decimal.TryParse(txtBills.Text, out bill))
            {
                bills.Add(bill);
                lstBills.Items.Add(bill.ToString("C"));
                txtBills.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
                txtBills.Clear();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal income;
            decimal totalBills = 0;
            decimal leftOver;
            if (decimal.TryParse(txtIncome.Text, out income))
            {
                foreach (decimal bill in bills)
                {
                    totalBills += bill;
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
            txtBills.Clear();
            MessageBox.Show("Everything has been cleared.");
        }
    }
}
