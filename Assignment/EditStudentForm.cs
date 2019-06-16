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
    public partial class EditStudentForm : Form
    {
        SqlConnection ConnectToDatabase;
        public EditStudentForm()
        {
            InitializeComponent();
            ConnectToDatabase = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectToDatabase"].ConnectionString);
        }

        string EducationLevel = string.Empty;
        int StudentID = 0;

        private void radioUndergrad_CheckedChanged(object sender, EventArgs e)
        {
            EducationLevel = "Undergraduate";
        }

        private void radioPostgrad_CheckedChanged(object sender, EventArgs e)
        {
            EducationLevel = "Postgraduate";
        }

        private void EditStudentButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Students " +
        "SET EducationalLevel= @EducationalLevel, County = @County, City = @City, Address1 = @Address1, Address2 = @Address2, Email = @Email, ContactNumber = @ContactNumber where StudentsID = @StudentsID ;", ConnectToDatabase);


            // adding parameters from the box into the database 
            cmd.Parameters.AddWithValue("@StudentsID", StudentNumberBox.Text);
            cmd.Parameters.AddWithValue("@EducationalLevel", EducationLevel);
            cmd.Parameters.AddWithValue("@County", CountyComboBox.Text);
            cmd.Parameters.AddWithValue("@City", CityBox.Text);
            cmd.Parameters.AddWithValue("@Address1", Address1Box.Text);
            cmd.Parameters.AddWithValue("@Address2", Address2Box.Text);
            cmd.Parameters.AddWithValue("@Email", EmailBox.Text);
            cmd.Parameters.AddWithValue("@ContactNumber", PhoneBox.Text);

         

            if (StudentNumberBox.Text == "")
            {
                MessageBox.Show("ID has provided in order to update the student!");
            }
            else if (CountyComboBox.Items == null
                || CityBox.Text == "" || Address1Box.Text == "" || Address2Box.Text == ""
                   || PhoneBox.Text == "")
            {
                MessageBox.Show("One of the following options was not provided: County, City, Address, Phone. Please fill out or required fieds.");
            }
            else if (!EmailBox.Text.Contains("@"))
            {
                MessageBox.Show("Provided e-mail address does not have '@' symbol, please try again.");
            }

            else
            {

                try
                {
                    ConnectToDatabase.Open();
                    cmd.ExecuteNonQuery();
                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("No student exist under such ID");
                    }

                    else
                    {
                        MessageBox.Show("Updated successfully!");
                        
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(string.Format("Error: {0}", (ex.Message)));
                }
                finally
                {
                    ConnectToDatabase.Close();
                    Close();
                    EditStudentForm next = new EditStudentForm();
                    next.Show();
                }

                StudentNumberBox.Text = ""; // clearing fields in the form, after clicking any button           
                CountyComboBox.Items.Clear();  // this is clearing combobox fields 
                CityBox.Text = "";
                Address1Box.Text = "";
                Address2Box.Text = "";
                EmailBox.Text = "";
                PhoneBox.Text = "";
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

        private void EditStudentForm_Load(object sender, EventArgs e)
        {
          
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
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
                dt.Load(rdr); //loading data to the grid
                dataGridView1.DataSource = dt; // showing data in the grid


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
            

        private void MouseClickSearchBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                StudentID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                CountyComboBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                CityBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                Address1Box.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                Address2Box.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                EmailBox.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                PhoneBox.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please Refresh and pick student by click.");
            }
        }
    }
}
