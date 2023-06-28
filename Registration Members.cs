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
    public partial class Registration_Members : Form
    {
        public Registration_Members()
        {
            InitializeComponent();
        }


        private void contact_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Member;Integrated Security=True";
            commandString = "INSERT INTO Member_table VALUES ('" + txtmemberid.Text + "' , '" + txtmemberfname.Text + "' , '" + txtsurname.Text + "' , '" + txtaddress.Text + "' , '" + txtcontact.Text + "' , '" + gender.Text + "' , '" + age.Text + "'); ";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Record Added Successfully!");
            conn.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Member;Integrated Security=True";
            commandString = "UPDATE Member_table SET FirstName = '" + txtmemberfname.Text + "' , LastName = '" + txtsurname.Text + "' , Address = '" + address.Text + "' , ContactNo = '" + contact.Text + "', Gender = '" + gender.Text + "', Age = '" + age.Text + "'  ";

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

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtmemberid.Text = "";
            txtmemberfname.Text = "";
            txtsurname.Text = "";
            txtaddress.Text = "";
            txtcontact.Text = "";
            gender.Text = "";
            age.Text = "";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Member;Integrated Security=True";
            commandString = "DELETE FROM Member_table where MemberID = '" + txtmemberid.Text + "' ";

            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo) ==DialogResult.No)
            {
                return;
            }
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Record deleted successfully!");

            txtmemberid.Text = "";
            txtmemberfname.Text = "";
            txtsurname.Text = "";
            txtaddress.Text = "";
            txtcontact.Text = "";
            gender.Text = "";
            age.Text = "";

            conn.Close();
 
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) ==DialogResult.No)
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
