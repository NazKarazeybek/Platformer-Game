using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Platformer_Game
{
    class Coin
    {
        private PictureBox coinPictureBox;
        private bool collected;

        public Coin()
        {
            collected = false;
            coinPictureBox = new PictureBox
            {
                Width = 10,
                Height = 10,
                BackColor = Color.Gold,
                Tag = "coin"
            };
        }

        // Adds the coin's PictureBox to the parent control (like the game screen)
        public void DrawTo(Control parent)
        {
            parent.Controls.Add(coinPictureBox);
        }

        // Sets the coin's screen position
        public void SetPosition(int x, int y)
        {
            coinPictureBox.Location = new Point(x, y);
        }

        // Returns the bounding box of the coin (for collision detection)
        public Rectangle GetBounds()
        {
            return coinPictureBox.Bounds;
        }

        // Marks the coin as collected and hides it from the screen
        public void Hide()
        {
            coinPictureBox.Visible = false;
            collected = true;
        }

        // Returns whether this coin has already been collected
        public bool IsCollected()
        {
            return collected;
        }

        // Checks if the coin is colliding with another rectangle (e.g., the hero/player)
        public bool CheckCollision(Rectangle other)
        {
            return !collected && coinPictureBox.Bounds.IntersectsWith(other);
        }
        public static void CreateCoins(GameScreen screen, List<Coin> coinList)
        {
            List<Point> positions = new List<Point>
    {
        new Point(50, 150),
        new Point(90, 90),
        new Point(20, 220),
        new Point(75, 205),
        new Point(110, 280),
        new Point(260, 260),
        new Point(190, 240),
        new Point(140, 150),
        new Point(220, 180),
        new Point(20, 50),
        new Point(160, 90),
        new Point(400, 40),
        new Point(430, 110),
        new Point(360, 90),
        new Point(300, 65),
        new Point(260, 120),
        new Point(230, 35),
        new Point(295, 190),
        new Point(345, 150),
        new Point(405, 185),
        new Point(365, 225),
        new Point(400, 300),
        new Point(320, 290),
        new Point(40, 300),
        new Point(130, 40)
    };

            foreach (Point pos in positions)
            {
                Coin coin = new Coin();
                coin.DrawTo(screen); // Attach to GameScreen
                coin.SetPosition(pos.X, pos.Y);
                coinList.Add(coin);
            }
        }

    }
}