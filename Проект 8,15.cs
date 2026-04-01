using System;
using System.IO;
using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            string путь = "book.txt";  
            if (!File.Exists(путь))
            {
                Console.WriteLine("Файл book.txt не найден");
                Console.ReadKey();
                return;
            }           
            string текст = File.ReadAllText(путь);
            int символов = текст.Length;        
            string[] строки = File.ReadAllLines(путь);
            int количествоСтрок = строки.Length;     
            string[] слова = текст.Split(new char[] { ' ', '\n', '\r', '\t', '.', ',', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
            int количествоСлов = слова.Length;   
            Console.WriteLine($"Количество символов: {символов}");
            Console.WriteLine($"Количество слов: {количествоСлов}");
            Console.WriteLine($"Количество строк: {количествоСтрок}");
            Console.ReadKey();
        }
    }
