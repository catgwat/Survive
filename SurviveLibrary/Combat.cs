using SurviveLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //make it public
    public class Combat
    {
        //not a dataype class, just a method warehouse.
        public static void DoAttack(Character attacker, Character defender)
        {
            //find the adjusted hit chance:
            int chance = attacker.CalcHitChance() - defender.CalcDodge();

            //get a random number from 1-100
            int roll = new Random().Next(1, 101);

            //To slow the program and make the user think something is happening, we can 
            //tell the thread to sleep (Sytem.Threading)
            Thread.Sleep(500);

            //the attacker "Hits" if the roll is less than the adjusted hit chance
            if (roll < chance)
            {
                //Calculate the damage
                int damage = attacker.CalcDamage();

                //Subtract the damage from the defender's life
                defender.Life -= damage;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damage} damage!");
                Console.ResetColor();
            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{attacker.Name} missed!");
                Console.ResetColor();

            }

        }

        public static bool DoBattle(Player player, Monster monster)
        {
            #region Potential Expansions
            //Initiative property on the Character class
            //if (player.Initiative >= monster.Initiative)

            //Racial or weapon bonus
            //if (player.PlayerRace == Race.Herengon) { DoAttack (player, monster) }
            #endregion

            DoAttack(player, monster);
            //if the monster is still alive, they get to attack.
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
                return false;//we did not kill the monster
            }
            else
            {
                #region Potential Expansion - Combat Rewards
                //you could add logic here to grant player life
                //player.Life += player.MaxLife / 10

                //int coins = new Random ().Next(1,11);
                #endregion

                player.Score++;
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"\nYou killed {monster.Name}!\n");
                Console.ResetColor();
                return true; //victory!! (monster is dead)
            }
        }
    }
}