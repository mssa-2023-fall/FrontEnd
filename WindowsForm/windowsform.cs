using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

public class MortgageForm : Form
{
    TextBox txtPurchasePrice = new TextBox();
    TextBox txtDownPayment = new TextBox();
    TextBox txtInterestRate = new TextBox();
    TextBox txtLoanTerm = new TextBox();

    Label lblMonthlyPayment = new Label();
    Label lblLoanStatus = new Label();

    Button btnCalculate = new Button();

    public MortgageForm()
    {
        // Set properties of controls and add them to the form
        txtPurchasePrice.Location = new System.Drawing.Point(20, 20);
        txtDownPayment.Location = new System.Drawing.Point(20, 60);
        txtInterestRate.Location = new System.Drawing.Point(20, 100);
        txtLoanTerm.Location = new System.Drawing.Point(20, 140);

        lblMonthlyPayment.Location = new System.Drawing.Point(20, 200);
        lblLoanStatus.Location = new System.Drawing.Point(20, 240);

        btnCalculate.Location = new System.Drawing.Point(20, 180);
        btnCalculate.Text = "Calculate";
        btnCalculate.Click += BtnCalculate_Click;

        this.Controls.Add(txtPurchasePrice);
        this.Controls.Add(txtDownPayment);
        this.Controls.Add(txtInterestRate);
        this.Controls.Add(txtLoanTerm);

        this.Controls.Add(lblMonthlyPayment);
        this.Controls.Add(lblLoanStatus);

        this.Controls.Add(btnCalculate);
    }

    private void BtnCalculate_Click(object sender, EventArgs e)
    {
        // Call the existing methods from your mortgage calculator program
        // Update the labels with the results
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MortgageForm());
    }
}
