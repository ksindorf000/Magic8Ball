using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    public class HappyEightBall : IQuestionable
    {
        public List<string> happyAnswers = new List<string>();

        /***********************************************
         * Answer()
         *      Called by Program.cs to show the answer
        ***********************************************/
        public string Answer()
        {
            return ShowAnswer();
        }

        /******************************************
         * GenerateAnswers()
         *      Adds 3 negative, 3 positive, and 
         *      3 neutral answers to a list
        ******************************************/
        public void GenerateAnswers()
        {
            //Add negative responses
            happyAnswers.Add("Sorry, I don't think so. " + 
                "But cheer up! You'll get some good news today!");
            happyAnswers.Add("No, I'm afraid not. " +
                "But I see a lucky streak headed your way!");
            happyAnswers.Add("Oh no, probably not." +
                "But you never know! I could be wrong!");

            //Add positive responses
            happyAnswers.Add("Whoohooo! The answer is yes!");
            happyAnswers.Add("Congratulations! Pop open the bubbly!");
            happyAnswers.Add("Call me a genie, your wish will come true!");

            //Add neutral responses
            happyAnswers.Add("If you were asking if the glass is half empty, " +
                "I'd say it's half-full.");
            happyAnswers.Add("I can't tell you that... " + 
                "but keep your fingers crossed!");
        }

        /*********************************************
         * ShowAnswer()
         *      Returns a random answer from the list
        *********************************************/
        public string ShowAnswer()
        {
            Random rng = new Random();
            int index = rng.Next(happyAnswers.Count());

            return "Well hello there! Let me see now... \n " + $"{happyAnswers[index]}";
        }

    }
}
