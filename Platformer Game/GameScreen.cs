using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer_Game
{
    public partial class GameScreen : UserControl
    {
        //control variables
        bool wPressed = false;
        bool aPressed = false;
        bool sPressed = false;
        bool dPressed = false;

        //hero speed
        int heroSpeed = 10;

        List<Coin> cList = new List<Coin>(); //list to hold all coins

        int score; //tracking score
        public GameScreen()
        {
            InitializeComponent();
            CreateCoins();
        }

        //reasoning for timers is because the movement would be worse
        private void gravityTimer_Tick(object sender, EventArgs e)
        {
            //Prevent the hero from going below the screen
            if (!hero.Bounds.IntersectsWith(groundPictureBox.Bounds) && !wPressed)
            {
                //Check if the hero is still within the bottom boundary of the screen
                if (hero.Bottom < this.ClientSize.Height)
                {
                    hero.Top += 10; //move hero down
                }
                else
                {
                    hero.Top = this.ClientSize.Height - hero.Height; //keep hero within screen
                }
            }
        }


        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = true;
                    break;
                case Keys.A:
                    aPressed = true;
                    break;
                case Keys.S:
                    sPressed = true;
                    break;
                case Keys.D:
                    dPressed = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = false;
                    break;
                case Keys.A:
                    aPressed = false;
                    break;
                case Keys.S:
                    sPressed = false;
                    break;
                case Keys.D:
                    dPressed = false;
                    break;
            }
        }

        public void CreateCoins()
        {
            Coin c1 = new Coin();
            c1.drawTo(this);
            cList.Add(c1);
            c1.setPos(100, 200);

            Coin c2 = new Coin();
            c2.drawTo(this);
            cList.Add(c2);
            c2.setPos(200, 100);

            Coin c3 = new Coin();
            c3.drawTo(this);
            cList.Add(c3);
            c3.setPos(110, 70);

            Coin c4 = new Coin();
            c4.drawTo(this);
            cList.Add(c4);
            c4.setPos(150, 30);

            Coin c5 = new Coin();
            c5.drawTo(this);
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

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //move hero
            if (wPressed == true)
            {
                hero.Top = hero.Top - heroSpeed;
            }
            if (sPressed == true)
            {
                hero.Top = hero.Top + heroSpeed;
            }
            if (dPressed == true)
            {
                hero.Left = hero.Left + heroSpeed;
            }
            if (aPressed == true)
            {
                hero.Left = hero.Left - heroSpeed;
            }


        }
    }
}



