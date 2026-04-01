using System;
using System.IO;
    class Program
    {
        static void Main(string[] args)
        {
            string файл1 = "file1.txt";
            string файл2 = "file2.txt";
            string результат = "result.txt";
            
            if (!File.Exists(файл1))
            {
                Console.WriteLine("Файл file1.txt не найден");
                Console.ReadKey();
                return;
            }    
            if (!File.Exists(файл2))
            {
                Console.WriteLine("Файл file2.txt не найден");
                Console.ReadKey();
                return;
            }
            string текст1 = File.ReadAllText(файл1);
            string текст2 = File.ReadAllText(файл2);  
            string объединенный = текст1 + Environment.NewLine + текст2;
            File.WriteAllText(результат, объединенный);
            Console.WriteLine("Файл result.txt создан");
            Console.ReadKey();
        }
    }
