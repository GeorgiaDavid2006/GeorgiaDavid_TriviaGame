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
            {answers[0], answers[1], answers[2], answers[3]}
            {answers[4], answers[5], answers[6], answers[7]}
            {answers[8], answers[9], answers[10], answers[11]}
            {answers[12], answers[13], answers[14], answers[15]}
            {answers[16], answers[17], answers[18], answers[19]}
            {answers[20], answers[21], answers[22], answers[23]}
            {answers[24], answers[25], answers[26], answers[27]}
            {answers[28], answers[29], answers[30], answers[31]}
            {answers[32], answers[33], answers[34], answers[35]}
            {answers[36], answers[37], answers[38], answers[39]}
        }
        static int correctAnswer;

        static string playerName;

        static int correctAnswers = 0;

        static void Main(string[] args)
        {
            questions[0] = ("If you want an if statement to have two conditions, which would you use?")
            
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
            foreach (string question in questions)
            {
                Console.WriteLine(question);
                Console.Write("1) " + answers[0]);
                Console.WriteLine("2) " + answers[1]);
                Console.Write("3) " + answers[2]);
                Console.WriteLine("4) " + answers[3]);

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
