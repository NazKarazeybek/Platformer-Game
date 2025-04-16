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
using System.Media;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Platformer_Game
{
    public partial class GameScreen : UserControl
    {
        //control variables
        bool wPressed = false;
        bool aPressed = false;
        bool dPressed = false;

        //hero speed
        int heroSpeed = 10;

        List<Coin> cList = new List<Coin>(); //list to hold all coins

        int score; //tracking score
        public GameScreen()
        {
            InitializeComponent();

            winLabel.Visible = false;

            //play gameScreen sound
            SoundPlayer gameSound = new SoundPlayer(Properties.Resources.gameScreenSound);
            gameSound.Play();
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
                case Keys.D:
                    dPressed = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //move hero
            if (wPressed == true)
            {
                hero.Top = hero.Top - heroSpeed;
            }
            if (dPressed == true)
            {
                hero.Left = hero.Left + heroSpeed;
            }
            if (aPressed == true)
            {
                hero.Left = hero.Left - heroSpeed;
            }

            //to not make hero go off the sceen
            hero.Left = Math.Max(0, Math.Min(this.ClientSize.Width - hero.Width, hero.Left));
            hero.Top = Math.Max(0, Math.Min(this.ClientSize.Height - hero.Height, hero.Top));

            CheckCoinCollisions();
            CheckForWin(); // Check if the player has collected all the coins and won
        }

        private void CheckCoinCollisions()
        {
            List<Coin> coinsToRemove = new List<Coin>();

            foreach (Coin coin in cList)
            {
                if (!coin.IsCollected() && coin.CheckCollision(hero.Bounds))
                {
                    coinsToRemove.Add(coin);
                    score++;
                    scoreLabel.Text = $"Score: {score}";
                    coin.Hide();
                }
            }

            foreach (Coin coin in coinsToRemove)
            {
                cList.Remove(coin);
            }
        }

        public void CheckForWin()
        {
            //check if won
            if (score == 25)
            {
                // Stop the gameScreen sound
                SoundPlayer gameSound = new SoundPlayer(Properties.Resources.gameScreenSound);
                gameSound.Stop();

                // Make winLabel visible
                winLabel.Visible = true;
                Refresh();

                // Pause for a moment
                Thread.Sleep(1000);
                Refresh();

                //stop all active timers before switching
                gameTimer.Stop();
                gravityTimer.Stop();

                // Change to GameOver screen
                Form1.ChangeScreen(this, new GameOver());
            }
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Coin.CreateCoins(this, cList); // this draws and places all the coins

        }
    }
}



