using System;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI?");
            string DUI = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            bool qualify = Convert.ToByte(age) > 15 && Convert.ToBoolean(DUI) == false && Convert.ToByte(tickets) < 3;
            Console.WriteLine("Qualifed?\n" + qualify);
        }
    }
}
