using MyQuizApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class QuestionBank
    {
        public static List<Question> GetQuestionsByCategory(string category)
        {
            var questions = new List<Question>
            {
                new Question("What is 2 * 2?", new string[] { "3", "4", "6", "8" }, 1, "math"),
                new Question("What is 15% of 200?", new string[] { "20", "30", "40", "50" }, 1, "math"),
                new Question("What is the derivative of x^2?", new string[] { "x", "2x", "x^2", "1" }, 1, "math"),

                new Question("What is the capital of Georgia?", new string[] { "Kutaisi", "Tbilisi", "Batumi", "Rustavi" }, 1, "geography"),
                new Question("Which country is famous for the Eiffel Tower?", new string[] { "Italy", "Germany", "France", "Spain" }, 2, "geography"),
                new Question("What is the capital of Mongolia?", new string[] { "Ulaanbaatar", "Astana", "Hanoi", "Seoul" }, 0, "geography"),

                new Question("Which planet is closest to the sun?", new string[] { "Earth", "Mars", "Venus", "Mercury" }, 3, "science"),
                new Question("Who discovered Penicillin?", new string[] { "Newton", "Edison", "Fleming", "Curie" }, 2, "science"),
                new Question("Which data structure uses LIFO?", new string[] { "Queue", "Stack", "Linked List", "Tree" }, 1, "science"),
            };
            return questions.Where(q => q.Category.ToLower() == category.ToLower()).ToList();
        }
    }
}