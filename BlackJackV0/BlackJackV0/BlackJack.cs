using System;
/// <summary>
/// A simple example of Blackjack card game
/// </summary>
namespace JAMK.IT
{
    class BlackJack
    {

        static void Main()
        {
            while(true)
                { 
            Random rnd = new Random();
            int myNumber = rnd.Next(1, 22);
            int theirNumber;
            
            
                out1:
                System.Console.WriteLine("*** BlackJack! ***");
                System.Console.Write("Can you beat my number? Enter any number between 1-21: ");

            string line = System.Console.ReadLine();

            if (line == "exit") 
            {
                break;
            }
               
            if (int.TryParse(line, out  < 1 || theirNumber > 21)
                {
                    Console.WriteLine("The given number is out of limits, try again.");
                    goto out1;
                }
                else
                {

                    //comparing
                    if (theirNumber >= myNumber && theirNumber <= 21)
                    {
                        System.Console.WriteLine("You win.");
                    }
                    else
                    {
                        System.Console.WriteLine("You lose.");
                    }
                }
            }
        }
    }
}