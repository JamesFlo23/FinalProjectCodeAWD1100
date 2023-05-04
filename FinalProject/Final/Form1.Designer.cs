namespace Final
{
    partial class Form1
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
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.txtSsn = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbGuest = new System.Windows.Forms.GroupBox();
            this.rbCustomer = new System.Windows.Forms.RadioButton();
            this.rbNoncustomer = new System.Windows.Forms.RadioButton();
            this.lblFailedLogin = new System.Windows.Forms.Label();
            this.gbLogin.SuspendLayout();
            this.gbGuest.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.lblWelcomeUser);
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.txtIdNumber);
            this.gbLogin.Controls.Add(this.txtSsn);
            this.gbLogin.Controls.Add(this.txtName);
            this.gbLogin.Controls.Add(this.label3);
            this.gbLogin.Controls.Add(this.label2);
            this.gbLogin.Controls.Add(this.label1);
            this.gbLogin.Location = new System.Drawing.Point(22, 75);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(495, 152);
            this.gbLogin.TabIndex = 4;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "gbLogin";
            this.gbLogin.Visible = false;
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.AutoSize = true;
            this.lblWelcomeUser.Location = new System.Drawing.Point(224, 16);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(0, 15);
            this.lblWelcomeUser.TabIndex = 7;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(313, 70);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(159, 56);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(119, 102);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(182, 23);
            this.txtIdNumber.TabIndex = 5;
            // 
            // txtSsn
            // 
            this.txtSsn.Location = new System.Drawing.Point(119, 70);
            this.txtSsn.Name = "txtSsn";
            this.txtSsn.Size = new System.Drawing.Size(182, 23);
            this.txtSsn.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(119, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 23);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID#:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "SSN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // gbGuest
            // 
            this.gbGuest.Controls.Add(this.rbCustomer);
            this.gbGuest.Controls.Add(this.rbNoncustomer);
            this.gbGuest.Location = new System.Drawing.Point(150, 21);
            this.gbGuest.Name = "gbGuest";
            this.gbGuest.Size = new System.Drawing.Size(242, 58);
            this.gbGuest.TabIndex = 3;
            this.gbGuest.TabStop = false;
            this.gbGuest.Text = "gbGuest";
            // 
            // rbCustomer
            // 
            this.rbCustomer.AutoSize = true;
            this.rbCustomer.Location = new System.Drawing.Point(153, 22);
            this.rbCustomer.Name = "rbCustomer";
            this.rbCustomer.Size = new System.Drawing.Size(77, 19);
            this.rbCustomer.TabIndex = 1;
            this.rbCustomer.TabStop = true;
            this.rbCustomer.Text = "Customer";
            this.rbCustomer.UseVisualStyleBackColor = true;
            this.rbCustomer.CheckedChanged += new System.EventHandler(this.rbCustomer_CheckedChanged);
            // 
            // rbNoncustomer
            // 
            this.rbNoncustomer.AutoSize = true;
            this.rbNoncustomer.Location = new System.Drawing.Point(11, 22);
            this.rbNoncustomer.Name = "rbNoncustomer";
            this.rbNoncustomer.Size = new System.Drawing.Size(105, 19);
            this.rbNoncustomer.TabIndex = 0;
            this.rbNoncustomer.TabStop = true;
            this.rbNoncustomer.Text = "Non-Customer";
            this.rbNoncustomer.UseVisualStyleBackColor = true;
            this.rbNoncustomer.CheckedChanged += new System.EventHandler(this.rbNoncustomer_CheckedChanged);
            // 
            // lblFailedLogin
            // 
            this.lblFailedLogin.AutoSize = true;
            this.lblFailedLogin.Location = new System.Drawing.Point(141, 230);
            this.lblFailedLogin.Name = "lblFailedLogin";
            this.lblFailedLogin.Size = new System.Drawing.Size(0, 15);
            this.lblFailedLogin.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 293);
            this.Controls.Add(this.lblFailedLogin);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.gbGuest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbGuest.ResumeLayout(false);
            this.gbGuest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox gbLogin;
        private Label lblWelcomeUser;
        private Button btnLogin;
        private TextBox txtIdNumber;
        private TextBox txtSsn;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox gbGuest;
        private RadioButton rbCustomer;
        private RadioButton rbNoncustomer;
        private Label lblFailedLogin;
    }
}