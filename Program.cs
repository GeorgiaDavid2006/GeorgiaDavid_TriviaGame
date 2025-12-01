using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeorgiaDavid_TriviaGame
{
    internal class Program
    {
        static string[] questions = new string[numberOfQuestions];
        static int numberOfQuestions = 10;
        static int currentQuestion;

        static string playerName = ("Player");

        static int correctAnswers = 0;
        static void Main(string[] args)
        {
            
        }

        static void DisplayHUD()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Player");
            Console.WriteLine("Question: " + questions[currentQuestion]);
            Console.WriteLine("Score: " + correctAnswers);
        }
    }
}
