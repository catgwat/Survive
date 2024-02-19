using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurviveLibrary
{
    public class MilkSnake : Monster
    {
        //FIELDS
        //--ONLY IF YOU HAVE BUSINESS RULES

        //PROPERTIES
        public bool IsQuick { get; set; }
        


        //CONSTRUCTORS
        public MilkSnake(string name, int hitChance, int dodge, int maxLife, int maxDamage, int minDamage, string description,
            bool isQuick)
             : base(name, hitChance, dodge, maxLife, maxDamage, minDamage, description)
        {
            IsQuick = isQuick;
            if (isQuick == true)
            {
                HitChance -= 5;
                Description = 
                    "\n\n                           ____" +
                    "\r\n  ________________________/ O  \\___/" +
                    "\r\n <_/_\\_/_\\_/_\\_/_\\_/_\\_/_______/   \\" +
                    "\r\n\r\n------------------------------------------------" +
                    "\nIn the shadows of the dense woods, a seemingly harmless figure slithers forth: the milk snake. " +
                    "\nWith vibrant bands of red, black, and yellow, it coils with deceptive elegance, masking its " +
                    "\nvenomous potential. Beware its camouflaged approach, for in these woods, the milk snake may strike " +
                    "\nwithout warning, posing a lethal threat to those who underestimate its deadly capabilities.";
            }
            
        }
        
        //METHODS

        public override string ToString()
        {
            return $"{base.ToString()} Enhancement: Super fast!\n -5 Hit Chance";
        }

        
    }
}
