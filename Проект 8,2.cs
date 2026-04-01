using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите букву: ");
            char буква = Console.ReadKey().KeyChar;
            Console.WriteLine();     
            if (char.IsLower(буква))
            {
                Console.WriteLine($"Результат: {char.ToUpper(буква)}");
            }
            else if (char.IsUpper(буква))
            {
                Console.WriteLine($"Результат: {char.ToLower(буква)}");
            }
            else
            {
                Console.WriteLine("Это не буква");
            }
            Console.ReadKey();
        }
    }
