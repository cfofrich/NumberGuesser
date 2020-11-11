using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var randomNumber = random.Next(10);

            Console.WriteLine("Pick a number between 1-10. I will tell you if you guessed correctly. You have 5 attempts");


            for (var index = 4; index >= 0; index--)

            {
                try
                {
                    int userNumber = Int32.Parse(Console.ReadLine());

                    if (randomNumber == userNumber)
                    {
                        Console.WriteLine("You guessed right!");
                        break;
                    }

                    else if (userNumber < 0 || userNumber > 10)
                    {
                        Console.WriteLine("Please guess a number between 1-10.");
                    }

                    else
                    {
                        Console.WriteLine("You guessed wrong!");
                        Console.WriteLine("You have " + index + " attempts remaining");
                    }
                }

                catch
                {
                    Console.WriteLine("Please enter a number");
                }


                
            }
        }
    }
}
