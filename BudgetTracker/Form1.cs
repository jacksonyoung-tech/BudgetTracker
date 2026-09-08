namespace BudgetTracker
{
    public partial class Form1 : Form
    {
        List<decimal> bills = new List<decimal>();
        public Form1()
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
    }
}
