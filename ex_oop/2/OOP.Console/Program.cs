using OOP.Core.Models;

Hero hero1 = new Hero(35, "Magmus", 30, 6, 4, new RollingDice(8));
Hero hero2 = new Hero(35, "Fasanus", 30, 4, 3, new RollingDice(10));

Arena arena = new Arena("Coloseum", hero1, hero2, hero1, hero2, "Welcome to the Coloseum. Let Gods decide your fate.");

arena.Render();

arena.Fight();
