// The Magnificent Mile: Zombie Apocalypse
// ie Apocolypse 
// By Gianna G. Dimperio
// Fall 2022
// This is work derivative of "C# Adventure Game" by http://programmingisfun.com/learn/c-sharp-adventure-game/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Transactions;

namespace TheMagnificentMileZombieApocolypse
{
    public static class Utility
    {
        
        public static string AskInput(string message){
            string input = "";
            do
            {
                Console.Write("Enter valid input: ");
                input = Console.ReadLine();
                input.ToLower();

            } while (input != "a" && input != "b" && input != "A" && input != "B");

            return input;
        }
    }
}
