using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите букву: ");
            char буква = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();      
            string гласные = "aeiouy";     
            if (гласные.Contains(буква))
            {
                Console.WriteLine($"Буква '{буква}' является гласной");
            }
            else if (char.IsLetter(буква))
            {
                Console.WriteLine($"Буква '{буква}' является согласной");
            }
            else
            {
                Console.WriteLine("Это не буква");
            }
            Console.ReadKey();
        }
    }
