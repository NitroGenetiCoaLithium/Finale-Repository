
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Object_Oriented_Programming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Apply rounded corners
            RoundPanel(pnlLogIn, 20);
            RoundButton(btnLogIn, 10);
        }

        // ROUND PANEL
        private void RoundPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;

            path.AddArc(0, 0, diameter, diameter, 180, 90);
            path.AddArc(panel.Width - diameter, 0,
                diameter, diameter, 270, 90);
            path.AddArc(panel.Width - diameter,
                panel.Height - diameter,
                diameter, diameter, 0, 90);
            path.AddArc(0, panel.Height - diameter,
                diameter, diameter, 90, 90);

            path.CloseFigure();

            panel.Region = new Region(path);
            path.Dispose();
        }

        // ROUND BUTTON
        private void RoundButton(Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;

            // Prevent radius from exceeding button height
            diameter = Math.Min(diameter, button.Height);

            path.AddArc(0, 0, diameter, diameter, 180, 90);
            path.AddArc(button.Width - diameter, 0,
                diameter, diameter, 270, 90);
            path.AddArc(button.Width - diameter,
                button.Height - diameter,
                diameter, diameter, 0, 90);
            path.AddArc(0, button.Height - diameter,
                diameter, diameter, 90, 90);

            path.CloseFigure();

            button.Region = new Region(path);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;

            path.Dispose();
        }

        private void btnSignUpInLogIn_Click(object sender, EventArgs e)
        {
            Form2 signUpForm = new Form2();
            signUpForm.Show();

            this.Hide();
        }
        private void txtEmailAddress_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmailAddress.Text;
        }

        private void txtLogInPassword_TextChanged(object sender, EventArgs e)
        {
            string loginPassword = txtLogInPassword.Text;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Form3 LandingPageForm = new Form3();
            LandingPageForm.Show();

            this.Hide();
        }
    }
}
