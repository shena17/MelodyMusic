using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MelodyMusic
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void stu_details_Click(object sender, EventArgs e)
        {
            Registration_Members obj = new Registration_Members();
            this.Hide();
            obj.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) ==DialogResult.No)
            {
                return;
            }
            else
            {
                Application.Exit();
            }
        }

        private void course_Click(object sender, EventArgs e)
        {
            Course_Reference obj = new Course_Reference();
            this.Hide();
            obj.Show();
        }

        private void payments_Click(object sender, EventArgs e)
        {
            Payments obj = new Payments();
            this.Hide();
            obj.Show();
        }
    }
}
