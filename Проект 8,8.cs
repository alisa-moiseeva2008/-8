using System.Text;
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку с цифрами: ");
            string строка = Console.ReadLine(); 
            StringBuilder результат = new StringBuilder();  
            foreach (char символ in строка)
            {
                if (!char.IsDigit(символ))
                {
                    результат.Append(символ);
                }
            }        
            Console.WriteLine($"Результат: {результат}");
            Console.ReadKey();
        }
    }
