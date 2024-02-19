using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurviveLibrary
{
    public class Monster : Character
    {
        //FIELDS
        private int _minDamage;

        //PROPERTIES
        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }
        //CONSTRUCTORS
        public Monster(string name, int hitChance, int dodge, int maxLife,
            int maxDamage, int minDamage, string description)
            : base(name, hitChance, dodge, maxLife)
        {
            //MaxDamage must be set before MinDamage
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }
        //default ctor for default monsters later
        //If your parent class does not have a parameterless ctor, you CANNOT have one in the child classes
        public Monster() //: base()
        {

        }
        //METHODS
        public override string ToString()
        {
            return "****************** MONSTER ****************" +
                base.ToString() +
                $"Damage: {MinDamage} - {MaxDamage}\n +" +
                $"Description: {Description}";
        }


        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
        }

        public static Monster GetMonster()
        {
            //TODO - Come back and customize this list with you own monster subtypes
            Monster m1 = new("Black Bear", 48, 10, 50, 15, 2,
                "\r\n\r\n .'\"'.        ___,,,___        .'``." +
                "\r\n: (\\  `.\"'\"```         ```\"'\"-'  /) ;" +
                "\r\n :  \\                         `./  .'" +
                "\r\n  `.                            :.'" +
                "\r\n    /        _         _        \\" +
                "\r\n   |         0}       {0         |" +
                "\r\n   |         /         \\         |" +
                "\r\n   |        /           \\        |" +
                "\r\n   |       /             \\       |" +
                "\r\n    \\     |      .-.      |     /" +
                "\r\n     `.   | . . /   \\ . . |   .'" +
                "\r\n       `-._\\.'.(     ).'./_.-'" +
                "\r\n           `\\'  `._.'  '/'" +
                "\r\n             `. --'-- .'" +
                "\r\n               `-...-'" +
                "\r\n\r\n------------------------------------------------" +
                "\nAs dusk falls, a powerful silhouette emerges from the shadows: the black bear. With " +
                "\ngleaming eyes and a thunderous roar, it commands the forest with primal authority. " +
                "\nApproach cautiously, for in these woods, the black bear reigns as a formidable threat.");
            Monster m2 = new("Rattlesnake", 43, 9, 35, 13, 2, "" +
                "\n                        _,..,,,_" +
                "\r\n                     '``````^~\"-,_`\"-,_" +
                "\r\n       .-~c~-.                    `~:. ^-." +
                "\r\n   `~~~-.c    ;                      `:.  `-,     _.-~~^^~:." +
                "\r\n         `.   ;      _,--~~~~-._       `:.   ~. .~          `." +
                "\r\n          .` ;'   .:`           `:       `:.   `    _.:-,.    `." +
                "\r\n        .' .:   :'    _.-~^~-.    `.       `..'   .:      `.    '" +
                "\r\n       :  .' _:'   .-'        `.    :.     .:   .'`.        :    ;" +
                "\r\n       :  `-'   .:'             `.    `^~~^`   .:.  `.      ;    ;" +
                "\r\n        `-.__,-~                  ~-.        ,' ':    '.__.`    :'" +
                "\r\n                                     ~--..--'     ':.         .:'" +
                "\r\n                                                     ':..___.:'" +
                "\r\n\r\n------------------------------------------------\r\n" +
                "In the woods, a chilling sound cuts through the silence: the rattlesnake's warning. " +
                "\nWith deadly intent, it lurks, poised to strike from the shadows. Beware, for in " +
                "\nthese woods, the rattlesnake is a formidable threat.");
            Monster m3 = new("Bob Cat", 42, 9, 35, 11, 1, "" +
                "\n      ^     ^   " +
                "\n    (\"`-''-/\").___..--''\"`-._" +
                "\r\n     `6_ 6  )   `-.  (     ).`-.__.`)" +
                "\r\n     (_Y_.)'  ._   )  `._ `. ``-..-'" +
                "\r\n   _..`--'_..-_/  /--'_.' ,'" +
                "\r\n  (il),-''  (li),'  ((!.-'    " +
                "\r\n" +
                "\nIn the depths of the woods, a stealthy predator prowls: the bobcat. With keen eyes and " +
                "\nrazor-sharp claws, it moves with silent grace, ready to pounce upon unsuspecting prey. " +
                "\nBeware its feral presence, for in these woods, the bobcat is a formidable threat that " +
                "\nstrikes swiftly and without mercy.");
            Monster m4 = new("Coyote", 41, 10, 35, 10, 1, "" +
                "\n                         ___________" +
                "\r\n                    __.-' `     `  ``--.___" +
                "\r\n                  .'.        `     `  `    `-.___" +
                "\r\n                 / -                   ` `  ` `  `--." +
                "\r\n                / -                    -       `  `  `-." +
                "\r\n               /_ -        '           .-           . ` `.  .-." +
                "\r\n              /         |             - -'      `  / \\  ` `// |" +
                "\r\n             /      `       '        -        `   ||\\ `   //  |" +
                "\r\n           .'           |       '    -            || |'    `' '" +
                "\r\n         .'-       `    |  |  |    -   .     -  //       |    '" +
                "\r\n       .' -     `                     .         /       ` .-  `" +
                "\r\n     .'   - '      `   /.|'`.   |   /        /       ` o ||o' `" +
                "\r\n    J     )  '        /'  ``|`|    /         /  /       `||'.'" +
                "\r\n    |__.-'7'       .-'  \\ `   ``.       |     / / /  .  '|||" +
                "\r\n      _.-'      .-'      \\` '   /`.     \\ ___  / '.  \\\\  |||" +
                "\r\n     /     __.-'         | '   /  |     |    `-----'-.\\\\ ( )" +
                "\r\n    /   .-'              J    /   |     |      |       \\`-<" +
                "\r\n   /   /                 F   J     \\    |       \\       `-'" +
                "\r\n  /   /                 /   |       |   |        `-._     )" +
                "\r\n |   /                 (    |       | \\ )            `.   |" +
                "\r\n-`---`--------.---------`.   `.     \\   \\             /'  | ------------" +
                "\r\n  .-.___`-.___ `._   ---. `.   `.___ \\   \\           |   /   " +
                "\r\n ------    `---._    `------\\_____)_\\_\\   \\_          \\='|  " +
                "\r\n __.-.      --.        `-----.____    '._/__`._  ___   \\=/   " +
                "\r\n    .--           -.  -                        `-   `------.--.__.---'" +
                "\r\n\r\n------------------------------------------------" +
                "\nIn the shadows of the woods, a cunning menace lurks: the coyote. With a haunting howl that " +
                "\npierces the night, it slinks silently through the underbrush, eyes gleaming with " +
                "\npredatory intent. Beware its stealthy approach, for in these woods, the coyote is a " +
                "\nrelentless hunter, ready to ambush its prey at any moment.");
            Monster m5 = new("Mothman", 45, 8, 50, 12, 2, " " +
                "\n                    |====|" +
                "\r\n  _____________   %%% o o%_________" +
                "\r\n (___________,,)  %c    >) ,________)" +
                "\r\n    (_________,,)  )   =  ,______)" +
                "\r\n         (_____,,)/ _/__,,____)" +
                "\r\n            / \\   \\__/ /\\" +
                "\r\n           /\\ |        \\/\\" +
                "\r\n          /__\\|'   ,   /  \\," +
                "\r\n         < -  '====o==,  /_\\" +
                "\r\n        /    /`       |\\ __ \\" +
                "\r\n       /__,_/    |  _/, \\____\\" +
                "\r\n       //   |     \\/  \\    \\\\" +
                "\r\n     _( \\   \\      \\  \\   _/ \\" +
                "\r\n      //|    \\     \\  \\    |/|" +
                "\r\n             < `  _\\ -)" +
                "\r\n            /    |_/ |" +
                "\r\n           |    / |_/" +
                "\r\n          /-_,  ' /|" +
                "\r\n          \\/ \\_,--.," +
                "\r\n          '(    )'" +
                "\r\n         / |    | \\" +
                "\r\n         |,/    \\,/     " +
                "\r\n\r\n------------------------------------------------" +
                "\nIn the depths of the woods, a legendary terror stirs: the Mothman. With glowing eyes that " +
                "\npierce the darkness and wings spanning the sky, it descends upon its unsuspecting prey " +
                "\nwith eerie precision. Beware its supernatural presence, for in these woods, the Mothman " +
                "\nis an ominous threat that strikes fear into the hearts of all who dare to cross its path.");
            Monster m6 = new("Wendigo", 47, 8, 50, 14, 2, "                           .-.      .-.\r\n                     _..--'`;;`-..-';;'`--.._\r\n                   .';,    _   `;;'   _    ,;`.\r\n                  ;;'  `;;' `;.`;;'.;' `;;'  `;;\r\n                 .;;._.;'`;.   `;;'   .;'`;._.;;.\r\n               ;'      '`;;`   `;;'   ';;'`      `;\r\n              ;:     .:.  `;;. `--' .;;'  .:.     :;\r\n               ;.   .:|:.     `;;;;'     .:|:.   .;\r\n                `;  `:|:'    .;;'`;;.    `:|:'  ;'\r\n                 `;. `:'  .;;'.::::.`;;.  `:' .;'\r\n                   `;._.;;' .:`::::':. `;;._.;'\r\n              .::::. `::   (:._.::._.:)   ::' .::::.\r\n         .:::::'  `::.`:_.--.`:::::. .--._:'.::'  `:::::.\r\n       .::'     `:.MJP `::-.:::\"\"\"\":::.-::'   `::      `::.\r\n     .::'      .::'      | /.^^^..^^^.\\ |      `::        `:.\r\n     :::      .:'::.     \\( `;;;..;;;' )/     .::::       :::\r\n     ::  :  .:':.  `::.   \\            /   .::'  .:     .  ::\r\n     :  ::  .   :     `::.              .::'     :  :   ::  :\r\n    .:  :    `.::.       `:.          .:'       .::.'    :  :.\r\n   ::  :  :   : :::.       `:.      .:'       .::: :   :  :  ::\r\n   ::  :        :' `:.       :.    .:       .:' `:        :  ::\r\n   :::     :   ::    `:.      :.  .:      .:'    ::   :     :::\r\n   ' :       :::'      :.      `::'      .:      `:::       : `\r\n\r\n-----------------------------------------------" +
                "\nIn the eerie silence of the woods, a malevolent presence looms: the Wendigo. With elongated " +
                "\nlimbs and hollow eyes burning with hunger, it stalks its prey with relentless determination. " +
                "\nBeware its insatiable appetite, for in these woods, the Wendigo is a terrifying force of " +
                "\nnature that devours all who dare to venture too close.");
            Monster m7 = new("Black Widow", 44, 6, 30, 12, 1, " " +
                "\r\n       ::                     ::       " +
                "\r\n       ::                     ::       " +
                "\r\n       ':                     :         " +
                "\r\n        :.                    :         " +
                "\r\n     ;' ::                   ::  '     " +
                "\r\n    .'  ';                   ;'  '.     " +
                "\r\n   ::    :;                 ;:    ::   " +
                "\r\n   ;      :;.             ,;:     ::   " +
                "\r\n   :;      :;:           ,;\"      ::   " +
                "\r\n   ::.      ':;  ..,.;  ;:'     ,.;:   " +
                "\r\n    \"'\"...   '::,::::: ;:   .;.;\"\"'     " +
                "\r\n        '\"\"\"....;:::::;,;.;\"\"\"         " +
                "\r\n    .:::.....'\"':::::::'\",...;::::;.   " +
                "\r\n   ;:' '\"\"'\"\";.,;:::::;.'\"\"\"\"\"\"  ':;   " +
                "\r\n  ::'         ;::;:::;::..         :;   " +
                "\r\n ::         ,;:::::::::::;:..       :: " +
                "\r\n ;'     ,;;:;::::::::::::::;\";..    ':. " +
                "\r\n::     ;:\"  ::::::\"\"\"'::::::  \":     :: " +
                "\r\n :.    ::   ::::::;  :::::::   :     ; " +
                "\r\n  ;    ::   :::::::  :::::::   :    ;   " +
                "\r\n   '   ::   ::::::....:::::'  ,:   '   " +
                "\r\n    '  ::    :::::::::::::\"   ::       " +
                "\r\n       ::     ':::::::::\"'    ::       " +
                "\r\n       ':       \"\"\"\"\"\"\"'      ::       " +
                "\r\n        ::                   ;:         " +
                "\r\n        ':;                 ;:\"         " +
                "\r\n          ';              ,;'           " +
                "\r\n            \"'           '\"             " +
                "\r\n\r\n------------------------------------------------\r\n" +
                "\nEmerging from the shadows with stealthy grace, its sleek black form moves with sinister intent, " +
                "\neight glistening legs poised to strike. The distinctive crimson hourglass adorning its " +
                "\nabdomen serves as a warning, a symbol of the venomous potency lurking within.");
            Monster m8 = new("Copperhead Snake", 49, 5, 35, 11, 1, "" +
                "\n   _________         _________" +
                "\r\n  /         \\       /         \\   " +
                "\r\n /  /~~~~~\\  \\     /  /~~~~~\\  \\   "+
                "\r\n |  |     |  |     |  |     |  |" +
                "\r\n |  |     |  |     |  |     |  |" +
                "\r\n |  |     |  |     |  |     |  |         /" +
                "\r\n |  |     |  |     |  |     |  |       //" +
                "\r\n(o  o)    \\  \\_____/  /     \\  \\_____/ /" +
                "\r\n \\__/      \\         /       \\        /" +
                "\r\n  |         ~~~~~~~~~         ~~~~~~~~" +
                "\r\n  ^" +
                "\r\n\r\n------------------------------------------------" +
                "\nA sinister hiss slices through the tranquility of the woods, heralding the arrival of a stealthy " +
                "\npredator: the copperhead snake. Slithering from the underbrush with sinuous grace, its scales " +
                "\nshimmering with iridescent hues of copper and bronze, the serpent moves with deadly intent. " +
                "\nIts triangular head, adorned with menacing eyes, darts back and forth, calculating its next " +
                "\nstrike.");
            MilkSnake s1 = new MilkSnake("Milk Snake", 50, 5, 30, 10, 1, "                           ____" +
                "\r\n  ________________________/ O  \\___/" +
                "\r\n <_/_\\_/_\\_/_\\_/_\\_/_\\_/_______/   \\" +
                "\r\n\r\n------------------------------------------------" +
                "\nIn the shadows of the dense woods, a seemingly harmless figure slithers forth: the milk snake. " +
                "\nWith vibrant bands of red, black, and yellow, it coils with deceptive elegance, masking its " +
                "\nvenomous potential. Beware its camouflaged approach, for in these woods, the milk snake may strike " +
                "\nwithout warning, posing a lethal threat to those who underestimate its deadly capabilities.", true);
            SkinWalker w1 = new SkinWalker("Skin Walker", 46, 7, 50, 13, 2, "" +
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
                "\r\n\r\n----------------------------------------------" +
                "\nA harmful entity who has the ability to turn into, possess, or disguise themselves as an animal. " +
                "\nWith eyes ablaze with malevolence and shrouded in the guise of darkness, it moves with uncanny " +
                "\nstealth, shifting between forms with chilling ease. Beware its shape-shifting prowess, for in " +
                "\nthese woods, the Skinwalker is a sinister threat that preys upon the unsuspecting with unholy " +
                "\nintent.", true);
            

            List<Monster> monsters = new List<Monster>()
            { m1, 
            m2, m2,
            m3, m3,
            m4, m4,
            m5, 
            m6,
            m7, m7,
            m8, m8,
            s1, s1,
            w1
            };

            int randomIndex = new Random().Next(monsters.Count);
            Monster monster = monsters[randomIndex];
            return monster;

        }
    }
}
