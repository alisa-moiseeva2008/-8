using System.IO;
    class Program
    {
        static void Main(string[] args)
        {
            string путь = "data.txt";
            if (!File.Exists(путь))
            {
                Console.WriteLine("Файл data.txt не найден");
                Console.ReadKey();
                return;
            }   
            string[] строки = File.ReadAllLines(путь);
            List<string> отфильтрованные = new List<string>();
            
            foreach (string строка in строки)
            {
                if (строка.Length >= 5)
                {
                    отфильтрованные.Add(строка);
                }
            }         
            File.WriteAllLines("filtered.txt", отфильтрованные);
            Console.WriteLine("Файл filtered.txt создан");
            Console.ReadKey();
        }
    }
