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
    public partial class NonCustomer : Form
    {
        private NonCustomerAccount _nc1;
        List<NonCustomerAccount> nonCustomers;
        List<CustomerAccount> customers;
        //private CustomerAccount _c1;
        //List<CustomerAccount> customers;
        //public NonCustomer(List<CustomerAccount> customers, CustomerAccount customer)
        //{
        //    InitializeComponent();
        //    _c1 = customer;
        //    this.customers = customers;
        //}
        public NonCustomer(List<CustomerAccount> customers, List<NonCustomerAccount> nonCustomers, NonCustomerAccount nonCustomer)
        {
            InitializeComponent();
            _nc1 = nonCustomer;
            this.nonCustomers = nonCustomers;
            this.customers = customers;
        }
        public NonCustomer()
        {
            InitializeComponent();
        }

        private void NonCustomer_Load(object sender, EventArgs e)
        {
            lblWelcomeNon.Text = "Welcome " + _nc1.FirstName;
            pbNonCustomerAccount.Image = _nc1.Photo;
        }

        private void btnNonCustomerMakeChange_Click(object sender, EventArgs e)
        {
            try
            {
                float changeAmoount = float.Parse(txtMakeChangeAmount.Text);
                if (changeAmoount > 0 && chkVerify.Checked == true)
                {
                    lblMakeChangeResult.Text = "Exchange Successful";
                }
                else if (changeAmoount > 0 && chkVerify.Checked == false)
                {
                    lblMakeChangeResult.Text = "Exchange Not Verified";
                }
                else if (changeAmoount < 0)
                {
                    lblMakeChangeResult.Text = "Enter a valid check amount";
                }
            }
            catch (Exception ex)
            {
                lblMakeChangeResult.Text = "Invalid Check Information";
            }
        }

        private void rbMakeChange_CheckedChanged(object sender, EventArgs e)
        {
            gbNonCustomerMakeChange.Visible= rbMakeChange.Checked;
            txtMakeChangeAmount.Text = string.Empty;
            chkVerify.Checked = false;
        }

        private void rbCashCheck_CheckedChanged(object sender, EventArgs e)
        {
            gbNonCustomerCashCheck.Visible = rbCashCheck.Checked;
            txtCashCheckAmount.Text = string.Empty;
            txtNonAccountName.Text = string.Empty;
            txtNonAccountNumber.Text = string.Empty;
        }

        private void rbOpenAccount_CheckedChanged(object sender, EventArgs e)
        {
            gbOpenAccount.Visible = rbOpenAccount.Checked;
            txtOpenAccountNumber.Text = string.Empty;
            txtOpenAccountDeposit.Text = string.Empty;
            chkBackgroundCheck.Checked = false;
            chkScannedId.Checked = false;
        }
        private void btnNonCustomerCashCheck_Click(object sender, EventArgs e)
        {
            try
            {
                string nonNameInput = txtNonAccountName.Text;
                int nonAccountInput = Convert.ToInt32(txtNonAccountNumber.Text);
                float nonCheckAmountInput = float.Parse(txtCashCheckAmount.Text);
                foreach (CustomerAccount customer in customers)
                {
                    if (nonNameInput == customer.FirstName + " " + customer.LastName && nonAccountInput == customer.AccountNumber && nonCheckAmountInput < customer.Balance)
                    {
                        customer.Balance -= nonCheckAmountInput;
                        lblCashCheckResult.Text = "Check Cashed Successfully";
                    }
                    else if (nonNameInput == customer.FirstName + " " + customer.LastName && nonAccountInput == customer.AccountNumber && nonCheckAmountInput >= customer.Balance)
                    {
                        lblCashCheckResult.Text = "Insufficient Funds";
                    }
                }
            }catch(Exception ex)
            {
                lblCashCheckResult.Text = "Invalid Account Information Entered";
            }
            
        }

        private void btnOpenAccount_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerAccount newCustomer = new CustomerAccount();
                int openAccountNum = Convert.ToInt32(txtOpenAccountNumber.Text);
                float openBalance = float.Parse(txtOpenAccountDeposit.Text);

                bool validAccount = true;
                foreach (CustomerAccount customer in customers)
                {
                    if (openAccountNum == customer.AccountNumber || openBalance < 100 || chkBackgroundCheck.Checked == false || chkScannedId.Checked == false)
                    {
                        validAccount = false;
                        break;
                    }
                }

                if (validAccount)
                {
                    newCustomer.DateOpened = DateOnly.FromDateTime(DateTime.Now);
                    newCustomer.Balance = openBalance;
                    newCustomer.AccountNumber = openAccountNum;

                    newCustomer.FirstName = _nc1.FirstName;
                    newCustomer.LastName = _nc1.LastName;
                    newCustomer.Address = _nc1.Address;
                    newCustomer.SSN = _nc1.SSN;
                    newCustomer.ID = _nc1.ID;
                    newCustomer.Photo = _nc1.Photo;

                    customers.Add(newCustomer);
                    nonCustomers.Remove(_nc1);
                    this.Close();
                }
                else
                {
                    lblWelcomeNewCustomer.Text = "New customer information invalid";
                }
            }
            catch (Exception ex)
            {
                lblWelcomeNewCustomer.Text = "New customer information invalid";
            }
        }
        //try
        //{
        //    CustomerAccount newCustomer = new CustomerAccount();
        //    int openAccountNum = Convert.ToInt32(txtOpenAccountNumber.Text);
        //    float openBalance = float.Parse(txtOpenAccountDeposit.Text);
        //    foreach (CustomerAccount customer in customers)
        //    {
        //        if (openAccountNum != customer.AccountNumber && openBalance >= 100)
        //        {
        //            newCustomer.DateOpened = DateOnly.FromDateTime(DateTime.Now);
        //            newCustomer.Balance = openBalance;
        //            newCustomer.AccountNumber = openAccountNum;

        //            newCustomer.FirstName = customer.FirstName;
        //            newCustomer.LastName = customer.LastName;
        //            newCustomer.Address = customer.Address;
        //            newCustomer.SSN = customer.SSN;
        //            newCustomer.ID = customer.ID;
        //            newCustomer.Photo = customer.Photo;
        //            customers.Add(newCustomer);
        //            nonCustomers.Remove(_nc1);
        //            this.Close();
        //        }
        //    }
        //}catch(Exception ex )
        //{
        //    lblWelcomeNewCustomer.Text = "New customer information invalid";
        //}


        private void btnNonCustomerLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
