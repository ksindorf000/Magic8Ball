using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MagicEightBall.Test
{
    [TestClass]
    public class UnitTest1
    {
        /******************************************
         * PlayGameGetsRandomAnswer()
         *      Randomly chooses an answer from an
         *      IQuestionable class
        ******************************************/
        [TestMethod]
        public void PlayGameGetsRandomAnswer()
        {
            RobotEightBall robot = new RobotEightBall();
            string answer = PlayGame.GetAnswer(robot);
            string answer2 = PlayGame.GetAnswer(robot);

            Assert.AreNotEqual(answer, answer2);
        }
    }
}
