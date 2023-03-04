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
using System.IO;


namespace Library_Management_System
{

    public partial class Books : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GAURAV\Documents\LibraryDb.mdf;Integrated Security=True;Connect Timeout=30");
        public Books()
        {

            InitializeComponent();
        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Books_Load(object sender, EventArgs e)
        {
            DisplayBooks();
            BooksDGV.RowHeadersVisible = false;


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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
    

        private void DisplayBooks()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM BookTbl", Con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            BooksDGV.DataSource = dt;
            Con.Close();

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (BNameTb.Text == "" || BAuthorTb.Text == "" || BPublisherTb.Text == "" || BPriceTb.Text == "" || QtyTb.Text == "")
            {
                MessageBox.Show("All Field Are Required !!! ");
            }
            else
            {
                Con.Open();
                string BName = BNameTb.Text;
                string BAuthor = BAuthorTb.Text;
                string BPublishers = BPublisherTb.Text;
                string BPrice = BPriceTb.Text;
                string Qty = QtyTb.Text;
                string Query = "INSERT INTO BookTbl (BName,BAuthor,BPublisher,BPrice,Bqty) VALUES('" + BName + "','" + BAuthor + "','" + BPublishers + "','" + BPrice + "','" + Qty + "')";

                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Book Added successfully !!!! ");

                BNameTb.Text = "";
                BAuthorTb.Text = "";
                BPublisherTb.Text = "";
                BPriceTb.Text = "";
                QtyTb.Text = "";
                DisplayBooks();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (BNameTb.Text == "" || BAuthorTb.Text == "" || BPublisherTb.Text == "" || BPriceTb.Text == "" || QtyTb.Text == "")
            {
                MessageBox.Show("Missing Information !!! ");
            }
            else
            {
                Con.Open();
                string BName = BNameTb.Text;
                string BAuthor = BAuthorTb.Text;
                string BPublishers = BPublisherTb.Text;
                string BPrice = BPriceTb.Text;
                string Qty = QtyTb.Text;
                string Query = "UPDATE BookTbl set BName ='" + BNameTb.Text + "',BAuthor='" + BAuthorTb.Text + "',BPublisher='" + BPublisherTb.Text + "',BPrice='" + BPriceTb.Text + "',Bqty='" + QtyTb.Text + "' where BId='" + key + "' ";

                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Book Update successfully !!!! ");

                BNameTb.Text = "";
                BAuthorTb.Text = "";
                BPublisherTb.Text = "";
                BPriceTb.Text = "";
                QtyTb.Text = "";
                DisplayBooks();
            }
        }
        int key = 0;
        private void BooksDGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = BooksDGV.Rows[e.RowIndex];
            BNameTb.Text = row.Cells[1].Value.ToString();
            BAuthorTb.Text = row.Cells[2].Value.ToString();
            BPublisherTb.Text = row.Cells[3].Value.ToString();
            BPriceTb.Text = row.Cells[4].Value.ToString();
            QtyTb.Text = row.Cells[5].Value.ToString();

            if (BNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Missing Information !!!");
            }
            else
            {
                Con.Open();
                string BName = BNameTb.Text;
                string BAuthor = BAuthorTb.Text;
                string BPublishers = BPublisherTb.Text;
                string BPrice = BPriceTb.Text;
                string Qty = QtyTb.Text;
                string Query = "DELETE FROM  BookTbl where  BId =" + key + "";

                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                DisplayBooks();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            BNameTb.Text = "";
            BAuthorTb.Text = "";
            BPublisherTb.Text = "";
            BPriceTb.Text = "";
            QtyTb.Text = "";
            DisplayBooks();
        }
    }
}