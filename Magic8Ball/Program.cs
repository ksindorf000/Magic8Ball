using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    class Program
    {
        /******************************************
         * Main()
        ******************************************/
        static void Main(string[] args)
        {
            string question;
            bool askAgain = true;
           
            while (askAgain)
            {
                Console.WriteLine("Please ask a yes or no question: ");
                question = Console.ReadLine();
                
                Console.WriteLine("\n");
                Console.WriteLine(PlayGame.ChooseEightBall());
                Console.WriteLine("\n");

                askAgain = KeepPlayingInput();
            }
        }

        /*********************************************
         * KeepPlayingInput()
         *      Ask and (validate input) if the player 
         *      wants to ask another question
        **********************************************/
        static bool KeepPlayingInput()
        {
            bool valid = false;
            bool askAgain = true;

            while (!valid)
            {
                Console.WriteLine("Ask another (Y/N):");
                string yN = Console.ReadLine().ToString().ToLower();

                if (yN == "y")
                {
                    askAgain = true;
                    valid = true;
                }
                else if (yN == "n")
                {
                    askAgain = false;
                    valid = true;
                }
                else
                {
                    valid = false;
                }
            }

            return askAgain;
        }
    }
}
