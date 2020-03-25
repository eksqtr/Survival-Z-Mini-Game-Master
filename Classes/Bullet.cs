/*
                                 /$$$$$$$            /$$ /$$             /$$                       
                                | $$__  $$          | $$| $$            | $$                       
                                | $$  \ $$ /$$   /$$| $$| $$  /$$$$$$  /$$$$$$                     
                                | $$$$$$$ | $$  | $$| $$| $$ /$$__  $$|_  $$_/                     
                                | $$__  $$| $$  | $$| $$| $$| $$$$$$$$  | $$                       
                                | $$  \ $$| $$  | $$| $$| $$| $$_____/  | $$ /$$                   
                                | $$$$$$$/|  $$$$$$/| $$| $$|  $$$$$$$  |  $$$$/                   
                                |_______/  \______/ |__/|__/ \_______/   \___/                     
                                                                   
                                                          /$$$$$$  /$$                             
                                                         /$$__  $$| $$                             
                                                        | $$  \__/| $$  /$$$$$$   /$$$$$$$ /$$$$$$$
                                                        | $$      | $$ |____  $$ /$$_____//$$_____/
                                                        | $$      | $$  /$$$$$$$|  $$$$$$|  $$$$$$ 
                                                        | $$    $$| $$ /$$__  $$ \____  $$\____  $$
                                                        |  $$$$$$/| $$|  $$$$$$$ /$$$$$$$//$$$$$$$/
                                                         \______/ |__/ \_______/|_______/|_______/
                                                Surval Z 1.0
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
    class Bullet
    {
        // Declaring variables for this Bullet Class.
        private PictureBox BulletControl;
        private Rectangle BulletBound;
        public double BulletSpeed { get; set; }
        public double BulletDamage { get; set; }
        public int BulletDirection { get; set; }

        public Bullet()
        {
            // Initialize the bullet properties.
            this.BulletControl = new PictureBox();
            this.BulletControl.Width = 15;
            this.BulletControl.Height = 15;
            this.BulletControl.Image = Properties.Resources.fire_bullet_15px;
            this.BulletControl.BackColor = Color.Transparent;
            this.BulletSpeed = 0.150;
        }

        public PictureBox GetBulletControl()
        {
            return this.BulletControl; // Get the bullet control 
        }

        public Rectangle GetBulletBound() 
        {
            // getting the current bullet bounds. 
            this.BulletBound = new Rectangle(this.BulletControl.Left, this.BulletControl.Top, this.BulletControl.Width, this.BulletControl.Height);
            return this.BulletBound;
        }



        public void SetBulletPos(Control character)
        {
            // Set the bullet position depending on the character rotation.
            switch (this.BulletDirection)
            {
                case Global.FACING_DIRECTION_UP: // Facing Up
                    this.BulletControl.Location = new Point(character.Location.X + 60, character.Location.Y);
                    break;
                case Global.FACING_DIRECTION_DOWN: // Facing down
                    this.BulletControl.Location = new Point(character.Location.X + 20, character.Location.Y + 95);
                    break;
                case Global.FACING_DIRECTION_RIGHT: // Facing right
                    this.BulletControl.Location = new Point(character.Location.X + 90, character.Location.Y + 60);
                    break;
                case Global.FACING_DIRECTION_LEFT: // Facing Left
                    this.BulletControl.Location = new Point(character.Location.X, character.Location.Y + 15);
                    break;
                case Global.FACING_DIRECTION_UPLEFT: // Facing Up Left
                    this.BulletControl.Location = new Point(character.Location.X + 10, character.Location.Y - 15);
                    break;
                case Global.FACING_DIRECTION_UPRIGHT: // Facing Up Right
                    this.BulletControl.Location = new Point(character.Location.X + 90, character.Location.Y + 20);
                    break;
                case Global.FACING_DIRECTION_DOWNLEFT: // Facing Down Left
                    this.BulletControl.Location = new Point(character.Location.X, character.Location.Y + 65);
                    break;
                case Global.FACING_DIRECTION_DOWNRIGHT: // Facing Down Right
                    this.BulletControl.Location = new Point(character.Location.X + 60, character.Location.Y + 75);
                    break;
            }

        }

         /* Bullets Projectile */
        public void ShootBullet()
        {
            double[] charPosition = new double[2]; // Declare Character Position Array for storing x and y
            double velocity = 100; // Set the velocity.
            switch (this.BulletDirection)
            {
                case Global.FACING_DIRECTION_UP: // up

                    // Character position in which where the bullet created.
                    charPosition[0] = this.BulletControl.Location.X; // X
                    charPosition[1] = this.BulletControl.Location.Y; // Y
                    velocity = velocity * this.BulletSpeed; // Velocity pixel * speed per miliseconds
                    charPosition[1] -= velocity + 1; // Set the position by deducting the current position to its velocity.
                    this.BulletControl.Location = new Point((int)charPosition[0], (int)charPosition[1]);
                    break;

                case Global.FACING_DIRECTION_DOWN: // down

                    // Same as the above ^
                    charPosition[0] = this.BulletControl.Location.X;
                    charPosition[1] = this.BulletControl.Location.Y;
                    velocity = velocity * this.BulletSpeed;
                    charPosition[1] += velocity + 1;
                    this.BulletControl.Location = new Point((int)charPosition[0], (int)charPosition[1]);
                    break;

                case Global.FACING_DIRECTION_RIGHT: // right

                    // Same as the above ^
                    charPosition[0] = this.BulletControl.Location.X;
                    charPosition[1] = this.BulletControl.Location.Y;
                    velocity = velocity * this.BulletSpeed;
                    charPosition[0] += velocity + 1;
                    this.BulletControl.Location = new Point((int)charPosition[0], (int)charPosition[1]);
                    break;

                case Global.FACING_DIRECTION_LEFT: // left

                    // Same as the above ^
                    charPosition[0] = this.BulletControl.Location.X;
                    charPosition[1] = this.BulletControl.Location.Y;
                    velocity = velocity * this.BulletSpeed;
                    charPosition[0] -= velocity + 1;
                    this.BulletControl.Location = new Point((int)charPosition[0], (int)charPosition[1]);
                    break;

                case Global.FACING_DIRECTION_UPLEFT: // up + left

                    // Same as the above ^
                    charPosition[0] = this.BulletControl.Location.X;
                    charPosition[1] = this.BulletControl.Location.Y;
                    velocity = velocity * this.BulletSpeed - 0.080;
                    charPosition[0] -= velocity;
                    charPosition[1] -= velocity;
                    this.BulletControl.Location = new Point((int)charPosition[0], (int)charPosition[1]);
                    break;
                case Global.FACING_DIRECTION_UPRIGHT: // up + right

                    // Same as the above ^
                    charPosition[0] = this.BulletControl.Location.X;
                    charPosition[1] = this.BulletControl.Location.Y;
                    velocity = velocity * this.BulletSpeed - 0.080;
                    charPosition[0] += velocity;
                    charPosition[1] -= velocity;
                    this.BulletControl.Location = new Point((int)charPosition[0], (int)charPosition[1]);
                    break;
                case Global.FACING_DIRECTION_DOWNLEFT: // down + left

                    // Same as the above ^
                    charPosition[0] = this.BulletControl.Location.X;
                    charPosition[1] = this.BulletControl.Location.Y;
                    velocity = velocity * this.BulletSpeed - 0.080;
                    charPosition[0] -= velocity;
                    charPosition[1] += velocity;
                    this.BulletControl.Location = new Point((int)charPosition[0], (int)charPosition[1]);
                    break;
                case Global.FACING_DIRECTION_DOWNRIGHT: // down + right

                    // Same as the above ^
                    charPosition[0] = this.BulletControl.Location.X;
                    charPosition[1] = this.BulletControl.Location.Y;
                    velocity = velocity * this.BulletSpeed - 0.080;
                    charPosition[0] += velocity;
                    charPosition[1] += velocity;
                    this.BulletControl.Location = new Point((int)charPosition[0], (int)charPosition[1]);
                    break;

            }
        }

    }
}
