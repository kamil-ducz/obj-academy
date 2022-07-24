using System;

namespace OOP.Core.Models
{
    public class RollingDice
    {
        private int sidesCount;
        private Random random;

        public RollingDice()
        {
            random = new Random();
        }

        public RollingDice(int sidesCount = 6) : this()
        {
            this.sidesCount = sidesCount;
        }

        public int GetSidesCount()
        {
            return sidesCount;
        }

        public int Roll()
        {
            return random.Next(1, sidesCount);
        }

        public string ShowRollResult()
        {
            return $"Rolling a dice with { this.sidesCount } sides";
        }
    }
}
