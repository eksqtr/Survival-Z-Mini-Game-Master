/* 
  /$$$$$$            /$$                            /$$$$$$  /$$                             
 /$$__  $$          |__/                           /$$__  $$| $$                             
| $$  \__/  /$$$$$$  /$$ /$$$$$$$   /$$$$$$$      | $$  \__/| $$  /$$$$$$   /$$$$$$$ /$$$$$$$
| $$       /$$__  $$| $$| $$__  $$ /$$_____/      | $$      | $$ |____  $$ /$$_____//$$_____/
| $$      | $$  \ $$| $$| $$  \ $$|  $$$$$$       | $$      | $$  /$$$$$$$|  $$$$$$|  $$$$$$ 
| $$    $$| $$  | $$| $$| $$  | $$ \____  $$      | $$    $$| $$ /$$__  $$ \____  $$\____  $$
|  $$$$$$/|  $$$$$$/| $$| $$  | $$ /$$$$$$$/      |  $$$$$$/| $$|  $$$$$$$ /$$$$$$$//$$$$$$$/
 \______/  \______/ |__/|__/  |__/|_______/        \______/ |__/ \_______/|_______/|_______/

                             Survival Z Mini Game 1.0 
                                                        Developed by: https://github.com/eksqtr
 */


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shooting_Games.Classes
{
    class Coins
    {
        private Panel CoinControl;
        private Rectangle CoinBound;
        private Label CoinText;
        public int CoinCountdown { get; set; }
        public int CoinAmount { get; set; }


        public Coins()
        {
            this.CoinControl = new Panel();
            this.CoinControl.BackgroundImage = Properties.Resources.cheap_2_30px;
            this.CoinControl.BackgroundImageLayout = ImageLayout.Stretch;
            this.CoinControl.BackColor = Color.Gainsboro;
            this.CoinControl.Width = 25;
            this.CoinControl.Height = 25;

            this.CoinText = new Label();
            this.CoinText.Text = "";
            this.CoinText.ForeColor = Color.OrangeRed;
            this.CoinText.AutoSize = true;
            this.CoinText.BackColor = Color.Gainsboro;

            this.CoinCountdown = 10; // 15 seconds
            this.CoinAmount = 2;
        }

        public Rectangle GetCoinBound()
        {
            this.CoinBound = new Rectangle(this.CoinControl.Left, this.CoinControl.Top, this.CoinControl.Width, this.CoinControl.Height);
            return this.CoinBound;
        }

        public Panel GetCoinControl()
        {
            return this.CoinControl;
        }

        public Label GetCoinTextControl()
        {
            return this.CoinText;
        }

    }
}
