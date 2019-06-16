using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Assignment
{
    public partial class LoginForm : Form
    {
       
        SqlConnection ConnectToDatabase;
        public LoginForm()
        {
            InitializeComponent();
            ConnectToDatabase = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectToDatabase"].ConnectionString);
           
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
            
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
          
           
                string uName = UsernameTextBox.Text;
                string pWord = PasswordTextBox.Text;
                ConnectToDatabase.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM LogIn2 WHERE Username=@Username", ConnectToDatabase);
                cmd.Parameters.AddWithValue("@Username", uName);
                cmd.Parameters.AddWithValue("@Password", pWord);
                SqlDataReader reader = cmd.ExecuteReader();
                
                if(!reader.HasRows)
                {
                    MessageBox.Show("Invalid login credentials");
                }
                else
                {
                this.Hide();
                
                Main f2 = new Main();
                f2.MdiParent = this.MdiParent;
                f2.Show();
                //loginToolStripMenuItem.Enabled = false;
                //studentToolStripMenuItem.Enabled = true;


                }
                
                PasswordTextBox.Text = "";
                UsernameTextBox.Text = "";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
