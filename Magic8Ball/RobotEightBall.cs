using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    public class RobotEightBall : IQuestionable
    {
        static List<string> robotAnswers = new List<string>();

        public void Answer()
        {
            ShowAnswer();
        }

        public void GenerateAnswers()
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

        public void ShowAnswer()
        {
            Random rng = new Random();
            int index = rng.Next(robotAnswers.Count());
            
            Console.WriteLine("Computing... Computing...");
            Console.WriteLine(robotAnswers[index]);
        }

    }
}
