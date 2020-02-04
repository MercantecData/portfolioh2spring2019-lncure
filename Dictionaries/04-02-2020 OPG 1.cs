using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        // - Lav et dictionary der kan gemme tal, og bruge strings som key. Gem 10 forskellige værdier heri.
        static void Main(string[] args)
        {
            Dictionary<string, int> testionary = new Dictionary<string, int>();

            testionary["a"] = 1;
            testionary["b"] = 2;
            testionary["c"] = 3;
            testionary["d"] = 4;
            testionary["e"] = 5;
            testionary["f"] = 6;
            testionary["g"] = 7;
            testionary["h"] = 8;
            testionary["i"] = 9;
            testionary["j"] = 10;
        }
    }
}
