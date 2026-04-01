using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string предложение = Console.ReadLine();   
            string[] слова = предложение.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); 
            Console.WriteLine($"Количество слов: {слова.Length}");
            Console.ReadKey();
        }
    }
