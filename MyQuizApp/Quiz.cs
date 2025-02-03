using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizApp
{
    internal class Quiz
    {
        private List<Question> _questions;
        private int _score;

        public Quiz(List<Question> questions)
        {
            _score = 0;
            _questions = SelectQuestions(questions);
        }

        private List<Question> SelectQuestions(List<Question> questions)
        {
            Random rnd = new Random();
            return questions.OrderBy(q => rnd.Next()).Take(3).ToList();
        }

        public void StartQuiz()
        {
            if (_questions.Count == 0)
            {
                Console.WriteLine("No questions found in this category.");
                return;
            }

            Console.WriteLine($"Welcome to the Quiz!");

            int questionNumber = 1;
            foreach (Question question in _questions)
            {
                Console.WriteLine($"Question {questionNumber}");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();

                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct!!!");
                    _score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer was: {question.Answers[question.CorrectAnswerIndex]}");
                }
                questionNumber++;
            }
            DisplayResult();
        }



        private void DisplayResult()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Results                                 ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.WriteLine($"Quiz finished. Your score is: {_score} out of {_questions.Count}");
            double percentage = (double)_score / _questions.Count;

            if (percentage >= 0.8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Excellent Work!");
            }
            else if (percentage >= 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Good effort!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Keep practicing");
            }
            Console.ResetColor();
        }

        private void DisplayQuestion(Question question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Question                                ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine(question.QuestionText);

            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("  ");
                Console.WriteLine($"{i + 1}. {question.Answers[i]}");
                Console.ResetColor();
            }
        }

        private int GetUserChoice()
        {
            Console.Write("Your answer(number): ");
            string input = Console.ReadLine();
            int choice = 0;

            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4: ");
                input = Console.ReadLine();
            }

            return choice - 1;
        }
    }
}