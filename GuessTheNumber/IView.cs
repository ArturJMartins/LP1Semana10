using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public interface IView
    {
        void WelcomeMessage();
        void ThankingMessage();
        void TryAgainLow();
        void TryAgainHigh();
        void CorrectGuessNumber(int attempts);
        int TakeAGuess();
    }
}