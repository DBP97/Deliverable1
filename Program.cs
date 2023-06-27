using System;

namespace Deliverable_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            string series = "";

            while (true)

            // First question for user 
            try
            {
                Console.Write("Enter an integer number between 1 and 100: ");
                input = int.Parse(Console.ReadLine());

                if (input >= 1 && input <= 100)
                {
                    break;
                }

                // If user enters an integer below 1 or higher than 100
                else
                {
                        Console.WriteLine("Please enter an integer number between 1 and 100.");
                }
            }

            // If user enters anything other than an integer
            catch
            {
                Console.WriteLine("Please use an integer number");
                Console.ReadKey(true);
            }

            // Second question for user
            while (true)
            {
                Console.Write("Specify the series type: Even or Odd: ");
                series = Console.ReadLine();

                // Pathway if user asks to list odd numbers
                if (series == "odd" || series == "Odd" || series == "ODD")
                {
                    try
                    {
                        Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are:");
                        int i = 1;
                        while (i <= input)
                        {
                            Console.WriteLine(i);
                            i = i + 2;
                        }
                        break;
                    }

                    // If user enters anything other than "even" or "odd"
                    catch
                    {
                        Console.WriteLine("Please specify the series type: Even or Odd: ");
                    }

                }

                // Pathway if user asks to list even numbers
                else if (series == "even" || series == "Even" || series == "EVEN")
                {
                    try
                    {
                        Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are:");
                        int i = 0;
                        while (i <= input)
                        {
                            Console.WriteLine(i);
                            i = i + 2;
                        }
                        break;
                    }

                    // If user enters anything other than "even" or "odd"
                    catch
                    {
                        Console.WriteLine("Please specify the series type: Even or Odd: ");
                    }
                }
            }

        }
    }
}
