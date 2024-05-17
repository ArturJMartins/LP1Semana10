using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace PlayerManager4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Controller prog = new Controller();
            UglyView view = new UglyView();
            // Start the program instance
            prog.Start(view);
        }
    }
}