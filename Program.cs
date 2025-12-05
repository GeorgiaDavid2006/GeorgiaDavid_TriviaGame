using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeorgiaDavid_TriviaGame
{
    internal class Program
    {
        static int numberOfQuestions = 10;
        static string[] questions = new string[numberOfQuestions];
        static int currentQuestion;

        static string[] answers =
        {
            {"incorrectAnswer1", "incorrectAnswer2", "correctAnswer","incorrectAnswer3"}
            {"incorrectAnswer1", "correctAnswer", "incorrectAnswer2", "incorrectAnswer3"}
            {"incorrectAnswer1", "incorrectAnswer2", "incorrectAnswer3", "correctAnswer"}
            {"correctAnswer", "incorrectAnswer1", "incorrectAnswer2", "incorrectAnswer3"}
            {"incorrectAnswer1", "correctAnswer", "incorrectAnswer2", "incorrectAnswer3"}
            {"correctAnswer", "incorrectAnswer1", "incorrectAnswer2", "incorrectAnswer3"}
            {"incorrectAnswer1", "incorrectAnswer2", "incorrectAnswer3", "correctAnswer"}
            {"incorrectAnswer1", "incorrectAnswer2", "correctAnswer","incorrectAnswer3"}
            {"incorrectAnswer1", "incorrectAnswer2", "correctAnswer","incorrectAnswer3"}
            {"incorrectAnswer1", "correctAnswer", "incorrectAnswer2", "incorrectAnswer3"}
        }

        static string playerName;

        static int correctAnswers = 0;

        static void Main(string[] args)
        {
            PlayerName();
            AskQuestion();
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
            for (int question = 0; question <= questions.GetLength; question++)
            {
                DisplayHUD();
                Console.WriteLine(questions[question]);
            }  
        }
    }
}
