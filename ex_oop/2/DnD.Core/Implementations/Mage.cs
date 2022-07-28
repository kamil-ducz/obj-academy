using OOP.Core.Models;
using System;

namespace OOP.Core.Implementations
{
    public class Mage : Hero
    {
        public new int Damage { get; set; }
        public new int Defense { get; set; }
        public new RollingDice? Dice { get; set; }
        public int ManaBar { get; set; }

        public Mage()
        {
            Damage = 4;
            Defense = 15;
            Dice = new RollingDice(4);
            ManaBar = 100;
        }

        public Mage(int damage, int defense, RollingDice? dice, int manaBar) : this()
        {
            Damage = damage;
            Defense = defense;
            Dice = dice;
            ManaBar = manaBar;
        }

        public void CastSpell()
        {
            var spellPower = new Random().Next(9, 20) + 1;
            this.Damage += spellPower;
        }
    }
}
