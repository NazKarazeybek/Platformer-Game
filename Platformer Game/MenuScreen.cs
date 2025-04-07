using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Platformer_Game
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //stop menu sound
            SoundPlayer menuSound = new SoundPlayer(Properties.Resources.menuScreenSound);
            menuSound.Stop();

            //click sound when clicked play
            SoundPlayer playSound = new SoundPlayer(Properties.Resources.clickSound);
            playSound.Play();

            //move to the game
            Form1.ChangeScreen(this, new GameScreen());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //playing sound
            SoundPlayer playSound = new SoundPlayer(Properties.Resources.clickSound);
            playSound.Play();
            
            //close game
            Application.Exit();
        }
    }
}
