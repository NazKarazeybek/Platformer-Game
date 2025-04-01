using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer_Game
{
    public partial class Form1 : Form
    {
        //setting variables
        bool isJumping = false;
        List<Coin> cList = new List<Coin>(); //list to hold all coins

        int score; //tracking score
        public Form1()
        {
            InitializeComponent();
        }

        //reasoning for timers is because the movement would be worse
        private void gravityTimer_Tick(object sender, EventArgs e)
        {
            // Prevent the hero from going below the ground level (or off the bottom of the screen)
            if (!hero.Bounds.IntersectsWith(groundPictureBox.Bounds) && !isJumping)
            {
                // Check if the hero is still within the bottom boundary of the screen
                if (hero.Bottom < this.ClientSize.Height) 
                {
                    hero.Top += 10; //move hero down
                }
                else
                {
                    hero.Top = this.ClientSize.Height - hero.Height; // Keep hero within screen
                }
            }
        }

        private void upTimer_Tick(object sender, EventArgs e)
        {
            // Prevent the hero from going off the top of the screen
            if (hero.Top > 0)
            {
                hero.Top -= 10; //move hero up
                isJumping = true;
            }
        }

        private void rightTimer_Tick(object sender, EventArgs e)
        {
            // Prevent the hero from going off the right side of the screen
            if (hero.Right < this.ClientSize.Width)
            {
                hero.Left += 10;
            }
        }

        private void leftTimer_Tick(object sender, EventArgs e)
        {
            // Prevent the hero from going off the left side of the screen
            if (hero.Left > 0)
            {
                hero.Left -= 10;
            }
        }

        private void PlatformerGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                upTimer.Start();
            }
            else if (e.KeyCode == Keys.Right)
            {
                rightTimer.Start();
            }
            else if (e.KeyCode == Keys.Left)
            {
                leftTimer.Start();
            }

        }

        private void PlatformerGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                upTimer.Stop();
                isJumping = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                rightTimer.Stop();
            }
            else if (e.KeyCode == Keys.Left)
            {
                leftTimer.Stop();
            }
        }

        private void PlatformerGame_Load(object sender, EventArgs e)
        {
            Coin c1 = new Coin();
            c1.drawTo(this);
            //look through it
            cList.Add(c1);
            c1.setPos(100, 200);

            Coin c2 = new Coin();
            c2.drawTo(this);
            //look through it
            cList.Add(c2);
            c1.setPos(200, 100);

            Coin c3 = new Coin();
            c3.drawTo(this);
            //look through it
            cList.Add(c3);
            c3.setPos(110, 70);

            Coin c4 = new Coin();
            c4.drawTo(this);
            //look through it
            cList.Add(c4);
            c4.setPos(150, 30);

            Coin c5 = new Coin();
            c5.drawTo(this);
            //look through it
            cList.Add(c5);
            c5.setPos(60, 190);

            Coin c6 = new Coin();
            c6.drawTo(this);
            cList.Add(c6);
            c6.setPos(60, 31);

            Coin c7 = new Coin();
            c7.drawTo(this);
            cList.Add(c7);
            c7.setPos(320, 280);

            Coin c8 = new Coin();
            c8.drawTo(this);
            cList.Add(c8);
            c8.setPos(410, 310);

            Coin c9 = new Coin();
            c9.drawTo(this);
            cList.Add(c9);
            c9.setPos(340, 270);

            Coin c10 = new Coin();
            c10.drawTo(this);
            cList.Add(c10);
            c10.setPos(300, 60);

            Coin c11 = new Coin();
            c11.drawTo(this);
            cList.Add(c11);
            c11.setPos(10, 290);

            Coin c12 = new Coin();
            c12.drawTo(this);
            cList.Add(c12);
            c12.setPos(180, 266);

            Coin c13 = new Coin();
            c13.drawTo(this);
            cList.Add(c13);
            c13.setPos(210, 950);

            Coin c14 = new Coin();
            c14.drawTo(this);
            cList.Add(c14);
            c14.setPos(160, 220);

            Coin c15 = new Coin();
            c15.drawTo(this);
            cList.Add(c15);
            c15.setPos(220, 56);

            Coin c16 = new Coin();
            c16.drawTo(this);
            cList.Add(c16);
            c16.setPos(225, 162);

            Coin c17 = new Coin();
            c17.drawTo(this);
            cList.Add(c17);
            c17.setPos(345, 137);

            Coin c18 = new Coin();
            c18.drawTo(this);
            cList.Add(c18);
            c18.setPos(421, 213);

            Coin c19 = new Coin();
            c19.drawTo(this);
            cList.Add(c19);
            c19.setPos(312, 169);

            Coin c20 = new Coin();
            c20.drawTo(this);
            cList.Add(c20);
            c20.setPos(44, 412);

            Coin c21 = new Coin();
            c21.drawTo(this);
            cList.Add(c21);
            c21.setPos(261, 158);

            Coin c22 = new Coin();
            c22.drawTo(this);
            cList.Add(c22);
            c22.setPos(168, 212);

            Coin c23 = new Coin();
            c23.drawTo(this);
            cList.Add(c23);
            c23.setPos(281, 281);

            Coin c24 = new Coin();
            c24.drawTo(this);
            cList.Add(c24);
            c24.setPos(2450, 139);

            Coin c25 = new Coin();
            c25.drawTo(this);
            cList.Add(c25);
            c25.setPos(329, 183);

        }

        private void gameLoopTimer_Tick(object sender, EventArgs e)
        {
           //(Look through c list
           foreach(Coin c in cList)
            {
                if (hero.Bounds.IntersectsWith(c.getBounds()))
                {
                    c.setPos(1001, 1001);
                    score++;
                    scoreLabel.Text = "Score: " + score;
                }
            }
        }
    }
}
