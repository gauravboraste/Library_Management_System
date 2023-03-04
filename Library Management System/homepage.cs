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
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            students stud = new students();
            stud.Show();
            this.Hide();

        }

        private void BooksBtn_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            book.Show();
            this.Hide();
        }

        private void IssueBtn_Click(object sender, EventArgs e)
        {
            issue iss = new issue();
            iss.Show();
            this.Hide();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            ReturnBook rtn = new ReturnBook();
            rtn.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginfrm log = new loginfrm();
            log.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
