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

        static string[] answers = new string[numberOfAnswers];
        static int numberOfAnswers = 40;
        static int correctAnswer;

        static string playerName;

        static int correctAnswers = 0;
        static void Main(string[] args)
        {
            PlayerName();
        }

        static void DisplayHUD()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(playerName);
            Console.WriteLine("Question: " + questions[currentQuestion]);
            Console.WriteLine("Score: " + correctAnswers);
        }

        static void PlayerName()
        {
            Console.WriteLine("Enter your Name");
            playerName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Welcome, " + playerName);
            Console.ReadKey();
        }

        static void AskQuestion()
        {

        }
    }
}
