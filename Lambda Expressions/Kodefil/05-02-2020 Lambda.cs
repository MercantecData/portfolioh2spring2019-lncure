using System;

namespace Lambda_Expression
{
    class Program
    {
        // - Lav en Lambda Expression der tager imod en int og returnerer tallet fordoblet. Gem i en passende delegate, og kør.
        public delegate int Opg1Delegate(int number);

        // - Lav en Lambda Expression der tager imod 3 floats og returnerer summen. Gem i en passende delegate, og kør.
        public delegate float Opg2Delegate(float a, float b, float c);

        // - Lav en Lambda Expression der ikke tager imod noget og returnerer "Hello World". Gem i en passende delegate og kør.
        public delegate string Opg3Delegate();
        //---------------------------------------------------------------------------------------------------------------------

        static void Main(string[] args)
        {
            Opg1Delegate del1 = (x) => x + x;

            Console.WriteLine(del1(12)); //12 er basically det vil sætter ind for at overtage x's plads.

            //----------------------------------------------------------------------------------------

            Opg2Delegate del2 = (a, b, c) => a + b + c;

            Console.WriteLine(del2(12.5f, 3.4f, 2.5f));

            //----------------------------------------------------------------------------------------

            Opg3Delegate del3 = () => "Hello World";

            Console.WriteLine((del3()));

            //----------------------------------------------------------------------------------------
        }
    }
}
