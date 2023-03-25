using System;


namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1, 2, or 3?");
            byte num1 = Convert.ToByte(Console.ReadLine());

            while (num1 == 1 || num1 == 2)
            {
                Console.WriteLine("You chose incorrectly.");
                num1 = Convert.ToByte(Console.ReadLine());
                break;
            }

            Console.WriteLine("1, 2, or 3? For real this time.");
            num1 = Convert.ToByte(Console.ReadLine());
            bool objective = false;

            do
            {
                switch (num1)
                {
                    case 1:
                        Console.WriteLine("No. Try again.");
                        num1 = Convert.ToByte(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("No. Try again.");
                        num1 = Convert.ToByte(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Yes!");
                        objective = true;
                        break;
                }
            }
            while (!objective);
            Console.ReadLine();
        }
    }
}