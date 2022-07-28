using OOP.Core.Models;
using System;

namespace OOP.Core.Implementations
{
    public class Warrior : Hero
    {
        public new int Damage { get; set; }
        public new int Defense { get; set; }
        public new RollingDice? Dice { get; set; }

        public Warrior()
        {
            Damage = 10;
            Defense = 10;
            Dice = new RollingDice(10);
        }

        public Warrior(int damage, int defense, RollingDice? dice) : this()
        {
            Damage = damage;
            Defense = defense;
            Dice = dice;
        }

        public void BlockByShield()
        {
            var parry = new Random().Next(5) + 1;
            if (parry == 1)
            {
                this.Defense += 5;
            }

        }
    }
}
