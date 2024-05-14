namespace ConsoleAppQuestionnaire
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Text;
    using Questionnaire_library;
    using TriviaApiLibrary;

    internal class Program
    {
        static void Main(string[] args)
        {
            //Greet user and ask for name to personalize the experience
            Console.WriteLine("Hello and welcome to my questionnaire app");
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");
            Console.WriteLine("I will be giving you a fun multiple choice question. ");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Are you ready? Here we go!");
            System.Threading.Thread.Sleep(2000);
            TriviaMultipleChoiceQuestion question = new TriviaMultipleChoiceQuestion();
            question.Question = new TriviaQuestion();
            question.Question.Text = "What is the capital of France?";
            question.CorrectAnswer = "Paris";
            question.IncorrectAnswers = new List<string> { "London", "Berlin", "Madrid" };
            question.Category = "Geography";
            question.Difficulty = "Easy";

            Console.WriteLine(question.Question.Text);
            Console.WriteLine("A) " + question.CorrectAnswer);
            Console.WriteLine("B) " + question.IncorrectAnswers[0]);
            Console.WriteLine("C) " + question.IncorrectAnswers[1]);
            Console.WriteLine("D) " + question.IncorrectAnswers[2]);
            Console.WriteLine("Please enter your answer: ");
            string userAnswer = Console.ReadLine();
            if (userAnswer.ToLower() == "a")
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }

            Console.WriteLine("Thank you for playing!");









        }
    }
}
