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

            Console.WriteLine("Players are: \n");
            Hero1.ShowHealthBar();
            Console.WriteLine();
            Hero2.ShowHealthBar();
            Console.WriteLine();
            DisplayArenaWelcomeMessage();

        }

        public void Fight()
        {
            var whoIsFirst = new Random().Next(2)+1;

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

            Console.WriteLine("-----------------------------------------------------\n");
            while (FirstAttacker.IsAlive() && SecondAttacker.IsAlive())
            {
                FirstAttacker.Attack(SecondAttacker);
                FirstAttacker.ShowHealthBar();
                Console.WriteLine();
                SecondAttacker.ShowHealthBar();
                Console.WriteLine();

                Console.ReadLine();

                if (!SecondAttacker.IsAlive())
                {
                    Console.WriteLine($"{ SecondAttacker.Name } is dead.");
                    break;
                }

                SecondAttacker.Attack(FirstAttacker);
                FirstAttacker.ShowHealthBar();
                Console.WriteLine();
                SecondAttacker.ShowHealthBar();
                Console.WriteLine();

                Console.ReadLine();

                if (!FirstAttacker.IsAlive())
                {
                    Console.WriteLine($"{ FirstAttacker.Name } is dead.");
                    break;
                }

                Console.WriteLine("-----------------------------------------------------\n");
            }
        }
    }
}
