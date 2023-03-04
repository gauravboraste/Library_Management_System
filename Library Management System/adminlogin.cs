using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
        }

        private void htmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(PasswordTb.Text == "")
            {
                MessageBox.Show("Enter The Admin Password");

            }
            else if(PasswordTb.Text == "Admin")
            {
                librarian home = new librarian();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Incorrect Password !!!!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PasswordTb.PasswordChar = '\0';


            }
            else
            {
                PasswordTb.PasswordChar = '*';

            }
        }
    }
}
