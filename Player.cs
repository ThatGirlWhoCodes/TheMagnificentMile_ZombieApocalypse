// The Magnificent Mile: Zombie Apocalypse
// ie Apocolypse 
// By Gianna G. Dimperio
// Fall 2022
// This is work derivative of "C# Adventure Game" by http://programmingisfun.com/learn/c-sharp-adventure-game/

using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TheMagnificentMile;

namespace TheMagnificentMileZombieApocolypse
{
    public class Player
    {
        public bool HasBackPack { get; set; }
        public double Wallet { get; set; }
        public string BackPack { get; set; }

        public Player()
        {
            HasBackPack = true;
        }
    }
}