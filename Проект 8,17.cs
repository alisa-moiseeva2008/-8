using System;
using System.Data;
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите математическое выражение (например, 2+3*4): ");
            string выражение = Console.ReadLine();     
            try
            {
                var результат = new DataTable().Compute(выражение, null);
                Console.WriteLine($"Результат: {результат}");
            }
            catch
            {
                Console.WriteLine("Ошибка в выражении");
            }
            Console.ReadKey();
        }
    }
