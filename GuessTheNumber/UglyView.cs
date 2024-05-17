using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class UglyView : IView
    {
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");
        }

        public void ThankingMessage()
        {
            Console.WriteLine("Thank you for playing Guess the Number!");
        }

        public int TakeAGuess()
        {
            Console.Write("Take a guess: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public void CorrectGuessNumber(int attempts)
        {
            Console.WriteLine(
                        "Congratulations! You guessed the number correctly!");
            Console.WriteLine("Number of attempts: " + attempts);
        }

        public void TryAgainLow()
        {
            Console.WriteLine("Too low! Try again.");
        }

        public void TryAgainHigh()
        {
            Console.WriteLine("Too high! Try again.");
        }
    }
}