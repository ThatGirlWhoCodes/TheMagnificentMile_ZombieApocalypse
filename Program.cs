// The Magnificent Mile: Zombie Apocalypse
// ie Apocolypse 
// By Gianna G. Dimperio
// Fall 2022
// This is work derivative of "C# Adventure Game" by http://programmingisfun.com/learn/c-sharp-adventure-game/

using System;
using System.Collections.Generic;
using System.Reflection;
using TheMagnificentMile;
using static System.Console;
using TheMagnificentMileZombieApocolypse;

namespace Adventure
{
    class Program
    {
        public static bool CurserVisible { get; private set; }

        static void Main()
        {
            Player player = new Player();
            Location location = new Location();
            Game.StartGame();
            Location MichiganAveStreet = new Location();
            MichiganAveStreet.Name = "Michigan Avenue";
            MichiganAveStreet.City = "Chicago";

            Console.ReadKey();
        }
    }
}

