using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Object_Oriented_Programming
{
    public partial class Form2 : Form
    {
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=db_OOP;Integrated Security=True;TrustServerCertificate=True";
        private bool isUsernameAvailable = false;
        private bool isContactValid = false;
        private bool isEmailValid = false;
        private bool isPasswordVisible = false;

        // UI feedback controls
        private Label lblUsernameStatus = null!;
        private Label lblBoxIndicator = null!;
        private Label lblContactStatus = null!;
        private Label lblContactBoxIndicator = null!;
        private Label lblEmailStatus = null!;
        private Label lblEmailBoxIndicator = null!;
        private Button btnTogglePassword = null!;

        public Form2()
        {
            InitializeComponent();

            RoundPanel(pnlSignUp, 20);
            RoundButton(btnSignUp, 10);

            // Hook up TextChanged and Resize events for real-time validation as you type
            this.txtUsername.TextChanged += txtUsername_TextChanged;
            this.txtUsername.Resize += txtUsername_Resize;
            this.txtContactNo.TextChanged += txtContactNo_TextChanged;
            this.txtContactNo.Resize += txtContactNo_Resize;
            this.txtSignUpEmailAddress.TextChanged += txtSignUpEmailAddress_TextChanged;
            this.txtSignUpEmailAddress.Resize += txtSignUpEmailAddress_Resize;
            this.txtSignUpPassword.Resize += txtSignUpPassword_Resize;

            SetupStatusComponents();
        }

        private void SetupStatusComponents()
        {
            // Username Status Label Below
            lblUsernameStatus = new Label
            {
                AutoSize = true,
                Location = new Point(txtUsername.Left, txtUsername.Bottom + 2),
                Font = new Font("Segoe UI", 9, FontStyle.Regular)
            };
            if (txtUsername.Parent != null)
            {
                txtUsername.Parent.Controls.Add(lblUsernameStatus);
                lblUsernameStatus.BringToFront();
            }

            // Username Indicator Inside
            lblBoxIndicator = new Label
            {
                AutoSize = false,
                Size = new Size(20, txtUsername.Height - 4),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                BackColor = Color.Transparent,
                Cursor = Cursors.Default
            };
            txtUsername.Controls.Add(lblBoxIndicator);
            PositionBoxIndicator();

            // Contact Status Label Below
            lblContactStatus = new Label
            {
                AutoSize = true,
                Location = new Point(txtContactNo.Left, txtContactNo.Bottom + 2),
                Font = new Font("Segoe UI", 9, FontStyle.Regular)
            };
            if (txtContactNo.Parent != null)
            {
                txtContactNo.Parent.Controls.Add(lblContactStatus);
                lblContactStatus.BringToFront();
            }

            // Contact Indicator Inside
            lblContactBoxIndicator = new Label
            {
                AutoSize = false,
                Size = new Size(20, txtContactNo.Height - 4),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                BackColor = Color.Transparent,
                Cursor = Cursors.Default
            };
            txtContactNo.Controls.Add(lblContactBoxIndicator);
            PositionContactBoxIndicator();

            // Email Status Label Below
            lblEmailStatus = new Label
            {
                AutoSize = true,
                Location = new Point(txtSignUpEmailAddress.Left, txtSignUpEmailAddress.Bottom + 2),
                Font = new Font("Segoe UI", 9, FontStyle.Regular)
            };
            if (txtSignUpEmailAddress.Parent != null)
            {
                txtSignUpEmailAddress.Parent.Controls.Add(lblEmailStatus);
                lblEmailStatus.BringToFront();
            }

            // Email Indicator Inside
            lblEmailBoxIndicator = new Label
            {
                AutoSize = false,
                Size = new Size(20, txtSignUpEmailAddress.Height - 4),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                BackColor = Color.Transparent,
                Cursor = Cursors.Default
            };
            txtSignUpEmailAddress.Controls.Add(lblEmailBoxIndicator);
            PositionEmailBoxIndicator();

            // Password Toggle Button Inside
            btnTogglePassword = new Button
            {
                AutoSize = false,
                Size = new Size(25, txtSignUpPassword.Height - 4),
                Text = "👁",
                TextAlign = ContentAlignment.MiddleCenter,
                FlatStyle = FlatStyle.Flat,
                UseVisualStyleBackColor = true,
                Cursor = Cursors.Hand
            };
            btnTogglePassword.FlatAppearance.BorderSize = 0;
            btnTogglePassword.Click += btnTogglePassword_Click;
            txtSignUpPassword.Controls.Add(btnTogglePassword);
            PositionPasswordToggle();
        }

        private void PositionBoxIndicator()
        {
            if (lblBoxIndicator != null && txtUsername != null)
            {
                lblBoxIndicator.Location = new Point(txtUsername.Width - lblBoxIndicator.Width - 3, 2);
                lblBoxIndicator.Height = txtUsername.Height - 4;
            }
        }

        private void PositionContactBoxIndicator()
        {
            if (lblContactBoxIndicator != null && txtContactNo != null)
            {
                lblContactBoxIndicator.Location = new Point(txtContactNo.Width - lblContactBoxIndicator.Width - 3, 2);
                lblContactBoxIndicator.Height = txtContactNo.Height - 4;
            }
        }

        private void PositionEmailBoxIndicator()
        {
            if (lblEmailBoxIndicator != null && txtSignUpEmailAddress != null)
            {
                lblEmailBoxIndicator.Location = new Point(txtSignUpEmailAddress.Width - lblEmailBoxIndicator.Width - 3, 2);
                lblEmailBoxIndicator.Height = txtSignUpEmailAddress.Height - 4;
            }
        }

        private void PositionPasswordToggle()
        {
            if (btnTogglePassword != null && txtSignUpPassword != null)
            {
                btnTogglePassword.Location = new Point(txtSignUpPassword.Width - btnTogglePassword.Width - 3, 2);
                btnTogglePassword.Height = txtSignUpPassword.Height - 4;
            }
        }

        private void txtUsername_Resize(object sender, EventArgs e) => PositionBoxIndicator();
        private void txtContactNo_Resize(object sender, EventArgs e) => PositionContactBoxIndicator();
        private void txtSignUpEmailAddress_Resize(object sender, EventArgs e) => PositionEmailBoxIndicator();
        private void txtSignUpPassword_Resize(object sender, EventArgs e) => PositionPasswordToggle();

        private void RoundPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.AddArc(0, 0, diameter, diameter, 180, 90);
            path.AddArc(panel.Width - diameter, 0, diameter, diameter, 270, 90);
            path.AddArc(panel.Width - diameter, panel.Height - diameter, diameter, diameter, 0, 90);
            path.AddArc(0, panel.Height - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();
            panel.Region = new Region(path);
            path.Dispose();
        }

        private void RoundButton(Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            diameter = Math.Min(diameter, button.Height);

            path.AddArc(0, 0, diameter, diameter, 180, 90);
            path.AddArc(button.Width - diameter, 0, diameter, diameter, 270, 90);
            path.AddArc(button.Width - diameter, button.Height - diameter, diameter, diameter, 0, 90);
            path.AddArc(0, button.Height - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();
            button.Region = new Region(path);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            path.Dispose();
        }

        private void btnLogIninSignUp_Click(object sender, EventArgs e)
        {
            Form1 logInForm = new Form1();
            logInForm.Show();
            this.Hide();
        }

        private void lblAlreadyHaveAnAccount_Click(object sender, EventArgs e) { }

        private void btnTogglePassword_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                txtSignUpPassword.UseSystemPasswordChar = false;
                btnTogglePassword.Text = "🔒";
            }
            else
            {
                txtSignUpPassword.UseSystemPasswordChar = true;
                btnTogglePassword.Text = "👁";
            }

            txtSignUpPassword.SelectionStart = txtSignUpPassword.Text.Length;
        }

        // Contact Number Validation in real-time as you type
        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {
            string contactNo = txtContactNo.Text;

            if (contactNo.Contains(" "))
            {
                contactNo = contactNo.Replace(" ", "");
                txtContactNo.Text = contactNo;
                txtContactNo.SelectionStart = txtContactNo.Text.Length;
            }

            foreach (char c in contactNo)
            {
                if (!char.IsDigit(c))
                {
                    txtContactNo.BackColor = Color.MistyRose;
                    lblContactStatus.ForeColor = Color.Red;
                    lblContactStatus.Text = "Contact number cannot contain letters or symbols";
                    lblContactBoxIndicator.ForeColor = Color.Red;
                    lblContactBoxIndicator.Text = "✕";
                    isContactValid = false;
                    return;
                }
            }

            if (string.IsNullOrEmpty(contactNo))
            {
                txtContactNo.BackColor = SystemColors.Window;
                lblContactStatus.Text = "";
                lblContactBoxIndicator.Text = "";
                isContactValid = false;
                return;
            }

            if (contactNo.Length >= 1 && contactNo[0] != '0')
            {
                txtContactNo.BackColor = Color.MistyRose;
                lblContactStatus.ForeColor = Color.Red;
                lblContactStatus.Text = "Contact number must start with 09";
                lblContactBoxIndicator.ForeColor = Color.Red;
                lblContactBoxIndicator.Text = "✕";
                isContactValid = false;
                return;
            }
            if (contactNo.Length >= 2 && contactNo[1] != '9')
            {
                txtContactNo.BackColor = Color.MistyRose;
                lblContactStatus.ForeColor = Color.Red;
                lblContactStatus.Text = "Contact number must start with 09";
                lblContactBoxIndicator.ForeColor = Color.Red;
                lblContactBoxIndicator.Text = "✕";
                isContactValid = false;
                return;
            }

            if (contactNo.Length > 11)
            {
                txtContactNo.BackColor = Color.MistyRose;
                lblContactStatus.ForeColor = Color.Red;
                lblContactStatus.Text = "The contact number must be exactly 11 characters";
                lblContactBoxIndicator.ForeColor = Color.Red;
                lblContactBoxIndicator.Text = "✕";
                isContactValid = false;
                return;
            }

            if (contactNo.Length < 11)
            {
                txtContactNo.BackColor = Color.MistyRose;
                lblContactStatus.ForeColor = Color.Red;
                lblContactStatus.Text = $"Contact number must be 11 digits ({contactNo.Length}/11)";
                lblContactBoxIndicator.ForeColor = Color.Red;
                lblContactBoxIndicator.Text = "✕";
                isContactValid = false;
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string checkQuery = "SELECT COUNT(1) FROM tbl_logInfo WHERE contact_no = @contactNo";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@contactNo", contactNo);
                        int existingCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (existingCount > 0)
                        {
                            txtContactNo.BackColor = Color.MistyRose;
                            lblContactStatus.ForeColor = Color.Red;
                            lblContactStatus.Text = "The number is already taken";
                            lblContactBoxIndicator.ForeColor = Color.Red;
                            lblContactBoxIndicator.Text = "✕";
                            isContactValid = false;
                        }
                        else
                        {
                            txtContactNo.BackColor = Color.Honeydew;
                            lblContactStatus.Text = "";
                            lblContactBoxIndicator.ForeColor = Color.Green;
                            lblContactBoxIndicator.Text = "✓";
                            isContactValid = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    txtContactNo.BackColor = Color.MistyRose;
                    lblContactStatus.ForeColor = Color.Red;
                    lblContactStatus.Text = "DB Error: " + ex.Message;
                    lblContactBoxIndicator.ForeColor = Color.Red;
                    lblContactBoxIndicator.Text = "!";
                    isContactValid = false;
                }
            }
        }

        // Email Address Validation (Must end with @gmail.com, no spaces, no duplication)
        private void txtSignUpEmailAddress_TextChanged(object sender, EventArgs e)
        {
            string email = txtSignUpEmailAddress.Text;

            if (email.Contains(" "))
            {
                email = email.Replace(" ", "");
                txtSignUpEmailAddress.Text = email;
                txtSignUpEmailAddress.SelectionStart = txtSignUpEmailAddress.Text.Length;
            }

            email = email.Trim();

            if (string.IsNullOrEmpty(email))
            {
                txtSignUpEmailAddress.BackColor = SystemColors.Window;
                lblEmailStatus.Text = "";
                lblEmailBoxIndicator.Text = "";
                isEmailValid = false;
                return;
            }

            if (!email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase) || email.Equals("@gmail.com", StringComparison.OrdinalIgnoreCase))
            {
                txtSignUpEmailAddress.BackColor = Color.MistyRose;
                lblEmailStatus.ForeColor = Color.Red;
                lblEmailStatus.Text = "Email address must end with @gmail.com";
                lblEmailBoxIndicator.ForeColor = Color.Red;
                lblEmailBoxIndicator.Text = "✕";
                isEmailValid = false;
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string checkQuery = "SELECT COUNT(1) FROM tbl_logInfo WHERE email_address = @email";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@email", email);
                        int existingCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (existingCount > 0)
                        {
                            txtSignUpEmailAddress.BackColor = Color.MistyRose;
                            lblEmailStatus.ForeColor = Color.Red;
                            lblEmailStatus.Text = "The email is already taken";
                            lblEmailBoxIndicator.ForeColor = Color.Red;
                            lblEmailBoxIndicator.Text = "✕";
                            isEmailValid = false;
                        }
                        else
                        {
                            txtSignUpEmailAddress.BackColor = Color.Honeydew;
                            lblEmailStatus.Text = "";
                            lblEmailBoxIndicator.ForeColor = Color.Green;
                            lblEmailBoxIndicator.Text = "✓";
                            isEmailValid = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    txtSignUpEmailAddress.BackColor = Color.MistyRose;
                    lblEmailStatus.ForeColor = Color.Red;
                    lblEmailStatus.Text = "DB Error: " + ex.Message;
                    lblEmailBoxIndicator.ForeColor = Color.Red;
                    lblEmailBoxIndicator.Text = "!";
                    isEmailValid = false;
                }
            }
        }

        // Username Check in real-time as you type (Max 15 characters, no spaces, database check)
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            string username = txtUsername.Text;

            if (username.Contains(" "))
            {
                username = username.Replace(" ", "");
                txtUsername.Text = username;
                txtUsername.SelectionStart = txtUsername.Text.Length;
            }

            username = username.Trim();

            if (string.IsNullOrEmpty(username))
            {
                txtUsername.BackColor = SystemColors.Window;
                if (lblUsernameStatus != null) lblUsernameStatus.Text = "";
                if (lblBoxIndicator != null) lblBoxIndicator.Text = "";
                isUsernameAvailable = false;
                return;
            }

            if (username.Length > 15)
            {
                txtUsername.BackColor = Color.MistyRose;
                if (lblUsernameStatus != null)
                {
                    lblUsernameStatus.ForeColor = Color.Red;
                    lblUsernameStatus.Text = "Username must be 15 characters or less";
                }
                if (lblBoxIndicator != null)
                {
                    lblBoxIndicator.ForeColor = Color.Red;
                    lblBoxIndicator.Text = "✕";
                }
                isUsernameAvailable = false;
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string checkQuery = "SELECT COUNT(1) FROM tbl_logInfo WHERE user_name = @username";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username);
                        int existingCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (existingCount > 0)
                        {
                            txtUsername.BackColor = Color.MistyRose;
                            if (lblUsernameStatus != null)
                            {
                                lblUsernameStatus.ForeColor = Color.Red;
                                lblUsernameStatus.Text = "The username is taken";
                            }
                            if (lblBoxIndicator != null)
                            {
                                lblBoxIndicator.ForeColor = Color.Red;
                                lblBoxIndicator.Text = "✕";
                            }
                            isUsernameAvailable = false;
                        }
                        else
                        {
                            txtUsername.BackColor = Color.Honeydew;
                            if (lblUsernameStatus != null)
                            {
                                lblUsernameStatus.Text = "";
                            }
                            if (lblBoxIndicator != null)
                            {
                                lblBoxIndicator.ForeColor = Color.Green;
                                lblBoxIndicator.Text = "✓";
                            }
                            isUsernameAvailable = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    txtUsername.BackColor = Color.MistyRose;
                    if (lblUsernameStatus != null)
                    {
                        lblUsernameStatus.ForeColor = Color.Red;
                        lblUsernameStatus.Text = "DB Error: " + ex.Message;
                    }
                    if (lblBoxIndicator != null) lblBoxIndicator.Text = "!";
                    isUsernameAvailable = false;
                }
            }
        }

        private void txtSignUpPassword_TextChanged(object sender, EventArgs e) { }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtSignUpPassword.Text.Trim();
            string contactNo = txtContactNo.Text.Trim();
            string email = txtSignUpEmailAddress.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(contactNo) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isUsernameAvailable)
            {
                txtUsername.BackColor = Color.MistyRose;
                MessageBox.Show("Please provide a valid, unique username (max 15 characters).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!isContactValid)
            {
                txtContactNo.BackColor = Color.MistyRose;
                MessageBox.Show("Please provide a valid, unique 11-digit contact number starting with 09.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!isEmailValid)
            {
                txtSignUpEmailAddress.BackColor = Color.MistyRose;
                MessageBox.Show("Please provide a valid, unique email address ending with @gmail.com.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string insertQuery = "INSERT INTO tbl_logInfo (user_name, pass_word, contact_no, email_address, is_active) VALUES (@username, @password, @contactNo, @email, @isActive)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@username", username);
                        insertCmd.Parameters.AddWithValue("@password", password);
                        insertCmd.Parameters.AddWithValue("@contactNo", contactNo);
                        insertCmd.Parameters.AddWithValue("@email", email);
                        insertCmd.Parameters.AddWithValue("@isActive", 1);

                        insertCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Account successfully created and saved to database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form3 LandingPageForm = new Form3();
                    LandingPageForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                // Show password (remove mask)
                txtSignUpPassword.PasswordChar = '\0';

                // Switch to open eye icon
                picShowPassword1.Image = Properties.Resources.eye_open;
            }
            else
            {
                // Hide password (apply bullet mask)
                txtSignUpPassword.PasswordChar = '•';

                // Switch back to closed eye with slash icon
                picShowPassword1.Image = Properties.Resources.eye_hidden;
            }
        }

        private void picShowPassword2_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                // Show password (remove mask)
                txtConfirmPassword.PasswordChar = '\0';

                // Switch to open eye icon
                picShowPassword2.Image = Properties.Resources.eye_open;
            }
            else
            {
                // Hide password (apply bullet mask)
                txtConfirmPassword.PasswordChar = '•';

                // Switch back to closed eye with slash icon
                picShowPassword2.Image = Properties.Resources.eye_hidden;
            }
        }
    }
}