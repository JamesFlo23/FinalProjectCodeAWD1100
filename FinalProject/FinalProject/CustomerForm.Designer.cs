namespace FinalProject
{
    partial class CustomerForm
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
            this.lblWelcomeCustomer = new System.Windows.Forms.Label();
            this.gbCustomerAction = new System.Windows.Forms.GroupBox();
            this.rbCloseAccount = new System.Windows.Forms.RadioButton();
            this.rbCustomerMakeChange = new System.Windows.Forms.RadioButton();
            this.rbSeePerks = new System.Windows.Forms.RadioButton();
            this.rbCustomerCashCheck = new System.Windows.Forms.RadioButton();
            this.rbStartLoan = new System.Windows.Forms.RadioButton();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDepositResult = new System.Windows.Forms.Label();
            this.lblWithdrawalResult = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.txtWithdrawal = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbMakeLoan = new System.Windows.Forms.GroupBox();
            this.lblLoanPayment = new System.Windows.Forms.Label();
            this.rbEightYear = new System.Windows.Forms.RadioButton();
            this.rbFiveYear = new System.Windows.Forms.RadioButton();
            this.rbThreeYear = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbCustomerCashCheck = new System.Windows.Forms.GroupBox();
            this.lblCustomerCashCheckResult = new System.Windows.Forms.Label();
            this.txtCustomerCashCheckAccount = new System.Windows.Forms.TextBox();
            this.txtCustomerCashCheckName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbCustomerMakeChange = new System.Windows.Forms.GroupBox();
            this.lblCustomerMakeChangeResult = new System.Windows.Forms.Label();
            this.chkVerifyCustomer = new System.Windows.Forms.CheckBox();
            this.txtCustomerMakeChangeAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbSeePerks = new System.Windows.Forms.GroupBox();
            this.lbxPerks = new System.Windows.Forms.ListBox();
            this.gbCloseAccount = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCustomerLogout = new System.Windows.Forms.Button();
            this.gbCustomerAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbMakeLoan.SuspendLayout();
            this.gbCustomerCashCheck.SuspendLayout();
            this.gbCustomerMakeChange.SuspendLayout();
            this.gbSeePerks.SuspendLayout();
            this.gbCloseAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcomeCustomer
            // 
            this.lblWelcomeCustomer.AutoSize = true;
            this.lblWelcomeCustomer.Location = new System.Drawing.Point(313, 17);
            this.lblWelcomeCustomer.Name = "lblWelcomeCustomer";
            this.lblWelcomeCustomer.Size = new System.Drawing.Size(122, 15);
            this.lblWelcomeCustomer.TabIndex = 1;
            this.lblWelcomeCustomer.Text = "lblWelcomeCustomer";
            // 
            // gbCustomerAction
            // 
            this.gbCustomerAction.Controls.Add(this.rbCloseAccount);
            this.gbCustomerAction.Controls.Add(this.rbCustomerMakeChange);
            this.gbCustomerAction.Controls.Add(this.rbSeePerks);
            this.gbCustomerAction.Controls.Add(this.rbCustomerCashCheck);
            this.gbCustomerAction.Controls.Add(this.rbStartLoan);
            this.gbCustomerAction.Location = new System.Drawing.Point(37, 187);
            this.gbCustomerAction.Name = "gbCustomerAction";
            this.gbCustomerAction.Size = new System.Drawing.Size(745, 59);
            this.gbCustomerAction.TabIndex = 2;
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
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.Location = new System.Drawing.Point(321, 44);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(101, 15);
            this.lblCurrentBalance.TabIndex = 3;
            this.lblCurrentBalance.Text = "lblCurrentBalance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Make Deposit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Make Withdrawal:";
            // 
            // lblDepositResult
            // 
            this.lblDepositResult.AutoSize = true;
            this.lblDepositResult.Location = new System.Drawing.Point(307, 112);
            this.lblDepositResult.Name = "lblDepositResult";
            this.lblDepositResult.Size = new System.Drawing.Size(92, 15);
            this.lblDepositResult.TabIndex = 6;
            this.lblDepositResult.Text = "lblDepositResult";
            // 
            // lblWithdrawalResult
            // 
            this.lblWithdrawalResult.AutoSize = true;
            this.lblWithdrawalResult.Location = new System.Drawing.Point(307, 160);
            this.lblWithdrawalResult.Name = "lblWithdrawalResult";
            this.lblWithdrawalResult.Size = new System.Drawing.Size(112, 15);
            this.lblWithdrawalResult.TabIndex = 7;
            this.lblWithdrawalResult.Text = "lblWithdrawalResult";
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(333, 81);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(169, 23);
            this.txtDeposit.TabIndex = 8;
            // 
            // txtWithdrawal
            // 
            this.txtWithdrawal.Location = new System.Drawing.Point(333, 130);
            this.txtWithdrawal.Name = "txtWithdrawal";
            this.txtWithdrawal.Size = new System.Drawing.Size(169, 23);
            this.txtWithdrawal.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.FirstMidLogo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // gbMakeLoan
            // 
            this.gbMakeLoan.Controls.Add(this.lblLoanPayment);
            this.gbMakeLoan.Controls.Add(this.rbEightYear);
            this.gbMakeLoan.Controls.Add(this.rbFiveYear);
            this.gbMakeLoan.Controls.Add(this.rbThreeYear);
            this.gbMakeLoan.Controls.Add(this.label8);
            this.gbMakeLoan.Controls.Add(this.textBox1);
            this.gbMakeLoan.Controls.Add(this.lblInterestRate);
            this.gbMakeLoan.Controls.Add(this.label7);
            this.gbMakeLoan.Location = new System.Drawing.Point(23, 268);
            this.gbMakeLoan.Name = "gbMakeLoan";
            this.gbMakeLoan.Size = new System.Drawing.Size(383, 217);
            this.gbMakeLoan.TabIndex = 12;
            this.gbMakeLoan.TabStop = false;
            this.gbMakeLoan.Text = "Make Loan";
            // 
            // lblLoanPayment
            // 
            this.lblLoanPayment.AutoSize = true;
            this.lblLoanPayment.Location = new System.Drawing.Point(135, 178);
            this.lblLoanPayment.Name = "lblLoanPayment";
            this.lblLoanPayment.Size = new System.Drawing.Size(93, 15);
            this.lblLoanPayment.TabIndex = 7;
            this.lblLoanPayment.Text = "lblLoanPayment";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 23);
            this.textBox1.TabIndex = 2;
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(146, 34);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(82, 15);
            this.lblInterestRate.TabIndex = 1;
            this.lblInterestRate.Text = "lblInterestRate";
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
            // gbCustomerCashCheck
            // 
            this.gbCustomerCashCheck.Controls.Add(this.lblCustomerCashCheckResult);
            this.gbCustomerCashCheck.Controls.Add(this.txtCustomerCashCheckAccount);
            this.gbCustomerCashCheck.Controls.Add(this.txtCustomerCashCheckName);
            this.gbCustomerCashCheck.Controls.Add(this.label4);
            this.gbCustomerCashCheck.Controls.Add(this.label3);
            this.gbCustomerCashCheck.Location = new System.Drawing.Point(439, 268);
            this.gbCustomerCashCheck.Name = "gbCustomerCashCheck";
            this.gbCustomerCashCheck.Size = new System.Drawing.Size(358, 155);
            this.gbCustomerCashCheck.TabIndex = 13;
            this.gbCustomerCashCheck.TabStop = false;
            this.gbCustomerCashCheck.Text = "Cash Check";
            // 
            // lblCustomerCashCheckResult
            // 
            this.lblCustomerCashCheckResult.AutoSize = true;
            this.lblCustomerCashCheckResult.Location = new System.Drawing.Point(121, 108);
            this.lblCustomerCashCheckResult.Name = "lblCustomerCashCheckResult";
            this.lblCustomerCashCheckResult.Size = new System.Drawing.Size(163, 15);
            this.lblCustomerCashCheckResult.TabIndex = 4;
            this.lblCustomerCashCheckResult.Text = "lblCustomerCashCheckResult";
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
            // gbCustomerMakeChange
            // 
            this.gbCustomerMakeChange.Controls.Add(this.lblCustomerMakeChangeResult);
            this.gbCustomerMakeChange.Controls.Add(this.chkVerifyCustomer);
            this.gbCustomerMakeChange.Controls.Add(this.txtCustomerMakeChangeAmount);
            this.gbCustomerMakeChange.Controls.Add(this.label5);
            this.gbCustomerMakeChange.Location = new System.Drawing.Point(439, 429);
            this.gbCustomerMakeChange.Name = "gbCustomerMakeChange";
            this.gbCustomerMakeChange.Size = new System.Drawing.Size(358, 138);
            this.gbCustomerMakeChange.TabIndex = 14;
            this.gbCustomerMakeChange.TabStop = false;
            this.gbCustomerMakeChange.Text = "Make Change";
            // 
            // lblCustomerMakeChangeResult
            // 
            this.lblCustomerMakeChangeResult.AutoSize = true;
            this.lblCustomerMakeChangeResult.Location = new System.Drawing.Point(103, 90);
            this.lblCustomerMakeChangeResult.Name = "lblCustomerMakeChangeResult";
            this.lblCustomerMakeChangeResult.Size = new System.Drawing.Size(122, 15);
            this.lblCustomerMakeChangeResult.TabIndex = 7;
            this.lblCustomerMakeChangeResult.Text = "lblMakeChangeResult";
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
            // gbSeePerks
            // 
            this.gbSeePerks.Controls.Add(this.lbxPerks);
            this.gbSeePerks.Location = new System.Drawing.Point(23, 491);
            this.gbSeePerks.Name = "gbSeePerks";
            this.gbSeePerks.Size = new System.Drawing.Size(383, 202);
            this.gbSeePerks.TabIndex = 15;
            this.gbSeePerks.TabStop = false;
            this.gbSeePerks.Text = "See Perks";
            // 
            // lbxPerks
            // 
            this.lbxPerks.FormattingEnabled = true;
            this.lbxPerks.ItemHeight = 15;
            this.lbxPerks.Location = new System.Drawing.Point(22, 22);
            this.lbxPerks.Name = "lbxPerks";
            this.lbxPerks.Size = new System.Drawing.Size(338, 169);
            this.lbxPerks.TabIndex = 0;
            // 
            // gbCloseAccount
            // 
            this.gbCloseAccount.Controls.Add(this.btnClose);
            this.gbCloseAccount.Controls.Add(this.label6);
            this.gbCloseAccount.Location = new System.Drawing.Point(439, 573);
            this.gbCloseAccount.Name = "gbCloseAccount";
            this.gbCloseAccount.Size = new System.Drawing.Size(358, 120);
            this.gbCloseAccount.TabIndex = 16;
            this.gbCloseAccount.TabStop = false;
            this.gbCloseAccount.Text = "Close Account";
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
            // btnCustomerLogout
            // 
            this.btnCustomerLogout.Location = new System.Drawing.Point(668, 699);
            this.btnCustomerLogout.Name = "btnCustomerLogout";
            this.btnCustomerLogout.Size = new System.Drawing.Size(129, 62);
            this.btnCustomerLogout.TabIndex = 17;
            this.btnCustomerLogout.Text = "Logout";
            this.btnCustomerLogout.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 772);
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
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.gbCustomerAction.ResumeLayout(false);
            this.gbCustomerAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbMakeLoan.ResumeLayout(false);
            this.gbMakeLoan.PerformLayout();
            this.gbCustomerCashCheck.ResumeLayout(false);
            this.gbCustomerCashCheck.PerformLayout();
            this.gbCustomerMakeChange.ResumeLayout(false);
            this.gbCustomerMakeChange.PerformLayout();
            this.gbSeePerks.ResumeLayout(false);
            this.gbCloseAccount.ResumeLayout(false);
            this.gbCloseAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblWelcomeCustomer;
        private GroupBox gbCustomerAction;
        private RadioButton rbCloseAccount;
        private RadioButton rbCustomerMakeChange;
        private RadioButton rbSeePerks;
        private RadioButton rbCustomerCashCheck;
        private RadioButton rbStartLoan;
        private Label lblCurrentBalance;
        private Label label1;
        private Label label2;
        private Label lblDepositResult;
        private Label lblWithdrawalResult;
        private TextBox txtDeposit;
        private TextBox txtWithdrawal;
        private PictureBox pictureBox1;
        private GroupBox gbMakeLoan;
        private GroupBox gbCustomerCashCheck;
        private Label label4;
        private Label label3;
        private Label lblCustomerCashCheckResult;
        private TextBox txtCustomerCashCheckAccount;
        private TextBox txtCustomerCashCheckName;
        private Label lblLoanPayment;
        private RadioButton rbEightYear;
        private RadioButton rbFiveYear;
        private RadioButton rbThreeYear;
        private Label label8;
        private TextBox textBox1;
        private Label lblInterestRate;
        private Label label7;
        private GroupBox gbCustomerMakeChange;
        private Label lblCustomerMakeChangeResult;
        private CheckBox chkVerifyCustomer;
        private TextBox txtCustomerMakeChangeAmount;
        private Label label5;
        private GroupBox gbSeePerks;
        private ListBox lbxPerks;
        private GroupBox gbCloseAccount;
        private Button btnClose;
        private Label label6;
        private Button btnCustomerLogout;
    }
}