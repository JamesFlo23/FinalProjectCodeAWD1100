namespace Final
{
    partial class NonCustomer
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
            this.pbNonCustomerAccount = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnNonCustomerLogout = new System.Windows.Forms.Button();
            this.gbOpenAccount = new System.Windows.Forms.GroupBox();
            this.btnOpenAccount = new System.Windows.Forms.Button();
            this.lblWelcomeNewCustomer = new System.Windows.Forms.Label();
            this.chkScannedId = new System.Windows.Forms.CheckBox();
            this.chkBackgroundCheck = new System.Windows.Forms.CheckBox();
            this.txtOpenAccountDeposit = new System.Windows.Forms.TextBox();
            this.txtOpenAccountNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbNonCustomerCashCheck = new System.Windows.Forms.GroupBox();
            this.txtCashCheckAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNonCustomerCashCheck = new System.Windows.Forms.Button();
            this.lblCashCheckResult = new System.Windows.Forms.Label();
            this.txtNonAccountNumber = new System.Windows.Forms.TextBox();
            this.txtNonAccountName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbNonCustomerMakeChange = new System.Windows.Forms.GroupBox();
            this.btnNonCustomerMakeChange = new System.Windows.Forms.Button();
            this.lblMakeChangeResult = new System.Windows.Forms.Label();
            this.chkVerify = new System.Windows.Forms.CheckBox();
            this.txtMakeChangeAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbNonCustomerAction = new System.Windows.Forms.GroupBox();
            this.rbOpenAccount = new System.Windows.Forms.RadioButton();
            this.rbCashCheck = new System.Windows.Forms.RadioButton();
            this.rbMakeChange = new System.Windows.Forms.RadioButton();
            this.lblWelcomeNon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbNonCustomerAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbOpenAccount.SuspendLayout();
            this.gbNonCustomerCashCheck.SuspendLayout();
            this.gbNonCustomerMakeChange.SuspendLayout();
            this.gbNonCustomerAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbNonCustomerAccount
            // 
            this.pbNonCustomerAccount.Location = new System.Drawing.Point(637, 14);
            this.pbNonCustomerAccount.Name = "pbNonCustomerAccount";
            this.pbNonCustomerAccount.Size = new System.Drawing.Size(249, 143);
            this.pbNonCustomerAccount.TabIndex = 16;
            this.pbNonCustomerAccount.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.Image = global::Final.Properties.Resources.FirstMidLogo;
            this.pbLogo.Location = new System.Drawing.Point(11, 28);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(248, 137);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 15;
            this.pbLogo.TabStop = false;
            // 
            // btnNonCustomerLogout
            // 
            this.btnNonCustomerLogout.Location = new System.Drawing.Point(761, 460);
            this.btnNonCustomerLogout.Name = "btnNonCustomerLogout";
            this.btnNonCustomerLogout.Size = new System.Drawing.Size(129, 62);
            this.btnNonCustomerLogout.TabIndex = 14;
            this.btnNonCustomerLogout.Text = "Logout";
            this.btnNonCustomerLogout.UseVisualStyleBackColor = true;
            this.btnNonCustomerLogout.Click += new System.EventHandler(this.btnNonCustomerLogout_Click);
            // 
            // gbOpenAccount
            // 
            this.gbOpenAccount.Controls.Add(this.btnOpenAccount);
            this.gbOpenAccount.Controls.Add(this.lblWelcomeNewCustomer);
            this.gbOpenAccount.Controls.Add(this.chkScannedId);
            this.gbOpenAccount.Controls.Add(this.chkBackgroundCheck);
            this.gbOpenAccount.Controls.Add(this.txtOpenAccountDeposit);
            this.gbOpenAccount.Controls.Add(this.txtOpenAccountNumber);
            this.gbOpenAccount.Controls.Add(this.label6);
            this.gbOpenAccount.Controls.Add(this.label5);
            this.gbOpenAccount.Location = new System.Drawing.Point(601, 173);
            this.gbOpenAccount.Name = "gbOpenAccount";
            this.gbOpenAccount.Size = new System.Drawing.Size(289, 258);
            this.gbOpenAccount.TabIndex = 13;
            this.gbOpenAccount.TabStop = false;
            this.gbOpenAccount.Text = "Open Account";
            this.gbOpenAccount.Visible = false;
            // 
            // btnOpenAccount
            // 
            this.btnOpenAccount.Location = new System.Drawing.Point(78, 170);
            this.btnOpenAccount.Name = "btnOpenAccount";
            this.btnOpenAccount.Size = new System.Drawing.Size(128, 50);
            this.btnOpenAccount.TabIndex = 9;
            this.btnOpenAccount.Text = "Open Account";
            this.btnOpenAccount.UseVisualStyleBackColor = true;
            this.btnOpenAccount.Click += new System.EventHandler(this.btnOpenAccount_Click);
            // 
            // lblWelcomeNewCustomer
            // 
            this.lblWelcomeNewCustomer.AutoSize = true;
            this.lblWelcomeNewCustomer.Location = new System.Drawing.Point(78, 223);
            this.lblWelcomeNewCustomer.Name = "lblWelcomeNewCustomer";
            this.lblWelcomeNewCustomer.Size = new System.Drawing.Size(146, 15);
            this.lblWelcomeNewCustomer.TabIndex = 6;
            this.lblWelcomeNewCustomer.Text = "lblWelcomeNewCustomer";
            // 
            // chkScannedId
            // 
            this.chkScannedId.AutoSize = true;
            this.chkScannedId.Location = new System.Drawing.Point(22, 135);
            this.chkScannedId.Name = "chkScannedId";
            this.chkScannedId.Size = new System.Drawing.Size(84, 19);
            this.chkScannedId.TabIndex = 5;
            this.chkScannedId.Text = "Scanned Id";
            this.chkScannedId.UseVisualStyleBackColor = true;
            // 
            // chkBackgroundCheck
            // 
            this.chkBackgroundCheck.AutoSize = true;
            this.chkBackgroundCheck.Location = new System.Drawing.Point(22, 107);
            this.chkBackgroundCheck.Name = "chkBackgroundCheck";
            this.chkBackgroundCheck.Size = new System.Drawing.Size(149, 19);
            this.chkBackgroundCheck.TabIndex = 4;
            this.chkBackgroundCheck.Text = "Background Check Ran";
            this.chkBackgroundCheck.UseVisualStyleBackColor = true;
            // 
            // txtOpenAccountDeposit
            // 
            this.txtOpenAccountDeposit.Location = new System.Drawing.Point(111, 70);
            this.txtOpenAccountDeposit.Name = "txtOpenAccountDeposit";
            this.txtOpenAccountDeposit.Size = new System.Drawing.Size(124, 23);
            this.txtOpenAccountDeposit.TabIndex = 3;
            // 
            // txtOpenAccountNumber
            // 
            this.txtOpenAccountNumber.Location = new System.Drawing.Point(146, 39);
            this.txtOpenAccountNumber.Name = "txtOpenAccountNumber";
            this.txtOpenAccountNumber.Size = new System.Drawing.Size(137, 23);
            this.txtOpenAccountNumber.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Opening Deposit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Verify Account Number:";
            // 
            // gbNonCustomerCashCheck
            // 
            this.gbNonCustomerCashCheck.Controls.Add(this.txtCashCheckAmount);
            this.gbNonCustomerCashCheck.Controls.Add(this.label7);
            this.gbNonCustomerCashCheck.Controls.Add(this.btnNonCustomerCashCheck);
            this.gbNonCustomerCashCheck.Controls.Add(this.lblCashCheckResult);
            this.gbNonCustomerCashCheck.Controls.Add(this.txtNonAccountNumber);
            this.gbNonCustomerCashCheck.Controls.Add(this.txtNonAccountName);
            this.gbNonCustomerCashCheck.Controls.Add(this.label2);
            this.gbNonCustomerCashCheck.Controls.Add(this.label1);
            this.gbNonCustomerCashCheck.Location = new System.Drawing.Point(307, 173);
            this.gbNonCustomerCashCheck.Name = "gbNonCustomerCashCheck";
            this.gbNonCustomerCashCheck.Size = new System.Drawing.Size(288, 209);
            this.gbNonCustomerCashCheck.TabIndex = 12;
            this.gbNonCustomerCashCheck.TabStop = false;
            this.gbNonCustomerCashCheck.Text = "Cash Check";
            this.gbNonCustomerCashCheck.Visible = false;
            // 
            // txtCashCheckAmount
            // 
            this.txtCashCheckAmount.Location = new System.Drawing.Point(117, 94);
            this.txtCashCheckAmount.Name = "txtCashCheckAmount";
            this.txtCashCheckAmount.Size = new System.Drawing.Size(100, 23);
            this.txtCashCheckAmount.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Check Amount:";
            // 
            // btnNonCustomerCashCheck
            // 
            this.btnNonCustomerCashCheck.Location = new System.Drawing.Point(81, 135);
            this.btnNonCustomerCashCheck.Name = "btnNonCustomerCashCheck";
            this.btnNonCustomerCashCheck.Size = new System.Drawing.Size(112, 23);
            this.btnNonCustomerCashCheck.TabIndex = 9;
            this.btnNonCustomerCashCheck.Text = "Cash Check";
            this.btnNonCustomerCashCheck.UseVisualStyleBackColor = true;
            this.btnNonCustomerCashCheck.Click += new System.EventHandler(this.btnNonCustomerCashCheck_Click);
            // 
            // lblCashCheckResult
            // 
            this.lblCashCheckResult.AutoSize = true;
            this.lblCashCheckResult.Location = new System.Drawing.Point(82, 170);
            this.lblCashCheckResult.Name = "lblCashCheckResult";
            this.lblCashCheckResult.Size = new System.Drawing.Size(0, 15);
            this.lblCashCheckResult.TabIndex = 10;
            // 
            // txtNonAccountNumber
            // 
            this.txtNonAccountNumber.Location = new System.Drawing.Point(117, 66);
            this.txtNonAccountNumber.Name = "txtNonAccountNumber";
            this.txtNonAccountNumber.Size = new System.Drawing.Size(165, 23);
            this.txtNonAccountNumber.TabIndex = 8;
            // 
            // txtNonAccountName
            // 
            this.txtNonAccountName.Location = new System.Drawing.Point(117, 29);
            this.txtNonAccountName.Name = "txtNonAccountName";
            this.txtNonAccountName.Size = new System.Drawing.Size(165, 23);
            this.txtNonAccountName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Account Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name on Account:";
            // 
            // gbNonCustomerMakeChange
            // 
            this.gbNonCustomerMakeChange.Controls.Add(this.btnNonCustomerMakeChange);
            this.gbNonCustomerMakeChange.Controls.Add(this.lblMakeChangeResult);
            this.gbNonCustomerMakeChange.Controls.Add(this.chkVerify);
            this.gbNonCustomerMakeChange.Controls.Add(this.txtMakeChangeAmount);
            this.gbNonCustomerMakeChange.Controls.Add(this.label4);
            this.gbNonCustomerMakeChange.Location = new System.Drawing.Point(11, 173);
            this.gbNonCustomerMakeChange.Name = "gbNonCustomerMakeChange";
            this.gbNonCustomerMakeChange.Size = new System.Drawing.Size(290, 154);
            this.gbNonCustomerMakeChange.TabIndex = 11;
            this.gbNonCustomerMakeChange.TabStop = false;
            this.gbNonCustomerMakeChange.Text = "Make Change";
            this.gbNonCustomerMakeChange.Visible = false;
            // 
            // btnNonCustomerMakeChange
            // 
            this.btnNonCustomerMakeChange.Location = new System.Drawing.Point(79, 94);
            this.btnNonCustomerMakeChange.Name = "btnNonCustomerMakeChange";
            this.btnNonCustomerMakeChange.Size = new System.Drawing.Size(102, 23);
            this.btnNonCustomerMakeChange.TabIndex = 8;
            this.btnNonCustomerMakeChange.Text = "Make Change";
            this.btnNonCustomerMakeChange.UseVisualStyleBackColor = true;
            this.btnNonCustomerMakeChange.Click += new System.EventHandler(this.btnNonCustomerMakeChange_Click);
            // 
            // lblMakeChangeResult
            // 
            this.lblMakeChangeResult.AutoSize = true;
            this.lblMakeChangeResult.Location = new System.Drawing.Point(79, 129);
            this.lblMakeChangeResult.Name = "lblMakeChangeResult";
            this.lblMakeChangeResult.Size = new System.Drawing.Size(0, 15);
            this.lblMakeChangeResult.TabIndex = 3;
            // 
            // chkVerify
            // 
            this.chkVerify.AutoSize = true;
            this.chkVerify.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.chkVerify.Location = new System.Drawing.Point(54, 63);
            this.chkVerify.Name = "chkVerify";
            this.chkVerify.Size = new System.Drawing.Size(85, 25);
            this.chkVerify.TabIndex = 2;
            this.chkVerify.Text = "Verified";
            this.chkVerify.UseVisualStyleBackColor = true;
            // 
            // txtMakeChangeAmount
            // 
            this.txtMakeChangeAmount.Location = new System.Drawing.Point(129, 34);
            this.txtMakeChangeAmount.Name = "txtMakeChangeAmount";
            this.txtMakeChangeAmount.Size = new System.Drawing.Size(155, 23);
            this.txtMakeChangeAmount.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Change Amount:";
            // 
            // gbNonCustomerAction
            // 
            this.gbNonCustomerAction.Controls.Add(this.rbOpenAccount);
            this.gbNonCustomerAction.Controls.Add(this.rbCashCheck);
            this.gbNonCustomerAction.Controls.Add(this.rbMakeChange);
            this.gbNonCustomerAction.Location = new System.Drawing.Point(282, 36);
            this.gbNonCustomerAction.Name = "gbNonCustomerAction";
            this.gbNonCustomerAction.Size = new System.Drawing.Size(343, 131);
            this.gbNonCustomerAction.TabIndex = 10;
            this.gbNonCustomerAction.TabStop = false;
            this.gbNonCustomerAction.Text = "What would you like to do today?";
            // 
            // rbOpenAccount
            // 
            this.rbOpenAccount.AutoSize = true;
            this.rbOpenAccount.Location = new System.Drawing.Point(106, 79);
            this.rbOpenAccount.Name = "rbOpenAccount";
            this.rbOpenAccount.Size = new System.Drawing.Size(102, 19);
            this.rbOpenAccount.TabIndex = 2;
            this.rbOpenAccount.TabStop = true;
            this.rbOpenAccount.Text = "Open Account";
            this.rbOpenAccount.UseVisualStyleBackColor = true;
            this.rbOpenAccount.CheckedChanged += new System.EventHandler(this.rbOpenAccount_CheckedChanged);
            // 
            // rbCashCheck
            // 
            this.rbCashCheck.AutoSize = true;
            this.rbCashCheck.Location = new System.Drawing.Point(195, 37);
            this.rbCashCheck.Name = "rbCashCheck";
            this.rbCashCheck.Size = new System.Drawing.Size(87, 19);
            this.rbCashCheck.TabIndex = 1;
            this.rbCashCheck.TabStop = true;
            this.rbCashCheck.Text = "Cash Check";
            this.rbCashCheck.UseVisualStyleBackColor = true;
            this.rbCashCheck.CheckedChanged += new System.EventHandler(this.rbCashCheck_CheckedChanged);
            // 
            // rbMakeChange
            // 
            this.rbMakeChange.AutoSize = true;
            this.rbMakeChange.Location = new System.Drawing.Point(31, 37);
            this.rbMakeChange.Name = "rbMakeChange";
            this.rbMakeChange.Size = new System.Drawing.Size(98, 19);
            this.rbMakeChange.TabIndex = 0;
            this.rbMakeChange.TabStop = true;
            this.rbMakeChange.Text = "Make Change";
            this.rbMakeChange.UseVisualStyleBackColor = true;
            this.rbMakeChange.CheckedChanged += new System.EventHandler(this.rbMakeChange_CheckedChanged);
            // 
            // lblWelcomeNon
            // 
            this.lblWelcomeNon.AutoSize = true;
            this.lblWelcomeNon.Location = new System.Drawing.Point(388, 6);
            this.lblWelcomeNon.Name = "lblWelcomeNon";
            this.lblWelcomeNon.Size = new System.Drawing.Size(0, 15);
            this.lblWelcomeNon.TabIndex = 9;
            // 
            // NonCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(894, 526);
            this.Controls.Add(this.pbNonCustomerAccount);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnNonCustomerLogout);
            this.Controls.Add(this.gbOpenAccount);
            this.Controls.Add(this.gbNonCustomerCashCheck);
            this.Controls.Add(this.gbNonCustomerMakeChange);
            this.Controls.Add(this.gbNonCustomerAction);
            this.Controls.Add(this.lblWelcomeNon);
            this.Name = "NonCustomer";
            this.Text = "NonCustomer";
            this.Load += new System.EventHandler(this.NonCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbNonCustomerAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbOpenAccount.ResumeLayout(false);
            this.gbOpenAccount.PerformLayout();
            this.gbNonCustomerCashCheck.ResumeLayout(false);
            this.gbNonCustomerCashCheck.PerformLayout();
            this.gbNonCustomerMakeChange.ResumeLayout(false);
            this.gbNonCustomerMakeChange.PerformLayout();
            this.gbNonCustomerAction.ResumeLayout(false);
            this.gbNonCustomerAction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbNonCustomerAccount;
        private PictureBox pbLogo;
        private Button btnNonCustomerLogout;
        private GroupBox gbOpenAccount;
        private Button btnOpenAccount;
        private Label lblWelcomeNewCustomer;
        private CheckBox chkScannedId;
        private CheckBox chkBackgroundCheck;
        private TextBox txtOpenAccountDeposit;
        private TextBox txtOpenAccountNumber;
        private Label label6;
        private Label label5;
        private GroupBox gbNonCustomerCashCheck;
        private Button btnNonCustomerCashCheck;
        private Label lblCashCheckResult;
        private TextBox txtNonAccountNumber;
        private TextBox txtNonAccountName;
        private Label label2;
        private Label label1;
        private GroupBox gbNonCustomerMakeChange;
        private Button btnNonCustomerMakeChange;
        private Label lblMakeChangeResult;
        private CheckBox chkVerify;
        private TextBox txtMakeChangeAmount;
        private Label label4;
        private GroupBox gbNonCustomerAction;
        private RadioButton rbOpenAccount;
        private RadioButton rbCashCheck;
        private RadioButton rbMakeChange;
        private Label lblWelcomeNon;
        private TextBox txtCashCheckAmount;
        private Label label7;
    }
}