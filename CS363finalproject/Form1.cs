using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Team A+
 * Andie Jackson
 * Mahdi Saeedi Velashani
 */

namespace CS363finalproject
{
    public partial class Form1 : Form
    {
        int WIDTH = 300, HEIGHT = 300, HAND = 150;
        int u; //in degree
        int cx, cy; //center of circle
        int x, y; //Hand coordinate
        int tx, ty, lim = 20;

        Bitmap bmp;
        Pen p;
        Graphics g;

        Boolean warning = false;

        public Form1()
        {
            InitializeComponent();
            warningLabel.Visible = false;
            topographicChecked.Checked = true;
            topographicChecked.Checked = false;
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
            Timer t = new Timer();
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

            //runway lines
            g.DrawLine(p, new Point(120, 130), new Point(180, 130));
            g.DrawLine(p, new Point(120, 132), new Point(180, 132));
            g.DrawLine(p, new Point(120, 140), new Point(180, 140));
            g.DrawLine(p, new Point(120, 142), new Point(180, 142));

            //airspace entrance lines
            g.DrawLine(p, new Point(250, 40), new Point(260, 40));
            g.DrawLine(p, new Point(30, 250), new Point(40, 250));

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

        //Case 1 global variables
        Timer t_case1 = new Timer();
        Boolean flippedA1C1 = false;
        Boolean flippedA2C1_1 = false;
        Boolean flippedA2C1_2 = false;
        Boolean flippedA3C1 = false;
        Boolean changedCountA1C1 = false;
        Boolean changedCountA2C1 = false;
        Boolean changedCountA3C1 = false;
        Boolean needsUpdatingC1 = true;
        int countC1 = 0;

        //Case 1: Arriving/Landed airplane
        private void Case1Button_Click(object sender, EventArgs e)
        {
            t_case1.Interval = 100; //millisecond
            t_case1.Tick += new EventHandler(this.case1_Tick);
            t_case1.Start();

            //reset airplane information
            needsUpdatingC1 = true;
            changedCountA1C1 = false;
            changedCountA2C1 = false;
            changedCountA3C1 = false;
            countC1 = 0;
            aircraftCount.Text = "3";
            infoFlight.Text = "AA263";
            infoDestination.Text = "AEJ";
            infoStatus.Text = "A";
            infoAltitude.Text = "2000";
            infoSpeed.Text = "185";
            infoHeading.Text = "0";

            //reset positions of airplanes
            airplane1.Location = new Point(330, 275);
            airplane1.Visible = true;
            airplane1.Image = Properties.Resources.airplaneWhite;

            airplane2.Location = new Point(220, 15);
            airplane2.Visible = true;
            airplane2.Image = Properties.Resources.airplaneGreen;
            airplane2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

            airplane3.Location = new Point(110,210);
            airplane3.Visible = true;
            airplane3.Image = Properties.Resources.airplaneGreen;

        }
        private void case1_Tick(object sender, EventArgs e)
        {
            countC1++;

            //airplane 1 (selected airplane) lands on runway
            if(airplane1.Location.Y == 150 && !flippedA1C1)
            {
                airplane1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                flippedA1C1 = true;
                airplane1.Left -= 1;
                infoHeading.Text = "270";

                if (countC1 % 15 == 0)
                {
                    int altitude = Convert.ToInt32(infoAltitude.Text);
                    infoAltitude.Text = Convert.ToString(altitude - 210);
                    int speed = Convert.ToInt32(infoSpeed.Text);
                    infoSpeed.Text = Convert.ToString(speed - 18);
                }
            }
            else if (airplane1.Location.Y > 150)
            {
                airplane1.Top -= 1;
                
                if (countC1 % 15 == 0)
                {
                    int altitude = Convert.ToInt32(infoAltitude.Text);
                    infoAltitude.Text = Convert.ToString(altitude - 65);
                    int speed = Convert.ToInt32(infoSpeed.Text);
                    infoSpeed.Text = Convert.ToString(speed - 6);
                }
            }
            else if(airplane1.Visible)
            {
                airplane1.Left -= 1;
                if (needsUpdatingC1)
                {
                    if (countC1 % 15 == 0)
                    {
                        int altitude = Convert.ToInt32(infoAltitude.Text);
                        infoAltitude.Text = Convert.ToString(altitude - 211);
                        int speed = Convert.ToInt32(infoSpeed.Text);
                        infoSpeed.Text = Convert.ToString(speed - 16);
                    }
                }
                if (airplane1.Location.X == 225)
                {
                    infoStatus.Text = "";
                    infoAltitude.Text = "   0";
                    infoSpeed.Text = "0";
                    infoHeading.Text = "0";
                    needsUpdatingC1 = false;
                    airplane1.Visible = false;
                    if (!changedCountA1C1)
                    {
                        int currentAirplanes = Convert.ToInt32(aircraftCount.Text);
                        aircraftCount.Text = Convert.ToString(currentAirplanes - 1);
                        changedCountA1C1 = true;
                    }
                }
            }

            //airplane 2 exits on top right airspace exit point
            if(airplane2.Location.X == 330)
            {
                airplane2.Visible = false;
                if (!changedCountA2C1)
                {
                    int currentAirplanes = Convert.ToInt32(aircraftCount.Text);
                    aircraftCount.Text = Convert.ToString(currentAirplanes - 1);
                    changedCountA2C1 = true;
                }
            }
            else if(airplane2.Location.X == 280 && !flippedA2C1_1)
            {
                airplane2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                flippedA2C1_1 = true;
                airplane2.Top += 1;
            }
            else if(airplane2.Location.Y == 30 && !flippedA2C1_2)
            {
                airplane2.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                flippedA2C1_2 = true;
            }
            else if(airplane2.Location.X < 280)
            {
                airplane2.Left += 1;
            }
            else if(airplane2.Location.Y < 30)
            {
                airplane2.Top += 1;
            }
            else if(airplane2.Visible)
            {
                airplane2.Left += 1;
            }

            //airplane 3 exits on top right airspace exit point
            if (airplane3.Location.X == 330)
            {
                airplane3.Visible = false;
                if (!changedCountA3C1)
                {
                    int currentAirplanes = Convert.ToInt32(aircraftCount.Text);
                    aircraftCount.Text = Convert.ToString(currentAirplanes - 1);
                    changedCountA3C1 = true;
                }

                //reset planes to starting directions (a1-up, a2-up, a3-up)
                if (flippedA1C1)
                {
                    airplane1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    flippedA1C1 = false;
                }

                if (flippedA2C1_1 || flippedA2C1_2)
                {
                    flippedA2C1_1 = false;
                    flippedA2C1_2 = false;
                }

                if (flippedA3C1)
                {
                    airplane3.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    flippedA3C1 = false;
                }

                t_case1.Dispose(); //stop the tick of Case 1
            }
            else if(airplane3.Location.Y == 30 && !flippedA3C1)
            {
                airplane3.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                flippedA3C1 = true;
                airplane3.Left += 2;
            }
            else if (airplane3.Location.Y > 30)
            {
                airplane3.Top -= 2;
            }
            else if (airplane3.Visible)
            {
                airplane3.Left += 1;
            }
        }

        //Case 2 global variables
        Timer t_case2 = new Timer();
        Boolean flippedA1C2 = false;
        Boolean flippedA2C2_1 = false;
        Boolean flippedA2C2_2 = false;
        Boolean flippedA3C2_1 = false;
        Boolean flippedA3C2_2 = false;
        Boolean changedCountA1C2 = false;
        Boolean changedCountA2C2 = false;
        Boolean changedCountA3C2 = false;
        Boolean needsUpdatingC2 = true;
        int countC2 = 0;

        //Case 2: Departing airplane
        private void Case2Button_Click(object sender, EventArgs e)
        {
            t_case2.Interval = 100; //millisecond
            t_case2.Tick += new EventHandler(this.case2_Tick);
            t_case2.Start();

            //reset airplane information
            needsUpdatingC2 = true;
            changedCountA1C2 = false;
            changedCountA2C2 = false;
            changedCountA3C2 = false;
            countC2 = 0;
            aircraftCount.Text = "3";
            infoFlight.Text = "DL305";
            infoDestination.Text = "MCO";
            infoStatus.Text = "D";
            infoAltitude.Text = "0";
            infoSpeed.Text = "20";
            infoHeading.Text = "270";

            //reset positions of airplanes
            airplane1.Location = new Point(330, 275);
            airplane1.Visible = true;
            airplane1.Image = Properties.Resources.airplaneGreen;

            airplane2.Location = new Point(220, 15);
            airplane2.Visible = true;
            airplane2.Image = Properties.Resources.airplaneGreen;
            airplane2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

            airplane3.Location = new Point(200, 150);
            airplane3.Visible = true;
            airplane3.Image = Properties.Resources.airplaneWhite;
            airplane3.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);

        }
        private void case2_Tick(object sender, EventArgs e)
        {
            countC2++;

            //airplane 1 lands on runway
            if (airplane1.Location.Y == 150 && !flippedA1C2)
            {
                airplane1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                flippedA1C2 = true;
                airplane1.Left -= 1;
            }
            else if (airplane1.Location.Y > 150)
            {
                airplane1.Top -= 1;
            }
            else if (airplane1.Visible)
            {
                airplane1.Left -= 1;
                if (airplane1.Location.X == 225)
                {
                    airplane1.Visible = false;
                    if (!changedCountA1C2)
                    {
                        int currentAirplanes = Convert.ToInt32(aircraftCount.Text);
                        aircraftCount.Text = Convert.ToString(currentAirplanes - 1);
                        changedCountA1C2 = true;
                    }
                }
            }

            //airplane 2 exits on top right airspace exit point
            if (airplane2.Location.X == 330)
            {
                airplane2.Visible = false;
                if (!changedCountA2C2)
                {
                    int currentAirplanes = Convert.ToInt32(aircraftCount.Text);
                    aircraftCount.Text = Convert.ToString(currentAirplanes - 1);
                    changedCountA2C2 = true;
                }
            }
            else if (airplane2.Location.X == 280 && !flippedA2C2_1)
            {
                airplane2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                flippedA2C2_1 = true;
                airplane2.Top += 1;
            }
            else if (airplane2.Location.Y == 30 && !flippedA2C2_2)
            {
                airplane2.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                flippedA2C2_2 = true;
            }
            else if (airplane2.Location.X < 280)
            {
                airplane2.Left += 1;
            }
            else if (airplane2.Location.Y < 30)
            {
                airplane2.Top += 1;
            }
            else if (airplane2.Visible)
            {
                airplane2.Left += 1;
            }

            //airplane 3 exits on bottom left airspace exit point
            if (airplane3.Location.X == 80)
            {
                airplane3.Visible = false;
                needsUpdatingC2 = false;
                if (!changedCountA3C2)
                {
                    int currentAirplanes = Convert.ToInt32(aircraftCount.Text);
                    aircraftCount.Text = Convert.ToString(currentAirplanes - 1);
                    changedCountA3C2 = true;
                }

                //reset planes to starting directions (a1-up, a2-up, a3-up)
                if (flippedA1C2)
                {
                    airplane1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    flippedA1C2 = false;
                }

                if (flippedA2C2_1 || flippedA2C2_2)
                {
                    flippedA2C2_1 = false;
                    flippedA2C2_2 = false;
                }

                if (flippedA3C2_1 || flippedA3C2_2)
                {
                    airplane3.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    flippedA3C2_1 = false;
                    flippedA3C2_2 = false;
                }

                t_case2.Dispose(); //stop the tick of Case 2
            }
            else if(airplane3.Location.X == 100 && !flippedA3C2_1)
            {
                airplane3.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                flippedA3C2_1 = true;

                infoHeading.Text = "180";
                if (countC2 % 15 == 0)
                {
                    int altitude = Convert.ToInt32(infoAltitude.Text);
                    infoAltitude.Text = Convert.ToString(altitude + 211);
                    int speed = Convert.ToInt32(infoSpeed.Text);
                    if (speed <= 234)
                    {
                        infoSpeed.Text = Convert.ToString(speed + 16);
                    }
                    else
                    {
                        infoSpeed.Text = "250";
                    }
                }
            }
            else if (airplane3.Location.Y == 280 && !flippedA3C2_2)
            {
                airplane3.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                flippedA3C2_2 = true;
                airplane3.Left += 2;

                infoHeading.Text = "270";
                if (countC2 % 15 == 0)
                {
                    int altitude = Convert.ToInt32(infoAltitude.Text);
                    infoAltitude.Text = Convert.ToString(altitude + 211);
                    int speed = Convert.ToInt32(infoSpeed.Text);
                    if (speed <= 234)
                    {
                        infoSpeed.Text = Convert.ToString(speed + 16);
                    }
                    else
                    {
                        infoSpeed.Text = "250";
                    }
                }
            }
            else if (airplane3.Location.Y < 280 && flippedA3C2_1)
            {
                airplane3.Top += 1;

                if (countC2 % 15 == 0)
                {
                    int altitude = Convert.ToInt32(infoAltitude.Text);
                    infoAltitude.Text = Convert.ToString(altitude + 211);
                    int speed = Convert.ToInt32(infoSpeed.Text);
                    if (speed <= 234)
                    {
                        infoSpeed.Text = Convert.ToString(speed + 16);
                    }
                    else
                    {
                        infoSpeed.Text = "250";
                    }
                }
            }
            else if (airplane3.Visible)
            {
                airplane3.Left -= 1;

                if (needsUpdatingC2)
                {
                    if (countC2 % 15 == 0)
                    {
                        int altitude = Convert.ToInt32(infoAltitude.Text);
                        infoAltitude.Text = Convert.ToString(altitude + 211);
                        int speed = Convert.ToInt32(infoSpeed.Text);
                        if (speed <= 234)
                        {
                            infoSpeed.Text = Convert.ToString(speed + 16);
                        }
                        else
                        {
                            infoSpeed.Text = "250";
                        }
                    }
                }
            }
        }

        //Case 3 global variables
        Timer t_case3 = new Timer();
        Boolean flippedA1C3 = false;
        Boolean flippedA2C3_1 = false;
        Boolean flippedA2C3_2 = false;
        Boolean flippedA3C3 = false;
        Boolean changedCountA1C3 = false;
        Boolean changedCountA2C3 = false;
        Boolean changedCountA3C3 = false;
        Boolean needsUpdatingC3 = true;
        int countC3 = 0;

        //Case 3: Collision avoidance between two airplanes
        private void Case3Button_Click(object sender, EventArgs e)
        {
            t_case3.Interval = 100; //millisecond
            t_case3.Tick += new EventHandler(this.case3_Tick);
            t_case3.Start();

            //reset airplane information
            needsUpdatingC1 = true;
            changedCountA1C3 = false;
            changedCountA2C3 = false;
            changedCountA3C3 = false;
            countC1 = 0;
            infoFlight.Text = "AA263";
            infoDestination.Text = "MSP";
            infoStatus.Text = "D";
            infoAltitude.Text = "2000";
            infoSpeed.Text = "175";
            infoHeading.Text = "0";

            //reset positions of airplanes
            airplane1.Location = new Point(330, 275);
            airplane1.Visible = true;
            airplane1.Image = Properties.Resources.airplaneGreen;

            airplane2.Location = new Point(110, 30);
            airplane2.Visible = true;
            airplane2.Image = Properties.Resources.airplaneWhite;
            airplane2.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);

            airplane3.Location = new Point(110, 210);
            airplane3.Visible = true;
            airplane3.Image = Properties.Resources.airplaneGreen;
        }
        private void case3_Tick(object sender, EventArgs e)
        {
            countC3++;

            //airplane 1 lands on runway
            if (airplane1.Location.Y == 150 && !flippedA1C3)
            {
                airplane1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                flippedA1C3 = true;
                airplane1.Left -= 1;
            }
            else if (airplane1.Location.Y > 150)
            {
                airplane1.Top -= 1;
            }
            else if (airplane1.Visible)
            {
                airplane1.Left -= 1;
                if (airplane1.Location.X == 225)
                {
                    airplane1.Visible = false;

                    if (!changedCountA1C2)
                    {
                        int currentAirplanes = Convert.ToInt32(aircraftCount.Text);
                        aircraftCount.Text = Convert.ToString(currentAirplanes - 1);
                        changedCountA1C3 = true;
                    }
                }
            }

            //airplane 2 almost hits airplane 3 and then exits on bottom left airspace exit point
            if(airplane2.Location.Y < 80)
            {
                airplane2.Top += 1;
                if(airplane2.Location.Y == 70)
                {
                    warningLabel.Visible = true;
                    warning = true;
                }
            }
            else if(airplane2.Location.Y == 80 && !flippedA2C3_1)
            {
                airplane2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                flippedA2C3_1 = true;
            }
            else if(airplane2.Location.X > 70)
            {
                airplane2.Left -= 2;
                if(airplane2.Location.X == 80)
                {
                    warningLabel.Visible = false;
                    warning = false;
                }
            }
            else if(airplane2.Location.X == 70 && !flippedA2C3_2)
            {
                airplane2.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                flippedA2C3_2 = true;
            }
            else if(airplane2.Location.Y < 280)
            {
                airplane2.Top += 2;
            }
            else if(airplane2.Location.Y == 280)
            {
                airplane2.Visible = false;
            }

            //airplane 3 almost hits airplane 2 and then exits on top right airspace exit point
            if(airplane3.Location.Y > 30)
            {
                airplane3.Top -= 1;
            }
            else if(airplane3.Location.Y == 30 && !flippedA3C3)
            {
                airplane3.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                flippedA3C3 = true;
            }
            else if(airplane3.Location.X < 320)
            {
                airplane3.Left += 2;
            }
            else if(airplane3.Location.X == 320)
            {
                airplane3.Visible = false;

                //reset planes to starting directions (a1-up, a2-up, a3-up)
                if (flippedA1C3)
                {
                    airplane1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    flippedA1C3 = false;
                }

                if (flippedA2C3_1 || flippedA2C3_2)
                {
                    airplane2.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    flippedA2C3_1 = false;
                    flippedA2C3_2 = false;
                }

                if (flippedA3C3)
                {
                    airplane3.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    flippedA3C3 = false;
                }

                t_case3.Dispose();
            }
        }

        //Case 4 global variables
        Timer t_case4 = new Timer();
        Boolean flippedA1C4 = false;
        Boolean flippedA2C4 = false;
        Boolean flippedA3C4 = false;
        Boolean changedCountA1C4 = false;
        Boolean changedCountA2C4 = false;
        Boolean changedCountA3C4 = false;
        Boolean needsUpdatingC4 = true;
        int countC4 = 0;

        //Case 4: Collision between two airplanes
        private void Case4Button_Click(object sender, EventArgs e)
        {
            t_case4.Interval = 100; //millisecond
            t_case4.Tick += new EventHandler(this.case4_Tick);
            t_case4.Start();

            //reset airplane information
            needsUpdatingC1 = true;
            changedCountA1C4 = false;
            changedCountA2C4 = false;
            changedCountA3C4 = false;
            countC1 = 0;
            infoFlight.Text = "AA263";
            infoDestination.Text = "MSP";
            infoStatus.Text = "A";
            infoAltitude.Text = "2000";
            infoSpeed.Text = "75";
            infoHeading.Text = "0";

            //reset positions of airplanes
            airplane1.Location = new Point(330, 275);
            airplane1.Visible = true;
            airplane1.Image = Properties.Resources.airplaneGreen;

            airplane2.Location = new Point(110, 30);
            airplane2.Visible = true;
            airplane2.Image = Properties.Resources.airplaneWhite;
            airplane2.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);

            airplane3.Location = new Point(110, 210);
            airplane3.Visible = true;
            airplane3.Image = Properties.Resources.airplaneGreen;
        }

        private void case4_Tick(object sender, EventArgs e)
        {
            t_case4.Dispose();
        }

        //Show or hide topographic map
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
