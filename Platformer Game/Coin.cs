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
        private PictureBox coinPictureBox = new PictureBox();
        public Coin()
        {
            coinPictureBox.Width = 10;
            coinPictureBox.Height = 10;
            coinPictureBox.BackColor = Color.Gold;
        }

        public void drawTo(Form F)
        {
            F.Controls.Add(coinPictureBox);
        }

        public Rectangle getBounds()
        {
            return coinPictureBox.Bounds;
        }

        public void setPos(int x, int y)
        {
            coinPictureBox.Location = new Point(x, y);
        }
    }
}
