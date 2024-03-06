using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        // Properties
        protected int noOf1s = 0;
        protected int noOf2s = 0;
        protected int noOf3s = 0;
        protected int noOf4s = 0;
        protected int noOf5s = 0;
        protected int noOf6s = 0;

        private int _diceRolls { get; set; }
        private int _diceValue { get; set; }
        private int _dieTotal { get; set; }
        private float _dieAverage { get; set; }

        // Methods

        /// <summary>
        /// Rolls three dice and displays their values, accumulating totals.
        /// </summary>
        /// <returns>The total value of the three dice.</returns>
        public int DiceRolling()
        {
            while (_diceRolls != 3)
            {
                _diceRolls++;
                Die newDice = new Die();
                Console.WriteLine("Dice {0} is {1}", _diceRolls, _diceValue = newDice.Roll());
                UpdateAmounts();
                _dieTotal += _diceValue;
            }
            Console.WriteLine("This is the total of your three dice rolls {0}", _dieTotal);
            return _dieTotal;
        }

        /// <summary>
        /// Allows the user to continue rolling dice, updating totals and averages.
        /// </summary>
        public void KeepRolling()
        {
            Console.WriteLine("------------------------------- \nDo you want to roll again? Enter 'no' to exit the loop.");
            bool continueToRoll;
            string answer = Console.ReadLine();
            continueToRoll = answer.ToLower() != "no";
            do
            {
                _diceRolls++;
                Die newDice = new Die();
                Console.WriteLine("Dice {0} is {1}", _diceRolls, _diceValue = newDice.Roll());
                UpdateAmounts();
                _dieTotal += _diceValue;
                _dieAverage = (float)_dieTotal / _diceRolls;
                Console.WriteLine("The total is {0} and the average roll is {1}", _dieTotal, _dieAverage);
                Console.WriteLine("------------------------------- \nDo you want to roll again? Enter 'no' to exit the loop.");
                answer = Console.ReadLine();
                continueToRoll = answer.ToLower() != "no";
            } while (continueToRoll);
        }

        /// <summary>
        /// Displays the counts of each number rolled.
        /// </summary>
        public void DisplayAmounts()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Amount of 1s: {0}\nAmount of 2s: {1}\nAmount of 3s: {2}\nAmount of 4s: {3}\nAmount of 5s: {4}\nAmount of 6s: {5}", noOf1s, noOf2s, noOf3s, noOf4s, noOf5s, noOf6s);
        }

        /// <summary>
        /// Updates the counts of each number rolled.
        /// </summary>
        private void UpdateAmounts()
        {
            switch (_diceValue)
            {
                case 1:
                    noOf1s++;
                    break;
                case 2:
                    noOf2s++;
                    break;
                case 3:
                    noOf3s++;
                    break;
                case 4:
                    noOf4s++;
                    break;
                case 5:
                    noOf5s++;
                    break;
                case 6:
                    noOf6s++;
                    break;
            }
        }
    }
}
