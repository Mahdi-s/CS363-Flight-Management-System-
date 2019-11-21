using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS363finalproject
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();
        int WIDTH = 300, HEIGHT = 300, HAND = 150;
        int u; //in degree
        int cx, cy; //center of circle
        int x, y; //Hand coordinate

        int tx, ty, lim = 20;

        Boolean warning = false;

        Bitmap bmp;

        Pen p;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            topographicChecked.Checked = true;
            topographicChecked.Checked = false;
            airplane2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //create Bitmap
            bmp = new Bitmap(WIDTH + 1, HEIGHT + 1);
            //background color
            this.BackColor = Color.Black;
            //center
            cx = WIDTH / 2;
            cy = HEIGHT / 2;

            //timer
            t.Interval = 5;// in millisec
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            //pen
            if (warning)
            {
                p = new Pen(Color.Red, 1f);
            }
            else
            {
                p = new Pen(Color.Green, 1f);
            }
            //graphics 
            g = Graphics.FromImage(bmp);
            //calculate x,y, coord of hand
            int tu = (u - lim) % 360;
            if(u >= 0 && u <= 180)
            {
                //right half
                // convert u into radians from degrees
                x = cx + (int)(HAND * Math.Sin(Math.PI * u / 180));
                y = cy - (int)(HAND * Math.Cos(Math.PI * u / 180));
            }
            else
            {
                x = cx - (int)(HAND * -Math.Sin(Math.PI * u / 180));
                y = cy - (int)(HAND * Math.Cos(Math.PI * u / 180));

            }
            if (tu >= 0 && tu <= 180)
            {
                //right half
                // convert u into radians from degrees
                tx = cx + (int)(HAND * Math.Sin(Math.PI * tu / 180));
                ty = cy - (int)(HAND * Math.Cos(Math.PI * tu / 180));
            }
            else
            {
                tx = cx - (int)(HAND * -Math.Sin(Math.PI * tu / 180));
                ty = cy - (int)(HAND * Math.Cos(Math.PI * tu / 180));

            }
            #region Radar Cirlces
            //draw circle
            g.DrawEllipse(p, 0, 0, WIDTH, HEIGHT);//Outer circle
            g.DrawEllipse(p, 30, 30, WIDTH - 60, HEIGHT - 60);
            g.DrawEllipse(p, 60, 60, WIDTH - 120, HEIGHT - 120);
            g.DrawEllipse(p, 90, 90, WIDTH - 180, HEIGHT - 180);
            g.DrawEllipse(p, 120, 120, WIDTH - 240, HEIGHT - 240); //smallest cirlce
            #endregion
            #region Line & Hand 
            //draw prepen line
            g.DrawLine(p, new Point(cx, 0), new Point(cx, HEIGHT));//up down
            g.DrawLine(p, new Point(0, cy), new Point(WIDTH, cy)); //left right

            //draw HAND
            g.DrawLine(new Pen(Color.Black, 1f), new Point(cx, cy), new Point(tx, ty));
            g.DrawLine(p, new Point(cx, cy), new Point(x, y));
            #endregion


            g.DrawLine(p, new Point(120, 130), new Point(180, 130));
            g.DrawLine(p, new Point(120, 132), new Point(180, 132));
            g.DrawLine(p, new Point(120, 140), new Point(180, 140));
            g.DrawLine(p, new Point(120, 142), new Point(180, 142));

            //load bitmap in picture
            pictureBox2.Image = bmp;
            //dispose
            p.Dispose();
            g.Dispose();

            //update
            u++;
            if (u == 360)
            {
                u = 0;
            }

        }

        private void Case1Button_Click(object sender, EventArgs e)
        {

        }

        private void Case2Button_Click(object sender, EventArgs e)
        {

        }

        private void Case3Button_Click(object sender, EventArgs e)
        {

        }

        private void Case4Button_Click(object sender, EventArgs e)
        {

        }

        private void TopographicChecked_CheckedChanged(object sender, EventArgs e)
        {
            if (topographicChecked.Checked)
            {
                pictureBox2.BackgroundImage = Properties.Resources.topomap;
            }
            else
            {
                pictureBox2.BackgroundImage = Properties.Resources.black;
            }
        }
    }
}
