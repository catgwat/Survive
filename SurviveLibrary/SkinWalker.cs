using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurviveLibrary
{
    internal class SkinWalker : Monster
    {
        public bool IsManipulative { get; set; }



        //CONSTRUCTORS
        public SkinWalker(string name, int hitChance, int dodge, int maxLife, int maxDamage, int minDamage, string description,
            bool isManipulative)
             : base(name, hitChance, dodge, maxLife, maxDamage, minDamage, description)
        {
            IsManipulative = isManipulative;
            if (isManipulative == true)
            {
                MaxDamage += 5;
                MaxLife += 5;
                Life = MaxLife;
                HitChance -= 10;
                Description = "" +
                    "\r\n\r\n                             .-," +
                    "\r\n                ,---._   _  -' >" +
                    "\r\n               | \"\\ \\\\\\ //_=33'" +
                    "\r\n               7-_ || \\//-' //" +
                    "\r\n               |\"= / -'/'' |/" +
                    "\r\n           __-'_   -'-/__  ||" +
                    "\r\n          / ,--'     / ,-'-||" +
                    "\r\n         /  /  ___ //    ,-||_" +
                    "\r\n        /  _--/_  '-    / \\|_';" +
                    "\r\n       |  /  // \"\\\\\\   /     \"" +
                    "\r\n       / /  //        |   , -'" +
                    "\r\n      /  ;,//,        /  /,  \\" +
                    "\r\n     |   |_/  |      /  / /  |" +
                    "\r\n     '-\\/\\_,_,/ _   V  /\\,7-\"'" +
                    "\r\n        '    /   ''---'  |" +
                    "\r\n             |      \\\\   |" +
                    "\r\n             |       \\\\  |" +
                    "\r\n             |       |\\\\ /" +
                    "\r\n             | \\     /|\\|" +
                    "\r\n             |  |    || ;" +
                    "\r\n             |  |   /|| ;" +
                    "\r\n             |  | ,/ / /" +
                    "\r\n             |  \\ / \\/ |" +
                    "\r\n            /    | \\_//" +
                    "\r\n            |    | \"\" /" +
                    "\r\n           ,'   ,'  |,'" +
                    "\r\n           /      \\| |" +
                    "\r\n          /     /  \\ |" +
                    "\r\n         /     /   / \\" +
                    "\r\n        /     /   / ,/" +
                    "\r\n       //  /       /\\\\" +
                    "\r\n    _-'/        ,-' | )" +
                    "\r\n ,-'       \\_   \\   \\ |" +
                    "\r\n/__,--      _,-\"\"  /   \\" +
                    "\r\n    \\____,-'       '---'" +
                    "\r\n\r\n------------------------------------------------" +
                    "\nA harmful entity who has the ability to turn into, possess, or disguise themselves as an animal." +
                    "\nWith eyes ablaze with malevolence and shrouded in the guise of darkness, it moves with uncanny " +
                    "\nstealth, shifting between forms with chilling ease. Beware its shape-shifting prowess, for in " +
                    "\nthese woods, the Skinwalker is a sinister threat that preys upon the unsuspecting with unholy " +
                    "\nintent.";
            }

        }

        //METHODS

        public override string ToString()
        {
            return $"{base.ToString()} Enhancement: terrifying, manipulative, and sneaky!\n +5 Damage \n +5 Max Life \n -10 Hit Chance";
        }
    }
}
