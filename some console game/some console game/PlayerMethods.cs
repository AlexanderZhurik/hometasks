using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace some_console_game
{
    static class PlayerMethods
    {
        public static string ShowInventory(this Player player)
        {
            var backpack = "";


            for (int i = 0; i < player.inventory.items.Count; i++)
            {
                if (player.inventory.items[i] == null) backpack += $"\n#{i} - пусто";
                else backpack += $"\n#{i} - Имя: {player.inventory.items[i].name}, стоимость - {player.inventory.items[i].cost}";
            }
            return $"Здоровье: {player.health}/{player.maxHealth}\n\nВаш инвентарь: \nОружие - {player.inventory.equipment[0].name}, урон {player.inventory.equipment[0].activeValue} \nОдежда - {player.inventory.equipment[1].name}, уровень защиты {player.inventory.equipment[1].activeValue} \nРюкзак: {backpack}";
        }
        public static void battle(this Player player, Monster enemy)
        {
            Console.WriteLine($"Игрок вступил в бой с {enemy.name}!");
            Thread.Sleep(1000);
            int currentMove = 0;
            while (player.health > 0 && enemy.health > 0)
            {

                Console.Write("Новая атака: ");
                if (player.Randomizer.Next(2) == 1)
                {
                    if (currentMove == 0)
                    {
                        enemy.health -= (player.baseDamage + player.inventory.equipment[0].activeValue);
                        Console.WriteLine($"Игрок атаковал успешно! {enemy.name} получает {(player.baseDamage + player.inventory.equipment[0].activeValue)} урона и у него остается {enemy.health} очков здоровья");
                        currentMove = 1;
                        Thread.Sleep(3000);
                    }
                    else

                    {
                        player.health -= enemy.baseDamage;
                        Console.WriteLine($"{enemy.name} атаковал успешно! Игрок получает {enemy.baseDamage} урона и у него остается {player.health} очков здоровья");
                        currentMove = 0;
                        Thread.Sleep(3000);
                    }
                }
                else
                {
                    if (currentMove == 0)
                    {
                        Console.WriteLine($"Игрок промахнулся! {enemy.name} ничего не теряет и у него остается {enemy.health} очков здоровья");
                        Thread.Sleep(3000);
                        currentMove = 1;
                    }
                    else

                    {
                        Console.WriteLine($"{enemy.name} промахнулся! Игрок ничего не теряет и у него остается {player.health} очков здоровья");
                        Thread.Sleep(3000);
                        currentMove = 0;
                    }
                }
            }
            if (player.isDead)
            {
                Console.WriteLine("Вы погибли! Игра окончена.");
            }
            else
            {
                Console.WriteLine($"Вы победили {enemy.name}!");
            }

        }
        public static void changeWeapon(this Player player, Item new_weapon)
        {
            player.inventory.items.Add(player.inventory.equipment[0]);
            player.inventory.equipment[0] = new_weapon;
        }
        public static void changeArmor(this Player player, Item new_armor)
        {
            player.inventory.items.Add(player.inventory.equipment[1]);
            player.inventory.equipment[1] = new_armor;
        }
        public static void pickUpAnItem(this Player player, Item item)
        {
            player.inventory.items.Add(item);
        }

    }
}
