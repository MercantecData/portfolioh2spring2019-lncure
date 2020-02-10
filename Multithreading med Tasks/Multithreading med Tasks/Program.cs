using System;
using System.Threading.Tasks;

namespace Multithreading_med_Tasks
{
    class Program
    {
        static bool timeout = false;
        static void Main(string[] args)
        {
            //------------------------------------------------------------------------
            Console.WriteLine("------------------------------------");
            Console.WriteLine("||A random number has been chosen!||");
            Console.WriteLine("||You must guess what it could be!||");
            Console.WriteLine("||before the timer hits zero!!!!!!||");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Press 'Enter' When you're ready!");
            Console.ReadLine();

            //------------------------------------------------------------------------

            Task t = DoMyTask();
            //------------------------------------------------------------------------
            Random random = new Random();
            int returnValue = random.Next(0, 10);
            //------------------------------------------------------------------------

            int userGuess = 0;

            while (userGuess != returnValue)
            {
                try
                {
                    userGuess = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                }

                if (timeout)
                {
                    Console.WriteLine("Du er løbet tør for tid din fucking idiot");
                    return;
                }

                if (userGuess == returnValue)
                {
                    Console.WriteLine("You're gay lmao, btw you won");
                    return;
                }
                Console.WriteLine("Wrong! try again!");
            }
        }

        static async Task DoMyTask()
        {
            int numberCount = 10;

            while (numberCount != 0)
            {
                Console.WriteLine("You have " + numberCount + " seconds left to answer");
                numberCount--;
                await Task.Delay(1000);
            }
            Console.WriteLine("How many seconds... in eternity?");
            timeout = true;
        }
    }
}
