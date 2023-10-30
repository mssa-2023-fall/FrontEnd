namespace MortgageCalculatorGUI
{
    partial class MainForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            monthlyInterestTextBox = new TextBox();
            monthlyInterestLabel = new Label();
            monthlyEscrowTextBox = new TextBox();
            monthlyEscrowLabel = new Label();
            button1 = new Button();
            monthlyPaymentTextBox = new TextBox();
            monthlyPaymentLabel = new Label();
            totalInterestTextBox = new TextBox();
            totalInterestLabel = new Label();
            loanPrincipalTextBox = new TextBox();
            loanPrincipalLabel = new Label();
            loanTermTextBox = new NumericUpDown();
            loanTermLabel = new Label();
            interestRateTextBox = new TextBox();
            interestRateLabel = new Label();
            downPaymentTextBox = new TextBox();
            downPaymentLabel = new Label();
            purchasePriceTextBox = new TextBox();
            purchasePriceLabel = new Label();
            tabPage2 = new TabPage();
            exportButton = new Button();
            dataGridView1 = new DataGridView();
            Month = new DataGridViewTextBoxColumn();
            Interest = new DataGridViewTextBoxColumn();
            Principal = new DataGridViewTextBoxColumn();
            Monthly_Payment = new DataGridViewTextBoxColumn();
            Loan_Remainder = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loanTermTextBox).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(532, 373);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(monthlyInterestTextBox);
            tabPage1.Controls.Add(monthlyInterestLabel);
            tabPage1.Controls.Add(monthlyEscrowTextBox);
            tabPage1.Controls.Add(monthlyEscrowLabel);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(monthlyPaymentTextBox);
            tabPage1.Controls.Add(monthlyPaymentLabel);
            tabPage1.Controls.Add(totalInterestTextBox);
            tabPage1.Controls.Add(totalInterestLabel);
            tabPage1.Controls.Add(loanPrincipalTextBox);
            tabPage1.Controls.Add(loanPrincipalLabel);
            tabPage1.Controls.Add(loanTermTextBox);
            tabPage1.Controls.Add(loanTermLabel);
            tabPage1.Controls.Add(interestRateTextBox);
            tabPage1.Controls.Add(interestRateLabel);
            tabPage1.Controls.Add(downPaymentTextBox);
            tabPage1.Controls.Add(downPaymentLabel);
            tabPage1.Controls.Add(purchasePriceTextBox);
            tabPage1.Controls.Add(purchasePriceLabel);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(524, 345);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Mortgage Calculator";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // monthlyInterestTextBox
            // 
            monthlyInterestTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            monthlyInterestTextBox.Location = new Point(330, 107);
            monthlyInterestTextBox.Name = "monthlyInterestTextBox";
            monthlyInterestTextBox.ReadOnly = true;
            monthlyInterestTextBox.Size = new Size(150, 35);
            monthlyInterestTextBox.TabIndex = 20;
            // 
            // monthlyInterestLabel
            // 
            monthlyInterestLabel.AutoSize = true;
            monthlyInterestLabel.Location = new Point(367, 91);
            monthlyInterestLabel.Name = "monthlyInterestLabel";
            monthlyInterestLabel.Size = new Size(94, 15);
            monthlyInterestLabel.TabIndex = 19;
            monthlyInterestLabel.Text = "Monthly Interest";
            // 
            // monthlyEscrowTextBox
            // 
            monthlyEscrowTextBox.Location = new Point(116, 222);
            monthlyEscrowTextBox.Name = "monthlyEscrowTextBox";
            monthlyEscrowTextBox.Size = new Size(100, 23);
            monthlyEscrowTextBox.TabIndex = 18;
            // 
            // monthlyEscrowLabel
            // 
            monthlyEscrowLabel.AutoSize = true;
            monthlyEscrowLabel.Location = new Point(18, 225);
            monthlyEscrowLabel.Name = "monthlyEscrowLabel";
            monthlyEscrowLabel.Size = new Size(92, 15);
            monthlyEscrowLabel.TabIndex = 17;
            monthlyEscrowLabel.Text = "Monthly Escrow";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSlateGray;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(179, 279);
            button1.Name = "button1";
            button1.Size = new Size(157, 61);
            button1.TabIndex = 16;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Calculate_Mortgage;
            // 
            // monthlyPaymentTextBox
            // 
            monthlyPaymentTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            monthlyPaymentTextBox.Location = new Point(330, 225);
            monthlyPaymentTextBox.Name = "monthlyPaymentTextBox";
            monthlyPaymentTextBox.ReadOnly = true;
            monthlyPaymentTextBox.Size = new Size(150, 35);
            monthlyPaymentTextBox.TabIndex = 15;
            // 
            // monthlyPaymentLabel
            // 
            monthlyPaymentLabel.AutoSize = true;
            monthlyPaymentLabel.Location = new Point(358, 207);
            monthlyPaymentLabel.Name = "monthlyPaymentLabel";
            monthlyPaymentLabel.Size = new Size(102, 15);
            monthlyPaymentLabel.TabIndex = 14;
            monthlyPaymentLabel.Text = "Monthly Payment";
            // 
            // totalInterestTextBox
            // 
            totalInterestTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            totalInterestTextBox.Location = new Point(330, 166);
            totalInterestTextBox.Name = "totalInterestTextBox";
            totalInterestTextBox.ReadOnly = true;
            totalInterestTextBox.Size = new Size(150, 35);
            totalInterestTextBox.TabIndex = 13;
            // 
            // totalInterestLabel
            // 
            totalInterestLabel.AutoSize = true;
            totalInterestLabel.Location = new Point(367, 150);
            totalInterestLabel.Name = "totalInterestLabel";
            totalInterestLabel.Size = new Size(74, 15);
            totalInterestLabel.TabIndex = 12;
            totalInterestLabel.Text = "Total Interest";
            // 
            // loanPrincipalTextBox
            // 
            loanPrincipalTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            loanPrincipalTextBox.Location = new Point(330, 46);
            loanPrincipalTextBox.Name = "loanPrincipalTextBox";
            loanPrincipalTextBox.ReadOnly = true;
            loanPrincipalTextBox.Size = new Size(150, 35);
            loanPrincipalTextBox.TabIndex = 11;
            // 
            // loanPrincipalLabel
            // 
            loanPrincipalLabel.AutoSize = true;
            loanPrincipalLabel.Location = new Point(367, 28);
            loanPrincipalLabel.Name = "loanPrincipalLabel";
            loanPrincipalLabel.Size = new Size(82, 15);
            loanPrincipalLabel.TabIndex = 10;
            loanPrincipalLabel.Text = "Loan Principal";
            // 
            // loanTermTextBox
            // 
            loanTermTextBox.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            loanTermTextBox.Location = new Point(116, 175);
            loanTermTextBox.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            loanTermTextBox.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            loanTermTextBox.Name = "loanTermTextBox";
            loanTermTextBox.Size = new Size(100, 23);
            loanTermTextBox.TabIndex = 9;
            loanTermTextBox.Tag = "";
            loanTermTextBox.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // loanTermLabel
            // 
            loanTermLabel.AutoSize = true;
            loanTermLabel.Location = new Point(10, 177);
            loanTermLabel.Name = "loanTermLabel";
            loanTermLabel.Size = new Size(100, 15);
            loanTermLabel.TabIndex = 8;
            loanTermLabel.Text = "Loan Term (Years)";
            // 
            // interestRateTextBox
            // 
            interestRateTextBox.Location = new Point(116, 124);
            interestRateTextBox.Name = "interestRateTextBox";
            interestRateTextBox.Size = new Size(100, 23);
            interestRateTextBox.TabIndex = 7;
            // 
            // interestRateLabel
            // 
            interestRateLabel.AutoSize = true;
            interestRateLabel.Location = new Point(38, 127);
            interestRateLabel.Name = "interestRateLabel";
            interestRateLabel.Size = new Size(72, 15);
            interestRateLabel.TabIndex = 6;
            interestRateLabel.Text = "Interest Rate";
            // 
            // downPaymentTextBox
            // 
            downPaymentTextBox.Location = new Point(116, 76);
            downPaymentTextBox.Name = "downPaymentTextBox";
            downPaymentTextBox.Size = new Size(100, 23);
            downPaymentTextBox.TabIndex = 3;
            // 
            // downPaymentLabel
            // 
            downPaymentLabel.AutoSize = true;
            downPaymentLabel.Location = new Point(22, 79);
            downPaymentLabel.Name = "downPaymentLabel";
            downPaymentLabel.Size = new Size(88, 15);
            downPaymentLabel.TabIndex = 2;
            downPaymentLabel.Text = "Down Payment";
            // 
            // purchasePriceTextBox
            // 
            purchasePriceTextBox.Location = new Point(116, 33);
            purchasePriceTextBox.Name = "purchasePriceTextBox";
            purchasePriceTextBox.Size = new Size(100, 23);
            purchasePriceTextBox.TabIndex = 1;
            // 
            // purchasePriceLabel
            // 
            purchasePriceLabel.AutoSize = true;
            purchasePriceLabel.Location = new Point(30, 36);
            purchasePriceLabel.Name = "purchasePriceLabel";
            purchasePriceLabel.Size = new Size(84, 15);
            purchasePriceLabel.TabIndex = 0;
            purchasePriceLabel.Text = "Purchase Price";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(exportButton);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(524, 345);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Amortization Schedule";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // exportButton
            // 
            exportButton.BackColor = Color.LightSlateGray;
            exportButton.Cursor = Cursors.Hand;
            exportButton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            exportButton.Location = new Point(453, 334);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(75, 23);
            exportButton.TabIndex = 1;
            exportButton.Text = "EXPORT";
            exportButton.UseVisualStyleBackColor = false;
            exportButton.Click += exportFile;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Month, Interest, Principal, Monthly_Payment, Loan_Remainder });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(540, 328);
            dataGridView1.TabIndex = 0;
            // 
            // Month
            // 
            Month.HeaderText = "Month";
            Month.Name = "Month";
            Month.Width = 50;
            // 
            // Interest
            // 
            Interest.HeaderText = "Interest";
            Interest.Name = "Interest";
            // 
            // Principal
            // 
            Principal.HeaderText = "Principal";
            Principal.Name = "Principal";
            // 
            // Monthly_Payment
            // 
            Monthly_Payment.HeaderText = "Monthly Payment";
            Monthly_Payment.Name = "Monthly_Payment";
            // 
            // Loan_Remainder
            // 
            Loan_Remainder.HeaderText = "Loan Remainder";
            Loan_Remainder.Name = "Loan_Remainder";
            Loan_Remainder.Width = 145;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 397);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Mortgage Calculator";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loanTermTextBox).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox interestRateTextBox;
        private Label interestRateLabel;
        private TextBox downPaymentTextBox;
        private Label downPaymentLabel;
        private TextBox purchasePriceTextBox;
        private Label purchasePriceLabel;
        private NumericUpDown loanTermTextBox;
        private Label loanTermLabel;
        private Label totalInterestLabel;
        private TextBox loanPrincipalTextBox;
        private Label loanPrincipalLabel;
        private Button button1;
        private TextBox monthlyPaymentTextBox;
        private Label monthlyPaymentLabel;
        private TextBox totalInterestTextBox;
        private TextBox monthlyEscrowTextBox;
        private Label monthlyEscrowLabel;
        private TextBox monthlyInterestTextBox;
        private Label monthlyInterestLabel;
        private DataGridView dataGridView1;
        private Button exportButton;
        private DataGridViewTextBoxColumn Month;
        private DataGridViewTextBoxColumn Interest;
        private DataGridViewTextBoxColumn Principal;
        private DataGridViewTextBoxColumn Monthly_Payment;
        private DataGridViewTextBoxColumn Loan_Remainder;
    }
}