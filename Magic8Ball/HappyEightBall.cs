using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    public class HappyEightBall : IQuestionable
    {
        static List<string> happyAnswers = new List<string>();

        public void Answer()
        {
            ShowAnswer();
        }

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

        public void ShowAnswer()
        {
            Random rng = new Random();
            int index = rng.Next(happyAnswers.Count());

            Console.WriteLine("Well hello there! Let me see now...");
            Console.WriteLine(happyAnswers[index]);
        }

    }
}
