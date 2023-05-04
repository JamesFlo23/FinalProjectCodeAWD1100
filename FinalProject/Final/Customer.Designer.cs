namespace Final
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCustomerLogout = new System.Windows.Forms.Button();
            this.gbCloseAccount = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gbSeePerks = new System.Windows.Forms.GroupBox();
            this.rtbPerks = new System.Windows.Forms.RichTextBox();
            this.gbCustomerMakeChange = new System.Windows.Forms.GroupBox();
            this.btnMakeChange = new System.Windows.Forms.Button();
            this.lblCustomerMakeChangeResult = new System.Windows.Forms.Label();
            this.chkVerifyCustomer = new System.Windows.Forms.CheckBox();
            this.txtCustomerMakeChangeAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbCustomerCashCheck = new System.Windows.Forms.GroupBox();
            this.txtCheckAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCashCheck = new System.Windows.Forms.Button();
            this.lblCustomerCashCheckResult = new System.Windows.Forms.Label();
            this.txtCustomerCashCheckAccount = new System.Windows.Forms.TextBox();
            this.txtCustomerCashCheckName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbMakeLoan = new System.Windows.Forms.GroupBox();
            this.btnMakeLoan = new System.Windows.Forms.Button();
            this.lblLoanPayment = new System.Windows.Forms.Label();
            this.rbEightYear = new System.Windows.Forms.RadioButton();
            this.rbFiveYear = new System.Windows.Forms.RadioButton();
            this.rbThreeYear = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtWithdrawal = new System.Windows.Forms.TextBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.lblWithdrawalResult = new System.Windows.Forms.Label();
            this.lblDepositResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.gbCustomerAction = new System.Windows.Forms.GroupBox();
            this.rbCloseAccount = new System.Windows.Forms.RadioButton();
            this.rbCustomerMakeChange = new System.Windows.Forms.RadioButton();
            this.rbSeePerks = new System.Windows.Forms.RadioButton();
            this.rbCustomerCashCheck = new System.Windows.Forms.RadioButton();
            this.rbStartLoan = new System.Windows.Forms.RadioButton();
            this.lblWelcomeCustomer = new System.Windows.Forms.Label();
            this.pbCustomerAccount = new System.Windows.Forms.PictureBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.gbCloseAccount.SuspendLayout();
            this.gbSeePerks.SuspendLayout();
            this.gbCustomerMakeChange.SuspendLayout();
            this.gbCustomerCashCheck.SuspendLayout();
            this.gbMakeLoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbCustomerAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomerAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCustomerLogout
            // 
            this.btnCustomerLogout.Location = new System.Drawing.Point(702, 693);
            this.btnCustomerLogout.Name = "btnCustomerLogout";
            this.btnCustomerLogout.Size = new System.Drawing.Size(129, 62);
            this.btnCustomerLogout.TabIndex = 33;
            this.btnCustomerLogout.Text = "Logout";
            this.btnCustomerLogout.UseVisualStyleBackColor = true;
            this.btnCustomerLogout.Click += new System.EventHandler(this.btnCustomerLogout_Click);
            // 
            // gbCloseAccount
            // 
            this.gbCloseAccount.Controls.Add(this.btnClose);
            this.gbCloseAccount.Controls.Add(this.label6);
            this.gbCloseAccount.Location = new System.Drawing.Point(473, 567);
            this.gbCloseAccount.Name = "gbCloseAccount";
            this.gbCloseAccount.Size = new System.Drawing.Size(358, 120);
            this.gbCloseAccount.TabIndex = 32;
            this.gbCloseAccount.TabStop = false;
            this.gbCloseAccount.Text = "Close Account";
            this.gbCloseAccount.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Wide Latin", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(55, 37);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(229, 55);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Are you sure you want to close your account?";
            // 
            // gbSeePerks
            // 
            this.gbSeePerks.Controls.Add(this.rtbPerks);
            this.gbSeePerks.Location = new System.Drawing.Point(57, 485);
            this.gbSeePerks.Name = "gbSeePerks";
            this.gbSeePerks.Size = new System.Drawing.Size(383, 202);
            this.gbSeePerks.TabIndex = 31;
            this.gbSeePerks.TabStop = false;
            this.gbSeePerks.Text = "See Perks";
            this.gbSeePerks.Visible = false;
            // 
            // rtbPerks
            // 
            this.rtbPerks.Location = new System.Drawing.Point(12, 19);
            this.rtbPerks.Name = "rtbPerks";
            this.rtbPerks.Size = new System.Drawing.Size(362, 167);
            this.rtbPerks.TabIndex = 0;
            this.rtbPerks.Text = "";
            // 
            // gbCustomerMakeChange
            // 
            this.gbCustomerMakeChange.Controls.Add(this.btnMakeChange);
            this.gbCustomerMakeChange.Controls.Add(this.lblCustomerMakeChangeResult);
            this.gbCustomerMakeChange.Controls.Add(this.chkVerifyCustomer);
            this.gbCustomerMakeChange.Controls.Add(this.txtCustomerMakeChangeAmount);
            this.gbCustomerMakeChange.Controls.Add(this.label5);
            this.gbCustomerMakeChange.Location = new System.Drawing.Point(473, 423);
            this.gbCustomerMakeChange.Name = "gbCustomerMakeChange";
            this.gbCustomerMakeChange.Size = new System.Drawing.Size(358, 138);
            this.gbCustomerMakeChange.TabIndex = 30;
            this.gbCustomerMakeChange.TabStop = false;
            this.gbCustomerMakeChange.Text = "Make Change";
            this.gbCustomerMakeChange.Visible = false;
            // 
            // btnMakeChange
            // 
            this.btnMakeChange.Location = new System.Drawing.Point(170, 61);
            this.btnMakeChange.Name = "btnMakeChange";
            this.btnMakeChange.Size = new System.Drawing.Size(114, 39);
            this.btnMakeChange.TabIndex = 8;
            this.btnMakeChange.Text = "Make Change";
            this.btnMakeChange.UseVisualStyleBackColor = true;
            this.btnMakeChange.Click += new System.EventHandler(this.btnMakeChange_Click);
            // 
            // lblCustomerMakeChangeResult
            // 
            this.lblCustomerMakeChangeResult.AutoSize = true;
            this.lblCustomerMakeChangeResult.Location = new System.Drawing.Point(103, 103);
            this.lblCustomerMakeChangeResult.Name = "lblCustomerMakeChangeResult";
            this.lblCustomerMakeChangeResult.Size = new System.Drawing.Size(0, 15);
            this.lblCustomerMakeChangeResult.TabIndex = 7;
            // 
            // chkVerifyCustomer
            // 
            this.chkVerifyCustomer.AutoSize = true;
            this.chkVerifyCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.chkVerifyCustomer.Location = new System.Drawing.Point(79, 62);
            this.chkVerifyCustomer.Name = "chkVerifyCustomer";
            this.chkVerifyCustomer.Size = new System.Drawing.Size(85, 25);
            this.chkVerifyCustomer.TabIndex = 6;
            this.chkVerifyCustomer.Text = "Verified";
            this.chkVerifyCustomer.UseVisualStyleBackColor = true;
            // 
            // txtCustomerMakeChangeAmount
            // 
            this.txtCustomerMakeChangeAmount.Location = new System.Drawing.Point(154, 33);
            this.txtCustomerMakeChangeAmount.Name = "txtCustomerMakeChangeAmount";
            this.txtCustomerMakeChangeAmount.Size = new System.Drawing.Size(155, 23);
            this.txtCustomerMakeChangeAmount.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Change Amount:";
            // 
            // gbCustomerCashCheck
            // 
            this.gbCustomerCashCheck.Controls.Add(this.txtCheckAmount);
            this.gbCustomerCashCheck.Controls.Add(this.label9);
            this.gbCustomerCashCheck.Controls.Add(this.btnCashCheck);
            this.gbCustomerCashCheck.Controls.Add(this.lblCustomerCashCheckResult);
            this.gbCustomerCashCheck.Controls.Add(this.txtCustomerCashCheckAccount);
            this.gbCustomerCashCheck.Controls.Add(this.txtCustomerCashCheckName);
            this.gbCustomerCashCheck.Controls.Add(this.label4);
            this.gbCustomerCashCheck.Controls.Add(this.label3);
            this.gbCustomerCashCheck.Location = new System.Drawing.Point(473, 262);
            this.gbCustomerCashCheck.Name = "gbCustomerCashCheck";
            this.gbCustomerCashCheck.Size = new System.Drawing.Size(358, 155);
            this.gbCustomerCashCheck.TabIndex = 29;
            this.gbCustomerCashCheck.TabStop = false;
            this.gbCustomerCashCheck.Text = "Cash Check";
            this.gbCustomerCashCheck.Visible = false;
            // 
            // txtCheckAmount
            // 
            this.txtCheckAmount.Location = new System.Drawing.Point(93, 97);
            this.txtCheckAmount.Name = "txtCheckAmount";
            this.txtCheckAmount.Size = new System.Drawing.Size(101, 23);
            this.txtCheckAmount.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Amount:";
            // 
            // btnCashCheck
            // 
            this.btnCashCheck.Location = new System.Drawing.Point(265, 97);
            this.btnCashCheck.Name = "btnCashCheck";
            this.btnCashCheck.Size = new System.Drawing.Size(78, 26);
            this.btnCashCheck.TabIndex = 5;
            this.btnCashCheck.Text = "Cash Check";
            this.btnCashCheck.UseVisualStyleBackColor = true;
            this.btnCashCheck.Click += new System.EventHandler(this.btnCashCheck_Click);
            // 
            // lblCustomerCashCheckResult
            // 
            this.lblCustomerCashCheckResult.AutoSize = true;
            this.lblCustomerCashCheckResult.Location = new System.Drawing.Point(121, 127);
            this.lblCustomerCashCheckResult.Name = "lblCustomerCashCheckResult";
            this.lblCustomerCashCheckResult.Size = new System.Drawing.Size(0, 15);
            this.lblCustomerCashCheckResult.TabIndex = 4;
            // 
            // txtCustomerCashCheckAccount
            // 
            this.txtCustomerCashCheckAccount.Location = new System.Drawing.Point(141, 71);
            this.txtCustomerCashCheckAccount.Name = "txtCustomerCashCheckAccount";
            this.txtCustomerCashCheckAccount.Size = new System.Drawing.Size(171, 23);
            this.txtCustomerCashCheckAccount.TabIndex = 3;
            // 
            // txtCustomerCashCheckName
            // 
            this.txtCustomerCashCheckName.Location = new System.Drawing.Point(141, 34);
            this.txtCustomerCashCheckName.Name = "txtCustomerCashCheckName";
            this.txtCustomerCashCheckName.Size = new System.Drawing.Size(171, 23);
            this.txtCustomerCashCheckName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Account Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name on Account:";
            // 
            // gbMakeLoan
            // 
            this.gbMakeLoan.Controls.Add(this.btnMakeLoan);
            this.gbMakeLoan.Controls.Add(this.lblLoanPayment);
            this.gbMakeLoan.Controls.Add(this.rbEightYear);
            this.gbMakeLoan.Controls.Add(this.rbFiveYear);
            this.gbMakeLoan.Controls.Add(this.rbThreeYear);
            this.gbMakeLoan.Controls.Add(this.label8);
            this.gbMakeLoan.Controls.Add(this.txtLoanAmount);
            this.gbMakeLoan.Controls.Add(this.lblInterestRate);
            this.gbMakeLoan.Controls.Add(this.label7);
            this.gbMakeLoan.Location = new System.Drawing.Point(57, 262);
            this.gbMakeLoan.Name = "gbMakeLoan";
            this.gbMakeLoan.Size = new System.Drawing.Size(383, 217);
            this.gbMakeLoan.TabIndex = 28;
            this.gbMakeLoan.TabStop = false;
            this.gbMakeLoan.Text = "Make Loan";
            this.gbMakeLoan.Visible = false;
            // 
            // btnMakeLoan
            // 
            this.btnMakeLoan.Location = new System.Drawing.Point(108, 157);
            this.btnMakeLoan.Name = "btnMakeLoan";
            this.btnMakeLoan.Size = new System.Drawing.Size(146, 30);
            this.btnMakeLoan.TabIndex = 8;
            this.btnMakeLoan.Text = "Request Loan";
            this.btnMakeLoan.UseVisualStyleBackColor = true;
            this.btnMakeLoan.Click += new System.EventHandler(this.btnMakeLoan_Click);
            // 
            // lblLoanPayment
            // 
            this.lblLoanPayment.AutoSize = true;
            this.lblLoanPayment.Location = new System.Drawing.Point(135, 194);
            this.lblLoanPayment.Name = "lblLoanPayment";
            this.lblLoanPayment.Size = new System.Drawing.Size(0, 15);
            this.lblLoanPayment.TabIndex = 7;
            // 
            // rbEightYear
            // 
            this.rbEightYear.AutoSize = true;
            this.rbEightYear.Location = new System.Drawing.Point(261, 136);
            this.rbEightYear.Name = "rbEightYear";
            this.rbEightYear.Size = new System.Drawing.Size(56, 19);
            this.rbEightYear.TabIndex = 6;
            this.rbEightYear.TabStop = true;
            this.rbEightYear.Text = "8 Year";
            this.rbEightYear.UseVisualStyleBackColor = true;
            // 
            // rbFiveYear
            // 
            this.rbFiveYear.AutoSize = true;
            this.rbFiveYear.Location = new System.Drawing.Point(146, 136);
            this.rbFiveYear.Name = "rbFiveYear";
            this.rbFiveYear.Size = new System.Drawing.Size(56, 19);
            this.rbFiveYear.TabIndex = 5;
            this.rbFiveYear.TabStop = true;
            this.rbFiveYear.Text = "5 Year";
            this.rbFiveYear.UseVisualStyleBackColor = true;
            // 
            // rbThreeYear
            // 
            this.rbThreeYear.AutoSize = true;
            this.rbThreeYear.Location = new System.Drawing.Point(33, 136);
            this.rbThreeYear.Name = "rbThreeYear";
            this.rbThreeYear.Size = new System.Drawing.Size(56, 19);
            this.rbThreeYear.TabIndex = 4;
            this.rbThreeYear.TabStop = true;
            this.rbThreeYear.Text = "3 Year";
            this.rbThreeYear.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Loan Term";
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Location = new System.Drawing.Point(199, 71);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(156, 23);
            this.txtLoanAmount.TabIndex = 2;
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(146, 34);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(0, 15);
            this.lblInterestRate.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "How much will your loan be for?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final.Properties.Resources.FirstMidLogo;
            this.pictureBox1.Location = new System.Drawing.Point(46, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // txtWithdrawal
            // 
            this.txtWithdrawal.Location = new System.Drawing.Point(367, 124);
            this.txtWithdrawal.Name = "txtWithdrawal";
            this.txtWithdrawal.Size = new System.Drawing.Size(169, 23);
            this.txtWithdrawal.TabIndex = 26;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(367, 70);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(169, 23);
            this.txtDeposit.TabIndex = 25;
            // 
            // lblWithdrawalResult
            // 
            this.lblWithdrawalResult.AutoSize = true;
            this.lblWithdrawalResult.Location = new System.Drawing.Point(341, 154);
            this.lblWithdrawalResult.Name = "lblWithdrawalResult";
            this.lblWithdrawalResult.Size = new System.Drawing.Size(0, 15);
            this.lblWithdrawalResult.TabIndex = 24;
            // 
            // lblDepositResult
            // 
            this.lblDepositResult.AutoSize = true;
            this.lblDepositResult.Location = new System.Drawing.Point(341, 106);
            this.lblDepositResult.Name = "lblDepositResult";
            this.lblDepositResult.Size = new System.Drawing.Size(0, 15);
            this.lblDepositResult.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Make Withdrawal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Make Deposit:";
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.Location = new System.Drawing.Point(355, 38);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(0, 15);
            this.lblCurrentBalance.TabIndex = 20;
            // 
            // gbCustomerAction
            // 
            this.gbCustomerAction.Controls.Add(this.rbCloseAccount);
            this.gbCustomerAction.Controls.Add(this.rbCustomerMakeChange);
            this.gbCustomerAction.Controls.Add(this.rbSeePerks);
            this.gbCustomerAction.Controls.Add(this.rbCustomerCashCheck);
            this.gbCustomerAction.Controls.Add(this.rbStartLoan);
            this.gbCustomerAction.Location = new System.Drawing.Point(71, 181);
            this.gbCustomerAction.Name = "gbCustomerAction";
            this.gbCustomerAction.Size = new System.Drawing.Size(745, 59);
            this.gbCustomerAction.TabIndex = 19;
            this.gbCustomerAction.TabStop = false;
            this.gbCustomerAction.Text = "What would you like to do today?";
            // 
            // rbCloseAccount
            // 
            this.rbCloseAccount.AutoSize = true;
            this.rbCloseAccount.Location = new System.Drawing.Point(600, 22);
            this.rbCloseAccount.Name = "rbCloseAccount";
            this.rbCloseAccount.Size = new System.Drawing.Size(102, 19);
            this.rbCloseAccount.TabIndex = 4;
            this.rbCloseAccount.TabStop = true;
            this.rbCloseAccount.Text = "Close Account";
            this.rbCloseAccount.UseVisualStyleBackColor = true;
            this.rbCloseAccount.CheckedChanged += new System.EventHandler(this.rbCloseAccount_CheckedChanged);
            // 
            // rbCustomerMakeChange
            // 
            this.rbCustomerMakeChange.AutoSize = true;
            this.rbCustomerMakeChange.Location = new System.Drawing.Point(448, 22);
            this.rbCustomerMakeChange.Name = "rbCustomerMakeChange";
            this.rbCustomerMakeChange.Size = new System.Drawing.Size(98, 19);
            this.rbCustomerMakeChange.TabIndex = 3;
            this.rbCustomerMakeChange.TabStop = true;
            this.rbCustomerMakeChange.Text = "Make Change";
            this.rbCustomerMakeChange.UseVisualStyleBackColor = true;
            this.rbCustomerMakeChange.CheckedChanged += new System.EventHandler(this.rbCustomerMakeChange_CheckedChanged);
            // 
            // rbSeePerks
            // 
            this.rbSeePerks.AutoSize = true;
            this.rbSeePerks.Location = new System.Drawing.Point(314, 22);
            this.rbSeePerks.Name = "rbSeePerks";
            this.rbSeePerks.Size = new System.Drawing.Size(74, 19);
            this.rbSeePerks.TabIndex = 2;
            this.rbSeePerks.TabStop = true;
            this.rbSeePerks.Text = "See Perks";
            this.rbSeePerks.UseVisualStyleBackColor = true;
            this.rbSeePerks.CheckedChanged += new System.EventHandler(this.rbSeePerks_CheckedChanged);
            // 
            // rbCustomerCashCheck
            // 
            this.rbCustomerCashCheck.AutoSize = true;
            this.rbCustomerCashCheck.Location = new System.Drawing.Point(170, 22);
            this.rbCustomerCashCheck.Name = "rbCustomerCashCheck";
            this.rbCustomerCashCheck.Size = new System.Drawing.Size(87, 19);
            this.rbCustomerCashCheck.TabIndex = 1;
            this.rbCustomerCashCheck.TabStop = true;
            this.rbCustomerCashCheck.Text = "Cash Check";
            this.rbCustomerCashCheck.UseVisualStyleBackColor = true;
            this.rbCustomerCashCheck.CheckedChanged += new System.EventHandler(this.rbCustomerCashCheck_CheckedChanged);
            // 
            // rbStartLoan
            // 
            this.rbStartLoan.AutoSize = true;
            this.rbStartLoan.Location = new System.Drawing.Point(38, 22);
            this.rbStartLoan.Name = "rbStartLoan";
            this.rbStartLoan.Size = new System.Drawing.Size(78, 19);
            this.rbStartLoan.TabIndex = 0;
            this.rbStartLoan.TabStop = true;
            this.rbStartLoan.Text = "Start Loan";
            this.rbStartLoan.UseVisualStyleBackColor = true;
            this.rbStartLoan.CheckedChanged += new System.EventHandler(this.rbStartLoan_CheckedChanged);
            // 
            // lblWelcomeCustomer
            // 
            this.lblWelcomeCustomer.AutoSize = true;
            this.lblWelcomeCustomer.Location = new System.Drawing.Point(347, 11);
            this.lblWelcomeCustomer.Name = "lblWelcomeCustomer";
            this.lblWelcomeCustomer.Size = new System.Drawing.Size(0, 15);
            this.lblWelcomeCustomer.TabIndex = 18;
            // 
            // pbCustomerAccount
            // 
            this.pbCustomerAccount.Location = new System.Drawing.Point(576, 13);
            this.pbCustomerAccount.Name = "pbCustomerAccount";
            this.pbCustomerAccount.Size = new System.Drawing.Size(243, 146);
            this.pbCustomerAccount.TabIndex = 34;
            this.pbCustomerAccount.TabStop = false;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(452, 99);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(98, 22);
            this.btnDeposit.TabIndex = 35;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(452, 153);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(98, 21);
            this.btnWithdraw.TabIndex = 36;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(847, 762);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.pbCustomerAccount);
            this.Controls.Add(this.btnCustomerLogout);
            this.Controls.Add(this.gbCloseAccount);
            this.Controls.Add(this.gbSeePerks);
            this.Controls.Add(this.gbCustomerMakeChange);
            this.Controls.Add(this.gbCustomerCashCheck);
            this.Controls.Add(this.gbMakeLoan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtWithdrawal);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.lblWithdrawalResult);
            this.Controls.Add(this.lblDepositResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCurrentBalance);
            this.Controls.Add(this.gbCustomerAction);
            this.Controls.Add(this.lblWelcomeCustomer);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.gbCloseAccount.ResumeLayout(false);
            this.gbCloseAccount.PerformLayout();
            this.gbSeePerks.ResumeLayout(false);
            this.gbCustomerMakeChange.ResumeLayout(false);
            this.gbCustomerMakeChange.PerformLayout();
            this.gbCustomerCashCheck.ResumeLayout(false);
            this.gbCustomerCashCheck.PerformLayout();
            this.gbMakeLoan.ResumeLayout(false);
            this.gbMakeLoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbCustomerAction.ResumeLayout(false);
            this.gbCustomerAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomerAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCustomerLogout;
        private GroupBox gbCloseAccount;
        private Button btnClose;
        private Label label6;
        private GroupBox gbSeePerks;
        private GroupBox gbCustomerMakeChange;
        private Label lblCustomerMakeChangeResult;
        private CheckBox chkVerifyCustomer;
        private TextBox txtCustomerMakeChangeAmount;
        private Label label5;
        private GroupBox gbCustomerCashCheck;
        private Label lblCustomerCashCheckResult;
        private TextBox txtCustomerCashCheckAccount;
        private TextBox txtCustomerCashCheckName;
        private Label label4;
        private Label label3;
        private GroupBox gbMakeLoan;
        private Label lblLoanPayment;
        private RadioButton rbEightYear;
        private RadioButton rbFiveYear;
        private RadioButton rbThreeYear;
        private Label label8;
        private TextBox txtLoanAmount;
        private Label lblInterestRate;
        private Label label7;
        private PictureBox pictureBox1;
        private TextBox txtWithdrawal;
        private TextBox txtDeposit;
        private Label lblWithdrawalResult;
        private Label lblDepositResult;
        private Label label2;
        private Label label1;
        private Label lblCurrentBalance;
        private GroupBox gbCustomerAction;
        private RadioButton rbCloseAccount;
        private RadioButton rbCustomerMakeChange;
        private RadioButton rbSeePerks;
        private RadioButton rbCustomerCashCheck;
        private RadioButton rbStartLoan;
        private Label lblWelcomeCustomer;
        private PictureBox pbCustomerAccount;
        private Button btnDeposit;
        private Button btnWithdraw;
        private Button btnMakeChange;
        private TextBox txtCheckAmount;
        private Label label9;
        private Button btnCashCheck;
        private Button btnMakeLoan;
        private RichTextBox rtbPerks;
    }
}