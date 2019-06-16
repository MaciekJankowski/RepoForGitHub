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
    public partial class ControlForm : Form
    {
        public ControlForm()
        {
            SqlConnection ConnectToDatabase;
            InitializeComponent();
            ConnectToDatabase = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectToDatabase"].ConnectionString);

            
                
            
        }

        public void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bool IsOpen = false;

            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f.Text == "LOGIN FORM")
            //    {
            //        IsOpen = true;
            //        f.Focus();
            //        break;
            //    }
            //    if (IsOpen == false)
            //    {

            //loginToolStripMenuItem.Enabled = false;
            //studentToolStripMenuItem.Enabled = true;

            //loginToolStripMenuItem.Enabled = true;
            //studentToolStripMenuItem.Enabled = false;


            panelMdi.Hide();
            TextBoxMdi.Hide();
            LoginForm f1 = new LoginForm();
            f1.MdiParent = this;
            f1.Show();
            //}
        }
            
            //}
            
                    
                
            
        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // does nothing
            // develop list of available options
            
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AddNewStudentForm f3 = new AddNewStudentForm();
            f3.MdiParent = this;
            f3.Show();
        }

        private void editStToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            EditStudentForm f4 = new EditStudentForm();
            f4.MdiParent = this;
            f4.Show();
        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStudentForm f5 = new DeleteStudentForm();
            f5.MdiParent = this;
            f5.Show();
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {

        }
    }
}
