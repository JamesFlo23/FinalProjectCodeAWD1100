using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Customer : Form
    {
        private CustomerAccount _c1;
        List<CustomerAccount> customers;
        public Customer(List<CustomerAccount> customers, CustomerAccount customer)
        {
            InitializeComponent();
            _c1 = customer;
            this.customers = customers;
        }
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            lblWelcomeCustomer.Text = "Welcome " + _c1.FirstName;
            lblCurrentBalance.Text = $"Your current balance is {_c1.Balance:c}";
            pbCustomerAccount.Image = _c1.Photo;
            GetRate();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            lblWithdrawalResult.Text = "";
            try
            {
                float deposit = float.Parse(txtDeposit.Text);
                _c1.Balance += deposit;
                lblCurrentBalance.Text = $"Your current balance is {_c1.Balance:c}";
                lblDepositResult.Text = "Deposit Success";
                GetRate();
                SeePerks();
            }
            catch(Exception ex)
            {
                lblDepositResult.Text = "Invalid Deposit";
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            lblDepositResult.Text = "";
            try
            {
                float withdrawal = float.Parse(txtWithdrawal.Text);
                if (_c1.Balance > withdrawal)
                {
                    _c1.Balance -= withdrawal;
                    lblCurrentBalance.Text = $"Your current balance is {_c1.Balance:c}";
                    lblWithdrawalResult.Text = "Withdraw Success";
                    GetRate();
                    SeePerks();                
                }
                else
                {
                    lblWithdrawalResult.Text = "Insufficient Funds";
                }
            }catch(Exception ex)
            {
                lblWithdrawalResult.Text = "Invalid Withdrawal";
            }
        }

        private void rbStartLoan_CheckedChanged(object sender, EventArgs e)
        {
            gbMakeLoan.Visible= rbStartLoan.Checked;
            GetRate();
            txtLoanAmount.Text = "";
            lblLoanPayment.Text = "";
        }
        private void GetRate()
        {
            decimal rate = 0;
            bool longTermCus = false;
            DateOnly dateNow = DateOnly.FromDateTime(DateTime.Now);
            if(dateNow.Year - _c1.DateOpened.Year < 365)
            {
                longTermCus= true;
            }

            if(_c1.Balance <= 10000)
            {
                rate = .08m;
            }else if(_c1.Balance > 10000 && _c1.Balance <= 100000 && longTermCus == false)
            {
                rate = .07m;
            }else if(_c1.Balance > 10000 && _c1.Balance <= 100000 && longTermCus == true)
            {
                rate = .06m;
            }else if(_c1.Balance > 100000 && _c1.Balance <= 500000 && longTermCus == false)
            {
                rate = .05m;
            }
            else if (_c1.Balance > 100000 && _c1.Balance <= 500000 && longTermCus == true)
            {
                rate = .04m;
            }
            else if (_c1.Balance > 500000 && longTermCus == false)
            {
                rate = .04m;
            }
            else if (_c1.Balance > 500000 && longTermCus == true)
            {
                rate = .03m;
            }
            lblInterestRate.Text = $"Your current interest rate is {rate:p}";
        }

        private void rbCustomerCashCheck_CheckedChanged(object sender, EventArgs e)
        {
            gbCustomerCashCheck.Visible= rbCustomerCashCheck.Checked;
            txtCustomerCashCheckAccount.Text = "";
            txtCustomerCashCheckName.Text = "";
            txtCheckAmount.Text = "";
            lblCustomerCashCheckResult.Text = "";
        }

        private void rbSeePerks_CheckedChanged(object sender, EventArgs e)
        {
            gbSeePerks.Visible= rbSeePerks.Checked;
            SeePerks();
        }

        private void rbCustomerMakeChange_CheckedChanged(object sender, EventArgs e)
        {
            gbCustomerMakeChange.Visible= rbCustomerMakeChange.Checked;
            lblCustomerMakeChangeResult.Text = "";
            txtCustomerMakeChangeAmount.Text = "";
        }

        private void rbCloseAccount_CheckedChanged(object sender, EventArgs e)
        {
            gbCloseAccount.Visible= rbCloseAccount.Checked;
        }

        private void btnCustomerLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMakeLoan_Click(object sender, EventArgs e)
        {
            bool longTermCus = false;
            decimal rate = 0;
            if (_c1.Balance <= 10000)
            {
                rate = .08m;
            }
            else if (_c1.Balance > 10000 && _c1.Balance <= 100000 && longTermCus == false)
            {
                rate = .07m;
            }
            else if (_c1.Balance > 10000 && _c1.Balance <= 100000 && longTermCus == true)
            {
                rate = .06m;
            }
            else if (_c1.Balance > 100000 && _c1.Balance <= 500000 && longTermCus == false)
            {
                rate = .05m;
            }
            else if (_c1.Balance > 100000 && _c1.Balance <= 500000 && longTermCus == true)
            {
                rate = .04m;
            }
            else if (_c1.Balance > 500000 && longTermCus == false)
            {
                rate = .04m;
            }
            else if (_c1.Balance > 500000 && longTermCus == true)
            {
                rate = .03m;
            }
            try
            {
                decimal loanAmount = decimal.Parse(txtLoanAmount.Text);
                int loanTerm = 0;
                if (rbThreeYear.Checked)
                {
                    loanTerm = 3;
                }
                if (rbFiveYear.Checked)
                {
                    loanTerm = 5;
                }
                if (rbEightYear.Checked)
                {
                    loanTerm = 8;
                }
                decimal monthlyPayment = loanAmount * (rate / loanTerm);
                lblLoanPayment.Text = $"{monthlyPayment:c}";
            }
            catch (Exception ex)
            {
                lblLoanPayment.Text = "Invalid Loan Payment";
            }
        }

        private void btnCashCheck_Click(object sender, EventArgs e)
        {
            try
            {
                string nameInput = txtCustomerCashCheckName.Text;
                int accountInput = Convert.ToInt32(txtCustomerCashCheckAccount.Text);
                float checkAmountInput = float.Parse(txtCheckAmount.Text);
                lblCustomerCashCheckResult.Text = "Invalid Customer/Check Information";
                foreach (CustomerAccount customer in customers)
                {
                    if (nameInput == customer.FirstName +" "+ customer.LastName && accountInput == customer.AccountNumber && checkAmountInput < customer.Balance)
                    {
                        customer.Balance -= checkAmountInput;
                        lblCustomerCashCheckResult.Text = "Check Cashed Successfully";
                        lblCurrentBalance.Text = $"Your current balance is {_c1.Balance:c}";
                        break;
                    }
                    if(nameInput == customer.FirstName + " " + customer.LastName && accountInput == customer.AccountNumber && checkAmountInput >= customer.Balance)
                    {
                        lblCustomerCashCheckResult.Text = "Insufficient Funds";
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                lblCustomerCashCheckResult.Text = "Invalid Customer/Check Information";
            }
        }
        private void SeePerks()
        {
            rtbPerks.Text = "";
            if(_c1.Balance >= 10000)
            {
                rtbPerks.Text += "Available to apply for free $200 VISA\n";
            }if(_c1.Balance >= 100000)
            {
                rtbPerks.Text += "Additional .05% off of loan interest\n";
            }
            if(_c1.Balance >= 500000)
            {
                rtbPerks.Text += "Premium Savings Account available\n";
            }
        }

        private void btnMakeChange_Click(object sender, EventArgs e)
        {
            try
            {
                float changeAmoount = float.Parse(txtCustomerMakeChangeAmount.Text);
                if (changeAmoount > 0 && chkVerifyCustomer.Checked == true)
                {
                    lblCustomerMakeChangeResult.Text = "Exchange Successful";
                    txtCustomerMakeChangeAmount.Text = string.Empty;
                }
                else if (changeAmoount > 0 && chkVerifyCustomer.Checked == false)
                {
                    lblCustomerMakeChangeResult.Text = "Exchange Not Verified";
                }
                else if (changeAmoount < 0)
                {
                    lblCustomerMakeChangeResult.Text = "Enter a valid check amount";
                }
            }catch(Exception ex)
            {
                lblCustomerMakeChangeResult.Text = "Invalid Check Information";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            customers.Remove(_c1);
            this.Close();
        }
    }
}
