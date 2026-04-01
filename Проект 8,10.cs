using System;
using System.IO;
    class Program
    {
        static void Main(string[] args)
        {
            string путь = "input.txt";
            
            if (File.Exists(путь))
            {
                string содержимое = File.ReadAllText(путь);
                Console.WriteLine("Содержимое файла:");
                Console.WriteLine(содержимое);
            }
            else
            {
                Console.WriteLine("Файл input.txt не найден");
            }
            Console.ReadKey();
        }
    }
