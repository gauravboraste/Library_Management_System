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
    public partial class ReturnBook : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GAURAV\Documents\LibraryDb.mdf;Integrated Security=True;Connect Timeout=30");
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void IsseuRtnDataset_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DisplayBooks()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM IssueTbl", Con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            IsseuRtnDataset.DataSource = dt;
            Con.Close();

        }

        private void ReturnDisplayBook()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ReturnTbl", Con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            RtnBookDataset.DataSource = dt;
            Con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            DisplayBooks();
            ReturnDisplayBook();
            IsseuRtnDataset.RowHeadersVisible = false;
            RtnBookDataset.RowHeadersVisible = false;
        }
        int key = 0;
        private void IsseuRtnDataset_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            {
                DataGridViewRow row = IsseuRtnDataset.Rows[e.RowIndex];
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
        }
        
        private void CalcTb_Click(object sender, EventArgs e)
        {
            int days;
            float Fine = 0;
            TimeSpan time = new TimeSpan();
          
            time = ReturnDateTb.Value.Date - IssueDateTb.Value.Date;
            days = time.Days;
            if(days <= 5)
                {
                Fine = 0;
                FineTb.Text = "No Fine";

                }
            else
            {
                Fine = days - 5;
                FineTb.Text = "Rs" + Convert.ToString(Fine * 10);
            }
        }

        public void RemoveFromIssue()
        {
            Con.Open();
            string query = "DELETE FROM IssueTbl WHERE INum=" + key + "";
            SqlCommand cmd = new SqlCommand(query,Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Issue Remove");
            Con.Close();
            DisplayBooks();
            ReturnDisplayBook();



        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (StidTb.Text == "" || StNameTb.Text == "" || BookidTb.Text == "" || BookNameTb.Text == "" || IssueDateTb.Text == "")
            {
                MessageBox.Show("All Field Are Required !!! ");
            }
            else
            {
                Con.Open();

                string SId = StidTb.Text;
                string SName = StNameTb.Text;
                string BId = BookidTb.Text;
                string BName = BookNameTb.Text;
                string IssueDate = IssueDateTb.Text;
                string RtnDate = ReturnDateTb.Text;
                string Finee = FineTb.Text;
                string Query = "INSERT INTO ReturnTbl (StId,StName,BookId,BookName,IssueDate,ReturnDate,Fine) VALUES('" + SId + "','" + SName + "','" + BId + "','" + BName + "','" + IssueDate + "','" + RtnDate + "','" + Finee + "')";
              
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Book Return  successfully !!!! ");
                RemoveFromIssue();
                ResetFun();
                DisplayBooks();
                
                ReturnDisplayBook();
            }
        }
        public void ResetFun()
        {
           StidTb.SelectedValue = -1;
           StNameTb.Text = "";
           BookidTb.SelectedValue = -1;
           BookNameTb.Text = "";
          
           FineTb.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetFun();
        }
    }
}

