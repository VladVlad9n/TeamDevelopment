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
        // Стиль написания Camel_casing
        int clickCount;

        public Form1()
        {
            InitializeComponent();
            btnContinue.Visible = false;
            btnStop.Enabled = false;
            btnContinue.Enabled = false;
        }

        public int hours, minutes, m1, seconds;
        double d, d1, d2,d3, d4, d5, d6;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            clickCount = 0;
        }

        private void textSandBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsLetter(c) || char.IsSymbol(c) || char.IsPunctuation(c))
            {
                e.Handled = true;
            }
        }
        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnContinue.Visible = true;
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnContinue.Enabled = false;

            timer1.Stop();
            label6.Text = "0";
            textSandBox.Text = "";
            pictureSandBox.Image = Properties.Resources._6;
            btnContinue.Visible = false;
            btnStart.Visible = true;

            btnStop.Width = 105;
            btnStop.BackColor = BackColor;
            btnStop.Location = new Point(178, 466);

            btnContinue.Width = 105;
            btnContinue.BackColor = DefaultBackColor;
            btnContinue.Location = new Point(178, 466);
            btnStart.Visible = true;
            textSandBox.Enabled = true;

            if (clickCount == 5)
            {
                pictureBox1.Visible = true;
            }
            else
            {
                clickCount++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnContinue.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds = seconds - 1;
            if (seconds == 0)
            {
                timer1.Stop();
            }

            d = (Convert.ToDouble(textSandBox.Text) / 5);
            d1 = Convert.ToDouble(textSandBox.Text);

            d2 = d1 - d;
            d3 = d2 - d;
            d4 = d3 - d;
            d5 = d4 - d;
            d6 = d5 - d;

            if (seconds == Convert.ToInt32(d2))
            {
                pictureSandBox.Image = Properties.Resources._2;
            }
            label9.Text = Convert.ToString(d2);
            if (seconds == Convert.ToInt32(d3))
            {
                pictureSandBox.Image = Properties.Resources._3;
            }
            if (seconds == Convert.ToInt32(d4))
            {
                pictureSandBox.Image = Properties.Resources._4;
            }
            if (seconds == Convert.ToInt32(d5))
            {
                pictureSandBox.Image = Properties.Resources._5;
            }
            if (seconds == Convert.ToInt32(d6) / 10)
            {
                pictureSandBox.Image = Properties.Resources._6;
                MessageBox.Show("Время вышло!");


                btnStop.Width = 105;
                btnStop.BackColor = BackColor;
                btnStop.Location = new Point(178, 466);

                btnContinue.Width = 105;
                btnContinue.BackColor = DefaultBackColor;
                btnContinue.Location = new Point(178, 466);
                btnStart.Visible = true;

                btnContinue.Visible = false;
                btnStart.Visible = true;

                btnStop.Enabled = false;
                btnContinue.Enabled = false;
                textSandBox.Enabled = true;
            }
            label6.Text = Convert.ToString(seconds);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textSandBox.Text) == 0 || textSandBox.Text is null)
                {
                    MessageBox.Show("Введите число больше нуля", "Что то пошло не так :/");
                }
                else if (Convert.ToInt32(textSandBox.Text) > 21600)
                {
                    MessageBox.Show("Введите число поменьше", "Что то пошло не так :/");
                }
                else
                {
                    btnStop.Enabled = true;
                    btnContinue.Enabled = true;

                    seconds = Convert.ToInt32(textSandBox.Text);

                    timer1.Start();
                    btnContinue.Enabled = true;
                    pictureSandBox.Image = Properties.Resources._1;
                    btnStart.Visible = false;
                    btnStop.Width = 216;
                    btnStop.BackColor = Color.SandyBrown;
                    btnStop.Location = new Point(67, 466);

                    btnContinue.Width = 216;
                    btnContinue.BackColor = Color.FromArgb(0, 153, 220);
                    btnContinue.Location = new Point(67, 466);
                    textSandBox.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Ведите корректный данные", "Что то пошло не так :/");
            }
        }
    }
}
