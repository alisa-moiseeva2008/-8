using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите символ: ");
            char символ = Console.ReadKey().KeyChar;
            Console.WriteLine();
            
            if (char.IsDigit(символ))
            {
                Console.WriteLine("Это цифра");
            }
            else if (char.IsLetter(символ))
            {
                Console.WriteLine("Это буква");
            }
            else
            {
                Console.WriteLine("Это спецсимвол");
            }
            Console.ReadKey();
        }
    }
