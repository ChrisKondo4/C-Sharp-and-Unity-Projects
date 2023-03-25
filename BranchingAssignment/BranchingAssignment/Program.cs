using System;

namespace BranchingAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\nWhat is your package's weight?");
            double weight = Convert.ToDouble(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("What is your package's width?");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is your package's height?");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is your package's length?");
                double length = Convert.ToDouble(Console.ReadLine());
                if ((width + height + length) > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    double total = ((height * width * length) * weight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + total + "\nThank you!");
                }
            }
        }
    }
}
