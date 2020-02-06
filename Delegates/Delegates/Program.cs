using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            a();
        }

        // - Lav en delegate som returnerer void og tager imod ingen parametre. Kald denne.
        public delegate void Delegayte();
        static Delegayte a = funktion;

        public static void funktion()
        {
            Console.WriteLine("yo");
        }
        //------------------------------------------------------
        //- Lav en anden delegate som returnerer float og tager imod ingen parametre. Kald denne.
        public delegate float Delegayte1();
        static Delegayte1 b = funktion1;

        public static float funktion1()
        {
            float abc = 1.5f + 4.0f;
            Console.WriteLine(abc);
            return abc;
        }

        //------------------------------------------------------
        //- Lav en anden delegate som returnerer void og tager imod 3 parametere.Kald denne.
    }
}
