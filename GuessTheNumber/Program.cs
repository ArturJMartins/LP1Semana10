using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main()
        {
            Controller prog = new Controller();
            UglyView view = new UglyView();

            Model modelo = new Model();
            // Start the program instance
            prog.Start(view,modelo);
        }
    }
}