namespace Object_Oriented_Programming
{
    partial class Form2
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
            pctSignUp = new PictureBox();
            pnlSignUp = new Panel();
            chkTermsAndConditions = new CheckBox();
            txtContactNo = new TextBox();
            lblContactNo = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            lblMessageSignUp = new Label();
            lblCreateYourAccount = new Label();
            lblLastName = new Label();
            btnLogIninSignUp = new Button();
            btnSignUp = new Button();
            txtSignUpPassword = new TextBox();
            lblSignUpPassword = new Label();
            txtSignUpEmailAddress = new TextBox();
            lblSignUpEmailAddress = new Label();
            lblSignUpValora = new Label();
            lblAlreadyHaveAnAccount = new Label();
            txtLastName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pctSignUp).BeginInit();
            pnlSignUp.SuspendLayout();
            SuspendLayout();
            // 
            // pctSignUp
            // 
            pctSignUp.Image = Properties.Resources._5e6a7038_1ced_49a1_889f_c579b889d961_removebg_preview;
            pctSignUp.Location = new Point(55, 32);
            pctSignUp.Name = "pctSignUp";
            pctSignUp.Size = new Size(478, 643);
            pctSignUp.SizeMode = PictureBoxSizeMode.StretchImage;
            pctSignUp.TabIndex = 1;
            pctSignUp.TabStop = false;
            // 
            // pnlSignUp
            // 
            pnlSignUp.BackColor = Color.White;
            pnlSignUp.Controls.Add(txtLastName);
            pnlSignUp.Controls.Add(chkTermsAndConditions);
            pnlSignUp.Controls.Add(txtContactNo);
            pnlSignUp.Controls.Add(lblContactNo);
            pnlSignUp.Controls.Add(txtFirstName);
            pnlSignUp.Controls.Add(lblFirstName);
            pnlSignUp.Controls.Add(lblMessageSignUp);
            pnlSignUp.Controls.Add(lblCreateYourAccount);
            pnlSignUp.Controls.Add(lblLastName);
            pnlSignUp.Controls.Add(btnLogIninSignUp);
            pnlSignUp.Controls.Add(btnSignUp);
            pnlSignUp.Controls.Add(txtSignUpPassword);
            pnlSignUp.Controls.Add(lblSignUpPassword);
            pnlSignUp.Controls.Add(txtSignUpEmailAddress);
            pnlSignUp.Controls.Add(lblSignUpEmailAddress);
            pnlSignUp.Controls.Add(lblSignUpValora);
            pnlSignUp.Location = new Point(662, 32);
            pnlSignUp.Name = "pnlSignUp";
            pnlSignUp.Size = new Size(341, 569);
            pnlSignUp.TabIndex = 2;
            // 
            // chkTermsAndConditions
            // 
            chkTermsAndConditions.AutoSize = true;
            chkTermsAndConditions.Location = new Point(30, 436);
            chkTermsAndConditions.Name = "chkTermsAndConditions";
            chkTermsAndConditions.Size = new Size(193, 19);
            chkTermsAndConditions.TabIndex = 21;
            chkTermsAndConditions.Text = "Agree to Terms and Conditions.";
            chkTermsAndConditions.UseVisualStyleBackColor = true;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(30, 292);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(278, 23);
            txtContactNo.TabIndex = 20;
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Location = new Point(30, 274);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(96, 15);
            lblContactNo.TabIndex = 19;
            lblContactNo.Text = "Contact Number";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(30, 236);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(278, 23);
            txtFirstName.TabIndex = 18;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(30, 218);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 17;
            lblFirstName.Text = "First Name";
            // 
            // lblMessageSignUp
            // 
            lblMessageSignUp.AutoSize = true;
            lblMessageSignUp.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessageSignUp.Location = new Point(43, 128);
            lblMessageSignUp.Name = "lblMessageSignUp";
            lblMessageSignUp.Size = new Size(256, 17);
            lblMessageSignUp.TabIndex = 16;
            lblMessageSignUp.Text = "Join us and find your next home with ease.";
            // 
            // lblCreateYourAccount
            // 
            lblCreateYourAccount.AutoSize = true;
            lblCreateYourAccount.Font = new Font("Georgia", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreateYourAccount.Location = new Point(30, 94);
            lblCreateYourAccount.Name = "lblCreateYourAccount";
            lblCreateYourAccount.Size = new Size(281, 34);
            lblCreateYourAccount.TabIndex = 15;
            lblCreateYourAccount.Text = "Create Your Account";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(30, 163);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 13;
            lblLastName.Text = "Last Name";
            // 
            // btnLogIninSignUp
            // 
            btnLogIninSignUp.Location = new Point(174, 524);
            btnLogIninSignUp.Name = "btnLogIninSignUp";
            btnLogIninSignUp.Size = new Size(75, 23);
            btnLogIninSignUp.TabIndex = 10;
            btnLogIninSignUp.Text = "Log In";
            btnLogIninSignUp.UseVisualStyleBackColor = true;
            btnLogIninSignUp.Click += btnLogIninSignUp_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.DarkGreen;
            btnSignUp.FlatStyle = FlatStyle.Popup;
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(30, 471);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(278, 33);
            btnSignUp.TabIndex = 8;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // txtSignUpPassword
            // 
            txtSignUpPassword.Location = new Point(30, 407);
            txtSignUpPassword.Name = "txtSignUpPassword";
            txtSignUpPassword.Size = new Size(278, 23);
            txtSignUpPassword.TabIndex = 6;
            // 
            // lblSignUpPassword
            // 
            lblSignUpPassword.AutoSize = true;
            lblSignUpPassword.Location = new Point(30, 389);
            lblSignUpPassword.Name = "lblSignUpPassword";
            lblSignUpPassword.Size = new Size(57, 15);
            lblSignUpPassword.TabIndex = 5;
            lblSignUpPassword.Text = "Password";
            // 
            // txtSignUpEmailAddress
            // 
            txtSignUpEmailAddress.Location = new Point(30, 348);
            txtSignUpEmailAddress.Name = "txtSignUpEmailAddress";
            txtSignUpEmailAddress.Size = new Size(278, 23);
            txtSignUpEmailAddress.TabIndex = 4;
            // 
            // lblSignUpEmailAddress
            // 
            lblSignUpEmailAddress.AutoSize = true;
            lblSignUpEmailAddress.Location = new Point(30, 330);
            lblSignUpEmailAddress.Name = "lblSignUpEmailAddress";
            lblSignUpEmailAddress.Size = new Size(81, 15);
            lblSignUpEmailAddress.TabIndex = 3;
            lblSignUpEmailAddress.Text = "Email Address";
            // 
            // lblSignUpValora
            // 
            lblSignUpValora.AutoSize = true;
            lblSignUpValora.Font = new Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSignUpValora.Location = new Point(136, 50);
            lblSignUpValora.Name = "lblSignUpValora";
            lblSignUpValora.Size = new Size(74, 25);
            lblSignUpValora.TabIndex = 0;
            lblSignUpValora.Text = "Valora";
            // 
            // lblAlreadyHaveAnAccount
            // 
            lblAlreadyHaveAnAccount.Location = new Point(0, 0);
            lblAlreadyHaveAnAccount.Name = "lblAlreadyHaveAnAccount";
            lblAlreadyHaveAnAccount.Size = new Size(100, 23);
            lblAlreadyHaveAnAccount.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(30, 181);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(278, 23);
            txtLastName.TabIndex = 22;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1111, 637);
            Controls.Add(pctSignUp);
            Controls.Add(pnlSignUp);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pctSignUp).EndInit();
            pnlSignUp.ResumeLayout(false);
            pnlSignUp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pctSignUp;
        private Panel pnlSignUp;
        private Button btnLogIninSignUp;
        private Label lblAlreadyHaveAnAccount;
        private Button btnSignUp;
        private TextBox txtSignUpPassword;
        private Label lblSignUpPassword;
        private TextBox txtSignUpEmailAddress;
        private Label lblSignUpEmailAddress;
        private Label lblSignUpValora;
        private Label lblCreateYourAccount;
        private Label lblLastName;
        private Label lblMessageSignUp;
        private TextBox txtContactNo;
        private Label lblContactNo;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private CheckBox chkTermsAndConditions;
        private TextBox txtLastName;
    }
}