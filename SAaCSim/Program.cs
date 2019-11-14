using System;

namespace SAaCSim
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;
            
            do
            {
                // Task18 task18 =  new Task18(ρ: 0.5, π1: 0.6, π2:0.4);
                Task18 task18 = new Task18(ρ: 0.5, π1: 0, π2: 0.9);

                task18.Execute();
                Console.WriteLine("Press Escape to exit.");
                keyInfo = Console.ReadKey();
                Console.Clear();
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}