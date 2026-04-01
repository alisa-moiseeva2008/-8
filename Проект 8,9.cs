using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string строка = Console.ReadLine();
            Console.Write("Что заменить: ");
            string что = Console.ReadLine();
            Console.Write("На что заменить: ");
            string наЧто = Console.ReadLine();   
            string результат = строка.Replace(что, наЧто);
            Console.WriteLine($"Результат: {результат}");
            Console.ReadKey();
        }
    }
