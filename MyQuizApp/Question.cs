using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizApp
{
    internal class Question
    {
        public string QuestionText { get; set; }

        public string[] Answers { get; set; }

        public int CorrectAnswerIndex { get; set; }

        public string Category { get; set; }


        public Question(string questionText, string[] anwers, int correctAnswerIndex, string category)
        {
            QuestionText = questionText;
            Answers = anwers;
            CorrectAnswerIndex = correctAnswerIndex;
            Category = category;
        }

        public bool IsCorrectAnswer(int choice)
        {
            return CorrectAnswerIndex == choice;
        }
    }
}
