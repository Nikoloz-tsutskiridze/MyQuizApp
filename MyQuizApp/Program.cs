using Practice;
using System;
using System.Collections.Generic;

namespace MyQuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a category: Math, Geography, Science");
            string category = Console.ReadLine().ToLower();

            List<Question> questions = QuestionBank.GetQuestionsByCategory(category);

            if (questions.Count == 0)
            {
                Console.WriteLine("No questions available for this category.");
                return;
            }

            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();
            Console.ReadLine();
        }
    }
}
