/*


 /$$   /$$                     /$$                                           /$$                 
| $$  /$$/                    | $$                                          | $$                 
| $$ /$$/   /$$$$$$  /$$   /$$| $$$$$$$   /$$$$$$   /$$$$$$   /$$$$$$   /$$$$$$$                 
| $$$$$/   /$$__  $$| $$  | $$| $$__  $$ /$$__  $$ |____  $$ /$$__  $$ /$$__  $$                 
| $$  $$  | $$$$$$$$| $$  | $$| $$  \ $$| $$  \ $$  /$$$$$$$| $$  \__/| $$  | $$                 
| $$\  $$ | $$_____/| $$  | $$| $$  | $$| $$  | $$ /$$__  $$| $$      | $$  | $$                 
| $$ \  $$|  $$$$$$$|  $$$$$$$| $$$$$$$/|  $$$$$$/|  $$$$$$$| $$      |  $$$$$$$                 
|__/  \__/ \_______/ \____  $$|_______/  \______/  \_______/|__/       \_______/                 
                     /$$  | $$                                                                   
                    |  $$$$$$/                                                                   
                     \______/                                                                    
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

   Reference: https://stackoverflow.com/questions/47980316/move-a-control-smoothly-using-keydown-event

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shooting_Games.Classes
{
    class Keyboard
    {
        private static readonly HashSet<Keys> keys = new HashSet<Keys>();

        public static void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (keys.Contains(e.KeyCode) == false)
            {
                keys.Add(e.KeyCode);
            }
        }

        public static void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (keys.Contains(e.KeyCode))
            {
                keys.Remove(e.KeyCode);
            }
        }

        public static bool IsKeyDown(Keys key)
        {
            return keys.Contains(key);
        }
    }
}
