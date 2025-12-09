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
        static string[] questions = 
        {
         "If you want an if statement to have two conditions, which symbol should you use?",
         "What does this mean?: !health <= 0",
         "Question3", 
         "Question4", 
         "Question5", 
         "Question6", 
         "Question7", 
         "Question8", 
         "Question9", 
         "Question10"
        };

        static int currentQuestion;

        static string[] answers =
        {
            "==",
            "&",
            "&&",
            "#",
            "Health is equal to zero",
            "Health is not less than or equal to zero",
            "Health is less than or equal to zero",
            "Health is less than zero"
        };

        static int answerNumber = 0;

        static string playerName;

        static int[] correctAnswers = {3, 2};

        static bool checkingForParse = true;

        static int points = 0;

        static void Main(string[] args)
        {
            PlayerName();
            AskQuestion();
        }

        static void DisplayHUD(int currentQuestion)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(playerName);
            Console.WriteLine($"Question {currentQuestion+1}: {questions[currentQuestion]}");
            if(currentQuestion == 0)
            {
                Console.WriteLine("Score:" + points);
            }
            else
            {
                Console.WriteLine("Score:" + points / currentQuestion);
            }
        }

        static void PlayerName()
        {
            Console.WriteLine("Enter your Name");
            playerName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Welcome, " + playerName);
            Console.ReadKey();
            Console.Clear();
        }

        static void AskQuestion()
        {
            checkingForParse = true;
            

            for (int question = 0; question < questions.Length; question++)
            {
                DisplayHUD(question);
                for (int answer = 0; answer < 4; answer++)
                {
                    Console.WriteLine($"\n{answer + 1} {answers[answerNumber]}");
                    answerNumber++;
                }
                

                while (checkingForParse == true)
                {
                    string playerAnswer = Console.ReadLine();

                    if (int.TryParse(playerAnswer, out int answerInt) && answerInt <= 4 && answerInt > 0)
                    {
                        if(answerInt == correctAnswers[question])
                        {
                            Console.WriteLine("Correct");
                            points += 100;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect");
                        }

                        checkingForParse = false;
                    }
                    else
                    {
                        Console.WriteLine("Answer is Invalid");
                    }
                }

                //Console.Clear();

                Console.ForegroundColor = ConsoleColor.White;
                //Console.WriteLine(questions[question]);

                Console.ReadKey();
                Console.Clear();
            }  
        }
    }
}
