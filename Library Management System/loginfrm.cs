using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    
    public partial class loginfrm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GAURAV\Documents\LibraryDb.mdf;Integrated Security=True;Connect Timeout=30");
        public loginfrm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        int que = 0;
        private void button1_Click(object sender, EventArgs e)

        {
            string passwordPattern = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
            bool isPasswordValid = Regex.IsMatch(PasswordTb.Text, passwordPattern);

            if (UsernameTb.Text == "" && PasswordTb.Text == "")
            {
                MessageBox.Show("Incorrect Username & Password !!!");
            }
            else
            {
               Con.Open();
               string query = "SELECT * From  LibrarianTbl where  LibName='" + UsernameTb.Text + "' and  LibPass= '" + PasswordTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet data = new DataSet();
                adapter.Fill(data);
                que = data.Tables[0].Rows.Count;
                if(que == 0)
                {
                    MessageBox.Show("Incorrect Username Or Password");

                }
                else
                {
                    homepage home = new homepage();
                    home.Show();
                    this.Hide();
                }


               
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            adminlogin adlog = new adminlogin();
            adlog.Show();
            this.Hide();

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
