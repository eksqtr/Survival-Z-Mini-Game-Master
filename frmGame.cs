/*
  /$$$$$$                                 /$$                     /$$       /$$$$$$$$      
 /$$__  $$                               |__/                    | $$      |_____ $$       
| $$  \__/ /$$   /$$  /$$$$$$  /$$    /$$ /$$ /$$    /$$ /$$$$$$ | $$           /$$/       
|  $$$$$$ | $$  | $$ /$$__  $$|  $$  /$$/| $$|  $$  /$$/|____  $$| $$          /$$/        
 \____  $$| $$  | $$| $$  \__/ \  $$/$$/ | $$ \  $$/$$/  /$$$$$$$| $$         /$$/         
 /$$  \ $$| $$  | $$| $$        \  $$$/  | $$  \  $$$/  /$$__  $$| $$        /$$/          
|  $$$$$$/|  $$$$$$/| $$         \  $/   | $$   \  $/  |  $$$$$$$| $$       /$$$$$$$$      
 \______/  \______/ |__/          \_/    |__/    \_/    \_______/|__/      |________/      
                                                                                           
                                                                                           
                                                                                           
  /$$$$$$                                          /$$$$$$$$                               
 /$$__  $$                                        | $$_____/                               
| $$  \__/  /$$$$$$  /$$$$$$/$$$$   /$$$$$$       | $$     /$$$$$$   /$$$$$$  /$$$$$$/$$$$ 
| $$ /$$$$ |____  $$| $$_  $$_  $$ /$$__  $$      | $$$$$ /$$__  $$ /$$__  $$| $$_  $$_  $$
| $$|_  $$  /$$$$$$$| $$ \ $$ \ $$| $$$$$$$$      | $$__/| $$  \ $$| $$  \__/| $$ \ $$ \ $$
| $$  \ $$ /$$__  $$| $$ | $$ | $$| $$_____/      | $$   | $$  | $$| $$      | $$ | $$ | $$
|  $$$$$$/|  $$$$$$$| $$ | $$ | $$|  $$$$$$$      | $$   |  $$$$$$/| $$      | $$ | $$ | $$
 \______/  \_______/|__/ |__/ |__/ \_______/      |__/    \______/ |__/      |__/ |__/ |__/
                                                                                           
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
using System.Timers;
using System.Windows.Forms;

namespace Shooting_Games
{
    public partial class frmGame : Form
    {
        // Enabling this Create ZOmbie Spawn location will let you to place zombie spawn characters on the battlefield and save the position in (bin/debug/spawn.txt)
        private  bool 
            ENABLE_CREATE_ZOMBIE_SPAWN_LOCATION = false;

        /* Misc Configurations */
        private const int
            MAX_BULLET =                                            10,     // Max Bullet for the character
            MAX_ZOMBIES =                                           30,     // Max zombies that able to spawn 
            MAX_COINSDROP =                                         99,     // Nax Coin drop
            SCORE_PER_ZOMBIE =                                      10,     // Set the score per zombie kill
            MAX_CHARACTER_STAMINA =                                 100,    // Max Character Stamina you can increase this if you want
            CHARACTER_SPAWN_STAMINA =                               100,    // Set this when you want how many stamina when the game starts (Note: you must not set a value that is greater than MAX_CHARACTER_STAMINA)
            ACTIVATE_STAMINA_TIMER_INTERVAL =                       100,    // Activate Stamina Timer interval per tick 100 miliseconds
            DEACTIVATE_STAMINA_TIMER_INTERVAL =                     1000,   // After the stamina depletes, stamina regeneration in every 1000 miliseconds
            STAMINA_COST_PER_TICK =                                 1,      // 1 Stamina for every ACTIVATE_STAMINA_TIMER_INTERVAL tick
            ZOMBIE_PER_WAVE =                                       10,     // Zombie per wave
            ZOMBIE_INCREASE_PER_WAVE =                              2,      // Zombie increase per wave
            NEXT_WAVE_MAX_COUNTDOWN =                               5,      // You can increase this if you want to adjust the Next wave Count down
            DELAY_SHOW_NEXTWAVEGUI =                                2000,   // Do not edit this this is just showing how many seconds to show the next wave gui
            MEDKITS_RECOVERY_HP =                                   30;     // Medkits HP per recovery (30%) you can increase this

        private const string
                STRING_HEALTH_FORMATTED =                           "{0}%",                         // Health String Format
                STRING_COIN_FORMATTED =                             "{0:D8}",                       // Coin String Format
                STRING_SCORE_FORMATTED =                            "{0}",                          // Score String Format
                STRING_ZOMBIELEFT_FORMATTED =                       "{0} Left(s)",                  // Zombie Lefts String Format
                STRING_ZOMBIEWAVE_FORMATTED =                       "Wave {0}",                     // Zombie Wave String Format
                STRING_MEDKITS_FORMATTED =                          "{0} Left(s)",                  // Medkits String Format
                STRING_AMMO_FROMATTED =                             "{0} / {1}",                    // Ammo String Format
                STRING_PICKUPCOINTEXT_FORMATTED =                   "+{0} Coins",                   // Pickup Coin Text String Format
                STRING_DAMAGETEXT_FORMATTED =                       "-{0} {1}",                     // Damage Text String Format
                STRING_ACTIVATESPRINT_FORMATTED =                   "Sprint Activated!",            // Activate Sprint String Format
                STRING_AVAILABLESTAMINA_FORMATTED =                 "Stamina Regenerated!";         // Stamina Regeneration String Format
         
        private const bool
            ENABLE_CRITICAL_DAMAGE =                                true;       // Enabling the Critical Damage when shooting zombies

        private const double
            CHARACTER_SPRINT_SPEED =                                0.050,      // Character Sprint from CHARACTER_NORMA_SPEED up to 30 percent!
            CHARACTER_NORMAL_SPEED =                                0.020,      // Character Norma Speed             

            ZOMBIE_DAMAGE =                                         5.0,        // Zombie Damage to the character 5.0 per attack you can increase this according to your taste.
            HANDGUN_DAMAGE =                                        30.0,       // Weapon Damage 30.0 you can increase this according to your taste.
            CRITICAL_DAMAGE =                                       1.5,        // CRITICAL_DAMAGE 1.5 * HANDGUN_DAMAGE 30.0 = 45.0 (Damage to the zombie) Critical Hit
            CRITICAL_RATE =                                         25,         // Critical Hit Rate or what we call Luck this determine the chance to trigger critical damage.
            
            SPRINT_REGENERATION_AMOUNT  =                           5.0;        // Sprint Regeneration for every DEACTIVATE_STAMINA_TIME_INTERVAL

        private int
            PlayerScores =                                          0,          // Set the default Player score
            ZombieLefts =                                           0,          // Set the Zombie Lefts
            PlayerCurrentZombieWave =                               1,          // Set the Player Zombie Wave on Game start
            NextZombieWaveCountdown = NEXT_WAVE_MAX_COUNTDOWN;                  // Set the Zombie Next wave count down based on NEXT_WAVE_MAX_COUNTDOWN

        private Zombie[] zombiesObj =                               new Zombie[MAX_ZOMBIES];    // zombiesObj as Object of Zombie Class
        private Bullet[] bulletObj =                                new Bullet[MAX_BULLET];     // coinObj as Object of Bullet Class
        private Coins[] coinsObj =                                  new Coins[MAX_COINSDROP];   // coinsObj as Object of Bullet Class
        private Character player_One;

        private bool IsGunFired = false;
        private bool IsZombieWaveFXPlaying = false;

        public frmGame()
        {
            InitializeComponent();
            // Initialize and set the Key down up key and Key Up Key from Keyboard Class
            this.KeyDown += Keyboard.OnKeyDown;
            this.KeyUp += Keyboard.OnKeyUp;
        }

        private void bttnPlayAgain_Click(object sender, EventArgs e)
        {
            frmMain_Load(sender, e); // Play again by calling the form Main Load Method
        }

        private void bttnBackToMenu_Click(object sender, EventArgs e)
        {
            // Remove all th event handlers of Play back stopped
            SoundFX.BackgroundAudio.PlaybackStopped -= OnBackGroundMusicPlayBackStopped;
            SoundFX.onZombieAttackAudioOut.PlaybackStopped -= OnZombieAttackPlayBackStopped;
            SoundFX.onZombieHitAudioOut.PlaybackStopped -= OnZombieHitPlayBackStopped;
            SoundFX.onZombieDiedAudioOut.PlaybackStopped -= OnZombieDiedPlayBackStopped;
            SoundFX.onCharacterReloadAudioOut.PlaybackStopped -= OnCharacterReloadPlayBackStopped;
            SoundFX.onZombieWaveStartAudioOut.PlaybackStopped -= OnZombieWaveStartPlaybackStopped;
            SoundFX.onZombieWaveClearedAudioOut.PlaybackStopped -= OnZombieWaveClearedStartPlaybackStopped;
            SoundFX.onGameOverAudioOut.PlaybackStopped -= OnGameOverStartPlayerbackStopped;

            // Stop the Music or Sound FX
            SoundFX.BackgroundAudio.Stop();
            SoundFX.onZombieAttackAudioOut.Stop();
            SoundFX.onZombieHitAudioOut.Stop();
            SoundFX.onZombieDiedAudioOut.Stop();
            SoundFX.onCharacterReloadAudioOut.Stop();
            SoundFX.onZombieWaveStartAudioOut.Stop();
            SoundFX.onZombieWaveClearedAudioOut.Stop();
            SoundFX.onGameOverAudioOut.Stop();

            // Clean all the WaveOutEvent
            SoundFX.BackgroundAudio.Dispose();
            SoundFX.onZombieAttackAudioOut.Dispose();
            SoundFX.onZombieHitAudioOut.Dispose();
            SoundFX.onZombieDiedAudioOut.Dispose();
            SoundFX.onCharacterReloadAudioOut.Dispose();
            SoundFX.onZombieWaveStartAudioOut.Dispose();
            SoundFX.onZombieWaveClearedAudioOut.Dispose();
            SoundFX.onGameOverAudioOut.Dispose();
            this.Close(); // Close this form
        }

        private void frmGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing) // Check if user closing the form
            {
                // Stop the background audio and Sound FX
                SoundFX.BackgroundAudio.Stop();
                SoundFX.onZombieAttackAudioOut.Stop();
                SoundFX.onZombieHitAudioOut.Stop();
                SoundFX.onZombieDiedAudioOut.Stop();
                SoundFX.onCharacterReloadAudioOut.Stop();
                SoundFX.onZombieWaveStartAudioOut.Stop();
                SoundFX.onZombieWaveClearedAudioOut.Stop();
                SoundFX.onGameOverAudioOut.Stop();

                // Clean all the WaveOutevent
                SoundFX.BackgroundAudio.Dispose();
                SoundFX.onZombieAttackAudioOut.Dispose();
                SoundFX.onZombieHitAudioOut.Dispose();
                SoundFX.onZombieDiedAudioOut.Dispose();
                SoundFX.onCharacterReloadAudioOut.Dispose();
                SoundFX.onZombieWaveStartAudioOut.Dispose();
                SoundFX.onZombieWaveClearedAudioOut.Dispose();
                SoundFX.onGameOverAudioOut.Dispose();

                // Instantiate the Menu Form
                frmMenu menuForm = new frmMenu();
                menuForm.Show(); // Show the Menu

            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            /* [START] Setting fresh game on start configuration */
            WallCollisionTick.Interval =                    10;             // 10 Miliseconds           0.010 second
            MovementControlsTick.Interval =                 1;              // 1 Milisecond             0.001 second
            zombie1Tick.Interval =                          1;              // 1 Milisecond             0.001 second
            StaminaTick.Interval =                          1000;           // 1000 Milisecond          1 second
            ZombieDamageTick.Interval =                     1000;           // 1000 Milisecond          1 second
            BulletCollisionZombie.Interval =                50;             // 50 Milisecond            0.050 seconds
            OnDelayTextGUITimer.Interval =                  2000;           // 2000 Milisecond          2 seconds
            GameHeartbeatTick.Interval =                    1000;           // 1000 Milisecond          1 second

            NextZombieWaveCountdown =                       NEXT_WAVE_MAX_COUNTDOWN;    // Next wave Count down
            PlayerCurrentZombieWave =                       0;                          // Default PlayerCurrentWave
            lblZombieWave.Text =                            "Initializing...";          // initalizing
            SpawnZombieTimer.Interval =                     7000;                       // 7000 miliseconds 7 seconds
            ZombieWaveOnStart.Start();

            OnDelayTextGUITimer.Interval =                  DELAY_SHOW_NEXTWAVEGUI;     // Set the Delay show next wave

            // Start all the Timers
            WallCollisionTick.Start();
            MovementControlsTick.Start();
            BulletTimer.Start();
            StaminaTick.Start();
            zombie1Tick.Start();
            ZombieDamageTick.Start();
            BulletCollisionZombie.Start();
            GameHeartbeatTick.Start();

            /* Now Reset all characters, zombies and others. */
            for(int i = 0; i < zombiesObj.Length; i++)
            {
                if(zombiesObj[i] != null)
                {
                    this.Controls.Remove(zombiesObj[i].GetZombieControl());
                    this.Controls.Remove(zombiesObj[i].GetZombieHPBar());
                    zombiesObj[i] = null;
                }
            }

            for (int i = 0; i < coinsObj.Length; i++)
            {
                if (coinsObj[i] != null)
                {
                    this.Controls.Remove(coinsObj[i].GetCoinControl());
                    coinsObj[i] = null;
                }
            }
            for (int i = 0; i < bulletObj.Length; i++)
            {
                if (bulletObj[i] != null)
                {
                    this.Controls.Remove(bulletObj[i].GetBulletControl());
                    coinsObj[i] = null;
                }
            }
            if (player_One != null)
            {
                this.Controls.Remove(player_One.GetCharacterControl());
                player_One = null;
            }

            /* Reset the GUI */
            txtGUI_ContainerWave.Visible = false;
            txtGUI_ContainerWave.SendToBack();
            txtGUI_WaveCleared.Visible = false;
            txtGUI_WaveCleared.SendToBack();
            gameOverGUI.Visible = false;
            gameOverGUI.SendToBack();


            /* Wall Boundery of the battle fields */
            Global.boundery[Global.WALL_BOUNDERY_TOP] = new Rectangle(topWall.Left, topWall.Top, topWall.Width, topWall.Height);
            Global.boundery[Global.WALL_BOUNDERY_LEFT] = new Rectangle(leftWall.Left, leftWall.Top, leftWall.Width, leftWall.Height);
            Global.boundery[Global.WALL_BOUNDERY_RIGHT] = new Rectangle(rightWall.Left, rightWall.Top, rightWall.Width, rightWall.Height);
            Global.boundery[Global.WALL_BOUNDERY_BOTTOM] = new Rectangle(bottomWall.Left, bottomWall.Top, bottomWall.Width, bottomWall.Height);

            /* Character Creation */
            player_One = new Character(speed:CHARACTER_NORMAL_SPEED, health:100.0, max_stamina:MAX_CHARACTER_STAMINA, stamina:CHARACTER_SPAWN_STAMINA, ammo:bulletObj.Length, coins:0, medkits: 5); 
            this.Controls.Add(player_One.GetCharacterControl());
            player_One.GetCharacterControl().BringToFront();
            player_One.GetCharacterControl().BackColor = Color.Gainsboro;

            this.Controls.Add(player_One.GetCharacterTextControl());
            player_One.GetCharacterTextControl().BringToFront();
            

            // Set the player position to center of the battle Field.
            player_One.SetCharacterPosition((this.ClientSize.Width / 2 - player_One.GetCharacterControl().Height / 2) + this.battleFieldBound.Location.X / 2, (this.ClientSize.Height / 2 - player_One.GetCharacterControl().Height / 2) + this.battleFieldBound.Location.Y / 2);
            progressBarStamina.Maximum = player_One.CharacterMaxStamina;
            progressBarStamina.Value = player_One.CharacterStamina;
            progressBarHP.Maximum = 100;
            progressBarHP.Value = 100;

            /* Update the Character Status */
            lblHealth.Text  = string.Format(STRING_HEALTH_FORMATTED, player_One.CharacterHealth); 
            lblAmmo.Text = string.Format(STRING_AMMO_FROMATTED, player_One.CharacterAmmo, bulletObj.Length);
            lblZombieWave.Text = string.Format(STRING_ZOMBIEWAVE_FORMATTED, PlayerCurrentZombieWave); 
            ZombieLefts = ZOMBIE_PER_WAVE;
            lblZombieLeft.Text = string.Format(STRING_ZOMBIELEFT_FORMATTED, ZombieLefts);
            lblScore.Text = string.Format(STRING_SCORE_FORMATTED, PlayerScores);
            lblCoin.Text = string.Format(STRING_COIN_FORMATTED, player_One.CharacterCoins); 
            lblMedkits.Text = string.Format(STRING_MEDKITS_FORMATTED, player_One.CharacterMedkits);

            PlayerScores = 0;
            lblScore.Text = string.Format(STRING_SCORE_FORMATTED, PlayerScores);




            /* Sound Effects */
            // Initialize the Sound Effects
            SoundFX.Init();

            SoundFX.BackgroundAudio.Stop();
            SoundFX.onZombieAttackAudioOut.Stop();
            SoundFX.onZombieHitAudioOut.Stop();
            SoundFX.onZombieDiedAudioOut.Stop();
            SoundFX.onCharacterReloadAudioOut.Stop();
            SoundFX.onZombieWaveStartAudioOut.Stop();
            SoundFX.onZombieWaveClearedAudioOut.Stop();
            SoundFX.onGameOverAudioOut.Stop();

            // Initialize the custom play back on stop
            SoundFX.BackgroundAudio.PlaybackStopped += OnBackGroundMusicPlayBackStopped;
            SoundFX.onZombieAttackAudioOut.PlaybackStopped += OnZombieAttackPlayBackStopped;
            SoundFX.onZombieHitAudioOut.PlaybackStopped += OnZombieHitPlayBackStopped;
            SoundFX.onZombieDiedAudioOut.PlaybackStopped += OnZombieDiedPlayBackStopped;
            SoundFX.onCharacterReloadAudioOut.PlaybackStopped += OnCharacterReloadPlayBackStopped;
            SoundFX.onZombieWaveStartAudioOut.PlaybackStopped += OnZombieWaveStartPlaybackStopped;
            SoundFX.onZombieWaveClearedAudioOut.PlaybackStopped += OnZombieWaveClearedStartPlaybackStopped;
            SoundFX.onGameOverAudioOut.PlaybackStopped += OnGameOverStartPlayerbackStopped;

            

            // Set all the SoundFX to position 0 for fresh start.
            SoundFX.onGameAudio.Position = 0;
            SoundFX.onStaminaActivated.Position = 0;
            SoundFX.onZombieAttack.Position = 0;
            SoundFX.onZombieHit.Position = 0;
            SoundFX.onZombieDied.Position = 0;
            SoundFX.onCharacterReload.Position = 0;
            SoundFX.onZombieWaveStart.Position = 0;
            SoundFX.onZombieWaveCleared.Position = 0;
            SoundFX.onGameOver.Position = 0;


            // Play the Background Audio.
            SoundFX.BackgroundAudio.Play();
            
            /* When Making Zombie Spawn */
            if(ENABLE_CREATE_ZOMBIE_SPAWN_LOCATION)
            {
                battleFieldBound.Visible = false;
                MovementControlsTick.Stop();
                SpawnZombieTimer.Stop();
                ZombieWaveOnStart.Stop();
                MessageBox.Show("Creating Zombie Spawn Point\n\nHello there you just enabled the creation of zombie spawn point. To create a zombie spawn point just click inside of the battle field then the zombie spawn point" +
                    "will be created. To check the spawn point coordinates please check under your project directory (this project/bin/debug/spawn.txt)");
            }
            this.ActiveControl = null; // we're going to set on focus null to some other controls that can be focusable to avoid contradicting with keypress (e.g buttons)
            /* [END] Setting fresh game on start configuration */
        }


        /* ===================== Audio Play backs  =====================*/

        //Background Audio Playback
        private void OnBackGroundMusicPlayBackStopped(object sender, StoppedEventArgs args)
        {
            if (MovementControlsTick.Enabled == true)
            {
                SoundFX.onGameAudio.Position = 0;
                SoundFX.BackgroundAudio.Play();
            }
        }

        // Reload Play back 
        private void OnCharacterReloadPlayBackStopped(object sender, StoppedEventArgs args)
        {
            SoundFX.onCharacterReload.Position = 0;
            ReloadBullet();
            player_One.CharacterFreeze = false;
            string tempStr = string.Format(STRING_AMMO_FROMATTED, player_One.CharacterAmmo, bulletObj.Length);
            lblAmmo.Text = tempStr;
        }

        // Zombie Attack Playback
        private void OnZombieAttackPlayBackStopped(object sender, StoppedEventArgs args)
        {
            SoundFX.onZombieAttack.Position = 0;
        }

        // Zombie Hit Playback
        private void OnZombieHitPlayBackStopped(object sender, StoppedEventArgs args)
        {
            SoundFX.onZombieHit.Position = 0;
        }
        
        // Zombie Died Playback
        private void OnZombieDiedPlayBackStopped(object sender, StoppedEventArgs args)
        {
            SoundFX.onZombieDied.Position = 0;
        }
        // Zombie Died Playback
        private void OnZombieWaveStartPlaybackStopped(object sender, StoppedEventArgs args)
        {
            if (SoundFX.BackgroundAudio == null) return;
            IsZombieWaveFXPlaying = false; // Set to false  to avoid glitch on character use stamina background FX
            SoundFX.onZombieWaveStart.Position = 0; // Reset the posiion to 0 
            SoundFX.BackgroundAudio.Play(); // Start the background music
        }
        // Zombie Died Playback
        private void OnZombieWaveClearedStartPlaybackStopped(object sender, StoppedEventArgs args)
        {
            if (SoundFX.BackgroundAudio == null) return;
            SoundFX.onZombieWaveCleared.Position = 0; // Reset the posiion to 0 
            SoundFX.BackgroundAudio.Play();
            //SoundFX.onZombieWaveClearedAudioOut.Play(); // Start the background music
        }
        // Zombie Died Playback
        private void OnGameOverStartPlayerbackStopped(object sender, StoppedEventArgs args)
        {
            if (SoundFX.onGameOverAudioOut == null) return;
            if (player_One.CharacterHealth > 0) return;
            SoundFX.onGameOver.Position = 0; // Reset the posiion to 0 
            SoundFX.onGameOverAudioOut.Play();
            //SoundFX.onZombieWaveClearedAudioOut.Play(); // Start the background music
        }
        /* ========================== Custom Methods ========================== */

            // Create Zombie
        private void AddZombie(int posX, int posY, double speed)
        {
            for (int x = 0; x < zombiesObj.Length; x++)
            {
                if (zombiesObj[x] == null)
                {
                    zombiesObj[x] = new Zombie(100, 100, speed);
                    this.Controls.Add(zombiesObj[x].GetZombieControl()); // Add the control in the form
                    this.Controls.Add(zombiesObj[x].GetZombieHPBar());   // Add the control in the form
                    zombiesObj[x].GetZombieControl().BackColor = Color.Gainsboro;   // Set the background color
                    zombiesObj[x].GetZombieHPBar().BackColor = Color.Gainsboro;     // Set the background color
                    zombiesObj[x].GetZombieControl().BringToFront();                // Bring the Control to front
                    zombiesObj[x].GetZombieHPBar().BringToFront();                  // Bring the Control to front
                    zombiesObj[x].GetZombieHPBar().Value = (int)zombiesObj[x].ZombieHealth; // Set the Zombie Health
                    zombiesObj[x].GetZombieControl().Location = new Point(posX, posY);  // Set the zombie Location based on X and Y
                    break; // We need to put a break here because we want only 1 zombie at atime.
                }
            }
        }

            // Create Bullet
        private void CreateBullet()
        {
            for(int x = 0; x < bulletObj.Length; x++)
            {
                if(bulletObj[x] == null) // If there stil available bullet then create
                {
                    bulletObj[x] = new Bullet();
                    bulletObj[x].BulletDirection = player_One.CharacterFacingDirection; // Set the facing direction of the bullet based on Character Facing direction
                    this.Controls.Add(bulletObj[x].GetBulletControl()); // Add the control in the form
                    bulletObj[x].GetBulletControl().BringToFront(); // Bring the control to front
                    bulletObj[x].GetBulletControl().BackColor = Color.Gainsboro; // Set the background color
                    bulletObj[x].SetBulletPos(player_One.GetCharacterControl()); // Set the bullet poistion
                    break; // We need to put a break here because we want only 1 bullet at a time.
                }
            }
        }

        // Reload the weapon
        private void ReloadBullet()
        {
            for(int i = 0; i < bulletObj.Length; i++)
            {
                if (bulletObj[i] != null) // Check if the  bullet is existing
                {
                    // Remove the control in the form
                    this.Controls.Remove(bulletObj[i].GetBulletControl());
                    bulletObj[i] = null; // Set the bulletObj to null
                }
            }
            player_One.CharacterAmmo = bulletObj.Length; // Set the CharacterAmmo based on bulletObj.length (MAX_BULLET)
        }

        // Drop the zombie coin
        private void DropZombieCoin(Control ctr)
        { 
            for(int i = 0; i < coinsObj.Length; i++)
            {
                if(coinsObj[i] == null) // Check if there still available slot for creating a coin
                {
                    coinsObj[i] = new Coins(); 
                    this.Controls.Add(coinsObj[i].GetCoinControl());  // Add the control in the form
                    coinsObj[i].GetCoinControl().Location = new Point(ctr.Location.X + 36, ctr.Location.Y + 26); // Set the coin based on control x and y
                    coinsObj[i].GetCoinControl().BringToFront(); // bring the coin to front.
                    break; // we put break here because we want only to create 1 coin at a time
                }
            }

        }


        // Check if the zombie is the last enemy in the wave
        private bool IsLastZombieForThisWave()
        {
            int count = 0; // Store to count the zombies
            if (ZombieLefts == 0)
            {
                foreach (var zCtr in zombiesObj)
                {
                    if (zCtr != null) // Check if there still a zombie
                    {
                        count++; // Count the zombie
                    }
                }
                return count > 0 ? false : true; // if count > 0 return false else true
            }
            return false; // return false
            
        }

        // Update the GUI Wave number
        private void UpdateGUIWaveNumber()
        {
            string waveNumStr = string.Format("{0:D2}", PlayerCurrentZombieWave); // extract the playercurrentzombie wave in 2 decimal placelment
            string numOneStr = string.Format("{0}\\images\\gameGUI\\txtgui_{1}.png", Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), waveNumStr.Substring(0, 1));  // get the first digit
            string numTwoStr = string.Format("{0}\\images\\gameGUI\\txtgui_{1}.png", Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), waveNumStr.Substring(1, 1)); // get the 2nd digit
            txtGUI_NumOne.BackgroundImage = Image.FromFile(numOneStr); // update the numone digit based on zombiewaves
            txtGUI_NumTwo.BackgroundImage = Image.FromFile(numTwoStr); // update the numtwo digit based on zombiewaves
        }
        // Give chracter coin with txt
        private void GiveCharacterCoin(int amount)
        {
            if (player_One == null) return; // if the player is null then dont give a coin
            player_One.CharacterCoins += amount; // add the coin 
            lblCoin.Text = string.Format(STRING_COIN_FORMATTED, player_One.CharacterCoins); // set the label text
        }

        // Show the playertext
        public void CharacterShowText(string text, Color color) // param text and color
        {
            player_One.GetCharacterTextControl().Text = text;
            player_One.GetCharacterTextControl().ForeColor = color;
            player_One.GetCharacterTextControl().Visible = true; // to show the text color
        }
        /* ========================== Timer Methods ========================== */
        // Timer for every 1 second 
        private void GameHeartbeatTick_Tick(object sender, EventArgs e)
        {
            // Coin Loop
            for (int i = 0; i < coinsObj.Length; i++)
            {
                if (coinsObj[i] == null) continue;
                if (--coinsObj[i].CoinCountdown <= 0) // Remove the coin if the player ignore the coin 
                {
                    this.Controls.Remove(coinsObj[i].GetCoinControl()); // remove this shit from the form
                    coinsObj[i] = null; // Set the coin object to null
                    continue;

                }
            }
            // Player Text Loop
            if(player_One.GetCharacterTextControl().Visible)
            {
                if(--player_One.CharacterTextCountdown <= 0) // Hide the player text if the countdown text reach 0
                {
                    player_One.GetCharacterTextControl().Visible = false; // hide the character text
                    player_One.CharacterTextCountdown = 2;           // set the default count down
                    player_One.GetCharacterTextControl().Text = ""; // remove the string
                }
                
            }
        }

        // Wall Collision Tick
        private void WallCollisionTick_Tick(object sender, EventArgs e)
        {

            for (int y = 0; y < bulletObj.Length; y++)
            {
                if (bulletObj[y] != null) // If bullet is not null proceed
                {
                    foreach (Rectangle wall in Global.boundery) // loop all the bonderies
                    {
                        if (bulletObj[y].GetBulletBound().IntersectsWith(wall)) // If the bullet intersects with the wall delete.
                        {
                            this.Controls.Remove(bulletObj[y].GetBulletControl()); // remove this shit
                        }
                    }
                }
            }
        }

        // Player Character MOvement Timer
        private void MovementControlsTick_Tick(object sender, EventArgs e)
        {
            player_One.UpdateCharacterMovement(); // Update the Character Movement
            // Coin Object Loop
            for (int i = 0; i < coinsObj.Length; i++) 
            {
                if (coinsObj[i] == null) continue;  // If null continue 
                if (player_One.GetCharacterBound().IntersectsWith(coinsObj[i].GetCoinBound())) // Check the collision betweel character and coin
                {
                    GiveCharacterCoin(coinsObj[i].CoinAmount); // Give the coin to the player
                    string coinStr = string.Format(STRING_PICKUPCOINTEXT_FORMATTED, coinsObj[i].CoinAmount); // format the text 
                    CharacterShowText(coinStr, Color.DarkOrange); // Show the text
                    player_One.GetCharacterTextControl().BringToFront(); // Bring it to front
                    this.Controls.Remove(coinsObj[i].GetCoinControl()); // remove this shit after picking up
                    coinsObj[i] = null; // set to null
                    continue; // continue the loop so we save memory from looping and looping again and again
                }
            }
        }
        // Delay Text imter
        private void OnDelayTextGUITimer_Tick(object sender, EventArgs e)
        {
            UpdateGUIWaveNumber(); // update the wave number
            txtGUI_ContainerWave.Visible = true; // set it to visible true
            battleFieldBound.Controls.Add(txtGUI_ContainerWave); // add it to the battleField Panel
            txtGUI_ContainerWave.Location = new Point(battleFieldBound.Width / 2 - txtGUI_ContainerWave.Width / 2, battleFieldBound.Height / 2 - txtGUI_ContainerWave.Height / 2); // Set it to the center
            txtGUI_ContainerWave.BringToFront(); // bring it front

            // We're going to hide it after.
            if (OnDelayTextGUITimer.Interval == (DELAY_SHOW_NEXTWAVEGUI + 2000) && txtGUI_ContainerWave.Visible) // If txtGui visible and timer = 5000 miliseconds hide it.
            {
                OnDelayTextGUITimer.Interval = DELAY_SHOW_NEXTWAVEGUI; // set the default
                OnDelayTextGUITimer.Stop(); // stop the timer
                txtGUI_ContainerWave.Visible = false; // hide the text
                battleFieldBound.Controls.Remove(txtGUI_ContainerWave); // remove it from the panel
                txtGUI_ContainerWave.SendToBack(); // send to back
                return;
            }
            OnDelayTextGUITimer.Interval = DELAY_SHOW_NEXTWAVEGUI + 2000; // DELAY_SHOW_NEXTWAVE + 2000 = 5000 miliseconds
        }

        // Zombie Wave on Start
        private void ZombieWaveOnStart_Tick(object sender, EventArgs e)
        {
           
            if (--NextZombieWaveCountdown <= 0)
            {
                IsZombieWaveFXPlaying = true;

                txtGUI_WaveCleared.Visible = false;
                battleFieldBound.Controls.Remove(txtGUI_WaveCleared);
                txtGUI_WaveCleared.SendToBack();

                OnDelayTextGUITimer.Start();
                SoundFX.BackgroundAudio.Pause(); // pause the background audio
                SoundFX.onZombieWaveStartAudioOut.Play();
                

                ZombieWaveOnStart.Stop(); // timer stop
                NextZombieWaveCountdown =NEXT_WAVE_MAX_COUNTDOWN + 1;

                PlayerCurrentZombieWave++;
                lblZombieWave.Text = string.Format(STRING_ZOMBIEWAVE_FORMATTED, PlayerCurrentZombieWave);
                ZombieLefts = (PlayerCurrentZombieWave == 1) ? ZOMBIE_PER_WAVE : ZOMBIE_PER_WAVE + PlayerCurrentZombieWave + ZOMBIE_INCREASE_PER_WAVE;
                lblZombieLeft.Text = string.Format(STRING_ZOMBIELEFT_FORMATTED, ZombieLefts);
                Console.WriteLine("Wave " + PlayerCurrentZombieWave);
                SpawnZombieTimer.Start();
                return;
            }
            Console.WriteLine("Next wave in " + NextZombieWaveCountdown);
        }
        private void zombie1Tick_Tick(object sender, EventArgs e)
        {
            foreach (var ctr in zombiesObj)
            {
                if (ctr != null) ctr.ZombieChase(ctr.GetZombieControl(), player_One.GetCharacterControl());
            }
        }

        private void BulletTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < bulletObj.Length; i++)
            {
                if (bulletObj[i] != null)
                {
                    bulletObj[i].ShootBullet();
                }
            }
        }
        private void StaminaTick_Tick(object sender, EventArgs e)
        {
            if (!MovementControlsTick.Enabled) return;
            if (player_One.CharacterStaminaActivated == true)
            {
                player_One.CharacterStamina -= STAMINA_COST_PER_TICK;
                if (player_One.CharacterStamina <= 0)
                {
                    player_One.CharacterStamina = 0;
                    player_One.CharacterStaminaActivated = false;
                    player_One.CharacterSpeed = CHARACTER_NORMAL_SPEED;
                    StaminaTick.Interval = DEACTIVATE_STAMINA_TIMER_INTERVAL;

                    SoundFX.BackgroundAudio.Stop();
                    SoundFX.BackgroundAudio.Init(SoundFX.onGameAudio);
                    if(!IsZombieWaveFXPlaying) SoundFX.BackgroundAudio.Play();
                }

            }
            else
            {
                if (player_One.CharacterStamina <= (player_One.CharacterMaxStamina - SPRINT_REGENERATION_AMOUNT))
                {
                    player_One.CharacterStamina += (int)SPRINT_REGENERATION_AMOUNT;
                }
                else
                {
                    if(player_One.CharacterStamina == player_One.CharacterMaxStamina)
                    {
                        player_One.CharacterStamina = player_One.CharacterMaxStamina - 1;
                        CharacterShowText(STRING_AVAILABLESTAMINA_FORMATTED, Color.ForestGreen);
                    }
                }
            }
            progressBarStamina.Value = player_One.CharacterStamina;
        }
        private void SpawnZombieTimer_Tick(object sender, EventArgs e)
        {

            Random rand = new Random();
            int randomMaxSpawn = rand.Next((2 < ZombieLefts) ? 2 : ZombieLefts, (5 < ZombieLefts) ? 5 : ZombieLefts);
            if (ZombieLefts > 0)
            {
                ZombieLefts -= randomMaxSpawn;
                lblZombieLeft.Text = string.Format(STRING_ZOMBIELEFT_FORMATTED, ZombieLefts);
                for (int x = 0; x < randomMaxSpawn; x++)
                {
                    int randomSpawnIndex = rand.Next(0, Global.ZOMBIE_SPAWN_POS.GetLength(0));
                    AddZombie(Global.ZOMBIE_SPAWN_POS[randomSpawnIndex, 0], Global.ZOMBIE_SPAWN_POS[randomSpawnIndex, 1], Math.Round((rand.NextDouble() * (1.4 - 1.0) + 1.0) * 0.010, 3)); // With random zombie speed 
                }
                if(progressBarHP.Value == 0) gameOverGUI.BringToFront();
                int randomInterval = rand.Next(5000, 7000);
                SpawnZombieTimer.Interval = randomInterval;
            }
            else
            {
                ZombieLefts = 0;
                lblZombieLeft.Text = string.Format(STRING_ZOMBIELEFT_FORMATTED, ZombieLefts);

            }

        }
        private void ZombieDamageTick_Tick(object sender, EventArgs e)
        {
            foreach (var zombie in zombiesObj)
            {
                if (zombie != null)
                {
                    if (zombie.GetZombieBound().IntersectsWith(player_One.GetCharacterBound()))
                    {

                        string hpStr;
                        player_One.CharacterHealth -= ZOMBIE_DAMAGE;
                        SoundFX.onZombieAttackAudioOut.Play();
                        if (player_One.CharacterHealth <= 0)
                        {
                            SoundFX.gameOverSound.Play();
                            player_One.CharacterHealth = 0.0;
                            SoundFX.BackgroundAudio.Stop();
                            progressBarHP.Value = 0;
                            lblHealth.Text = "Died";
                            ZombieDamageTick.Stop();
                            MovementControlsTick.Stop();
                            SoundFX.onGameOverAudioOut.Play();
                            gameOverGUI.Visible = true;
                            gameOverGUI.BringToFront();
                            break;
                        }
                        else
                        {
                            progressBarHP.Value -= (int)ZOMBIE_DAMAGE;
                            hpStr = string.Format("{0}%", player_One.CharacterHealth);
                            lblHealth.Text = hpStr;
                        }
                    }
                }
            }
        }

        private void BulletCollisionZombie_Tick(object sender, EventArgs e)
        {
            for (int y = 0; y < bulletObj.Length; y++)
            {
                if (bulletObj[y] != null)
                { 
                    for (int x = 0; x < zombiesObj.Length; x++)
                    {
                        if (zombiesObj[x] != null)
                        {
                            if (bulletObj[y].GetBulletBound().IntersectsWith(zombiesObj[x].GetZombieBound()))
                            {
                                this.Controls.Remove(bulletObj[y].GetBulletControl()); 
                                bulletObj[y] = null;

                                SoundFX.onZombieHitAudioOut.Stop();
                                SoundFX.onZombieHit.Position = 0;
                                SoundFX.onZombieHitAudioOut.Play();
                                
                                Random rand = new Random();
                                int critChance = rand.Next(1, 100);
                                double damage = (critChance < CRITICAL_RATE && ENABLE_CRITICAL_DAMAGE) ? (CRITICAL_DAMAGE * HANDGUN_DAMAGE) : (HANDGUN_DAMAGE);
                                zombiesObj[x].ZombieHealth -= damage;

                                if(damage > HANDGUN_DAMAGE) Console.WriteLine("CRIT Damage: " + damage);
                                else Console.WriteLine("Normal Damage: " + damage);

                                zombiesObj[x].GetZombieHPBar().Value = (zombiesObj[x].ZombieHealth <= 0) ? (0) : ((int)zombiesObj[x].ZombieHealth);
                                if (zombiesObj[x].ZombieHealth <= 0.0)
                                {
                                    DropZombieCoin(zombiesObj[x].GetZombieControl());
                                    zombiesObj[x].ZombieHealth = 0;
                                    PlayerScores += SCORE_PER_ZOMBIE;

                                    string scoreStr = string.Format(STRING_SCORE_FORMATTED, PlayerScores);
                                    lblScore.Text = scoreStr;
                                    
                                    SoundFX.onZombieDiedAudioOut.Play();
                                    this.Controls.Remove(zombiesObj[x].GetZombieControl());
                                    this.Controls.Remove(zombiesObj[x].GetZombieHPBar());
                                    zombiesObj[x] = null;
                                    if (IsLastZombieForThisWave())
                                    {
                                        SoundFX.BackgroundAudio.Pause();
                                        SoundFX.onZombieWaveClearedAudioOut.Play(); 
                                        txtGUI_WaveCleared.Visible = true;
                                        battleFieldBound.Controls.Add(txtGUI_WaveCleared);
                                        txtGUI_WaveCleared.Location = new Point(battleFieldBound.Width / 2 - txtGUI_WaveCleared.Width / 2, battleFieldBound.Height / 2 - txtGUI_WaveCleared.Height /2);
                                        txtGUI_WaveCleared.BringToFront();
                                        
                                        SpawnZombieTimer.Stop();
                                        ZombieWaveOnStart.Start();
                                    }
                                }
                                break;
                            }
                        }
                    }
                }
            }
        }

        /* ======================= Form Methods =======================*/
        private void frmGame_SizeChanged(object sender, EventArgs e)
        {

        }
        private void frmMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (!ENABLE_CREATE_ZOMBIE_SPAWN_LOCATION) return;
            Console.WriteLine("Pos X: " + e.X);
            Console.WriteLine("Pos Y: " + e.Y);

            string path = string.Format("{0}\\spawn.txt", Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            if (!File.Exists(path)) File.Create(path).Dispose();
            AddZombie(e.X, e.Y, 0.000);
            using (var textFile = File.AppendText(path))
            {
                textFile.WriteLine("{" + e.X + " ," + e.Y + "}, ");

            }


        }

        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                if (!MovementControlsTick.Enabled) return;
                if (IsGunFired) return;
                if (player_One.CharacterAmmo <= 0)
                {
                    SoundFX.gunEmptySound.Play();
                    return;
                }
                CreateBullet();
                SoundFX.gunShotSound.Play();
                player_One.CharacterAmmo--;
                string tempStr = string.Format(STRING_AMMO_FROMATTED, player_One.CharacterAmmo, bulletObj.Length);
                lblAmmo.Text = tempStr;
                IsGunFired = true;

            }

        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                spaceButton.BackColor = Color.Tomato;
                IsGunFired = false;
            }
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up) upButton.BackColor = Color.SeaGreen;
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down) downButton.BackColor = Color.SeaGreen;
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left) leftButton.BackColor = Color.SeaGreen;
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right) rightButton.BackColor = Color.SeaGreen;
            if (e.KeyCode == Keys.F) fButton.BackColor = Color.Tomato;
            if (e.KeyCode == Keys.R) rButton.BackColor = Color.Tomato;
            if (e.KeyCode == Keys.Tab) shiftButton.BackColor = Color.Tomato;
            
            
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) spaceButton.BackColor = Color.DarkRed;
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up) upButton.BackColor = Color.DarkRed;
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down) downButton.BackColor = Color.DarkRed;
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left) leftButton.BackColor = Color.DarkRed;
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right) rightButton.BackColor = Color.DarkRed;
            if (e.KeyCode == Keys.F)
            {
                fButton.BackColor = Color.DarkRed;
                if(player_One.CharacterMedkits <= 0.0)
                {
                    CharacterShowText("Not enough medkits!", Color.DarkOrange);
                    return;
                }
                if(player_One.CharacterHealth >= 100.0)
                {
                    CharacterShowText("HP is already full!", Color.DarkOrange);
                    return;
                }
                
                CharacterShowText("+" + MEDKITS_RECOVERY_HP + " Health", Color.ForestGreen);
                player_One.CharacterHealth += MEDKITS_RECOVERY_HP;
                if (player_One.CharacterHealth > 100.0) player_One.CharacterHealth = 100.0;
                progressBarHP.Value =(int) player_One.CharacterHealth;
                lblHealth.Text = string.Format(STRING_HEALTH_FORMATTED, player_One.CharacterHealth);
                player_One.CharacterMedkits--;
                lblMedkits.Text = string.Format(STRING_MEDKITS_FORMATTED, player_One.CharacterMedkits);
            }
            if (e.KeyCode == Keys.Tab)
            {
                shiftButton.BackColor = Color.DarkRed;
                if (!MovementControlsTick.Enabled) return;
                if (player_One.CharacterStaminaActivated == false && player_One.CharacterStamina == player_One.CharacterMaxStamina - 1)
                {
                    player_One.CharacterStaminaActivated = true;
                    player_One.CharacterSpeed = CHARACTER_SPRINT_SPEED;
                    StaminaTick.Interval = ACTIVATE_STAMINA_TIMER_INTERVAL;
                    CharacterShowText(STRING_ACTIVATESPRINT_FORMATTED, Color.ForestGreen);

                    SoundFX.BackgroundAudio.Stop();
                    SoundFX.onStaminaActivated.Position = 0;
                    SoundFX.BackgroundAudio.Init(SoundFX.onStaminaActivated);
                    SoundFX.BackgroundAudio.Play();
                }

            }
            if (e.KeyCode == Keys.R)
            {
                rButton.BackColor = Color.DarkRed;
                if (!MovementControlsTick.Enabled) return;
                if (player_One.CharacterAmmo > 0) return;
                // player_One.CharacterFreeze = true; uncomment this if you want when reloading you freezing the character
                SoundFX.onCharacterReloadAudioOut.Play();


            }
        }
    }
}
