﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_library
{
    internal class Answer
    {
        //uml diagram
        //----------------------
        //------Answer----------
        //----------------------
        //+text: string --------
        //+IsCorrect: bool -----
        //----------------------
        //+Answer(text:string, IsCorrect: bool)
        //+ToString(): string---
        //----------------------
        public string text { get; set; }    
        public bool IsCorrect { get; set; }
        public Answer() { }
        public Answer(string text, bool IsCorrect)
        {
            this.text = text;
            this.IsCorrect = IsCorrect;
        }
        public override string ToString()
        {
            return text;
        }




    }
}
