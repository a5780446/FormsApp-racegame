using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp賽跑
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*private void run()
        {
            pictureBox2.Left += 10;
            pictureBox3.Left += 10;
        }
        public delegate void run_go(); //聲明委託
        private void Calldelegate() //調用委託
        {
            BeginInvoke(new run_go(run));
        }
        public void DoWork()
        {
            Calldelegate();
        }*/

        public static int math(int a,int b)
        {
            return a * b;
        }

         //亂數用變數
        int z1 ,z2, z3, z4, z5;
        int money = 300;
        int xx = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            pictureBox2.Image = imageList1.Images[1];
            pictureBox3.Image = imageList1.Images[2];
            pictureBox4.Image = imageList1.Images[3];
            pictureBox5.Image = imageList1.Images[4];
            Random rantime = new Random(); //亂數給(sleep)的時間
            z1 = rantime.Next(50, 100);
            z2 = rantime.Next(50, 100);
            z3 = rantime.Next(50, 100);
            z4 = rantime.Next(50, 100);
            z5 = rantime.Next(50, 100);

            
            label1.Text = money.ToString();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();
            button1.Enabled = false;
            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e) //下注金額判斷
        {
            if (int.Parse(textBox1.Text) % 50 != 0)
            {
                MessageBox.Show("以50為單位下注,謝謝客官~");
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                if (int.Parse(textBox1.Text) > 800)
                    xx = 15;
                else if (int.Parse(textBox1.Text) > 500)
                    xx = 8;
                else
                    xx = 4;
                money -= int.Parse(textBox1.Text);  //扣錢
                label1.Text = money.ToString();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Interval = z4;
            pictureBox4.Left += 10;
            if (pictureBox4.Left > pictureBox0.Width - 80 && radioButton4.Checked==true)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                timer5.Stop();
                MessageBox.Show("4號為勝利者,恭喜贏得獎金");
                
                money += math(int.Parse(textBox1.Text), xx);
                label1.Text = money.ToString();
            }
            else if(pictureBox4.Left > pictureBox0.Width - 80)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                timer5.Stop();
                MessageBox.Show("4號為勝利者,再接再厲");
            }
        }

        private void button4_Click(object sender, EventArgs e)  //跑者歸位
        {
            pictureBox1.Left = pictureBox0.Left + 5;
            pictureBox2.Left = pictureBox0.Left + 5;
            pictureBox3.Left = pictureBox0.Left + 5;
            pictureBox4.Left = pictureBox0.Left + 5;
            pictureBox5.Left = pictureBox0.Left + 5;
            button1.Enabled = true;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            timer5.Interval = z5;
            pictureBox5.Left += 10;
            if (pictureBox5.Left > pictureBox0.Width - 80 && radioButton5.Checked == true)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                timer5.Stop();
                MessageBox.Show("5號為勝利者,恭喜贏得獎金");
                money += math(int.Parse(textBox1.Text), xx);
                label1.Text = money.ToString();

            }
            else if(pictureBox5.Left > pictureBox0.Width - 80)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                timer5.Stop();
                MessageBox.Show("5號為勝利者,再接再厲");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = z1;
            pictureBox1.Left += 10;
            if (pictureBox1.Left > pictureBox0.Width - 80 && radioButton1.Checked==true)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                timer5.Stop();
                MessageBox.Show("1號為勝利者,恭喜贏得獎金");
                money += math(int.Parse(textBox1.Text), xx);
                label1.Text = money.ToString();
            }
            else if (pictureBox1.Left > pictureBox0.Width - 80)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                timer5.Stop();
                MessageBox.Show("1號為勝利者,再接再厲");
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = z2;
            /*Thread two = new Thread(new ThreadStart(DoWork));
            two.Start();*/
            pictureBox2.Left += 10;
            if (pictureBox2.Left > pictureBox0.Width - 80 && radioButton2.Checked==true)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                timer5.Stop();
                MessageBox.Show("2號為勝利者,恭喜贏得獎金");
                money += math(int.Parse(textBox1.Text), xx);
                label1.Text = money.ToString();
            }
            else if(pictureBox2.Left > pictureBox0.Width - 80)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                timer5.Stop();
                MessageBox.Show("2號為勝利者,再接再厲");
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Interval = z3;
            pictureBox3.Left += 10;
            if (pictureBox3.Left > pictureBox0.Width - 80 && radioButton3.Checked==true)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                timer5.Stop();
                MessageBox.Show("3號為勝利者,恭喜贏得獎金");
                money += math(int.Parse(textBox1.Text), xx);
                label1.Text = money.ToString();
            }
            else if (pictureBox3.Left > pictureBox0.Width - 80)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                timer5.Stop();
                MessageBox.Show("3號為勝利者,再接再厲");
            }
        }

        /*希望大大可以教學一下:
        我想把pictureBox[1 - 5] 都建立不同thread;
        按button1,5條thread一起走*/




    }
}
    
