using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            empty(gamespeed);
            gameover();
           coins(gamespeed);
           coinscollection();
        }
        int collectedcoins=0;
        Random r = new Random();
        int x,y;
        void empty(int speed)
        {
            if (empty1.Top >= 500)
            {
                x = r.Next(0,200);
              
                empty1.Location = new Point(x,0);
            }
            else
            {
                empty1.Top += speed;
            }
            if (empty2.Top >= 500)
            {
                x = r.Next(0,400);
              
                empty2.Location = new Point(x,0);
            }
            else
            {
                empty2.Top += speed;
            }
            if (empty3.Top >= 500)
            {
                x = r.Next(200,350);
              
                empty3.Location = new Point(x,0);
            }
            else
            {
                empty3.Top += speed;
            }
        }

        void coins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(0, 200);

                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }
            if (coin2.Top >= 500)
            {
                x = r.Next(0, 200);

                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }
            if (coin3.Top >= 500)
            {
                x = r.Next(50, 300);

                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }
            if (coin4.Top >= 500)
            {
                x = r.Next(0, 200);

                coin4.Location = new Point(x, 0);
            }
            else
            {
                coin4.Top += speed;
            }
        }
        void gameover()
        {
            if(car.Bounds.IntersectsWith(empty1.Bounds))
            {
                timer1.Enabled=false;
                over.Visible=true;
            }
        }
        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }
            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }
           if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        void coinscollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoins++;
                label1.Text="Coins="+collectedcoins.ToString();
                x = r.Next(50, 300);

                coin1.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoins++;
                label1.Text = "Coins=" + collectedcoins.ToString();
                x = r.Next(50, 300);

                coin2.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoins++;
                label1.Text = "Coins=" + collectedcoins.ToString();
                x = r.Next(50, 300);

                coin3.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoins++;
                label1.Text = "Coins=" + collectedcoins.ToString();
                x = r.Next(50, 300);

                coin4.Location = new Point(x, 0);
            }
        }
        int gamespeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Left)
            {
                if(car.Left>0)
                car.Left+=-8;
            }
            if (e.KeyCode == Keys.Right)
            {
                if(car.Right<380)
                car.Left += 8;
            }
            if(e.KeyCode==Keys.Up)
                if (gamespeed < 21)
                {
                    gamespeed++;
                }
            if(e.KeyCode==Keys.Down)
                if (gamespeed > 0)
                {
                    gamespeed--;
                }
        }

        private void Form1_BackgroundImageChanged(object sender, EventArgs e)
        {

        }

       
    }
}
