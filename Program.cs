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
            "Health is less than zero",
            "Answer9",
            "Answer10",
            "Answer11",
            "Answer12",
            "Answer13",
            "Answer14",
            "Answer15",
            "Answer16",
            "Answer17",
            "Answer18",
            "Answer19",
            "Answer20",
            "Answer21",
            "Answer22",
            "Answer23",
            "Answer24",
            "Answer25",
            "Answer26",
            "Answer27",
            "Answer28",
            "Answer29",
            "Answer30",
            "Answer31",
            "Answer32",
            "Answer33",
            "Answer34",
            "Answer35",
            "Answer36",
            "Answer37",
            "Answer38",
            "Answer39",
            "Answer40",
        };

        static int answerNumber = 0;

        static string playerName;

        static int[] correctAnswers = {3, 2, 1, 1, 1, 1, 1, 1, 1, 1};

        static bool checkingForParse = true;

        static bool isPlaying = true;

        static int points = 0;

        static void Main(string[] args)
        {
            while(isPlaying)
            {
                PlayerName();
                AskQuestion();
                DisplayScore();
            }
        }

        static void DisplayScore()
        {
            bool playerEndPrompt = true; 

            while(playerEndPrompt == true)
            {
                Console.WriteLine($"You got {points / questions.Length}% of the questions right"); 
                if(points/questions.Length == 100)
                {
                    Console.WriteLine("Congratulations! You got everything right!");
                }
                else if(points/questions.Length == 0)
                {
                    Console.WriteLine("Maybe you need to brush up on your programming knowledge");
                }
                else
                {
                    Console.WriteLine("Well done");
                }
                    Console.WriteLine("Would you like to play again? [y/n]");
                string playerContinue = Console.ReadLine();
                if (playerContinue == "Y" || playerContinue == "y")
                {
                    playerEndPrompt = false;
                    points = 0;
                    answerNumber = 0;
                }
                else if (playerContinue == "N" || playerContinue == "n")
                {
                    isPlaying = false;
                    playerEndPrompt = false;
                    Console.WriteLine("Thank you for playing");
                    Console.ReadKey();
                }
                else
                {

                }
            }  
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
            for (int question = 0; question < questions.Length; question++)
            {
                DisplayHUD(question);
                for (int answer = 0; answer < answers.Length/questions.Length; answer++)
                {
                    Console.WriteLine($"\n{answer + 1} {answers[answerNumber]}");
                    answerNumber++;
                }

                checkingForParse = true;
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
