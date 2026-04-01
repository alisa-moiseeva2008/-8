using System;
using System.Text;
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string символы = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder пароль = new StringBuilder();
            
            for (int i = 0; i < 8; i++)
            {
                пароль.Append(символы[rnd.Next(символы.Length)]);
            }       
            Console.WriteLine($"Сгенерированный пароль: {пароль}");
            Console.ReadKey();
        }
    }
