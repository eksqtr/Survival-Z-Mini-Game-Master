/*
  /$$$$$$                                 /$$                     /$$       /$$$$$$$$      
 /$$__  $$                               |__/                    | $$      |_____ $$       
| $$  \__/ /$$   /$$  /$$$$$$  /$$    /$$ /$$ /$$    /$$ /$$$$$$ | $$           /$$/       
|  $$$$$$ | $$  | $$ /$$__  $$|  $$  /$$/| $$|  $$  /$$/|____  $$| $$          /$$/        
 \____  $$| $$  | $$| $$  \__/ \  $$/$$/ | $$ \  $$/$$/  /$$$$$$$| $$         /$$/         
 /$$  \ $$| $$  | $$| $$        \  $$$/  | $$  \  $$$/  /$$__  $$| $$        /$$/          
|  $$$$$$/|  $$$$$$/| $$         \  $/   | $$   \  $/  |  $$$$$$$| $$       /$$$$$$$$      
 \______/  \______/ |__/          \_/    |__/    \_/    \_______/|__/      |________/ 

 /$$      /$$                                     /$$$$$$$$                               
| $$$    /$$$                                    | $$_____/                               
| $$$$  /$$$$  /$$$$$$  /$$$$$$$  /$$   /$$      | $$     /$$$$$$   /$$$$$$  /$$$$$$/$$$$ 
| $$ $$/$$ $$ /$$__  $$| $$__  $$| $$  | $$      | $$$$$ /$$__  $$ /$$__  $$| $$_  $$_  $$
| $$  $$$| $$| $$$$$$$$| $$  \ $$| $$  | $$      | $$__/| $$  \ $$| $$  \__/| $$ \ $$ \ $$
| $$\  $ | $$| $$_____/| $$  | $$| $$  | $$      | $$   | $$  | $$| $$      | $$ | $$ | $$
| $$ \/  | $$|  $$$$$$$| $$  | $$|  $$$$$$/      | $$   |  $$$$$$/| $$      | $$ | $$ | $$
|__/     |__/ \_______/|__/  |__/ \______/       |__/    \______/ |__/      |__/ |__/ |__/
                                                                                          
                                                                                          
                             Survival Z Mini Game 1.0 
                                                        Developed by: https://github.com/eksqtr
*/
using NAudio.Wave;
using Shooting_Games.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shooting_Games
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private int[] imgSize = new int[2];
        private int[] imgPos = new int[2];
   
        private SoundPlayer welcomeFX = new SoundPlayer(Properties.Resources.welcome_to_survival_z_scary);

        private void frmMenu_Load(object sender, EventArgs e)
        {
            welcomeFX = new SoundPlayer(Properties.Resources.welcome_to_survival_z_scary);
            if (SoundFX.BackgroundAudio != null) SoundFX.BackgroundAudio = null;
            SoundFX.BackgroundAudio = new WaveOutEvent();
            SoundFX.onGameAudio = new AudioFileReader(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\audio\\menu_soundtrack.wav");
            SoundFX.BackgroundAudio.Init(SoundFX.onGameAudio);
            SoundFX.BackgroundAudio.PlaybackStopped += OnBackgroundPlayBackStopped;
            SoundFX.BackgroundAudio.Play();
            welcomeFX.Play();
        }
        private void bttnPlay_Click(object sender, EventArgs e)
        {
            welcomeFX = new SoundPlayer();
            SoundFX.BackgroundAudio.Stop();
            SoundFX.BackgroundAudio.Dispose();
            frmGame gameForm = new frmGame();
            gameForm.Show();
            this.Hide();
        }
        private void OnBackgroundPlayBackStopped(object sender, StoppedEventArgs args)
        {
            if (SoundFX.BackgroundAudio != null)
            {
                SoundFX.onGameAudio.Position = 0;
                SoundFX.BackgroundAudio.Play();
                //welcomeFX.Play();
            }
            
        }
        private void bttnShop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not yet available in this version.", "Feature not yet implemented", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void bttnCredits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not yet available in this version.", "Feature not yet implemented", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void imageOne_Click(object sender, EventArgs e)
        {
            if(imageOne.Width != this.ClientSize.Width)
            {
                imgSize[0] = imageOne.Width;
                imgSize[1] = imageOne.Height;
                imgPos[0] = imageOne.Location.X;
                imgPos[1] = imageOne.Location.Y;

                imageOne.BackgroundImageLayout = ImageLayout.Stretch;
                imageOne.Height = this.ClientSize.Height;
                imageOne.Width = this.ClientSize.Width;
                imageOne.BackgroundImage = Properties.Resources.mainmenu_image_one;
                imageOne.Dock = DockStyle.Fill;
                imageOne.BringToFront();
            }
            else
            {
                imageOne.Dock = DockStyle.None;
                imageOne.BackgroundImageLayout = ImageLayout.Stretch;
                imageOne.Height = imgSize[1];
                imageOne.Width = imgSize[0];
                imageOne.Location = new Point(imgPos[0], imgPos[1]);
                imageOne.BackgroundImage = null;
            }
        }

        private void imageTwo_Click(object sender, EventArgs e)
        {
            if (imageTwo.Width != this.ClientSize.Width)
            {
                imgSize[0] = imageTwo.Width;
                imgSize[1] = imageTwo.Height;
                imgPos[0] = imageTwo.Location.X;
                imgPos[1] = imageTwo.Location.Y;

                imageTwo.BackgroundImageLayout = ImageLayout.Stretch;
                imageTwo.Height = this.ClientSize.Height;
                imageTwo.Width = this.ClientSize.Width;
                imageTwo.BackgroundImage = Properties.Resources.mainmenu_image_two;
                imageTwo.Dock = DockStyle.Fill;
                imageTwo.BringToFront();
            }
            else
            {
                imageTwo.Dock = DockStyle.None;
                imageTwo.BackgroundImageLayout = ImageLayout.Stretch;
                imageTwo.Height = imgSize[1];
                imageTwo.Width = imgSize[0];
                imageTwo.Location = new Point(imgPos[0], imgPos[1]);
                imageTwo.BackgroundImage = null;
            }

        }

        private void imageThree_Click(object sender, EventArgs e)
        {
            if (imageThree.Width != this.ClientSize.Width)
            {
                imgSize[0] = imageThree.Width;
                imgSize[1] = imageThree.Height;
                imgPos[0] = imageThree.Location.X;
                imgPos[1] = imageThree.Location.Y;

                imageThree.BackgroundImageLayout = ImageLayout.Stretch;
                imageThree.Height = this.ClientSize.Height;
                imageThree.Width = this.ClientSize.Width;
                imageThree.BackgroundImage = Properties.Resources.mainmenu_image_three;
                imageThree.Dock = DockStyle.Fill;
                imageThree.BringToFront();
            }
            else
            {
                imageThree.Dock = DockStyle.None;
                imageThree.BackgroundImageLayout = ImageLayout.Stretch;
                imageThree.Height = imgSize[1];
                imageThree.Width = imgSize[0];
                imageThree.Location = new Point(imgPos[0], imgPos[1]);
                imageThree.BackgroundImage = null;
            }
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
