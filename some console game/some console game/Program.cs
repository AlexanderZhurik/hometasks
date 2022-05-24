using System;
using System.Threading;
namespace some_console_game
{
    static class Info
    {
        static public void EntityInfo(Entity entity)
        {
            Console.WriteLine($"{entity.name}\nЗдоровье - {entity.health}/{entity.maxHealth}\nНаносимый урон - {entity.baseDamage}\n");
        }
        static public string WeaponInfo(Item item)
        {
            if (item.ItemType == Item.type.Weapon)
            {
                return $"{item.name}: Урон - {item.activeValue}, цена - {item.cost}";
            }
            else throw new Exception("Предмет не является оружием!");
        }
        static public string FoodOtherInfo(Item item)
        {
            if (item.ItemType == Item.type.Food || item.ItemType == Item.type.Other)
            {
                return $"{item.name}: цена - {item.cost}";
            }
            else throw new Exception("Предмет не является едой или прочим!");
        }
    }
    static class Items
    {
        public static Item healpotion = new("Зелье лечения", 5, Item.type.Food);
        public static Item magicalsword = new("Магический меч", 50, Item.type.Weapon, 10);
        public static Item someitem = new("Я не придумал что тут будет", 2, Item.type.Other);
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new();
            player.maxHealth = 20;
            player.baseDamage = 1;
            player.inventory.equipment[0] = new Item("Вилы", 0, Item.type.Weapon, 2);
            player.inventory.equipment[1] = new Item("Льняная рубашка", 0, Item.type.Armor, 0);
            Info.EntityInfo(player);
            string userAnswer;
            while (!player.isDead)
            {
                Console.WriteLine("\n\nВыберите действие:\nC - спуститься в пещеру, H - восстановить здоровье, I - посмотреть инвентарь, S - cxoдить в магазин");
                userAnswer = Console.ReadLine();
                if (userAnswer == "C")
                {
                    player.Cave();
                }
                else if (userAnswer == "H")
                {
                    if (player.inventory.items.Contains(Items.healpotion)) {
                        player.inventory.items.Remove(Items.healpotion);
                        player.health = player.maxHealth;
                    }
                    else
                    {
                        Console.WriteLine("У вас нет зелья лечения");
                    }
                }
                else if (userAnswer == "I")
                {
                    Console.WriteLine(player.ShowInventory());
                }
                else if (userAnswer == "S")
                {
                    Console.WriteLine($"Добро пожаловать в магазин. Доступный ассортимент:\n  1. {Info.WeaponInfo(Items.magicalsword)}\n  2. {Info.FoodOtherInfo(Items.healpotion)}\n  3. {Info.FoodOtherInfo(Items.someitem)}\n\n Ваш баланс: {player.goldAmount}");
                    
                    string result;
                    while (true)
                    {
                        Console.WriteLine("Вы хотите что-то купить? Y / N");
                        result = Console.ReadLine();
                        if (result == "N")
                        {
                            Console.WriteLine("Вы вышли из магазина\n");
                            break;
                        }
                        else if (result == "Y")
                        {
                            Console.WriteLine("Выберите номер покупаемого предмета");
                            string shopResult;
                            while (true)
                            {
                                shopResult = Console.ReadLine();
                                if (shopResult == "1")
                                {
                                    if (player.goldAmount >= Items.magicalsword.cost)
                                    {
                                        Console.WriteLine("Поздравляю! Вы купили магический меч и экипировали его. Вам интересно почему у вас не спрашивают, хотите ли вы его экипировать? Во-первых это лучшее оружие в игре (из трех существующих) так что почему бы вам его и не экипировать, а во-вторых я не хочу прописывать ещё одно условие, но этот текст почему-то написал. Вот так вот.");
                                        player.goldAmount -= Items.magicalsword.cost;
                                        player.changeWeapon(Items.magicalsword);
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("У вас недостаточно денег.");
                                        break;
                                    }
                                }
                                else if (shopResult == "2")
                                {
                                    if (player.goldAmount >= Items.healpotion.cost)
                                    {
                                        Console.WriteLine("Поздравляю! Вы купили зелье лечения.");
                                        player.goldAmount -= Items.healpotion.cost;
                                        player.pickUpAnItem(Items.healpotion);
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("У вас недостаточно денег.");
                                        break;
                                    }
                                }
                                else if (shopResult == "3")
                                {
                                    if (player.goldAmount >= Items.someitem.cost)
                                    {
                                        Console.WriteLine("Я не знаю зачем вы это купили, я сделал этот предмет просто чтоб в магазине было больше двух предметов, но ладно");
                                        player.goldAmount -= Items.someitem.cost;
                                        player.pickUpAnItem(Items.someitem);
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("У вас недостаточно денег. Да и подумайте, оно вам надо?");
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Товара с таким номером не существует.");
                                }
                                break; 
                            }
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели что-то не то.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели что-то не то.");
                }
            }
        }
    }
}
