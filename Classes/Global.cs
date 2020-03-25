/*
 
 
   /$$$$$$  /$$           /$$                 /$$        /$$$$$$  /$$                             
 /$$__  $$| $$          | $$                | $$       /$$__  $$| $$                             
| $$  \__/| $$  /$$$$$$ | $$$$$$$   /$$$$$$ | $$      | $$  \__/| $$  /$$$$$$   /$$$$$$$ /$$$$$$$
| $$ /$$$$| $$ /$$__  $$| $$__  $$ |____  $$| $$      | $$      | $$ |____  $$ /$$_____//$$_____/
| $$|_  $$| $$| $$  \ $$| $$  \ $$  /$$$$$$$| $$      | $$      | $$  /$$$$$$$|  $$$$$$|  $$$$$$ 
| $$  \ $$| $$| $$  | $$| $$  | $$ /$$__  $$| $$      | $$    $$| $$ /$$__  $$ \____  $$\____  $$
|  $$$$$$/| $$|  $$$$$$/| $$$$$$$/|  $$$$$$$| $$      |  $$$$$$/| $$|  $$$$$$$ /$$$$$$$//$$$$$$$/
 \______/ |__/ \______/ |_______/  \_______/|__/       \______/ |__/ \_______/|_______/|_______/ 
                                                                                                 
                              Survival Z Mini Game 1.0 
                                                        Developed by: https://github.com/eksqtr
 
 
 */






using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Shooting_Games.Classes
{
    public static class Global
    {
        public const int
            FACING_DIRECTION_UP =                   0,
            FACING_DIRECTION_DOWN =                 1,
            FACING_DIRECTION_RIGHT =                2,
            FACING_DIRECTION_LEFT =                 3,
            FACING_DIRECTION_UPLEFT =               4,
            FACING_DIRECTION_UPRIGHT =              5,
            FACING_DIRECTION_DOWNLEFT =             6,
            FACING_DIRECTION_DOWNRIGHT =            7;

        public const int
            MAX_ZOMBIES =                           10,
            MAX_WEAPON_HANDGUN_AMMO =               7,
            MAX_WEAPON_ASSAULT_AMMO =               15;

        public const int
            WEAPON_TYPE_HANDGUN =                   1,
            WEAPON_TYPE_ASSAULT =                   2;


        public const int
            WALL_BOUNDERY_TOP =                     0,
            WALL_BOUNDERY_LEFT =                    1,
            WALL_BOUNDERY_RIGHT =                   2,
            WALL_BOUNDERY_BOTTOM =                  3;

        public static int[,] ZOMBIE_SPAWN_POS = new int[,] 
            {
                {217 ,99 }, {1190 ,533 }, {245 ,520 }, {1190 ,101 }, {404 ,106 }, {1189 ,366 }, {445 ,504 }, 
                {1058 ,108 }, {246 ,271 }, {1197 ,249 }, {254 ,401 }, {1093 ,535 }, {727 ,97 }, {728 ,518 },

            };
        public static Rectangle[] boundery = new Rectangle[4];

    }
}

