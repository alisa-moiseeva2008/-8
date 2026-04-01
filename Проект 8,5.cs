using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string строка = Console.ReadLine();   
            char[] массив = строка.ToCharArray();
            Array.Reverse(массив);
            string перевернутая = new string(массив);
            Console.WriteLine($"Перевернутая строка: {перевернутая}");
            Console.ReadKey();
        }
    }
