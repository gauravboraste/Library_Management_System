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
    public partial class librarian : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GAURAV\Documents\LibraryDb.mdf;Integrated Security=True;Connect Timeout=30");
        public librarian()
        {
            InitializeComponent();
        }

        private void librarian_Load(object sender, EventArgs e)
        {
            DisplayBooks();
            LibrarianDataset.RowHeadersVisible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            homepage home = new homepage();
            home.Show();
        }

        public void ResetFun()
        {
            LibNameTb.Text = "";
            LibPhnTb.Text = "";
            LibPassTb.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string passwordPattern = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
            bool isPasswordValid = Regex.IsMatch(LibPassTb.Text, passwordPattern);

            if (LibNameTb.Text == "" || LibPhnTb.Text == "" || LibPassTb.Text == "")
            {
                MessageBox.Show("All Field Are Required !!! ");
            }
            else if (!isPasswordValid)
            {
                MessageBox.Show("Minimum eight and maximum 10 characters, at least one uppercase letter, one lowercase letter, one number and one special character:!");
            }
            else
            {
                Con.Open();
                string LibNamee = LibNameTb.Text;
                string LibPhn = LibPhnTb.Text;
                string LibPasss = LibPassTb.Text;
                
                string Query = "INSERT INTO LibrarianTbl (LibName,LibPhone,LibPass) VALUES('" + LibNamee + "','" + LibPhn + "','" + LibPasss + "')";

                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Librarian Added successfully !!!! ");


                DisplayBooks();

                ResetFun();


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DisplayBooks()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM LibrarianTbl", Con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                LibrarianDataset.DataSource = dt;
                Con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        int key = 0;
        private void LibrarianDataset_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = LibrarianDataset.Rows[e.RowIndex];
            LibNameTb.Text = row.Cells[1].Value.ToString();
            LibPhnTb.Text = row.Cells[2].Value.ToString();
            LibPassTb.Text = row.Cells[3].Value.ToString();
         

            if (LibNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LibNameTb.Text == "" || LibPhnTb.Text == "" || LibPassTb.Text == "" )
            {
                MessageBox.Show("Missing Information !!! ");
            }
            else
            {
                try
                {
                    Con.Open();
                    string LibNamee = LibNameTb.Text;
                    string LibPhn = LibPhnTb.Text;
                    string LibPasss = LibPassTb.Text;

                    string Query = "UPDATE LibrarianTbl set LibName ='" + LibNameTb.Text + "',LibPhone='" + LibPhnTb.Text + "',LibPass='" + LibPassTb.Text + "' where LibId='" + key + "' ";

                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    MessageBox.Show("Librarian Update successfully !!!! ");

                    DisplayBooks();

                    ResetFun();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Missing Information !!!");
            }
            else
            {
                Con.Open();
                string LibNamee = LibNameTb.Text;
                string LibPhn = LibPhnTb.Text;
                string LibPasss = LibPassTb.Text;
                string Query = "DELETE FROM  LibrarianTbl where  LibId =" + key + "";

                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                DisplayBooks();
                ResetFun();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                LibPassTb.PasswordChar = '\0';


            }
            else
            {
                LibPassTb.PasswordChar = '*';

            }
        }
    }
    }

