/*
                                   /$$$$$$$$                         /$$       /$$          
                                  |_____ $$                         | $$      |__/          
                                       /$$/   /$$$$$$  /$$$$$$/$$$$ | $$$$$$$  /$$  /$$$$$$ 
                                      /$$/   /$$__  $$| $$_  $$_  $$| $$__  $$| $$ /$$__  $$
                                     /$$/   | $$  \ $$| $$ \ $$ \ $$| $$  \ $$| $$| $$$$$$$$
                                    /$$/    | $$  | $$| $$ | $$ | $$| $$  | $$| $$| $$_____/
                                   /$$$$$$$$|  $$$$$$/| $$ | $$ | $$| $$$$$$$/| $$|  $$$$$$$
                                  |________/ \______/ |__/ |__/ |__/|_______/ |__/ \_______/
                                                                                                    
                                                            /$$$$$$  /$$                                
                                                           /$$__  $$| $$                                
                                                          | $$  \__/| $$  /$$$$$$   /$$$$$$$ /$$$$$$$   
                                                          | $$      | $$ |____  $$ /$$_____//$$_____/   
                                                          | $$      | $$  /$$$$$$$|  $$$$$$|  $$$$$$    
                                                          | $$    $$| $$ /$$__  $$ \____  $$\____  $$   
                                                          |  $$$$$$/| $$|  $$$$$$$ /$$$$$$$//$$$$$$$/   
                                                           \______/ |__/ \_______/|_______/|_______/    

                                        Survival Z Mini Game 1.0 
                                                                 Developed by: https://github.com/eksqtr
 
 
 */
 #define DEBUG_PRINT

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shooting_Games.Classes;

namespace Shooting_Games.Classes
{
    class Zombie
    {
        private PictureBox ZombieControl;
        private ProgressBar ZombieHPBar;
        private Label ZombieText;
        private Rectangle ZombieBound = new Rectangle();
        

        public double ZombieHealth { get; set; }
        public double ZombieVelocity { get; set; }
        private int ZombieFacingDirection { get; set; }
        public int ZombieAttackDirection { get; set; }

        public bool IsZombieAttackingCharacter { get; set; } = false;



        public Zombie(double health = 100.0, double velocity = 100, double speed = 0.020)
        {
            this.ZombieHealth = health;
            this.ZombieVelocity = velocity * speed;
            this.ZombieFacingDirection = -1;
            this.ZombieAttackDirection = -1;

            this.ZombieControl = new PictureBox();
            this.ZombieControl.Image = Properties.Resources.zombie_move_down;
            this.ZombieControl.Height = 100;
            this.ZombieControl.Width = 100;

            this.ZombieText = new Label();
            this.ZombieText.Text = "";
            this.ZombieText.ForeColor = Color.OrangeRed;
            this.ZombieText.AutoSize = true;
            this.ZombieText.BackColor = Color.Gainsboro;

            this.ZombieHPBar = new ProgressBar();
            this.ZombieHPBar.Height = 10;
            this.ZombieHPBar.Width = 75;
            this.ZombieHPBar.Maximum = (int)health;
            this.ZombieHPBar.Value = (int)health;
            this.ZombieBound = new Rectangle(ZombieControl.Left, ZombieControl.Top, ZombieControl.Width, ZombieControl.Height);
            

        }
        public Label GetZombieTextControl()
        {
            return this.ZombieText;
        }
        private void UpdateZombieFacingAngle(PictureBox zombie, int direction)
        {
            switch (direction)
            {
                case Global.FACING_DIRECTION_UP: // up
                    zombie.Image = Properties.Resources.zombie_move_up;
                    this.ZombieFacingDirection = Global.FACING_DIRECTION_UP;
                    break;

                case Global.FACING_DIRECTION_DOWN: // down
                    zombie.Image = Properties.Resources.zombie_move_down;
                    this.ZombieFacingDirection = Global.FACING_DIRECTION_DOWN;
                    break;

                case Global.FACING_DIRECTION_RIGHT: // right
                    zombie.Image = Properties.Resources.zombie_move_right;
                    this.ZombieFacingDirection = Global.FACING_DIRECTION_RIGHT;
                    break;

                case Global.FACING_DIRECTION_LEFT: // left
                    zombie.Image = Properties.Resources.zombie_move_left;
                    this.ZombieFacingDirection = Global.FACING_DIRECTION_LEFT;
                    break;
            }
        }

        private void UpdateZombieAttackAngle(PictureBox zombie, int direction)
        {
            switch (direction)
            {
                case Global.FACING_DIRECTION_UP: // up
                    zombie.Image = Properties.Resources.zmbie_attack_up;
                    this.ZombieFacingDirection = Global.FACING_DIRECTION_UP;
                    this.IsZombieAttackingCharacter = true;
                    this.ZombieAttackDirection = -1;
                    break;

                case Global.FACING_DIRECTION_DOWN: // down
                    zombie.Image = Properties.Resources.zombie_attack_down;
                    ZombieFacingDirection = Global.FACING_DIRECTION_DOWN;
                    this.IsZombieAttackingCharacter = true;
                    this.ZombieAttackDirection = -1;
                    
                    break;

                case Global.FACING_DIRECTION_RIGHT: // right
                    zombie.Image = Properties.Resources.zombie_attack_right;
                    ZombieFacingDirection = Global.FACING_DIRECTION_RIGHT;
                    this.IsZombieAttackingCharacter = true;
                    this.ZombieAttackDirection = -1;
                    break;

                case Global.FACING_DIRECTION_LEFT: // left
                    zombie.Image = Properties.Resources.zombie_attack_left;
                    ZombieFacingDirection = Global.FACING_DIRECTION_LEFT;
                    this.IsZombieAttackingCharacter = true;
                    this.ZombieAttackDirection = -1;
                    break;
                default:
                    this.IsZombieAttackingCharacter = false;
                    break;
            }
        }
        public void ZombieChase(Control zombie, Control character)
        {
            double velocity = this.ZombieVelocity;

            double[] zomPosition = new double[2]; // X and Y
            zomPosition[0] = zombie.Location.X;
            zomPosition[1] = zombie.Location.Y;

            double[] charPosition = new double[2]; // X and Y
            charPosition[0] = character.Location.X;
            charPosition[1] = character.Location.Y;

            Rectangle charBounds = new Rectangle(character.Left, character.Top, character.Width, character.Height);
            Rectangle zomBounds = new Rectangle(zombie.Left, zombie.Top, zombie.Width, zombie.Height);

            if (!zomBounds.IntersectsWith(charBounds))
            {
                this.IsZombieAttackingCharacter = false;
                if (zomPosition[0] > charPosition[0])
                {
                    zomPosition[0] -= velocity; // move left
                    this.ZombieAttackDirection = Global.FACING_DIRECTION_LEFT;
                    
                }
                else if (zomPosition[0] < charPosition[0])
                {
                    zomPosition[0] += velocity; // move right
                    this.ZombieAttackDirection = Global.FACING_DIRECTION_RIGHT;
                }

                if (zomPosition[1] > charPosition[1])
                {
                    zomPosition[1] -= velocity; // move up
                    if (this.ZombieFacingDirection != Global.FACING_DIRECTION_UP) UpdateZombieFacingAngle((PictureBox)zombie, Global.FACING_DIRECTION_UP);
                    this.ZombieAttackDirection = Global.FACING_DIRECTION_UP;
                }
                else if (zomPosition[1] < charPosition[1])
                {
                    zomPosition[1] += velocity; // move down
                    if (this.ZombieFacingDirection != Global.FACING_DIRECTION_DOWN) UpdateZombieFacingAngle((PictureBox)zombie, Global.FACING_DIRECTION_DOWN);
                    this.ZombieAttackDirection = Global.FACING_DIRECTION_DOWN;
                }
                if (this.ZombieAttackDirection == Global.FACING_DIRECTION_LEFT) if (this.ZombieFacingDirection != Global.FACING_DIRECTION_LEFT) UpdateZombieFacingAngle((PictureBox)zombie, Global.FACING_DIRECTION_LEFT);
                if (this.ZombieAttackDirection == Global.FACING_DIRECTION_RIGHT) if (this.ZombieFacingDirection != Global.FACING_DIRECTION_RIGHT) UpdateZombieFacingAngle((PictureBox)zombie, Global.FACING_DIRECTION_RIGHT);

            }
            
            else
            {
                zomPosition[0] = zomPosition[0];
                zomPosition[1] = zomPosition[1];
                UpdateZombieAttackAngle((PictureBox)zombie, this.ZombieAttackDirection);
            }
            zombie.Location = new Point((int)zomPosition[0], (int)zomPosition[1]);
            this.ZombieHPBar.Location = new Point(zombie.Location.X + 15, zombie.Location.Y + 100);
        }

        public Rectangle GetZombieBound()
        {
            ZombieBound = new Rectangle(ZombieControl.Left, ZombieControl.Top, ZombieControl.Width, ZombieControl.Height);
            return this.ZombieBound;
        }

        public PictureBox GetZombieControl()
        {
            return this.ZombieControl;
        }

        public ProgressBar GetZombieHPBar()
        {
            return this.ZombieHPBar;
        }

    }
}
