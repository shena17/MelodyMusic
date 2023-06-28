using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelodyMusic
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = txt_username.Text;
            String password = txt_password.Text;

            if (username == "Admin" && password == "1234")
            {
                MainMenu obj = new MainMenu();
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
