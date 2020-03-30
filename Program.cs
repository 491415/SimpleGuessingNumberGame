using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGuessingNumberGame
{
    public class Program
    {
		public static void drawPotato()
		{
			Console.WriteLine("   **");
			Console.WriteLine(" **  **");
			Console.WriteLine("**    **");
			Console.WriteLine("**    **");
			Console.WriteLine(" **  **");
			Console.WriteLine("   **");
		}
        public static int drawNumber()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 101);
            return randomNumber;
        }
		
        public static void Main(string[] args)
        {
            int drawnNumber = drawNumber();
            int guessCounter = 0;
			Console.Write("Guess a number between 1 and 100: ");
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                guessCounter++;
                if (number > 0 && number < 101)
                {
                    if (number > drawnNumber)
                    {
                        Console.WriteLine("Your number is greater, please guess again. Guess counter: {0}", guessCounter);
                    }
                    else if (number < drawnNumber)
                    {
                        Console.WriteLine("Your number is lesser, please guess again. Guess counter: {0}", guessCounter);
                    }
                    else if (number == drawnNumber)
                    {
                        Console.WriteLine("Congratulations, you've guessed right. Guesses made: {0} \nHere is a picture of a potato.", guessCounter);
						drawPotato();
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("You have entered a number that is not within range.");
                }
            }
           
        }
    }
}