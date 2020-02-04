using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        // - Lav et dictionary der kan gemme booleans og bruge float som key. Gem 10 forskellige værdier heri.
        static void Main(string[] args)
        {
            Dictionary<float, bool> testionary = new Dictionary<float, bool>();

            testionary[1.1f] = true;
            testionary[1.2f] = false;
            testionary[1.3f] = true;
            testionary[1.4f] = false;
            testionary[1.5f] = true;
            testionary[1.6f] = false;
            testionary[1.7f] = true;
            testionary[1.8f] = false;
            testionary[1.9f] = true;
            testionary[1.10f] = false;
        }
    }
}
