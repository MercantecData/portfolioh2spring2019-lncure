using System;

namespace Overloading_mathclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(math.Add("hjælp ","mig"));
            Console.ReadKey();

        }

        public class math
        {
            //------------------------------------------------------
            public static int Add (int a, int b)
            {
                return a + b; 
            }
            public static int Subtract(int a, int b)
            {
                return a - b;
            }
            public static int Divide(int a, int b)
            {
                return a / b;
            }
            public static int Multiply(int a, int b)
            {
                return a * b;
            }

            //-------------------------------------------------------

            public static float Add(float a, float b)
            {
                return a + b;
            }
            public static float Subtract(float a, float b)
            {
                return a + b;
            }
            public static float Divide(float a, float b)
            {
                return a + b;
            }
            public static float Multiply(float a, float b)
            {
                return a + b;
            }

            //--------------------------------------------------------

            public static string Add(string a, string b)
            {
                return a + b;
            }
        }
    }
}
