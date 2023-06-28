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
    public partial class Course_Reference : Form
    {
        public Course_Reference()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Course;Integrated Security=True";
            commandString = "INSERT INTO Course_table VALUES ('" + courseID.Text + "', '" + courseType.Text + "', '" + courseAmount.Text + "', '" + courseDuration.Text + "', '" + details.Text + "'); ";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Record added successfully!");
            conn.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Course;Integrated Security=True";
            commandString = "DELETE FROM Course_table where CourseID = '" + courseID.Text + "' ";

            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Record deleted successfully!");

            courseID.Text = "";
            courseType.Text = "";
            courseAmount.Text = "";
            courseDuration.Text = "";
            details.Text = "";

            conn.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            courseID.Text = "";
            courseType.Text = "";
            courseAmount.Text = "";
            courseDuration.Text = "";
            details.Text = "";
        }

        private void update_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Course;Integrated Security=True";
            commandString = "UPDATE Course_table SET CourseID = '" + courseID.Text + "' , CourseType = '" + courseType.Text + "' , CourseAmount = '" + courseAmount.Text + "' , CourseDuration = '" + courseDuration.Text + "', InstructorDetails = '" + details.Text + "' ";

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

        private void exit_Click_1(object sender, EventArgs e)
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
