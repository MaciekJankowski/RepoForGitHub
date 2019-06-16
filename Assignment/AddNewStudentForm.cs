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
    public partial class AddNewStudentForm : Form
    {
        SqlConnection ConnectToDatabase;
        public AddNewStudentForm()
        {
            InitializeComponent();
            ConnectToDatabase = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectToDatabase"].ConnectionString);
        }

        private void Main_Load(object sender, EventArgs e)
        {


        }

        string EducationLevel = string.Empty;

     


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            EducationLevel = "Undergraduate";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            EducationLevel = "Postgraduate";
        }

        private void AddStudentButton_Click(object sender, EventArgs e) // button that add a new students
        {

            SqlCommand cmd = new SqlCommand("Insert Into Students " +
                "Values(@StudentsID, @EducationalLevel, @FirstName, @LastName, @County, @City, @Address1, @Address2, @Course, @Email, @ContactNumber);", ConnectToDatabase);




            cmd.Parameters.AddWithValue("@StudentsID", StudentNumberBox.Text); // adding parameters from the box into the database 
            cmd.Parameters.AddWithValue("@EducationalLevel", EducationLevel);
            cmd.Parameters.AddWithValue("@FirstName", FirstNameBox.Text);
            cmd.Parameters.AddWithValue("@LastName", SurnameBox.Text);
            cmd.Parameters.AddWithValue("@County", CountyComboBox.Text);
            cmd.Parameters.AddWithValue("@City", CityBox.Text);
            cmd.Parameters.AddWithValue("@Address1", Address1Box.Text);
            cmd.Parameters.AddWithValue("@Address2", Address2Box.Text);
            cmd.Parameters.AddWithValue("@Course", CourseComboBox.Text);
            cmd.Parameters.AddWithValue("@Email", EmailBox.Text);
            cmd.Parameters.AddWithValue("@ContactNumber", PhoneBox.Text);

          

            if (StudentNumberBox.Text == "" || StudentNumberBox.TextLength < 7)
            {
                MessageBox.Show("ID has to be 8 characters long!");
            }
            else if (FirstNameBox.Text == "" || SurnameBox.Text == "" || CountyComboBox.Items == null
                || CityBox.Text == "" || Address1Box.Text == "" || Address2Box.Text == ""
                   || CourseComboBox.Items == null || PhoneBox.Text == "")
            {
                MessageBox.Show("One of the following options was not provided: First Name, Surname, County, City, Address, Course, Phone. Please fill out or required fieds.");
            }
            else if (!EmailBox.Text.Contains("@"))
            {
                MessageBox.Show("Provided e-mail address does not have '@' symbol, please try again.");
            }
            else
            {

                try
                {
                    ConnectToDatabase.Open(); // opening database
                    cmd.ExecuteNonQuery(); // populating database with provided information

                    MessageBox.Show("Saved successfully!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(string.Format("Error: {0}", (ex.Message))); // In case of error
                }
                finally
                {
                    ConnectToDatabase.Close(); // closing database once the query was executed
                    Close();
                    AddNewStudentForm next = new AddNewStudentForm();
                    next.Show();

                }

                StudentNumberBox.Text = ""; // clearing fields in the form, after clicking any button
                FirstNameBox.Text = "";
                SurnameBox.Text = "";
                CountyComboBox.Items.Clear();  // this is clearing combobox fields 
                CityBox.Text = "";
                Address1Box.Text = "";
                Address2Box.Text = "";
                CourseComboBox.Items.Clear();
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

        private void AddNewStudentForm_Load(object sender, EventArgs e)
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
    }
}
