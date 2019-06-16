using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class DeleteStudentForm : Form
    {
        SqlConnection ConnectToDatabase;
        public DeleteStudentForm()
        {
            InitializeComponent();
            ConnectToDatabase = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectToDatabase"].ConnectionString);
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE from Students WHERE StudentsID= '" + this.StudentNumberBox.Text + "'", ConnectToDatabase);




            cmd.Parameters.AddWithValue("@StudentsID", StudentNumberBox.Text);


            StudentNumberBox.Text = "";
            

            try
            {
                ConnectToDatabase.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows == 0)
                { MessageBox.Show("Not in there"); }
                else
                { MessageBox.Show("Deleted successfully!"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", (ex.Message))); // ex.Messsage generate system, ex is our convention
            }
            finally
            {
                ConnectToDatabase.Close();
                Close();
                DeleteStudentForm next = new DeleteStudentForm();
                next.Show();
            }


        }
        private void refresh()
        {
            SqlCommand cmd = new SqlCommand("Select * from Students", ConnectToDatabase); // when click refresh, show all from conn

            try
            {
                ConnectToDatabase.Open();

                SqlDataReader rdr = cmd.ExecuteReader(); //reading from connection
                DataTable dt = new DataTable(); // making data in the grid
                dt.Load(rdr); //loading data to the grid
                dataGridView1.DataSource = dt; // showing data in the grid


            }
            finally
            {
                ConnectToDatabase.Close();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void DeleteStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Students where StudentsID like @StudentsID +'%' ;", ConnectToDatabase);
            cmd.Parameters.AddWithValue("@StudentsID", StudentNumberBox.Text);
            try
            {
                ConnectToDatabase.Open();

              
                SqlDataReader rdr = cmd.ExecuteReader(); //reading from connection
                DataTable dt = new DataTable(); // making data in the grid


                while (rdr.Read()) // does not work I cant figure it out for now....
                {
                    if (rdr.ToString() == StudentNumberBox.Text)
                    {
                        dt.Load(rdr); //loading data to the grid
                        dataGridView1.DataSource = dt; // showing data in the grid
                    }
                    else
                    {
                        MessageBox.Show("Invalid Student Number. Does not exist. Please try again.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("No student with such ID exist, please try again.");
            }
            finally
            {
                ConnectToDatabase.Close();
            }

            StudentNumberBox.Text = "";

        }
    }
}
