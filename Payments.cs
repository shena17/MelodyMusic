using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace MelodyMusic
{
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Payment;Integrated Security=True";
            commandString = "INSERT INTO Payment_table VALUES ('" + paymentID.Text + "', '" + amount.Text + "', '" + paidDate.Value.ToString() + "', '" + memberID.Text + "'); ";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Record added successfully!");
            conn.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            paymentID.Text = "";
            amount.Text = "";
            paidDate.Text = "";
            memberID.Text = "";
        }

        private void update_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Payment;Integrated Security=True";
            commandString = "UPDATE Payment_table SET PaymentID = '" + paymentID.Text + "' , Amount = '" + amount.Text + "' , PaidDate = '" + paidDate.Value.ToString() + "' , MemberID = '" + memberID.Text + "' ";

            if (MessageBox.Show("Are you sure, you want to Update this record?", "Update", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully!");
            conn.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            else
            {
                MainMenu obj = new MainMenu();
                this.Hide();
                obj.Show();
            }
        }
    }
}
