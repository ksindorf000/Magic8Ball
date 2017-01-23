using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    class Program
    {
        static RobotEightBall robot = new RobotEightBall();
        static SadEightBall sad = new SadEightBall();
        static HappyEightBall happy = new HappyEightBall();

        /******************************************
         * Main()
        ******************************************/
        static void Main(string[] args)
        {
            Console.WriteLine("Please ask a yes or no question: ");
            string question = Console.ReadLine();

            ChooseEightBall();
        }

        /******************************************
         * ChooseEightBall()
         *      Randomly chooses an eight ball
        ******************************************/
        static void ChooseEightBall()
        {
            Random rng = new Random();
            int i = rng.Next(1, 3);
            
            if (i == 1)
            {
                GetAnswer(robot);
            }
            else if (i == 2)
            {
                GetAnswer(sad);
            }
            else
            {
                GetAnswer(happy);
            }
        }

        /***************************************************
         * GetAnswer()
         *      Gets an answer from the selected eight ball
        ***************************************************/
        static void GetAnswer(IQuestionable EightBall)
        {
            string answer = EightBall.Answer();
        }

    }
}
