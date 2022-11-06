// The Magnificent Mile: Zombie Apocolypse 
// By Gianna G. Dimperio
// Fall 2022
// This is work derivative of "C# Adventure Game" by http://programmingisfun.com/learn/c-sharp-adventure-game/


using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.X86;
using System.Collections.Generic;
using static System.Console;
using TheMagnificentMileZombieApocolypse;
using TheMagnificentMile;
using System.Runtime.CompilerServices;

namespace Adventure

{

    class Game
    {
        private static string CharacterName;
        public Location MyLocation;
        public Player MyPlayer;
        static int Scenarios = 3;
        static List<string> inventory = new List<string>();


        static string[] PartOne = {
            "\"Your walking on a busy side walk and you see hands, legs, and heads arise from the ground.\nFurther ahead, see a frightened man. You run up to him to bargain your $2 for either a flashlight or an umbrella.\nTo choose type either (A) for the Flashlight, or (B) for the umbrella.",
            "\"All the power went out in the city! But atleast you have gotten yourself a flashlight! \nYou shine your flashlight around to see shadow of a zombie... \nYou move the light around and something glitters...\nIts a coin!",
            "\"All the power went out in the city! You see a shadow of a zombie! \nSo you move the umbrella in a widening arc, scaring it off.",
            "\"You continue your walk... \nA couple minutes later, we see one coming straight at you, so fast, yet so sluggishly. \n" + CharacterName + " what do you want to do? (A) Turn around and run, or (B) utilize your item(s)?",
            "\"Your running and as the zombie catches up....",
            "\"Your thankful in this moment for that frightened looking man with the bag. \nYou use your item(s) to distract the zombies focus elsewhere. Whew!",
            "\"Wow" + CharacterName + " you have done wonders thus far! Keep going to recieve even more coins and items!",
        };
        static string[] PartTwo ={
            "\"As you continue your walk, the camraderie and panic everyone is feeling is universal. \nYou are thinking of what to do, continue your mission or try to calm down the cities people? \nTo choose enter either (A) for continue your mission, or (B) to help the cities people.",
            "\"You choose to continue your mission.",
            "\"You are running up to random pedestrians talking them down...but...",
            "\"A zombie is running full force towards you, you have 1 coin, and 1 item(s). \nBut there is a couple cents on the floor and you grab them to bargain. \nYou see a water bottle you can buy for all your coins, or bargain for a golden sword. \nChoose either (A) for a water bottle for more energy, or (B) for the golden sword",
            "\"You pick up the water bottle and never felt more energized to attack these zombies once and for all!",
            "\"You grab the golden sword as fast as you can and kill your first Zombie!",
            "\"You sneak into a building to get yourself together and have a moment to asses and figure out the plan of action. "
        };
        static string[] PartThree ={
            "\"As you step inside of one of the tall skyscrapers, its quiet, so quiet you can hear a pin drop. \nYou suspiciously and consciously look around the old building. \nYou hear a grunt and as you turn around you see a zombie! \n Do you want to use one of your items or run and lock the door somewhere in the building? \nTo choose enter (A) to use an item, and (B) to lock a door in the building. Hurry!",
            "\"You grab your item(s) to distract the zombie in the opposite direction, but it is not working as well as the first time around...",
            "\"You sprint to the oppotsite way of the zombie. \nThank gosh those suckers can't run fast! \nYou lock yourself in an unknown location and panickly baracades the door for saftey.",
            "\"You take a second to catch your breath...",
            "\"You throw the umbrella frustrated it is not working, and grab your sword! \nThe sword grazes the zombie and you notice that the zombie immediatley turns into dust as if they are allergic to the material the sword is made of. Bingo! You have just earned another coin, " + CharacterName + "Congratulations!",
            "\"Your holding you mouth close so the zombie can't even hear you breath. \nThere is no grunting sounds and so your ready to continue.",
            "\"You slyly and quietly leave the large building you were in.",
        };
        public static void StartGame()
        {
            GameTitle();

            //intro text
            Console.WriteLine("You are about to enter the headquarters of The Zombie Apocalypse on the Magnificent Mile.");
            Console.Title = @"Zombie Art";
            string title = @"
                                    _,--~~~,
                                   .'        `.
                                   |           ;
                                   |           :
                                  /_,-==/     .'
                                /'`\*  ;      :      
                              :'    `-        :      
                              `~*,'     .     :      
                                 :__.,._  `;  :      
                                 `\'    )  '  `,     
                                     \-/  '     )     
                                     :'          \ _
                                      `~---,-~    `,)
                      ___                   \     /~`\
                \---__ `;~~~-------------~~~(| _-'    `,
              ---, ' \`-._____     _______.---'         \
             \--- `~~-`,      ~~~~~~                     `,
            \----      )                                   \
            \----.  __ /                                    `-
             \----'` -~____  
                           ~~~~~--------,.___     -szaman-
                                             ```\_

            ";
            Console.WriteLine(title);
            Thread.Sleep(3000);
            Console.Clear();

            NameCharacter();
            Choice();
            EndGame();
        }
        public static void EndGame()
        {
            //end of game text

            Console.Clear();
            //inventory items user has collected in the end.
            Console.WriteLine(CharacterName + " you found items during your mission:");
            foreach (string item in inventory)
            {
                Console.WriteLine(item);
            }
            if (inventory.Contains("Golden Sword"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("End of story text here.");
                Console.WriteLine($"Hooray! {CharacterName} you have found the Golden Sword that can get rid of the rest of the zombies!");
                Console.WriteLine("Again, Congratulations on finding the Golden Sword!");
                Console.WriteLine("Now, go get the rest of em and save the city.");
                Console.ResetColor();

                Console.Title = @"City Scape";
                Console.ForegroundColor = ConsoleColor.Blue;
                string title = @"
        __   __                     ___      _
       |  | |  |      /|           |   |   _/ \_
       |  | |  |  _  | |__         |   |_-/     \-_     _
     __|  | |  |_| | | |  |/\_     |   |  \     /  |___|
    |  |  | |  | | __| |  |   |_   |   |   |___|   |   |
    |  |  |^|  | ||  | |  |   | |__|   |   |   |   |   |
    |  |  |||  | ||  | |  |   | /\ |   |   |   |   |   |
    ~~~~~~~~~~~~~~~~~~~~~~~~~~~/  \~~~~~~~~~~~~~~~~~~~~~~~
   ~ ~~  ~ ~~ ~~~ ~ ~ ~~ ~~ ~~ \   \__   ~  ~  ~~~~ ~~~ ~~
 ~~ ~ ~ ~~~ ~~  ~~ ~~~~~~~~~~ ~ \   \o\  ~~ ~ ~~~~ ~ ~ ~~~
   ~ ~~~~~~~~ ~ ~ ~~ ~ ~ ~ ~ ~~~ \   \o\=   ~~ ~~  ~~ ~ ~~
~ ~ ~ ~~~~~~~ ~  ~~ ~~ ~ ~~ ~ ~ ~~ ~ ~ ~~ ~~~ ~ ~ ~ ~ ~~~~
            ";
                Console.WriteLine(title);
                Thread.Sleep(12000);
                Console.Clear();
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("You didn't find the Golden Sword... better luck next time!");
                Console.Title = @"City Scape";
                Console.ForegroundColor = ConsoleColor.Blue;
                //Scource: https://ascii.co.uk/.
                string title = @"
        __   __                     ___      _
       |  | |  |      /|           |   |   _/ \_
       |  | |  |  _  | |__         |   |_-/     \-_     _
     __|  | |  |_| | | |  |/\_     |   |  \     /  |___|
    |  |  | |  | | __| |  |   |_   |   |   |___|   |   |
    |  |  |^|  | ||  | |  |   | |__|   |   |   |   |   |
    |  |  |||  | ||  | |  |   | /\ |   |   |   |   |   |
    ~~~~~~~~~~~~~~~~~~~~~~~~~~~/  \~~~~~~~~~~~~~~~~~~~~~~~
   ~ ~~  ~ ~~ ~~~ ~ ~ ~~ ~~ ~~ \   \__   ~  ~  ~~~~ ~~~ ~~
 ~~ ~ ~ ~~~ ~~  ~~ ~~~~~~~~~~ ~ \   \o\  ~~ ~ ~~~~ ~ ~ ~~~
   ~ ~~~~~~~~ ~ ~ ~~ ~ ~ ~ ~ ~~~ \   \o\=   ~~ ~~  ~~ ~ ~~
~ ~ ~ ~~~~~~~ ~  ~~ ~~ ~ ~~ ~ ~ ~~ ~ ~ ~~ ~~~ ~ ~ ~ ~ ~~~~
            ";
                Console.WriteLine(title);
                Thread.Sleep(5000);
                Console.Clear();
                Console.ResetColor();

            }
            Console.WriteLine("Press enter to exit!");
        }
        static void Choice()
        {
            for (int section = 1; section <= Scenarios; section++)
            {
                string input = "";
                switch (section)
                {
                    case 1:

                        Console.WriteLine(PartOne[0]);
                        Console.ForegroundColor = ConsoleColor.Green;

                        input = Utility.AskInput("Enter: ");
                        Console.ResetColor();

                        if (input == "a")
                        {
                            Console.WriteLine(PartOne[1]);

                            Console.Title = @"Flashlight";
                            Console.ForegroundColor = ConsoleColor.White;

                            //Source: https://ascii.co.uk/art/flashlight.
                            string title = @"
                      _.----.
    .----------------"" /  /  \
   (     EVEREADY   | |   |) |
    `----------------._\  \  /
                       ""----'
Lester / itz / Nate
";
                            inventory.Add("Flashlight");
                            Console.WriteLine(title);
                            Thread.Sleep(5000);
                            Console.Clear();
                            Console.ResetColor();

                        }
                        else
                        {
                            Console.WriteLine(PartTwo[2]);
                            Console.Title = @"Umbrella";
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            //Source: https://www.asciiart.eu/clothing-and-accessories/umbrellas.
                            string title = @"
        __.|.__
    .-""'..':`..`""-.
  .' .' .  :  . `. `.
 / .   .   :   .   . \
/_ _._ _.._:_.._ _._ _\
  '   '    |    '   '
           |
           |
           |
           |
           |
         `=' mh
            ";
                            inventory.Add("Umbrella");
                            Console.WriteLine(title);
                            Thread.Sleep(5000);
                            Console.Clear();
                            Console.ResetColor();


                        }
                        Console.Clear();
                        //part 4 print next part of section
                        Console.WriteLine(PartOne[3]);
                        input = Utility.AskInput("Enter: ");
                        Console.Clear();

                        //part 5 again if a print next, otherwise skip ahead 
                        if (input == "a")
                        {
                            Console.WriteLine(PartOne[4]);
                        }
                        else
                        {
                            Console.WriteLine (PartThree[5]);
                        }

                        Console.WriteLine(PartOne[6]);
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine(PartTwo[0]);
                        input = Utility.AskInput("Enter: "); 
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();
                        if (input == "a")
                        {
                            Console.WriteLine(PartTwo[1]);
                        }
                        else
                        {
                            Console.WriteLine(PartTwo[2]);
                        }
                        Console.WriteLine(PartTwo[3]);
                        input = Utility.AskInput("Enter valid input: "); 
                        Console.Clear();
        
                        if (input == "a")
                        {
                            Console.WriteLine(PartTwo[4]);
                            inventory.Add("Water bottle");

                        }
                        else
                        {
                            Console.WriteLine(PartTwo[5]);
                            inventory.Add("Golden Sword");

                            Console.Title = @"Golden Sword";
                            //Source: https://www.asciiart.eu/weapons/swords. 
                            string title = @"
 __-----_________________{]__________________________________________________
{&&&&&&&#%%&#%&%&%&%&%#%&|]__________________________________________________\
                         {]
            ";
                            Console.WriteLine(title);
                            Thread.Sleep(5000);
                            Console.Clear();
                            Console.ResetColor();

                        }
                        Console.WriteLine(PartTwo[6]);
                        Console.Clear(); 
                        break;
                    case 3:
                        //part three
                        Console.WriteLine(PartThree[0]);
                        input = Utility.AskInput("Enter: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();
                        if (input == "a")
                        {
                            Console.WriteLine(PartThree[1]);

                        }
                        else
                        {
                            Console.WriteLine(PartThree[2]);
                        }
                        Console.WriteLine(PartThree[3]);
                        Console.Clear();

                        if (input == "a")
                        {
                            Console.WriteLine(PartThree[4]);
                        }
                        else
                        {
                            Console.WriteLine(PartThree[5]);
                        }
                        Console.WriteLine(PartThree[6]);
                        ResetColor();
                        break;

                    default:
                        //default if section number does not match one fo the above
                        break;
                }
            }
        }
        static void GameTitle()
        {
            string Title = "The Magnificent Mile: Zombie Apocalypse";
            Console.Title = Title;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Title);
            Console.ResetColor();

            //Source: https://www.asciiart.eu/weapons/swords. 
            string title = @"

                  ________            _______
         /\ \ \ \/_______/     ______/\      \  /\ \/ /\ \/ /\  \_____________
        /\ \ \ \/______ /     /\    /:\\      \ ::\  /::\  /::\ /____  ____ __
       /\ \ \ \/_______/     /:\\  /:\:\\______\::/  \::/  \::///   / /   //
      /\ \ \ \/_______/    _/____\/:\:\:/_____ / / /\ \/ /\ \///___/ /___//___
_____/___ \ \/_______/    /\::::::\\:\:/_____ / \ /::\  /::\ /____  ____  ____
         \ \/_______/    /:\\::::::\\:/_____ /   \\::/  \::///   / /   / /   /
          \/_______/    /:\:\\______\/______/_____\\/ /\ \///___/ /___/ /_____
\          \______/    /:\:\:/_____:/\      \ ___ /  /::\ /____  ____  _/\::::
\\__________\____/    /:\:\:/_____:/:\\      \__ /_______/____/_/___/_ /  \:::
//__________/___/   _/____:/_____:/:\:\\______\ /                     /\  /\::
///\          \/   /\ .----.\___:/:\:\:/_____ // \                   /  \/  \:
///\\          \  /::\\ \_\ \\_:/:\:\:/_____ //:\ \                 /\  /\  /\
//:/\\          \//\::\\ \ \ \\/:\:\:/_____ //:::\ \               /  \/  \/+/
/:/:/\\_________/:\/:::\`----' \\:\:/_____ //o:/\:\ \_____________/\  /\  / /
:/:/://________//\::/\::\_______\\:/_____ ///\_\ \:\/____________/  \/  \/+/\
/:/:///_/_/_/_/:\/::\ \:/__  __ /:/_____ ///\//\\/:/ _____  ____/\  /\  / /  \
:/:///_/_/_/_//\::/\:\///_/ /_//:/______/_/ :~\/::/ /____/ /___/  \/  \/+/\  /
/:///_/_/_/_/:\/::\ \:/__  __ /:/____/\  / \\:\/:/ _____  ____/\  /\  / /  \/
:///_/_/_/_//\::/\:\///_/ /_//:/____/\:\____\\::/ /____/ /___/  \/  \/+/\  /\
///_/_/_/_/:\/::\ \:/__  __ /:/____/\:\/____/\\/____________/\  /\  / /  \/  \
//_/_/_/_//\::/\:\///_/ /_//::::::/\:\/____/  /----/----/--/  \/  \/+/\  /\  /
/_/_/_/_/:\/::\ \:/__  __ /\:::::/\:\/____/ \/____/____/__/\  /\  / /  \/  \/_
_/_/_/_//\::/\:\///_/ /_//\:\::::\:\/____/ \_____________/  \/  \/+/\  /\  /
/_/_/_/:\/::\ \:/__  __ /\:\:\::::\/____/   \ _ _ _ _ _ /\  /\  / /  \/  \/___
_/_/_//\::/\:\///_/ /_//\:\:\:\              \_________/  \/  \/+/\  /\  /   /
/_/_/:\/::\ \:/__  __ /\:\:\:\:\______________\       /\  /\  / /  \/  \/___/_
_/_//\::/\:\///_/ /_//::\:\:\:\/______________/      /  \/  \/+/\  /\  /   /
/_/:\/::\ \:/__  __ /::::\:\:\/______________/\     /\  /\  / /  \/  \/___/___
_//\::/\:\///_/ /_//:\::::\:\/______________/  \   /  \/  \/+/\  /\  /   /   /
/:\/::\ \:/__  __ /:\:\::::\/______________/    \ /\  /\  / /  \/  \/___/___/
/\::/\:\///_/ /_//:\:\:\                         \  \/\\\/+/\  /\  /   /   /+/
\/::\ \:/__  __ /:\:\:\:\_________________________\ ///\\\/  \/  \/___/___/ /_
::/\:\///_/ /_//:\:\:\:\/_________________________////::\\\  /\  /   /   /+/
::\ \:/__  __ /:\:\:\:\/_________________________/:\/____\\\/  \/___/___/ /___
/\:\///_/ /_//:\:\:\:\/_________________________/:::\    /\/\  /   /   /+/   /
\ \:/__  __ /:\:\:\:\/_________________________/:::::\  ///  \/___/___/ /___/_
:\///_/ /_//:\:\:\:\/_________________________/:\:::::\///\  /   /  __________
\:/__  __ /:\:\:\:\/_________________________/:::\:::::\/  \/___/__/\
///_/ /_//:\:\:\:\/_________________________/:\:::\:::::\  /   /  /::\
/__  __ /\::\:\:\/_________________________/_____::\:::::\/___/__/:/\:\
/_/ /_//::\::\:\/_____________________/\/_/_/_/_/\  \           /::\ \:\
_  __ /:\::\:8\/_____________________/\/\   /\_\\/\  \ 8       /:/\:\ \:\
/ /_//\     \|______________________//\\/\::\/__\\/\  \|______/::\ \:\ \:\
 __ /  \  \                        /:\/:\/\_______\/\        /:/\:\ \:\/::\
/_//    8      -8  --  --  --  -- //\::/\\/_/_/_/_/_/ --  --/::\ \:\ \::/\:\
_ /     |\  \   |________________/:\/::\///__/ /__//_______/:/\:\ \:\/::\ \:\
__________\     \               //\::/\:/___  ___ /       /::\ \:\ \::/\:\ \:\
::::::::::\\  \  \             /:\/::\///__/ /__//       /:/\:\ \:\/::\ \:\ \:
            ";
            Console.WriteLine(title);
            Thread.Sleep(8000);
            Console.Clear();
            Console.ResetColor();


            Console.WriteLine("Press enter to start");
            Console.ReadKey();
            Console.Clear();
        }
        static void NameCharacter()
        {
            Console.WriteLine("You need a code name for this mission.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter your code name now.");

            CharacterName = Console.ReadLine();

            Console.ResetColor();
            Console.WriteLine("Your code name is confirmed to be " + CharacterName + ". Good luck!\n\n");
            Console.Clear();
        }
    }
}