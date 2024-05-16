using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaApiLibrary;


namespace Questionnaire_library
{
    public class Question
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

        public string text { get; set; }
        public string ImageUrl { get; set; }
        List<Answer> possibleAnswers = new List<Answer>();

        public Question(string text)
        {
            this.text = text;
        }

        void AddAnswer(Answer answer)
        {
            possibleAnswers.Add(answer);
        }

        Answer GetAnswer(int index)
        {
            return possibleAnswers[index];
        }

        public override string ToString()
        {
            return text;
        }
    }

}
