using System;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace MortgageCalculatorGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Calculate_Mortgage(object sender, EventArgs e)
        {
            //Purchase Price
            decimal purchasePrice;
            bool purchasePriceParse = decimal.TryParse(purchasePriceTextBox.Text, out purchasePrice);
            if (purchasePriceParse == false)
            {
                MessageBox.Show("Enter a valid purchase price");
                purchasePriceTextBox.Clear();
                purchasePriceTextBox.Focus();
                return;
            }

            //Down Payment
            decimal downPayment;
            bool downPaymentParse = decimal.TryParse(downPaymentTextBox.Text, out downPayment);
            if (downPaymentParse == false)
            {
                MessageBox.Show("Enter a valid down payment");
                downPaymentTextBox.Clear();
                downPaymentTextBox.Focus();
                return;
            }

            //Interest Rate
            decimal interestRatePercent;
            bool interestRateParse = decimal.TryParse(interestRateTextBox.Text, out interestRatePercent);
            if (interestRateParse == false)
            {
                MessageBox.Show("Enter a valid interest rate.");
                interestRateTextBox.Clear();
                interestRateTextBox.Focus();
                return;
            }
            decimal interestRate = interestRatePercent / 100m;

            //Loan Term
            decimal loanTerm;
            bool loanTermParse = decimal.TryParse(loanTermTextBox.Text, out loanTerm);
            if (loanTermParse == false)
            {
                MessageBox.Show("Enter a valid loan term.");
                loanTermTextBox.ResetText();
                loanTermTextBox.Focus();
                return;
            }

            //Monthly Escrow
            decimal monthlyEscrow;
            decimal loanInsurance;
            int n = 12; //number of payments per year
            bool monthlyEscrowParse = decimal.TryParse(monthlyEscrowTextBox.Text, out monthlyEscrow);
            if (monthlyEscrowParse == false)
            {
                MessageBox.Show("Enter a valid monthly escrow payment.");
                monthlyEscrowTextBox.Clear();
                monthlyEscrowTextBox.Focus();
                return;
            }

            //Mortgage calculator logic
            decimal originationFee = 0.01m * (purchasePrice - downPayment) + 2500m; //Adds 1% on purchase price +$2,500 for the origination fee
            decimal loanPrincipal = purchasePrice - downPayment + originationFee; //Total loan amount

            decimal equity = purchasePrice - loanPrincipal;
            if (equity < (purchasePrice * .1m)) //PMI required.
            {
                loanInsurance = 0.01m * loanPrincipal;
            }
            else //No PMI.
            {
                loanInsurance = 0;
            }

            //Calculate monthly payment
            decimal monthlyPayment = loanPrincipal * (interestRate / n) *
                (decimal)(Math.Pow((double)(1 + interestRate / n), n * (double)loanTerm) /
                (Math.Pow((double)(1 + interestRate / n), n * (double)loanTerm) - 1));
            decimal totalMonthlyPayment = Convert.ToDecimal(monthlyPayment) + monthlyEscrow;

            // Calculate the initial monthly interest
            decimal initialMonthlyInterest = loanPrincipal * (interestRate / n);

            //Amortization list and total loan interest
            List<decimal> interestPaymentByMonth = new List<decimal>();
            List<decimal> principalPaymentByMonth = new List<decimal>();
            List<decimal> principalBalanceByMonth = new List<decimal>();
            List<decimal> totalPaymentByMonth = new List<decimal>();

            decimal remainingLoanPrincipal = loanPrincipal;
            decimal totalInterest = 0;

            for (int month = 1; month <= n * loanTerm; month++)
            {
                decimal monthlyInterest = remainingLoanPrincipal * (interestRate / n);
                decimal principalPayment = monthlyPayment - monthlyInterest;
                remainingLoanPrincipal -= principalPayment;

                totalInterest += monthlyInterest; //interest for each month
                interestPaymentByMonth.Add(monthlyInterest); //add monthly interest to list
                principalPaymentByMonth.Add(principalPayment); //add monthly principal payment to list
                totalPaymentByMonth.Add(monthlyInterest + principalPayment); //add monthly payment to list
                principalBalanceByMonth.Add(remainingLoanPrincipal); //add remaining principal amount to list
            }

            dataGridView1.Rows.Clear();

            for (int i = 0; i < interestPaymentByMonth.Count; i++)
            {
                string[] row = new string[] { (i + 1).ToString(), interestPaymentByMonth[i].ToString("C"), principalPaymentByMonth[i].ToString("C"), totalPaymentByMonth[i].ToString("C"), principalBalanceByMonth[i].ToString("C") };
                dataGridView1.Rows.Add(row);
            }


            loanPrincipalTextBox.Text = loanPrincipal.ToString("C");
            monthlyInterestTextBox.Text = interestPaymentByMonth[0].ToString("C"); // initial monthly interest
            totalInterestTextBox.Text = totalInterest.ToString("C");
            monthlyPaymentTextBox.Text = monthlyPayment.ToString("C");

        }
        private void exportFile(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "CSV File (*.csv)|*.csv";
            saveFile.FileName = "Export.csv";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                {
                    // Write column headers
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        sw.Write("\"" + dataGridView1.Columns[i].Name + "\"");
                        if (i < dataGridView1.ColumnCount - 1)
                        {
                            sw.Write(",");
                        }
                    }
                    sw.WriteLine();

                    // Write rows
                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            sw.Write("\"" + dataGridView1[j, i].Value.ToString() + "\"");
                            if (j < dataGridView1.ColumnCount - 1)
                            {
                                sw.Write(",");
                            }
                        }
                        sw.WriteLine();
                    }
                }

                MessageBox.Show("File Successfully Saved!", "Info");
            }
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}