using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaApiLibrary;

namespace Questionnaire_library
{
    internal class Question
    {
        //uml diagram
        //----------------------
        //------Question--------
        //----------------------
        //-possibleAnswer: list-
        //+<<get/set>> text: string
        //+<<get/set>> ImageUrl: string
        //----------------------
        //+Question(text: string)
        //+AddAnswer(answer: Answer)
        //+GetAnswer(index : int) : answer
        //+Tostring() : string
        //----------------------


        private List<Answer> possibleAnswers = new List<Answer>();
        public string text { get; set; }
        public string ImageUrl { get; set; }
        public Question() { } 
        
        public Question(string text)
        {
            this.text = text;
        }
        public void AddAnswer(Answer answer)
        {
            possibleAnswers.Add(answer);
        }

        public Answer GetAnswer(int index)
        {
            return possibleAnswers[index];
        }

        public void RemoveAnswer(int index)
        {

            possibleAnswers.RemoveAt(index);

        }
        public void RemoveAnswer(string text) { }

        public override string ToString()
        {
            return text;
        }

        public void DisplayQuestion()
        {
            Console.WriteLine(text);
            for (int i = 0; i < possibleAnswers.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + possibleAnswers[i].ToString());
            }
        }

        public bool ValidateAnswer(int index)
        {
            return possibleAnswers[index].IsCorrect;
        }


        


    }
}
