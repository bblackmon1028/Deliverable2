using System;

namespace Deliverable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Table for how many?");
            int partySize = int.Parse(Console.ReadLine());

            if (partySize <= 6)
            {
                Console.WriteLine(
                    "Awesome, follow me right this way! \n" +
                    "Let's get started with some drinks. We have water and soda.\n");

                int waterCount = 0;
                int sodaCount = 0;


                for (int i = 1; i <= partySize; i++)
                {
                    Console.WriteLine("Person number " + i + " what is your drink?");
                    string drink = Console.ReadLine();

                    if (drink.Equals("Water", StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine("\nWater, got it.\n");
                        waterCount += 1;
                    }
                    else if (drink.Equals("Soda", StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine("\nSoda, got it\n");
                        sodaCount += 1;
                    }
                    else
                    {
                        Console.WriteLine("\nSorry, we don't have that.\n");
                    }
                }

                //Buffet $9.99, water is free, and Soda is $3
                double buffetTotal = partySize * 9.99;
                double waterTotal = 0;
                double sodaTotal = sodaCount * 3;
                double billTotal = buffetTotal + sodaTotal;


                Console.WriteLine(
                    "\nOk, so that will be " + waterCount + " water(s) and " + sodaCount + " soda(s). \n" +
                    "While I grab your drinks, feel free to hit the buffet! \n" +
                    "\nHere's your bill! Your total is: $" + billTotal);
            }
            else
            {
                Console.WriteLine("Sorry, we only accept parties of 6 or less people.");
            }
        }
    }
}
