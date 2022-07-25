using OOP.Core.Models;


Hero hero1 = new Hero(7, "Magmus", 7, 4, 2, new RollingDice(4));
Hero hero2 = new Hero(20, "Fasanus", 20, 10, 8, new RollingDice(10));

Arena arena = new Arena("Coloseum", hero1, hero2, hero1, hero2, "Welcome to the Coloseum. Let Gods decide your fate.");

arena.Render();

arena.Fight();
