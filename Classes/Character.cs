/* 
                                      /$$$$$$  /$$                                                /$$                        
                                     /$$__  $$| $$                                               | $$                        
                                    | $$  \__/| $$$$$$$   /$$$$$$   /$$$$$$  /$$$$$$   /$$$$$$$ /$$$$$$    /$$$$$$   /$$$$$$ 
                                    | $$      | $$__  $$ |____  $$ /$$__  $$|____  $$ /$$_____/|_  $$_/   /$$__  $$ /$$__  $$
                                    | $$      | $$  \ $$  /$$$$$$$| $$  \__/ /$$$$$$$| $$        | $$    | $$$$$$$$| $$  \__/
                                    | $$    $$| $$  | $$ /$$__  $$| $$      /$$__  $$| $$        | $$ /$$| $$_____/| $$      
                                    |  $$$$$$/| $$  | $$|  $$$$$$$| $$     |  $$$$$$$|  $$$$$$$  |  $$$$/|  $$$$$$$| $$      
                                     \______/ |__/  |__/ \_______/|__/      \_______/ \_______/   \___/   \_______/|__/      
                                                                                                                           
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

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shooting_Games.Classes
{
    class Character: Keyboard // Character extends Keyboard (inheritance)
    {
        // Delcare variables for Character Class
        private PictureBox CharacterControl; // Picturebox representing the charcter

        private Rectangle CharacterBound; // The Bound for this character use for collision

        private Label CharacterText; // The label
        public int CharacterTextCountdown { get; set; }
        public int CharacterFacingDirection { get; set; }
        public double CharacterSpeed { get; set; }
        public double CharacterHealth { get; set; }
        public bool CharacterStaminaActivated { get; set; } = false;
        public int CharacterStamina { get; set; }
        public int CharacterAmmo { get; set; }
        public bool CharacterFreeze { get; set; } = false;
        public int CharacterMaxStamina { get; set; } = 100;
        public int CharacterCoins { get; set; }
        public int CharacterMedkits { get; set; }

        // Constructor
        public Character(double speed = 0.20, double health = 100.0, int max_stamina = 100, int stamina = 0 , int ammo = 7, int coins = 0, int medkits = 10)
        {
            // Initialize the default properties of the character.
            this.CharacterControl = new PictureBox();
            this.CharacterControl.Image = Properties.Resources.character_move_up;
            this.CharacterControl.Height = 100;
            this.CharacterControl.Width = 100;

            this.CharacterText = new Label();
            this.CharacterText.AutoSize = true;
            this.CharacterText.BackColor = Color.Gainsboro;
            this.CharacterText.Font = new Font("Microsoft Sans Serif", 8.75f, FontStyle.Bold);
            this.CharacterText.Text = "";
            this.CharacterTextCountdown = 2;
            this.CharacterText.Visible = false;

            this.CharacterMaxStamina = max_stamina;
            this.CharacterStamina = stamina;
            this.CharacterSpeed = speed;
            this.CharacterHealth = health;
            this.CharacterAmmo = ammo;
            this.CharacterCoins = coins;
            this.CharacterMedkits = medkits;
        }

        public Label GetCharacterTextControl()
        {
            // Getting the label control of the character.
            return this.CharacterText;
        }
        
        public Rectangle GetCharacterBound()
        {
            // Getting the bounds of the character.
            this.CharacterBound = new Rectangle(this.CharacterControl.Left, this.CharacterControl.Top, this.CharacterControl.Width, this.CharacterControl.Height);
            return this.CharacterBound;
        }

        private bool IsControllerCollisionWithWalls(Rectangle bound)
        {
            // This Check if the character collision between walls.
            if (this.CharacterBound.IntersectsWith(bound)) return true;
            return false;
        }
        private void UpdateCharacterFacingAngle(PictureBox character, int direction)
        {
            switch (direction)
            {
                case Global.FACING_DIRECTION_UP: // up
                    character.Image = Properties.Resources.character_move_up;
                    this.CharacterFacingDirection = Global.FACING_DIRECTION_UP;
                    break;

                case Global.FACING_DIRECTION_DOWN: // down
                    character.Image = Properties.Resources.character_move_down;
                    this.CharacterFacingDirection = Global.FACING_DIRECTION_DOWN;
                    break;

                case Global.FACING_DIRECTION_RIGHT: // right
                    character.Image = Properties.Resources.character_move_right;
                    this.CharacterFacingDirection = Global.FACING_DIRECTION_RIGHT;
                    break;

                case Global.FACING_DIRECTION_LEFT: // left
                    character.Image = Properties.Resources.character_move_left;
                    this.CharacterFacingDirection = Global.FACING_DIRECTION_LEFT;
                    break;

                case Global.FACING_DIRECTION_UPLEFT: // up + left
                    character.Image = Properties.Resources.character_move_upleft;
                    this.CharacterFacingDirection = Global.FACING_DIRECTION_UPLEFT;
                    break;
                case Global.FACING_DIRECTION_UPRIGHT: // up + right
                    character.Image = Properties.Resources.character_move_upright;
                    this.CharacterFacingDirection = Global.FACING_DIRECTION_UPRIGHT;
                    break;
                case Global.FACING_DIRECTION_DOWNLEFT: // down + left
                    character.Image = Properties.Resources.character_move_downleft;
                    this.CharacterFacingDirection = Global.FACING_DIRECTION_DOWNLEFT;
                    break;
                case Global.FACING_DIRECTION_DOWNRIGHT: // down + right
                    character.Image = Properties.Resources.character_move_downright;
                    this.CharacterFacingDirection = Global.FACING_DIRECTION_DOWNRIGHT;
                    break;
            }
        }
        public void SetCharacterPosition(int posX, int posY)
        {
            // Set the character position.
            this.CharacterControl.Location = new Point(posX, posY);
        }
        public PictureBox GetCharacterControl()
        {
            // Get the character control.
            return this.CharacterControl;
        }

        public void UpdateCharacterMovement()
        {
            if (this.CharacterFreeze) return;
            double[] charPosition = new double[2]; // X and Y
            charPosition[0] = CharacterControl.Location.X; // Store the X 
            charPosition[1] = CharacterControl.Location.Y; // Store the Y
            double velocity = 100 * this.CharacterSpeed; // Velocity pixel * speed per miliseconds.

            if (Keyboard.IsKeyDown(Keys.Up) || Keyboard.IsKeyDown(Keys.W)) // Keys 
            {
                if (!IsControllerCollisionWithWalls(Global.boundery[0])) // If not Collision move the character
                {
                    if (this.CharacterFacingDirection != Global.FACING_DIRECTION_UP) UpdateCharacterFacingAngle(CharacterControl, Global.FACING_DIRECTION_UP);
                    charPosition[1] -= velocity;
                    
                }
                else charPosition[1] = charPosition[1]; // else stop the character from moving.
            }
            else if (Keyboard.IsKeyDown(Keys.Down) || Keyboard.IsKeyDown(Keys.S)) // Keys 
            {
                if (!IsControllerCollisionWithWalls(Global.boundery[3]))
                {
                    if (this.CharacterFacingDirection != Global.FACING_DIRECTION_DOWN) UpdateCharacterFacingAngle(CharacterControl, Global.FACING_DIRECTION_DOWN); // Set the Character Facing Direction ONCE (to avoid keep setting the character facing angle to be called over and over)
                    charPosition[1] += velocity; // Update the character Velocity.
                }
                else charPosition[1] = charPosition[1];
            }

            //Also, don't put else here, so you can go diagonally.
            if (Keyboard.IsKeyDown(Keys.Left) || Keyboard.IsKeyDown(Keys.A)) // Keys 
            {
                if (!IsControllerCollisionWithWalls(Global.boundery[1])) // If not Collision move the character
                {
                    if (this.CharacterFacingDirection != Global.FACING_DIRECTION_LEFT) UpdateCharacterFacingAngle(CharacterControl, Global.FACING_DIRECTION_LEFT); // Set the Character Facing Direction ONCE (to avoid keep setting the character facing angle to be called over and over)
                    charPosition[0] -= velocity; // Update the character velocity.
                }
                else charPosition[0] = charPosition[0]; // Stop the character
            }
            else if (Keyboard.IsKeyDown(Keys.Right) || Keyboard.IsKeyDown(Keys.D)) // Keys 
            {
                if (!IsControllerCollisionWithWalls(Global.boundery[2])) // If not Collision move the character
                {

                    if (this.CharacterFacingDirection != Global.FACING_DIRECTION_RIGHT) UpdateCharacterFacingAngle(CharacterControl, Global.FACING_DIRECTION_RIGHT); // Set the Character Facing Direction ONCE (to avoid keep setting the character facing angle to be called over and over)
                    charPosition[0] += velocity; // Update the character velocity.
                }
                else charPosition[0] = charPosition[0]; // Stop the character
            }

            if (Keyboard.IsKeyDown(Keys.Up) && Keyboard.IsKeyDown(Keys.Left) || Keyboard.IsKeyDown(Keys.W) && Keyboard.IsKeyDown(Keys.A)) // Keys 
            {
                if (this.CharacterFacingDirection != Global.FACING_DIRECTION_UPLEFT) UpdateCharacterFacingAngle(CharacterControl, Global.FACING_DIRECTION_UPLEFT); // Set the Character Facing Direction ONCE (to avoid keep setting the character facing angle to be called over and over)

                // Console.WriteLine("Pressing Diagonal UP + Left");
            }
            else if (Keyboard.IsKeyDown(Keys.Up) && Keyboard.IsKeyDown(Keys.Right) || Keyboard.IsKeyDown(Keys.W) && Keyboard.IsKeyDown(Keys.D)) // Keys 
            {
                if (this.CharacterFacingDirection != Global.FACING_DIRECTION_UPRIGHT) UpdateCharacterFacingAngle(CharacterControl, Global.FACING_DIRECTION_UPRIGHT); // Set the Character Facing Direction ONCE (to avoid keep setting the character facing angle to be called over and over)
                // Console.WriteLine("Pressing Diagonal UP + Right");
            }
            else if (Keyboard.IsKeyDown(Keys.Down) && Keyboard.IsKeyDown(Keys.Left) || Keyboard.IsKeyDown(Keys.S) && Keyboard.IsKeyDown(Keys.A)) // Keys 
            {
                if (this.CharacterFacingDirection != Global.FACING_DIRECTION_DOWNLEFT) UpdateCharacterFacingAngle(CharacterControl, Global.FACING_DIRECTION_DOWNLEFT); // Set the Character Facing Direction ONCE (to avoid keep setting the character facing angle to be called over and over)
                //  Console.WriteLine("Pressing Diagonal Down + Left");
            }
            else if (Keyboard.IsKeyDown(Keys.Down) && Keyboard.IsKeyDown(Keys.Right) || Keyboard.IsKeyDown(Keys.S) && Keyboard.IsKeyDown(Keys.D)) // Keys 
            { 
                if (this.CharacterFacingDirection != Global.FACING_DIRECTION_DOWNLEFT) UpdateCharacterFacingAngle(CharacterControl, Global.FACING_DIRECTION_DOWNRIGHT); // Set the Character Facing Direction ONCE (to avoid keep setting the character facing angle to be called over and over)
                // Console.WriteLine("Pressing Diagonal Down + Right");
            }
            this.CharacterText.Location = new Point((int)charPosition[0] + 2, (int)charPosition[1] - 16); // Update the Label Location based on X and Y
            this.CharacterControl.Location = new Point((int)charPosition[0], (int)charPosition[1]); // Update the Character position based on X and Y
        }
    }
}
