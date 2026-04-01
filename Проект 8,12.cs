using System;
using System.IO;
using System.Text;
    class Program
    {
        static void Main(string[] args)
        {
            string путь = "secret.txt";     
            if (!File.Exists(путь))
            {
                Console.WriteLine("Файл secret.txt не найден");
                Console.ReadKey();
                return;
            }       
            string текст = File.ReadAllText(путь);
            StringBuilder зашифрованный = new StringBuilder();      
            foreach (char символ in текст)
            {
                if (char.IsLetter(символ))
                {
                    зашифрованный.Append('*');
                }
                else
                {
                    зашифрованный.Append(символ);
                }
            }
            
            File.WriteAllText("encrypted.txt", зашифрованный.ToString());
            Console.WriteLine("Файл encrypted.txt создан");
            Console.ReadKey();
        }
    }
