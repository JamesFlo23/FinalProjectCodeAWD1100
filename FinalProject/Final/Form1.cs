namespace Final
{
    public partial class Form1 : Form
    {
        CustomerContext customerDb;
        List<Customer> customerList;
        List<CustomerAccount> customers = new List<CustomerAccount>
        {
            new CustomerAccount("Patrick", "Star", "123-45-6789","178 Bikini Bottom Rd", 112233, 101000, Properties.Resources.PatrickStar_ID, 600.00f, new DateOnly(2023, 4, 10)),
             new CustomerAccount("Spongebob", "Squarepants", "465-78-7878","182 Bikini Bottom Rd", 223344, 101001, Properties.Resources.SpongeBob_ID, 78000.00f, new DateOnly(2020, 12, 25)),
              new CustomerAccount("Sandy", "Cheeks", "111-11-1118", "126 Conch Street", 334455,101002, Properties.Resources.SandyCheeks_ID, 500000.00f, new DateOnly(2019, 6, 21)),
               new CustomerAccount("Eugene", "Krabs", "345-77-6658", "3541 Anchor Way", 445566,101003, Properties.Resources.MrKrabs_ID, 1000000.00f, new DateOnly(2015, 8, 15)),
        };
        List<NonCustomerAccount> noncustomers = new List<NonCustomerAccount>
        {
            new NonCustomerAccount("Sheldon","Plankton","789-78-4564","973 Bottom Feeder Lane", 207207, Properties.Resources.Plankton_ID),
            new NonCustomerAccount("Gary","Squarepants","684-55-4682","182 Bikini Bottom Rd", 124578, Properties.Resources.GaryTheSnail_ID),
            new NonCustomerAccount("Squidward","Tentacles","547-54-6524","180 Bikini Bottom Rd", 659887, Properties.Resources.Squidward_ID),
        };
        public Form1()
        {
            customerDb = new CustomerContext();
            InitializeComponent();
            rbCustomer.Checked = false;
            rbNoncustomer.Checked = false;
            txtIdNumber.Text = string.Empty;
            txtName.Text = string.Empty;
            txtSsn.Text = string.Empty;
            lblFailedLogin.Text = string.Empty;
        }
        public List<CustomerAccount> GetCustomerList()
        {
            return customers;
        }

        private void rbNoncustomer_CheckedChanged(object sender, EventArgs e)
        {
            gbLogin.Visible = true;
            lblWelcomeUser.Text = "Enter Noncustomer Information";
            lblFailedLogin.Text = " ";
        }

        private void rbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            gbLogin.Visible = true;
            lblWelcomeUser.Text = "Enter Customer Information";
            lblFailedLogin.Text = " ";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string loginName = txtName.Text;
                string loginSsn = txtSsn.Text;
                int idNum = Convert.ToInt32(txtIdNumber.Text);
                if (rbCustomer.Checked == true)
                {
                    for (int i = 0; i < customers.Count; i++)
                    {
                        if ((loginName == customers[i].FirstName + " " + customers[i].LastName) && loginSsn == customers[i].SSN && idNum == customers[i].ID)
                        {
                            CustomerAccount c1 = customers[i];
                            Customer customerForm = new Customer(customers, c1);
                            customerForm.Show();
                        }
                        else
                        {
                            lblFailedLogin.Text = "Failed";
                        }
                    }
                }
                if (rbNoncustomer.Checked == true)
                {
                    for (int i = 0; i < noncustomers.Count; i++)
                    {
                        if ((loginName == noncustomers[i].FirstName + " " + noncustomers[i].LastName) && loginSsn == noncustomers[i].SSN && idNum == noncustomers[i].ID)
                        {
                            NonCustomerAccount nc1 = noncustomers[i];
                            NonCustomer noncustomerForm = new NonCustomer(customers, noncustomers, nc1);
                            noncustomerForm.Show();
                        }
                        else
                        {
                            lblFailedLogin.Text = "Failed";
                        }
                    }
                }
            }catch(Exception ex)
            {
                lblFailedLogin.Text = "Invalid User Credentials";
            }
        }
    }
}