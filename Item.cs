// The Magnificent Mile: Zombie Apocolypse 
// By Gianna G. Dimperio
// Fall 2022
// This is work derivative of "C# Adventure Game" by http://programmingisfun.com/learn/c-sharp-adventure-game/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;
using Adventure;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace TheMagnificentMile
{
    public class Item
    {
        public Item(string name, ConsoleColor color, double weight, string treasure)
        {
            Name = name;
            Color = color;
            Weight = weight;
        }

        //default item: 
        public string Name { get; set; }
        public double Weight { get; set; }
        public ConsoleColor Color { get; set; }

        //public Item(string name, ConsoleColor color, double weight)
        //{
        //    Name = name;
        //    Name = "Golden Sword"; 
        //    Weight = weight;

        //    Item item = new Item(name, color, weight);
        //    Item = "Golden Sword";
        //}

        //public Item()
        //{
        //    Item item = new Item();
        //    Console.Title = "Golden Sword";
        //}
        //    //instantiate random
        //GoldenSword goldenSword = new GoldenSword();

        //string [] items = goldenSword.Items;    
        //    Random randomNumber = new Random();
        //    int number;

        //    //Next(Int32) returns a non-negative random number less than the maximum.
        //    number = randomNumber.Next(Items.Length);

        //    Name = Items[number];
        //    Description = Descriptions[number];
        //    Console.WriteLine("\nYou found a " + Name + " (" + Description + "). \n");
    }
}
