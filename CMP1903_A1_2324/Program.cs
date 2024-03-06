using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the Game class
            Game newGame = new Game();
            
            // Rolling the dice
            newGame.DiceRolling();
            
            // Creating a continuous rolling loop
            newGame.KeepRolling();
            
            // Displaying the counts of each number rolled
            newGame.DisplayAmounts();

            // Testing the classes with debug assertions
            Testing test1 = new Testing();
        }
    }
}