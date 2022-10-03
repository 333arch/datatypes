using System;

namespace ConsoleApp1
{
    class Program
    {
        static int DiceRoll(int Faces)
        {
            Random Roll = new Random();
            return Roll.Next(1, Faces);
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Please input the number of faces on the dice");
            int Faces = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DiceRoll(Faces));
        }
    }
}
