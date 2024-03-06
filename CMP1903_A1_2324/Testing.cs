using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        // Testing constructor 
        public Testing() 
        {
            TestDie();
            TestGame();
        }

        /// <summary>
        /// This method tests the Die class and checks that the value is between 1 - 6
        /// </summary>
        public void TestDie()
        {
            Die dice1 = new Die();
            int die1value = dice1.Roll();

            Debug.Assert(die1value <= 6 && die1value >= 1, "The die rolled a value outside the range of a standard 6-sided die.");
        }

        /// <summary>
        /// This method tests the Game class and checks that the total of the three die is within the logical 6-sided die range
        /// </summary>
        public void TestGame()
        {
            Game testGame = new Game();
            Console.WriteLine("-------------------------------");
            int testGameTotal = testGame.DiceRolling();

            Debug.Assert(testGameTotal <= 18 && testGameTotal >= 3, "The total of the dice is outside the logical range of a 3-dice roll.");
        }
    }
}
