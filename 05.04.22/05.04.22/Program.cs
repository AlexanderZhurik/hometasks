using System;

namespace _05._04._22
{

    static class IOHelper
    {
        public static int SaveInput(int min_value, int max_value, string message)
        {
            if (int.TryParse(message, out int output))
            {
                if (output >= min_value && output <= max_value) return output;
                else
                {
                    throw new Exception("Число не входит в обозначенные рамки");
                }
            }
            else
            {
                throw new Exception("Введенная строка не является целым числом");
            }

        }
        public static int SaveInput(string message)
        {
            if (int.TryParse(message, out int output))
            {
                return output;
            }
            else
            {
                throw new Exception("Введенная строка не является целым числом");
            }

        }
        public static double SaveInput(double min_value, double max_value, string message)
        {
            if (double.TryParse(message, out double output))
            {
                if (output >= min_value && output <= max_value) return output;
                else
                {
                    throw new Exception("Число не входит в обозначенные рамки");
                }
            }
            else
            {
                throw new Exception("Введенная строка не является целым числом");
            }

        }
        public static void Line(int length)
        {
            for (int i = 0; i < length; i++) { Console.Write("-"); }
            Console.WriteLine();
        }
        public static int TextMenu(string[] menu_items)
        {
            for (int i = 0; i < menu_items.Length; i++) { Console.WriteLine($"{i+1}. {menu_items[i]}"); }
            Console.WriteLine("Choose an option");
            return SaveInput(Console.ReadLine());
        }
        public static int[] GenerateIntArray(int size, int min, int max)
        {
            Random rnd = new Random();
            int[] output = new int[size];
            for (int i = 0; i < size; i++) {
                output[i] = rnd.Next(min, max);
            }
            return output;
        }
        public static double[] GenerateDoubleArray(int size, double min, double max)
        {
            Random rnd = new Random();
            double[] output = new double[size];
            for (int i = 0; i < size; i++)
            { output[i] = rnd.NextDouble() * (max - min) + min; }
            return output;
        }
        public static int[,] GenerateIntMatrix(int rows, int cols, int min, int max)
        {
            Random rnd = new Random();
            int[,] output = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    output[i,j] = rnd.Next(min, max);
            }
            return output;
        }
        public static double[,] GenerateDoubleMatrix(int rows, int cols, double min, double max)
        {
            Random rnd = new Random();
            double[,] output = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; i < cols; j++)
                    output[i, j] = rnd.NextDouble() * (max - min) + min;
            }
            return output;
        }
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        public static void PrintArray(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        public static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void PrintArray(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
    class Passport
    {
        public int Serial
        {
            get
            {
                return Serial;
            }
            set
            {
                if (value.ToString().Length == 4) Serial = value;
                else throw new Exception("Serial must be 4 digits!");
            }
        }
        public int Number
        {
            get
            {
                return Number;
            }
            set
            {
                if (value.ToString().Length == 6) Number = value;
                else throw new Exception("Number must be 6 digits!");
            }
        }
        public string Issued
        {
            get
            {
                return Issued;
            }
            set
            {
                if (value.Length != 0) Issued = value;
                else throw new Exception("Issued field can't be empty!");
            }
        }
        public DateTime IssuedDate
        {
            get
            {
                return IssuedDate;
            }
            set
            {
                if (value.Year >= 1991 && value >= DateTime.Now)
                {
                    IssuedDate = value;
                }
                else throw new Exception("Issued date is invalid!");
            }
        }
        public bool isActive { get; set; }

    }
    class Monster
    {
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                if (value.Length != 0) Name = value;
                else throw new Exception("Name can't be empty!");
            }
        }
        public enum MonsterType{ dragon, orc, undead, construct, demon, mutant, animal, magical, cursed};
        public MonsterType MonType { get; set; }
        public int MaxHP { 
            get {
                return MaxHP;
            }
            set {
                if (value > 0 && value <= 500) MaxHP = value;
                else throw new Exception("The health is too big or too small!");
            }

        }
        public int HP
        {
            get
            {
                return HP;
            }
            set
            {
                if (value > 0 && value <= MaxHP) HP = value;
                else throw new Exception("The health is too big or too small!");
            }

        }
        public int MinAttack
        {
            get
            {
                return MinAttack;
            }
            set
            {
                if (value > 1 && value <= 10) MinAttack = value;
                else throw new Exception("The MinAttack is too big or too small!");
            }

        }
        public int MaxAttack
        {
            get
            {
                return MaxAttack;
            }
            set
            {
                if (value > 20 && value <= 100) MaxAttack = value;
                else throw new Exception("The MaxAttack is too big or too small!");
            }

        }
        public string WarCry { get; set; }
        public string DeathCry { get; set; }
        public string TypeText
        {
            get
            {
                switch (MonType)
                {
                    case MonsterType.dragon: 
                        return "дракон";
                        break;
                    case MonsterType.animal:
                        return "животное";
                        break;
                    case MonsterType.construct:
                        return "машина";
                        break;
                    case MonsterType.cursed:
                        return "проклятый";
                        break;
                    case MonsterType.demon:
                        return "демон";
                        break;
                    case MonsterType.magical:
                        return "магическое";
                        break;
                    case MonsterType.mutant:
                        return "мутант";
                        break;
                    case MonsterType.orc:
                        return "орк";
                        break;
                    case MonsterType.undead:
                        return "нежить";
                        break;
                    default:
                        return "";
                }
            }
        }
        public bool IsDead
        {
            get
            {
                if (HP > 0) return true;
                else return false;
            }
        }
        public string GetInfo
        {
            get
            {
                return $"Имя: {Name}\nТип монстра: {TypeText}\nУрон: {MinAttack}-{MaxAttack}\n3доровье: {HP}/{MaxHP}";
            }
        }
        public Monster()
        {
            Name = "Монстр";
            MonType = MonsterType.magical;
            MaxHP = 100;
            HP = 100;
            MinAttack = 5;
            MaxAttack = 30;
            WarCry = "A-a-a-a-a";
            DeathCry = "A-aa-aa-aa...";

        }
        public Monster(string name, MonsterType type, int maxhp, int minatt, int maxatt)
        {
            Name = name;
            MonType = type;
            MaxHP = maxhp;
            HP = maxhp;
            MinAttack = minatt;
            MaxAttack = maxatt;
            WarCry = "A-a-a-a-a";
            DeathCry = "A-aa-aa-aa...";
        }
        public Monster(string name, MonsterType type, int maxhp, int minatt, int maxatt, string war, string dead)
        {
            Name = name;
            MonType = type;
            MaxHP = maxhp;
            HP = maxhp;
            MinAttack = minatt;
            MaxAttack = maxatt;
            WarCry = war;
            DeathCry = dead;
        }
        public int getAttack(int bonus)
        {
            Random rnd = new Random();
            return rnd.Next(MinAttack, MaxAttack) + bonus;
        }
        public void Wounds(int damage)
        {
            if (HP <= damage) HP = 0;
            else HP -= damage;
        }
        public void Heal()
        {
            HP = MaxHP;
        }
    }
}
