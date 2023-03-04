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
    public partial class Splash_Screen : Form
    {
        int ticks;
        public Splash_Screen()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Splash_Screen_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            metroProgressBar1.Value += 2;
            label2.Text = metroProgressBar1.Value.ToString() + "%";




            ticks++;
            if (ticks == metroProgressBar1.Value || metroProgressBar1.Value == 100)

            {
                loginfrm log = new loginfrm();
                log.Show();
                this.Hide();
                timer1.Stop();
            }
            
            

        }
    }
}
