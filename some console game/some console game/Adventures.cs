using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace some_console_game
{
    static class Adventures
    {
        static private Random rnd = new Random();
        static public void Cave(this Player player)
        {
            int result = rnd.Next(3);
            if (result == 0)
            {
                Console.WriteLine("Вы облазили всю пещеру и ничего не нашли.");

            }
            else if (result == 1)
            {
                int gold = rnd.Next(5, 20);
                player.goldAmount += gold;
                Console.WriteLine($"Кто-то в спешке бросил в пещере кошелек. Вы подняли его и обнаружили {gold} золотых монет.");
            }
            else if (result == 2)
            {
                Console.WriteLine($"Вы услышали странные стукающие звуки. После того, как вы пошли на звук, вы начали путаться в паутине. Только у вас получилось выбраться из нее, как сразу же на вас набросился огромный паук. Вы решили вступить с ним в бой.");
                player.battle(new("Паук", 5, 2));
                if (player.isDead)
                {
                    Console.WriteLine("Вы умерли. Игра окончена.");
                }
                else
                {
                    Console.Write("После убийства паука вы получили 5 золотых монет");
                    if (rnd.Next(1) == 1)
                    {
                        Item SpiderSword = new Item("Меч из паука", 5, Item.type.Weapon, 3);
                        Console.WriteLine("и нож, который торчал из брюха паука.\n");
                        Console.WriteLine($"У вас в руках {Info.WeaponInfo(SpiderSword)}. Хотите ли вы взять его в ругу вместо своего {Info.WeaponInfo(player.inventory.equipment[0])}? Y - да, N - нет");
                        string ans;
                        while (true)
                        {
                            ans = Console.ReadLine();
                            if (ans == "Y")
                            {
                                player.inventory.items.Add(player.inventory.equipment[0]);
                                player.changeWeapon(SpiderSword);
                                Console.WriteLine("Оружие было сменено.");
                                break;
                            }
                            if (ans == "N")
                            {
                                player.pickUpAnItem(SpiderSword);
                                Console.WriteLine("Оружие добавлено в инвентарь.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Вы ввели что-то не то, попробуйте ещё раз.");
                            }

                        }

                    }
                    else
                    {
                        Console.WriteLine(".");
                    }
                    player.goldAmount += 5;
                }
            }
            if (result == 3)
            {
                Console.WriteLine("При исследовании пещеры вы упали с обрыва в темноте и потеряли 4 единицы здоровья.");
                if (player.health > 4)
                {
                    player.health -= 4;
                }
                else
                {
                    player.health = 0;
                    player.isDead = true;
                    Console.WriteLine("Вы умерли. Игра окончена.");
                }
            }
        }
    }
}
