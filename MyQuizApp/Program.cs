using System.Net.Http.Headers;

namespace MyQuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question(
                    "What is the capital of Georgia?",
                     new string[] { "Kutaisi", "Tbilisi", "Batumi", "Rustavi" }, 
                     1
                ), new Question(
                    "What is 2 * 2?",
                     new string[] { "3", "4", "6", "8" }, 
                     1
                ), new Question(
                    "Which one is better?",
                     new string[] { "BMW", "Subaru", "Chevy", "Audi" }, 
                     2
                )
            };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();
            Console.ReadLine();
        }
    }
}
