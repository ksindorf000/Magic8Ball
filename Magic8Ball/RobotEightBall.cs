using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    public class RobotEightBall : IQuestionable
    {
        public List<string> robotAnswers = new List<string>();

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
            int index = rng.Next(robotAnswers.Count());

            return "Computing... Computing... \n " + 
                $"{robotAnswers[index]}";
        }

        /******************************************
         * GenerateAnswers()
         *      Adds 3 negative, 3 positive, and 
         *      3 neutral answers to a list
        ******************************************/
        private void GenerateAnswers()
        {
            //Add negative responses
            robotAnswers.Add("Negative.");
            robotAnswers.Add("No.");
            robotAnswers.Add("False.");

            //Add positive responses
            robotAnswers.Add("Affirmative.");
            robotAnswers.Add("Yes.");
            robotAnswers.Add("True.");

            //Add neutral responses
            robotAnswers.Add("The odds are 50/50.");
            robotAnswers.Add("A 50 percent chance has been determined.");
        }
    }
}
