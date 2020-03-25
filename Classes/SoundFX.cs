/*
  /$$$$$$                                      /$$       /$$$$$$$$ /$$   /$$                           
 /$$__  $$                                    | $$      | $$_____/| $$  / $$                           
| $$  \__/  /$$$$$$  /$$   /$$ /$$$$$$$   /$$$$$$$      | $$      |  $$/ $$/                           
|  $$$$$$  /$$__  $$| $$  | $$| $$__  $$ /$$__  $$      | $$$$$    \  $$$$/                            
 \____  $$| $$  \ $$| $$  | $$| $$  \ $$| $$  | $$      | $$__/     >$$  $$                            
 /$$  \ $$| $$  | $$| $$  | $$| $$  | $$| $$  | $$      | $$       /$$/\  $$                           
|  $$$$$$/|  $$$$$$/|  $$$$$$/| $$  | $$|  $$$$$$$      | $$      | $$  \ $$                           
 \______/  \______/  \______/ |__/  |__/ \_______/      |__/      |__/  |__/                           
                                                                                                       
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
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace Shooting_Games.Classes
{
    public class SoundFX
    {
        // Declare Sond effects variable for global used.
        public static SoundPlayer gunShotSound;
        public static SoundPlayer gunEmptySound;
        public static SoundPlayer gameOverSound;

        public static AudioFileReader onZombieAttack;
        public static WaveOutEvent onZombieAttackAudioOut;

        public static AudioFileReader onGameAudio;
        public static AudioFileReader onStaminaActivated;
        public static WaveOutEvent BackgroundAudio;

        public static AudioFileReader onZombieHit;
        public static WaveOutEvent onZombieHitAudioOut;

        public static AudioFileReader onZombieDied;
        public static WaveOutEvent onZombieDiedAudioOut;

        public static AudioFileReader onCharacterReload;
        public static WaveOutEvent onCharacterReloadAudioOut;

        public static AudioFileReader onZombieWaveStart;
        public static WaveOutEvent onZombieWaveStartAudioOut;

        public static AudioFileReader onZombieWaveCleared;
        public static WaveOutEvent onZombieWaveClearedAudioOut;

        public static AudioFileReader onGameOver;
        public static WaveOutEvent onGameOverAudioOut;


        public static void Init()
        {
            /*
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) 
                : This will get the Path location of this application where .exe is located.

            */
            /* Sound Wave Events */
            SoundFX.gunShotSound = new SoundPlayer(Properties.Resources.handgun_shot);
            SoundFX.gunEmptySound = new SoundPlayer(Properties.Resources.empty_clip);
            SoundFX.gameOverSound = new SoundPlayer(Properties.Resources.gameover_audio);
            

            if(SoundFX.BackgroundAudio != null) SoundFX.BackgroundAudio.Dispose();
            // Background SoundFX 
            SoundFX.BackgroundAudio = new WaveOutEvent();
            SoundFX.onStaminaActivated = new AudioFileReader(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\audio\\stamina_soundtrack.wav");
            SoundFX.onGameAudio = new AudioFileReader(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\audio\\ongame_soundtrack.wav");
            SoundFX.BackgroundAudio.Init(SoundFX.onGameAudio);

            if (SoundFX.onZombieAttackAudioOut != null)  SoundFX.onZombieAttackAudioOut.Dispose();
            // Zombie Attack SoundFX
            SoundFX.onZombieAttackAudioOut = new WaveOutEvent();
            SoundFX.onZombieAttack = new AudioFileReader(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\audio\\zombie_attack1.wav");
            SoundFX.onZombieAttackAudioOut.Init(SoundFX.onZombieAttack);

            if (SoundFX.onZombieHitAudioOut != null) SoundFX.onZombieHitAudioOut.Dispose();
            // Zombie Hit SoundFX
            SoundFX.onZombieHitAudioOut = new WaveOutEvent();
            SoundFX.onZombieHit = new AudioFileReader(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\audio\\zombie_hit.wav");
            SoundFX.onZombieHitAudioOut.Init(SoundFX.onZombieHit);

            if (SoundFX.onZombieDiedAudioOut != null) SoundFX.onZombieDiedAudioOut.Dispose();
            // Zombie Died SoundFX
            SoundFX.onZombieDiedAudioOut = new WaveOutEvent();
            SoundFX.onZombieDied = new AudioFileReader(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\audio\\zombie_died.wav");
            SoundFX.onZombieDiedAudioOut.Init(SoundFX.onZombieDied);

            if (SoundFX.onCharacterReloadAudioOut != null) SoundFX.onCharacterReloadAudioOut.Dispose();
            // Character Reload Weapon SoundFX
            SoundFX.onCharacterReloadAudioOut = new WaveOutEvent();
            SoundFX.onCharacterReload = new AudioFileReader(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\audio\\reload.wav");
            SoundFX.onCharacterReloadAudioOut.Init(SoundFX.onCharacterReload);

            if (SoundFX.onZombieWaveStartAudioOut != null) SoundFX.onZombieWaveStartAudioOut.Dispose();
            // Zombie Wave on Start SoundFX
            SoundFX.onZombieWaveStartAudioOut = new WaveOutEvent();
            SoundFX.onZombieWaveStart = new AudioFileReader(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\audio\\zombie_wave_start.wav");
            SoundFX.onZombieWaveStartAudioOut.Init(SoundFX.onZombieWaveStart);

            if (SoundFX.onZombieWaveClearedAudioOut != null) SoundFX.onZombieWaveClearedAudioOut.Dispose();
            // Zombie Wave Cleared SoundFX
            SoundFX.onZombieWaveClearedAudioOut = new WaveOutEvent();
            SoundFX.onZombieWaveCleared = new AudioFileReader(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\audio\\wave_cleared.mp3");
            SoundFX.onZombieWaveClearedAudioOut.Init(SoundFX.onZombieWaveCleared);

            if (SoundFX.onGameOverAudioOut != null) SoundFX.onGameOverAudioOut.Dispose();
            // Game over SoundFX
            SoundFX.onGameOverAudioOut = new WaveOutEvent();
            SoundFX.onGameOver = new AudioFileReader(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\audio\\gameover_soundtrack.mp3");
            SoundFX.onGameOverAudioOut.Init(SoundFX.onGameOver);
        }



    }
}
