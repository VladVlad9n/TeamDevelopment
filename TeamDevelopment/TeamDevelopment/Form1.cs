using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TeamDevelopment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button4.Visible = false;
        }

        public int h, m,m1, s;
        double d,d1,d2,d3,d4,d5,d6;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label6.Text = "0";
            textBox3.Text = "";
            pictureBox1.Image = Properties.Resources._6;
            button4.Visible = false;
            button1.Visible = true;

            button2.Width = 67;
            button2.BackColor = Control.DefaultBackColor;
            button2.Location = new Point(185, 466);

            button4.Width = 67;
            button4.BackColor = Control.DefaultBackColor;
            button4.Location = new Point(185, 466);
            button1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button4.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                s = s - 1;
                if (s == -1)
                {
                    m = m - 1;
                    s = 59;
                }

            if (m == -1)
            {
                h = h - 1;
                m = 59;
            }

            if (h == 0 && m == 0 && s == 0)
            {
                timer1.Stop();
                
            }

            d = (Convert.ToDouble(textBox3.Text) / 5);
            d1 = Convert.ToDouble(textBox3.Text);
            
            d2 = d1 - d;
            d3 = d2 - d;
            d4 = d3 - d;
            d5 = d4 - d;
            d6 = d5 - d;
            if (s == Convert.ToInt32(d2)) 
            {
                pictureBox1.Image = Properties.Resources._2;
            }
            label9.Text = Convert.ToString(d2);
            if (s == Convert.ToInt32(d3))
            {
                pictureBox1.Image = Properties.Resources._3;
            }
            if (s == Convert.ToInt32(d4))
            {
                pictureBox1.Image = Properties.Resources._4;
            }
            if (s == Convert.ToInt32(d5))
            {
                pictureBox1.Image = Properties.Resources._5;
            }
            if (s == Convert.ToInt32(d6)/10)
            {
                pictureBox1.Image = Properties.Resources._6;
                MessageBox.Show("Время вышло!");


                button2.Width = 67;
                button2.BackColor = Control.DefaultBackColor;
                button2.Location = new Point(185, 466);

                button4.Width = 67;
                button4.BackColor = Control.DefaultBackColor;
                button4.Location = new Point(185, 466);
            }
            
            label6.Text = Convert.ToString(s);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = Convert.ToInt32(textBox3.Text);

            timer1.Start();
            pictureBox1.Image = Properties.Resources._1;
            button1.Visible = false;
            button2.Width = 140;
            button2.BackColor = Color.Red;
            button2.Location = new Point(112,466);

            button4.Width = 140;
            button4.BackColor = Color.Blue;
            button4.Location = new Point(112, 466);
        }
    }
}
