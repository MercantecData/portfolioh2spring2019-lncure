using System;

namespace Udfordring
{
    class Program
    {
        public class math
        {

            //------------------------------------------------------
            public static int Add(int a, int b)
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
                int flam;
                int ingo;

                Int32.TryParse(a, out flam);
                Int32.TryParse(b, out ingo);

                return (flam + ingo).ToString();
            }
            public delegate int DelegateTest(int a, int b);
            static void Main(string[] args)
            {
                Console.WriteLine(math.Add("4", "9"));
                
                Console.ReadKey();

                DelegateTest a1 = Add;

                a1(14, 32);
            }
        }
    }
}
