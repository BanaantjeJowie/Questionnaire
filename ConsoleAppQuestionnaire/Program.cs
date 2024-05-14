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
            Console.WriteLine("What is the capital of France?");









        }
    }
}
