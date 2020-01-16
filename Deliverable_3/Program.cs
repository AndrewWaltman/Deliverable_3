using System;

namespace Deliverable_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The goal of this project is to have the user insert a number between 1 and 100, and have the computer
            run through with odd an even number solutions throughout the program.
            */
            Console.WriteLine("Hello and welcome to the magic of computers! \nWith this program, we can see the number you've given, and decipher it as an even or odd number and more.");
            Console.WriteLine("First, however, could you please give us your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hey thanks. Now, please insert a number between 1 and 100: ");           
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 1)
            {
                Console.WriteLine("Well, "+ name +". Your number is " + number + ", which is an odd number.");
            }
            else if ((number % 2 == 1) && (number >= 61))
            {
                Console.WriteLine("Well, " + name + ". Your number is " + number + "which is odd, and greater than 60.");
            }

            if ((number % 2 == 0) && (number >= 2 && number <= 25 ))
            {
                Console.WriteLine("Well, " + name + ". Your number is " + number+ " which is even, and less than 25.");
            }
            else if ((number % 2 == 0) && (number >= 26 && number <= 60))
            {
                Console.WriteLine("Well, " + name + ". Your number is " + number + " which is even, and less than 60.");
            }
            else if ((number % 2 == 0) && (number >= 62))
            {
                Console.WriteLine("Well, " + name + ". Your number is " + number + " which is even, and greater than 60.");
            }
        }
    }
}
