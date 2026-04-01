using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите символ: ");
            char символ = Console.ReadKey().KeyChar;
            Console.WriteLine();       
            Console.WriteLine($"Код символа '{символ}': {(int)символ}");
            Console.ReadKey();
        }
    }
