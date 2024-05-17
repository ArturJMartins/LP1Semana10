using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class Model
    {
        public int TargetNumber { get; private set; }
        public int Attempts { get; private set; }
        public bool GuessCorrectly { get; private set; }

        public Model()
        {
            
            Attempts = 0;
            GuessCorrectly = false;

            Random random = new Random();
            TargetNumber = random.Next(1, 101);
        }

        public void IncreaseAttempts()
        {
            Attempts++;
        }

        public void SetGuessCorrectly(bool guessCorrectly)
        {
            GuessCorrectly = guessCorrectly;
        }
    }
}