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
        static Delegayte a = Funktion;

        public static void Funktion()
        {
            Console.WriteLine("yo");
        }
        //------------------------------------------------------
        //- Lav en anden delegate som returnerer float og tager imod ingen parametre. Kald denne.
        public delegate float Delegayte1();
        static Delegayte1 b = Funktion1;

        public static float Funktion1()
        {
            float abc = 1.5f + 4.0f;
            Console.WriteLine(abc);
            return abc;
        }
        //------------------------------------------------------
        //- Lav en anden delegate som returnerer void og tager imod 3 parametere.Kald denne.
        public delegate void Delegayte2(string q, string w, string e);
        static Delegayte2 c = Funktion2();

        public static void Funktion2(string q, string w, string e)
        {
            q = "skinkeost";
            w = "osteSkinke";
            e = "SsktienkSekinke";

            Console.WriteLine(q + w + e);
        }
    }
}
