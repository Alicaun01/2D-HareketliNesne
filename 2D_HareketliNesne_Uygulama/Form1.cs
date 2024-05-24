using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2D_HareketliNesne_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if (pictureBox1.Top <= 23)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left > 665)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if (pictureBox1.Top >= 455)
            {
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            if (pictureBox1.Left <= 145)
            {
                timer4.Stop();
                timer5.Start();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if (pictureBox1.Top <=130)
            {
                timer5.Stop();
                timer6.Start();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left >= 575)
            {
                timer6.Stop();
                timer7.Start();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if (pictureBox1.Top>=360)
            {
                timer7.Stop();
                timer8.Start();
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            if (pictureBox1.Left <= 253)
            {
                timer8.Stop();
                timer9.Start();
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if (pictureBox1.Top <=230)
            {
                timer9.Stop();
                timer10.Start();
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if(pictureBox1.Left >=450)
            {
                timer10.Stop();
                MessageBox.Show("Varış Noktasına Ulaşıldı!");
            }

        }
    }
}
