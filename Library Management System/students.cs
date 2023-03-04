using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class students : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GAURAV\Documents\LibraryDb.mdf;Integrated Security=True;Connect Timeout=30");
        public students()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void students_Load(object sender, EventArgs e)
        {
            DisplayBooks();
            StudentDataSet.RowHeadersVisible = false;
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetFunction();
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
                string SName = SNameTb.Text;
                string Dept = DeptNameTb.Text;
                string SemBox = SemCoBox.Text;
                string Phone = PhoneTb.Text;
                string Query = "DELETE FROM  StudentTbl where  StID =" + key + "";

                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Data Delete  successfully !!!!");
                DisplayBooks();
            }
            ResetFunction();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SNameTb.Text == "" || DeptNameTb.Text == "" || DeptNameTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information !!! ");
            }
            else
            {
                Con.Open();
                string SName = SNameTb.Text;
                string Dept = DeptNameTb.Text;
                string SemBox = SemCoBox.Text;
                string Phone = PhoneTb.Text;

                string Query = "UPDATE StudentTbl set StName ='" + SNameTb.Text + "',StDept='" + DeptNameTb.Text + "',StSem='" + SemCoBox.Text + "',StPhone='" + PhoneTb.Text + "' where StId='" + key + "' ";

                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();

              
                MessageBox.Show("Student Details Update successfully !!!! ");
                ResetFunction();


                DisplayBooks();
            }
        }

        private void DisplayBooks()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM StudentTbl", Con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            StudentDataSet.DataSource = dt;
            Con.Close();

        }
        private void button1_Click(object sender, EventArgs e)

        { 
            if (SNameTb.Text == "" || DeptNameTb.Text == "" || SemCoBox.Text == "" || PhoneTb.Text == "" )
            {
                MessageBox.Show("All Field Are Reqired!!!!");
            }
            else
            {
                Con.Open();

                string SName = SNameTb.Text;
                string Dept = DeptNameTb.Text;
                string SemBox = SemCoBox.Text;
                string Phone = PhoneTb.Text;
                string Query = "INSERT INTO StudentTbl (StName,StDept,StSem,StPhone) VALUES('" + SName + "','" + Dept + "','" + SemBox + "','" + Phone + "')";

                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Student Details  Added successfully !!!! ");

                ResetFunction();


                DisplayBooks();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            homepage home = new homepage();
            home.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int key = 0;
        private void StudentDataSet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = StudentDataSet.Rows[e.RowIndex];
            SNameTb.Text = row.Cells[1].Value.ToString();
            DeptNameTb.Text = row.Cells[2].Value.ToString();
            SemCoBox.Text = row.Cells[3].Value.ToString();
            PhoneTb.Text = row.Cells[4].Value.ToString();
            

            if (SNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(row.Cells[0].Value.ToString());
            }

         
        }
        public void ResetFunction()
        {
            SNameTb.Text = "";
            DeptNameTb.Text = "";
            SemCoBox.Text = "";
            PhoneTb.Text = "";
        }
    }
}
