using DungeonLibrary;
using SurviveLibrary;
using System.Numerics;
using System.Threading;

namespace Survive
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Title / Introduction
            Console.WriteLine("\tWelcome to \"Survive,\" an adrenaline-pumping console adventure where you embark on an epic journey  " +
                "\nthrough the untamed wilderness of the Appalachian Mountains. Prepare to test your courage, wit, " +
                "\nand strength as you traverse rugged terrains, battle fierce creatures, and uncover the " +
                "\nmysteries lurking within the ancient forests." +
                "\r\n\r\n\tIn this immersive game, you'll step into the boots of a fearless hiker, determined to conquer " +
                "\nthe challenges that await. From elusive cryptids to dangerous beasts, every encounter will push you " +
                "\nto your limits as you fight for survival against the unknown." +
                "" +
                "\r\n\r\nAre you ready to face the dangers of the wilderness and emerge victorious against the odds?");
            Console.WriteLine("\n\n*****Please maximize your console window for the best experience!");
            Console.Write("\n\nPress any key to continue...");
                Console.ReadLine();
                Console.Clear();

            Console.WriteLine("  \r\n                                                        ," +
                "\r\n                                            .__ ._       \\_." +
                "\r\n                                     _, _.  '  \\/   \\.-  /" +
                "\r\n                                      \\/     .-_`   // |/     \\," +
                "\r\n                     .-\"\"\"\"-.          \\.   '   \\`. ||  \\.-'  /" +
                "\r\n                    F        Y        .-.`-(   _/\\ V/ \\\\//,-' >-'   ._," +
                "\r\n                   F          Y   .__/   `. \\.   ' J   ) ./  / __._/" +
                "\r\n                  J         \\, I    '   _/ \\  \\  | |  / /  .'-'.-' `._," +
                "\r\n           (       L   \\_.--.| \\_.      ' .___ `\\: | / .--'.-'\"     \\" +
                "\r\n         \\ '\\    .  L   /    \\\\/        ._/`-.`  \\ .'.' .'---./__   '" +
                "\r\n    \\__  '\\ ) \\._/   `-.__. ` \\\\_. '   .---.  \\     /  /  ,   `  `" +
                "\r\n  --'  \\\\  ): // \\,            `-.`__.'     `- \\  /   / _/-.---.__.- ." +
                "\r\n     _.-`.'/ /'\\_, ._     >--.-\"\"'____.--\"`_     '   /.'..' \\   \\   _/`" +
                "\r\n _ .---._\\ \\'/ '__./__.-..  / .-|(    x_.-'___  |   :' /    _..---_' \\" +
                "\r\n .:' /`\\ `. `..'.--'\\      /.' /`-`._  `-,'   ` '   I '_.--'__--..___.--._.-" +
                "\r\n     `  `. `\\/'/  _.   _.-'      _.____./ .-.--\"\"-. .-\"    ' _..-.---'   \\" +
                "\r\n  -._ .--.\\ / /-./     /   .---'-//.___. .-'       \\__ .--.  `    `.     '`-" +
                "\r\n ,--'/.-. ^.   .-.--.  ` _/    _//     ./   _..   .'  `.    \\ \\    |_." +
                "\r\n    /' | >.   ' | \\._.-       '    _..'  `.' . `.       )    | |\\  `" +
                "\r\n  ./ \\ \\'  ) c| /  \\     \\_..  .--'    ,\\ \\_/`  :    )  (`-. `.|`\\\\" +
                "\r\n   \\'  / ,-.  | ` ./`  ._/ `\\\\'.--.,-((  `.`.__ |   _/   \\    |)  `--._/`" +
                "\r\n______'\\   |  < __________  //'  //  _)   )/-._`.  (,-')  )  / \\_.    /\\. _____" +
                "\r\n           |  |        .__./    //  '\\  |//    `.\\ '\\ (  (  <`   ._  '" +
                "\r\n           >  |      _.  /   ..-\\ _    _/ \\_.  \\ `\\    \\_ `---.-'__" +
                "\r\n        . /  `-   _.'        /   `   _/|       J  /`     `-,,-----.`-." +
                "\r\n            '  .:'          '`      '          < `   f  I //        `­\\_," +
                "\r\n              '                         \\.     J        I/\\_.        ./" +
                "\r\n         __/                            `:     I  .:    K  `          `" +
                "\r\n         \\/ )                            `,   J         L" +
                "\r\n          )_(_                             .  F  .-'    J" +
                "\r\n         /    `.                           .  I  (.   . I _.-.._" +
                "\r\n   '    <'    \\ )                     _.---.J/      :'   L -'" +
                "\r\n .:.     \\. _.->/                        _.-'_.)     ` `-.`---.,_." +
                "\r\n:<        (    \\                    .--\"\"   .F' J) `.`L.__`-.___" +
                "\r\n.:        |-'\\_.|                          Y ..Z     ))   `--'  `-" +
                "\r\n.         ) | > :                            . '    :'" +
                "\r\n          / ) L_J                            .x,." +
                "\r\n          L_J .,                             .:<.," +
                "\r\n        .'`   `                               :J.,`" +
                "\r\n                                           . ;.+K,:." +
                "\r\n                                               .,L+.," +
                "\r\n\r\n------------------------------------------------\r\n");
            Console.Write("\nPress any key to continue...");
            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Player set up
            //WEAPON SET UP!!!!!

            Console.WriteLine("But first we must pick our gear and level of expertise..." +
                "\nType the corresponding number to choose a weapon from the list below:\n");
  
            Weapon w1 = new Weapon("HydroFlask", 5, 18, 1, false, WeaponType.Hydro_Flask);

            Weapon w2 = new Weapon("Pocket Knife", 5, 19, 4, false, WeaponType.Pocket_Knife);

            Weapon w3 = new Weapon("Bear Spray", 5, 18, 0, true, WeaponType.Bear_Spray);

            Weapon w4 = new Weapon("Trekking Poles", 5, 17, 1, true, WeaponType.Trekking_Poles);

            Weapon w5 = new Weapon("Hiking Staff", 5,16, 2, true, WeaponType.Hiking_Staff);

            Weapon w6 = new Weapon("Machete", 5, 20, 3, false, WeaponType.Machete);

            Weapon w7 = new Weapon("Flashlight", 5, 15, 4, false, WeaponType.Flashlight);
                
            List<Weapon> weapons = new() { w1, w2, w3, w4, w5, w6, w7 };

            for (int i = 0; i < weapons.Count; i++)
            {
                Console.WriteLine($"{i+1}) {weapons[i].Name}");
            }
            int.TryParse(Console.ReadLine(), out int index);
            index--;
            Weapon wChoice = weapons[index];
            Console.WriteLine(wChoice);

            //RACE SET UP!!!!!!!!!
            Console.WriteLine("Please choose the number corresponding to the level of experience you'd like\n your hiker to have from the list below:\n");
            Race r1 = Race.Park_Ranger;
            Race r2 = Race.Granola_Hiker;
            Race r3 = Race.Rookie_Hiker;

            List<Race> races = new() { r1, r2, r3 };
            for (int i = 0; i < races.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {races[i].ToString().Replace('_',' ')}");
            }
            int.TryParse(Console.ReadLine(), out index);
            index--;
            Race rChoice = races[index];
            Console.WriteLine($"Nice! You chose {rChoice.ToString().Replace('_', ' ')}.");

            //PLAYER SET UP!!!!!!!!!!
            Console.WriteLine("Finally, please choose the number corresponding to the character you would like to play as:\n");
            Player c1 = new Player("Amy", 48, 6, 95,rChoice,wChoice);
            Player c2 = new Player("Kristin", 46, 10, 95, rChoice, wChoice);
            Player c3 = new Player("Catie", 44, 9, 95, rChoice, wChoice);
            Player c4 = new Player("Dick", 50, 7, 95, rChoice, wChoice);
            Player c5 = new Player("DJ", 40, 5, 95, rChoice, wChoice);
            Player c6 = new Player("Chase", 42, 30, 95, rChoice,wChoice);

            List<Player> players = new() { c1, c2, c3, c4, c5, c6 };
            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine($"{i +1}) {players[i].Name}\n\tHit Chance:{players[i].HitChance}\n\tDodge:{players[i].Dodge}");
            }
            int.TryParse(Console.ReadLine(), out index);
            index--;
            Player pChoice = players[index];
            Console.WriteLine($"\n\nWelcome to the wilderness, {pChoice}! \n\nPrepare to survive Appalachia..."); 
            
            #endregion

            #region Main Game Loop

            bool exit = false;//if true, quit the whole game
                do
                {
                
                    Monster monster = Monster.GetMonster();
                    
                    string room = GetRoom();
                    Console.WriteLine(room);
                    Console.WriteLine($"{monster.Name} - {monster.Description}");
                    #region Encounter loop
                    bool newRoom = false;
                do
                {
                    #region MENU
                    //Prompt the user
                    Console.Write("\nPlease choose an action:\n" +
                        "A) Attack\n" +
                        "R) Run away\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit\n");

                    string userChoice = Console.ReadKey(true).Key.ToString();
                    Console.Clear();


                    switch (userChoice)
                    {
                        case "A":
                            Console.WriteLine("ATTACK!");
                            bool deadMonster = Combat.DoBattle(pChoice, monster);
                            newRoom = deadMonster;
                                break;

                        case "R":
                            //TODO monster free attack chance
                            Console.WriteLine("Run away!!!");
                            Console.WriteLine($"{monster.Name} attacks you as you flee...");
                            Combat.DoAttack(monster, pChoice);
                            Console.WriteLine();
                            newRoom = true;
                            break;

                        case "P":
                            Console.WriteLine($"Behold, a hiker...{pChoice}");
                            if (pChoice.Score == 2)
                            {
                                (pChoice.Life) += 60;
                                Console.WriteLine("Tough work slaying all of these beasts-- time for a bandaid, protein bar, and some electrolytes. Ah, +60 to life feels good.");
                                Console.WriteLine();
                            }
                            break;

                        case "M":
                            Console.WriteLine($"Monster stats: {monster}");
                            break;

                        case "X":
                            Console.WriteLine("No one likes a quitter.");
                            exit = true;
                            break;

                        default:
                            #region Invalid input
                            Console.WriteLine("You have made a grave error. Want to try again?");
                            #endregion
                            break;
                    }

                    #endregion

                    #region Check player life

                    

                        if (pChoice.Life <= 0)
                        {
                            Console.WriteLine("Oh no...you died, dead!\a");
                            exit = true; //end the game
                        }
                    
                    #endregion
                } while (!newRoom && !exit);//while both newRoom and exit are not true, keep looping.
                    #endregion
                } while (!exit);//while exit is not true, keep looping

            #endregion

            #region Outro
            Console.WriteLine($"You defeated {pChoice.Score} monsters!");
            Console.ReadKey(true);
            #endregion
        } 

            private static string GetRoom()
            {
                string[] rooms =
                {
                "You have hiked to the New Hampshire White Mountains and there is a creature approaching!", //0
                "You have hiked to southern Maine and there is a creature approaching!", //1
                "You have hiked to 'The Roller Coaster' and there is a creature approaching!", //2
                "You have hiked to northern Pennsylvania and there is a creature approaching!", //3
                "You have hiked to Mt. Katahdin and there is a creature approaching!", //4
                "You have hiked to southern Virginia and there is a creature approaching!", //5
                "You have hiked to Springer Mountain and there is a creature approaching!", //6
                "You have hiked to Max Patch and there is a creature approaching!", //7
                "You have hiked to McAfee Knob and there is a creature approaching!", //8a
                "You have hiked to The Shenandoahs and there is a creature approaching!", //9
                
            };
                Random rand = new Random();

                int index = rand.Next(rooms.Length);

                string room = rooms[index];

                return room;

            //    //refactoring -> rewriting code
            //    //return rooms[new Random().Next(rooms.Length)];
            }
        
    }
}
