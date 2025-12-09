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
         "Which of these is a proper for loop?", 
         "How would you declare an array?", 
         "What is a string?", 
         "What is the difference between a float and an int?", 
         "How would you get the length of a list?", 
         "How many bits are in a double?", 
         "If your first if statement returns false, which would you use to check another condition?", 
         "If you design a quest where a player needs to follow an NPC, and they move slower than their walking speed but faster than their running speed, you are:"
        };
        static int currentQuestion;

        static string[] answers =
        {
            "==",
            "$",
            "&&",
            "||",
            "Health is equal to zero",
            "Health is not less than or equal to zero",
            "Health is less than or equal to zero",
            "Health is less than zero",
            "(int i = 0, i < 10, i++)",
            "(int i == 0; i < 10; i++)",
            "(int i <= 0; i <= 10; i++)",
            "(int i = 0; i < 10; i++)",
            "string[] newArray = {}",
            "string() newArray = {}",
            "string[0] newArray = {}",
            "string[] new Array{}",
            "A number variable",
            "A sequence of characters",
            "A single letter variable",
            "A non-number, non-letter variable such as ? or !",
            "A float only represents whole numbers, an int can represent whole and floating-point numbers",
            "An int only represents whole numbers, a float only represents floating-point numbers",
            "An int only represents whole numbers, a float can represent whole and floating-point numbers",
            "There is no difference",
            "myList.Count",
            "myList.GetLength",
            "myList.Length",
            "myList.GetLength(0)",
            "32",
            "24",
            "8",
            "64",
            "if()",
            "else()",
            "else if()",
            "if else()",
            "Banned from making video games for one year",
            "Banned from making video games",
            "A good developer",
            "Gone",
        };
        static int answerNumber = 0;

        static string playerName;

        static int[] correctAnswers = {3, 2, 4, 1, 2, 3, 1, 4, 3, 2};

        static bool checkingForParse = true;

        static bool isPlaying = true;

        static int points = 0;

        static int borderSize = 120;

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
            Console.WriteLine($"\n{playerName}");
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
                for(int border = 0; border < borderSize; border++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("═");
                }

                DisplayHUD(question);
                for (int answer = 0; answer < answers.Length/questions.Length; answer++)
                {
                    Console.WriteLine($"\n{answer + 1} {answers[answerNumber]}");
                    answerNumber++;
                }

                for (int border = 0; border < borderSize; border++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("═");
                }

                Console.WriteLine("");

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
                    else if(playerAnswer == "otterbox")
                    {
                        EasterEgg();
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

        static void EasterEgg()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Congratulations! You found the secret");
        }
    }
}
