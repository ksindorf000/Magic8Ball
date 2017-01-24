using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    public class SadEightBall : IQuestionable
    {
        public List<string> sadAnswers = new List<string>();

        /***********************************************
         * Answer()
         *      Called by Program.cs to show the answer
        ***********************************************/
        public string Answer()
        {
            return ShowAnswer();
        }

        /*********************************************
         * ShowAnswer()
         *      Returns a random answer from the list
        *********************************************/
        public string ShowAnswer()
        {
            GenerateAnswers();

            Random rng = new Random();
            int index = rng.Next(sadAnswers.Count());

            return "Oh yippee... another question... \n" +
                $"{sadAnswers[index]}";
        }

        /******************************************
         * GenerateAnswers()
         *      Adds 3 negative, 3 positive, and 
         *      3 neutral answers to a list
        ******************************************/
        public void GenerateAnswers()
        {
            //Add negative responses
            sadAnswers.Add("Wish I could say yes, but I don't want to.");
            sadAnswers.Add("I'd say no but nobody listens to me anyway...");
            sadAnswers.Add("No, but what's new?");

            //Add positive responses
            sadAnswers.Add("Yes. Sure is a cheerful answer - I guess it'll do.");
            sadAnswers.Add("Yes. But please keep your shirt on, " + 
                "we are professionals around here.");
            sadAnswers.Add("I suppose you'll find out anyway... the answer is yes.");

            //Add neutral responses
            sadAnswers.Add("Maybe yes, maybe no. Who knows, really?");
            sadAnswers.Add("Really though, does it matter?");
        }
    }
}
