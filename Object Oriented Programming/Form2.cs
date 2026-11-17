using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Object_Oriented_Programming
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            RoundPanel(pnlSignUp, 20);
            RoundButton(btnSignUp, 10);
        }

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

        private void btnLogIninSignUp_Click(object sender, EventArgs e)
        {
            Form1 logInForm = new Form1();
            logInForm.Show();

            this.Hide();
        }

        private void lblAlreadyHaveAnAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
