using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        private int _diceValue { get; set; }
        private static Random Rand = new Random();

        /// <summary>
        /// Rolls the die and returns a random value between 1 and 6 (inclusive).
        /// </summary>
        /// <returns>The value rolled on the die.</returns>
        public int Roll()
        {
            _diceValue = Rand.Next(1, 7);
            return _diceValue;
        }
    }
}
