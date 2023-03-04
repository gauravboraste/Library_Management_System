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
   
    public partial class issue : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GAURAV\Documents\LibraryDb.mdf;Integrated Security=True;Connect Timeout=30");
        public issue()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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

        private void issue_Load(object sender, EventArgs e)
        {
            FillStudentId();
            DisplayBooks();
            FillBookId();
            IssueDataset.RowHeadersVisible = false;
        }

        private void DisplayBooks()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM IssueTbl", Con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            IssueDataset.DataSource = dt;
            Con.Close();

        }

        public void FillStudentId()
        {
            Con.Open();
            string query = "SELECT * FROM StudentTbl";
            SqlCommand cmd = new SqlCommand(query,Con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable Tbl = new DataTable();
            adapter.Fill(Tbl);
            StidTb.DataSource = Tbl;
            StidTb.DisplayMember = "StId";
            StidTb.ValueMember = "StId";
            Con.Close();
        }



        public void FillBookId()
        {
            Con.Open();
            string query = "SELECT * FROM BookTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable Tbl = new DataTable();
            adapter.Fill(Tbl);
            BookidTb.DataSource = Tbl;
            BookidTb.DisplayMember = "BId";
            BookidTb.ValueMember = "BId";
            Con.Close();
        }

        public void GetStudentName()
        {
            Con.Open();
            string query = "SELECT * FROM StudentTbl WHERE StId= " + StidTb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();
           
            while (reader.Read())
            {
                StNameTb.Text = "" + reader[1].ToString();
            }

            Con.Close();

        }

        public void GetBookName()
        {
            Con.Open();
            string query = "SELECT * FROM BookTbl WHERE BId= " + BookidTb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                BookNameTb.Text = "" + reader[1].ToString();
            }

            Con.Close();

        }
         int Num = 0;
        public void CountBook()
        {
            try
            {
                Con.Open();
                string query = "SELECT COUNT (*) from IssueTbl where StId=" + StidTb.SelectedValue.ToString() + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                Num = (int)cmd.ExecuteScalar();
                Con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            CountBook();
            if (StidTb.Text == "" || StNameTb.Text == "" || BookidTb.Text == "" || BookNameTb.Text == "" || IssueDateTb.Text == "")
            {
                MessageBox.Show("All Field Are Required !!! ");
            }
            else if (Num == 5)
            {
                MessageBox.Show("No More Then 5 Books Issued");
            }
            else
            {
                Con.Open();
                
               string SId = StidTb.Text;
               string SName = StNameTb.Text;
               string BId = BookidTb.Text;
               string BName = BookNameTb.Text;
               string IssueDate = IssueDateTb.Text;
                string Query = "INSERT INTO IssueTbl (StId,StName,BookId,BookName,IssueDate) VALUES('" + SId + "','" + SName + "','" + BId + "','" + BName + "','" + IssueDate + "')";

                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Book Issue  successfully !!!! ");

                DisplayBooks();
            }
        }

        private void StidTb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStudentName();
        }

        private void BookidTb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetBookName();
        }

        public void ResetFun()
        {
            StidTb.Text = "";
            StNameTb.Text = "";
            BookidTb.Text = "";
            BookNameTb.Text = "";
            
        }
        int key = 0;
        private void button2_Click(object sender, EventArgs e)
        {
          
            if (StidTb.Text == "" || StNameTb.Text == "" || BookidTb.Text == "" || BookNameTb.Text == "" || IssueDateTb.Text == "")
            {
                MessageBox.Show("Information Missing");
            }
            else
            {
                Con.Open();
                string SId = StidTb.Text;
                string SName = StNameTb.Text;
                string BId = BookidTb.Text;
                string BName = BookNameTb.Text;
                string IssueDate = IssueDateTb.Text;
                string Query = "UPDATE IssueTbl set StId ='" + StidTb.Text + "',StName='" + StNameTb.Text + "',BookId='" + BookidTb.Text + "',BookName='" + BookNameTb.Text + "',IssueDate='" + IssueDateTb.Text + "' where INum='" + key + "' ";

                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Book Issue  Update successfully !!!! ");

                ResetFun();
                DisplayBooks();
            }
        }

        private void IssueDataset_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = IssueDataset.Rows[e.RowIndex];
            StidTb.Text = row.Cells[1].Value.ToString();
            StNameTb.Text = row.Cells[2].Value.ToString();
            BookidTb.Text = row.Cells[3].Value.ToString();
            BookNameTb.Text = row.Cells[4].Value.ToString();
            IssueDateTb.Text = row.Cells[5].Value.ToString();

            if (StNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(row.Cells[0].Value.ToString());
                
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
                string SId = StidTb.Text;
                string SName = StNameTb.Text;
                string BId = BookidTb.Text;
                string BName = BookNameTb.Text;
                string IssueDate = IssueDateTb.Text;
                string Query = "DELETE FROM  IssueTbl where  INum =" + key + "";

                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                
                Con.Close();

                MessageBox.Show("Book Details Delete successfully !!!! ");
                DisplayBooks();
                ResetFun();
            }
        }
    }
    }

