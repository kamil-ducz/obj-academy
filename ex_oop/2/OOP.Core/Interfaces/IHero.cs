using OOP.Core.Models;

namespace OOP.Core.Interfaces
{
    public interface IHero
    {
        public string DisplayHeroName();
        public bool IsAlive();
        public void ShowHealthBar();
        public void Defend(int hit);
        public void Attack(Hero enemy);
    }
}
