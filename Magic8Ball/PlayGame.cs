using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    public class PlayGame
    {
        //Create EightBalls
        static RobotEightBall robot = new RobotEightBall();
        static SadEightBall sad = new SadEightBall();
        static HappyEightBall happy = new HappyEightBall();

        /******************************************
         * ChooseEightBall()
         *      Randomly chooses an eight ball
        ******************************************/
        public static string ChooseEightBall()
        {
            Random rng = new Random();
            int i = rng.Next(1, 20);

            if (i % 2 == 0)
            {
                return GetAnswer(robot);
            }
            else if (i % 3 == 0)
            {
                return GetAnswer(happy);
            }
            else
            {
                return GetAnswer(sad);
            }
        }

        /***************************************************
         * GetAnswer()
         *      Gets an answer from the selected eight ball
        ***************************************************/
        static string GetAnswer(IQuestionable EightBall)
        {
            return EightBall.Answer();
        }
    }
}
