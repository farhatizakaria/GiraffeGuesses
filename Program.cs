using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {

            thinkingNumber(); // Calling the function
            Console.ReadKey(); // Keeps the window's console openning
            
        }
        private static void thinkingNumber()
        {
            Random randNum = new Random(); // Initializing
            int computerNum = randNum.Next(1, 7);
            // Declaring values
            bool inCorrect = true;
            int userNumGuessed;
            int tryingCounter = 0;

            //                          LET'S MAKE A LOOP                                //
            do
            {
                // Some chat codes
                Console.WriteLine("What's your guessed number between 1 and 7 ? ");
                userNumGuessed = int.Parse(Console.ReadLine());
                if (userNumGuessed == computerNum)
                {
                    Console.WriteLine("You got it, it's correct number ! ");
                    Console.WriteLine("The trying counter says you tried {0} times", tryingCounter);
                    Console.ReadKey();
                    inCorrect = false;
                }
                else
                {
                    Console.WriteLine("Nope It's incorrect");
                    //inCorrect = true;
                    tryingCounter++;
                    //Console.Clear();
                }

            } while (inCorrect); // Looping while the user is loser :) LOL!
        }
    }
}
