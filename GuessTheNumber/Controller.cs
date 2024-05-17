using System;

namespace GuessTheNumber
{
    public class Controller
    {
        public void Start(IView view,Model modelo)
        {
            int guess;

            view.WelcomeMessage();

            while (!modelo.GuessCorrectly)
            {
                guess = view.TakeAGuess();
                modelo.IncreaseAttempts();

                if (guess == modelo.TargetNumber)
                {
                    view.CorrectGuessNumber(modelo.Attempts);
                    modelo.SetGuessCorrectly(true);
                }
                else if (guess < modelo.TargetNumber)
                {
                    view.TryAgainLow();
                }
                else
                {
                    view.TryAgainHigh();
                }
            }

            view.ThankingMessage();
        }
    }
}