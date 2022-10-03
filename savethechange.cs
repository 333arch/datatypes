using System;

namespace ConsoleApp1
{
    class Program
    {
        static void savethechange(double Money)
        {
            double Rounded = Math.Round(Money);
            double Total = Rounded - Money;
            Console.WriteLine(Total);
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Please input money spent");
            double Money = Convert.ToDouble(Console.ReadLine());
            savethechange(Money);
        }
    }
}
