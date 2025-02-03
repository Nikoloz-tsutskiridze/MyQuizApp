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

        public Question(string questionText, string[] anwers, int correctAnswerIndex)
        {
            QuestionText = questionText;
            Answers = anwers;
            CorrectAnswerIndex = correctAnswerIndex;
        }

        public bool IsCorrectAnswer(int choice)
        {
            return CorrectAnswerIndex == choice;
        }
    }
}
