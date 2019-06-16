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
    public partial class Main : Form
    {
        SqlConnection ConnectToDatabase;
        public Main()
        {

            InitializeComponent();
            ConnectToDatabase = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectToDatabase"].ConnectionString); // connecting to database
        }

        private void Main_Load(object sender, EventArgs e)
        {


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

           private void RefreshButton_Click_1(object sender, EventArgs e)
        {
            refresh();
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            Close();
        }
    }



        }
  
