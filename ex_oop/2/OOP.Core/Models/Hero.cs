using System;
using System.Text;

namespace OOP.Core.Models
{
    public class Hero
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int MaxHealth { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }
        public RollingDice Dice { get; set; }

        public Hero()
        {
            Name = "Hero";
            Dice = new RollingDice();
        }

        public Hero(int health, string name, int maxHealth, int damage, int defense, RollingDice dice) : this()
        {
            Health = health;
            Name = name;
            MaxHealth = maxHealth;
            Damage = damage;
            Defense = defense;
            Dice = dice;
        }

        public string DisplayHeroName()
        {
            return Name;
        }

        public bool IsAlive()
        {
            if (Health <= 0)
            {
                return false;
            }

            return true;
        }

        public void ShowHealthBar()
        {
            StringBuilder healthBar = new StringBuilder();

            for (int i = 0; i < this.Health; i++)
            {
                healthBar.Append("#");
            }

            Console.WriteLine(healthBar.ToString() + "\n" + DisplayHeroName());
        }

        public void Defend(int hit)
        {
            var injury = hit - (Defense+Dice.Roll());

            if (injury > 0)
            {
                Health -= injury;
                Console.WriteLine($"{ this.Name } takes { injury } hp damage!");
            }
            if (injury <= 0)
            {
                Console.WriteLine("Enemy blocks the hit!");
            }
        }

        public void Attack(Hero enemy)
        {
            int hit = Damage + Dice.Roll();

            if (hit > 0)
            {
                Console.WriteLine($"{ this.Name } attacks { enemy.Name } with a hit worth { hit } hp!");
                enemy.Defend(hit);
            }
        }
    }
}
