using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurviveLibrary
{
    public class Player : Character
    {
        //PROPERTIES
        public Race PlayerRace { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public int Score { get; set; }
        


        //CONSTRUCTORS

        public Player(string name, int hitChance, int dodge, int maxLife, Race playerRace, Weapon equippedWeapon) : base(name, hitChance, dodge, maxLife)
        {
            PlayerRace = playerRace;
            EquippedWeapon = equippedWeapon;
            
            
            switch (PlayerRace)
            {
                case Race.Park_Ranger:
                    Life = MaxLife += 5;
                    HitChance -= 10;
                    Dodge += 5;
                    break;
                case Race.Granola_Hiker:
                    Life = MaxLife += 2;
                    HitChance -= 5;
                    Dodge += 2;
                    break;
                case Race.Rookie_Hiker:
                    Life = MaxLife -= 2;
                    HitChance += 10;
                    Dodge -= 5;
                    break;
                default:
                    break;
            }
        }


        //METHODS

        public override string ToString()
        {
            string description = "";
            switch (PlayerRace)
            {
                case Race.Park_Ranger:
                    description = "Park Ranger - The most advanced and best equipped!";
                break;
                case Race.Granola_Hiker:
                    description = "Granola Hiker - They have prepared for this by training and spending LOTS of money at REI.";
                break;
                case Race.Rookie_Hiker:
                    description = "Rookie Hiker - Their heart is in the right place..maybe not their strength and stamina though...";
                break;
                default:
                break;
            }
                return base.ToString() + $"Score: {Score}" +
                $"\nWeapon: {EquippedWeapon.Name}\n" +
                $"Description: {description}";
        }
        public override int CalcDamage()
        {
            //create a random object
            Random rand = new Random();

            //determine damage
            int damage = rand.Next(EquippedWeapon.MinDamage,
                EquippedWeapon.MaxDamage + 1);

            //return damage
            return damage;
        }
        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;
        }
        
    }
}
