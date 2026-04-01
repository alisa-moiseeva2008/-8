using System;
using System.IO;
    class Program
    {
        static void Main(string[] args)
        {
            string путь = "text.txt";
            
            if (!File.Exists(путь))
            {
                Console.WriteLine("Файл text.txt не найден");
                Console.ReadKey();
                return;
            }           
            Console.Write("Введите слово для поиска: ");
            string слово = Console.ReadLine();
            
            string текст = File.ReadAllText(путь);
            string[] слова = текст.Split(new char[] { ' ', '\n', '\r', '\t', '.', ',', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);       
            int количество = 0;
            foreach (string с in слова)
            {
                if (с.Equals(слово, StringComparison.OrdinalIgnoreCase))
                {
                    количество++;
                }
            }
            
            Console.WriteLine($"Слово '{слово}' встречается {количество} раз");
            Console.ReadKey();
        }
    }
