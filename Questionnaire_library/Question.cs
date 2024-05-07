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

        public string Text { get; set; }

        public string ImageUrl { get; set; }

        public Question(string text)
        {
            Text = text;
        }

        public void AddAnswer(Answer answer)
        {
            possibleAnswers.Add(answer);
        }


        public Answer GetAnswer(int index)
        {
            return possibleAnswers[index];
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Text);
            for (int i = 0; i < possibleAnswers.Count; i++)
            {
                sb.AppendLine($"{i + 1}. {possibleAnswers[i].Text}");
            }
            return sb.ToString();
        }





    }

}
