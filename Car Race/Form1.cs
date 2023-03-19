using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Car_Race
{
    public partial class Form1 : Form
    {
        Random R = new Random();
        enum direction { left, right, none,up,down }
        int speed = 5;
        double score = 0;
        direction dir = direction.none;
            
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mytimer_Tick(object sender, EventArgs e)
        {
            
            L1.Top += speed;
            L2.Top += speed;
            L3.Top += speed;
            L4.Top += speed;
            L5.Top += speed;
            L6.Top += speed;
            
            if (L1.Top > panel1.Height) { L1.Top = -L1.Height; }
            if (L2.Top > panel1.Height) { L2.Top = -L2.Height; }
            if (L3.Top > panel1.Height) { L3.Top = -L3.Height; }
            if (L4.Top > panel1.Height) { L4.Top = -L4.Height; }
            if (L5.Top > panel1.Height) { L5.Top = -L5.Height; }
            if (L6.Top > panel1.Height) { L6.Top = -L6.Height; }

            if (dir == direction.left && player.Left > 0) { player.Left -= speed; }
            else if (dir == direction.right && player.Right < (panel1.Width )) { player.Left += speed; }
            else if (dir == direction.up && player.Top > 0) { player.Top -=speed; }

         if(car1.Visible)
            {
                car1.Top += speed;
                if (car1.Top > panel1.Height)
                {
                    car1.Visible = false;
                    car1.Top = -Height;
                    car1.Left = R.Next(panel1.Width/2,panel1.Width-car1.Width);
                
                    car1.Visible = true;

                }
            }
            if (car2.Visible)
            {
                car2.Top += speed;
                if(car2.Top>panel1.Height)
                {
                    car2.Visible = false;
                    car2.Top = -Height;
                    car2.Left = R.Next((panel1.Width-car2.Width)/2);
                    car2.Visible = true;
                }
            }


            if(player.Bounds.IntersectsWith(car1.Bounds) ||player.Bounds.IntersectsWith(car2.Bounds))
            {
                mytimer.Enabled = false;
                lblgameover.Visible = true;
                
            }

            score++;
            double cccc = (score / 10);
            if (score > 100) cccc = score / 7;
            if (score > 150) cccc = score / 6.2;
            if (score > 200) cccc = score / 6;
            if (score > 300) cccc = score / 5.5;


            if (score > 1000) speed = 8;
            if (score > 1500) speed = 10;
            if (score > 2000) speed = 12;
            if (score > 2500) speed = 15;

            lblscore.Text = "Score : " + (int)cccc;
            
        }

        private void L1_Click(object sender, EventArgs e)
        {

        }

        private void L2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            if (e.KeyData == Keys.Left) d1 = direction.left;
            else if (e.KeyData == Keys.Right) d1 = direction.right;
            else d1 = direction.none;
            */
            if (e.KeyData == Keys.Left) dir = direction.left;
            else if (e.KeyData == Keys.Right) dir = direction.right;
            else if (e.KeyData == Keys.Up) dir = direction.up;
            else dir = direction.none;

            if(e.KeyData==Keys.Space&& player.Bounds.IntersectsWith(car1.Bounds) || player.Bounds.IntersectsWith(car2.Bounds))
            {
               // car1.Visible = false;
                //car2.Visible = false;
                lblgameover.Visible = false;
                player.Left = (panel1.Width-player.Width) / 2;
                player.Top =( panel1.Height-player.Height-4);
               // car1.Visible = true;
               // car2.Visible = true;
                car2.Left = 0;
                car1.Left = (400);
                score = 0;
                speed = 5;

                mytimer.Enabled = true;
                
            }
           
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            dir = direction.none;
        }

        private void player_Click(object sender, EventArgs e)
        {

        }
    }
}
