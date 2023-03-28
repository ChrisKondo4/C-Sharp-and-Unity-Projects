using System;
using System.Collections.Generic;

namespace ConsAppAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "Hello, ", "my name is ", "whatever ", "you decide! " };
            Console.WriteLine("Please say something back!");
            string back = Console.ReadLine();
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += back;
            }
            foreach (string index in stringArray)
            {
                Console.WriteLine(index);
            }


            byte infinite = 0;
            while (infinite < 3)
            {
                Console.WriteLine("INFINITY!!!");
                infinite++;
            }
            Console.WriteLine("Or not?\nType something else to continue.");
            Console.ReadLine();

            while (infinite < 6)
            {
                Console.WriteLine("INFINITY!!! AGAIN!!!");
                infinite++;
            }
            Console.WriteLine("Again? Really?\nType something else to continue.");
            Console.ReadLine();

            while (infinite <= 9)
            {
                Console.WriteLine("INFINITY!!! ONCE AGAIN!!!");
                infinite++;
            }
            Console.WriteLine("Okay fine, I'll stop it.");
            Console.ReadLine();


            List<string> stringList = new List<string>();
            stringList.Add("watermelon");
            stringList.Add("pear");
            stringList.Add("banana");
            stringList.Add("nectarine");

            Console.WriteLine("Try to guess one of my top 4 fruits.");
            string guess = Console.ReadLine();
            bool isGuessed = false;

            do
            {
                switch (guess)
                {
                    case "watermelon":
                        Console.WriteLine("0");
                        isGuessed = true;
                        break;
                    case "pear":
                        Console.WriteLine("1");
                        isGuessed = true;
                        break;
                    case "banana":
                        Console.WriteLine("2");
                        isGuessed = true;
                        break;
                    case "nectarine":
                        Console.WriteLine("3");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are incorrect. Try again.");
                        guess = Console.ReadLine();
                        break;
                }
            }
            while (!isGuessed);
            Console.ReadLine();


            List<string> stringList1 = new List<string>();
            stringList1.Add("Hello");
            stringList1.Add("Hi");
            stringList1.Add("Hey");
            stringList1.Add("Good afternoon");
            stringList1.Add("Good evening");
            stringList1.Add("Good morning");
            stringList1.Add("Hey");

            Console.WriteLine("Please name a greeting.");
            string greeting = Console.ReadLine();
            bool gotit = false;
            for (int i = 0; i < stringList1.Count ; i++ )
            {
                if (greeting == stringList1[i])
                {
                    Console.WriteLine(i);
                    gotit = true;
                }
            }
            if (gotit == false) {
                Console.WriteLine("Your greeting isn't on my list.");
            }

            Console.ReadLine();
            List<string> stringList2 = new List<string>();
            bool start = true;
            foreach (string indices in stringList1)
            {
                if (start == true)
                {
                    stringList2.Add(indices);
                    Console.WriteLine(indices);
                    start = false;
                }
                foreach (string indices1 in stringList2)
                {
                    if (indices1 == indices)
                    {
                        Console.WriteLine(indices + "Has shown up before!");
                    }
                    else
                    {
                        Console.WriteLine(indices);
                        stringList2.Add(indices);
                    }
                }
            }
        }
    }
}
