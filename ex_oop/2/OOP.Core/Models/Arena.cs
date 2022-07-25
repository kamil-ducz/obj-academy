using System;

namespace OOP.Core.Models
{
    public class Arena
    {
        public string Name { get; set; }
        public Hero Hero1 { get; set; }
        public Hero Hero2 { get; set; }
        public Hero FirstAttacker { get; set; }
        public Hero SecondAttacker { get; set; }
        public string WelcomeMessage { get; set; }

        public Arena(string name, Hero hero1, Hero hero2, Hero firstAttacker, Hero secondAttacker, string welcomeMessage)
        {
            Name = name;
            Hero1 = hero1;
            Hero2 = hero2;
            FirstAttacker = firstAttacker;
            SecondAttacker = secondAttacker;
            WelcomeMessage = welcomeMessage;
        }

        private void DisplayArenaWelcomeMessage()
        {
            Console.WriteLine($"Welcome to the arena { this.Name }! The fight begins...\n");
        }

        public void Render()
        {
            Console.Clear();

            DisplayArenaWelcomeMessage();
            Console.WriteLine("Players are: \n");

            Console.WriteLine(Hero1.ShowHealthBar(Hero1.Health));
            Console.WriteLine(Hero1.DisplayHeroName() + "\n");

            Console.WriteLine(Hero2.ShowHealthBar(Hero2.Health));
            Console.WriteLine(Hero2.DisplayHeroName() + "\n");
        }

        public void Fight()
        {
            var whoIsFirst = new Random().Next(1, 2);

            if (whoIsFirst == 1)
            {
                this.FirstAttacker = Hero1;
                this.SecondAttacker = Hero2;
            }
            if (whoIsFirst == 2)
            {
                this.FirstAttacker = Hero2;
                this.SecondAttacker = Hero1;
            }

            while (Hero1.IsAlive() && Hero2.IsAlive())
            {
                FirstAttacker.Attack(SecondAttacker);
                SecondAttacker.Attack(FirstAttacker);
            }
        }
    }
}
