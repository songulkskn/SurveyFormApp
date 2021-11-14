using SurveyFormApp.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Concretes
{
    public class MultipleChoiceQuestion : Question
    {
        public MultipleChoiceQuestion(String text, List<String> option, List<String> answer)
        {
            this.Text = text;
            this.Option = option;
            this.Answer = answer;
        }
        public List<String> Option { get; protected set; }
        /// <summary>
        /// En fazla 4 seçeneğin ve 1 tane cevap seçileceğinin kontrolü sağlanmıştır.
        /// </summary>
        public override void QuestionValidation()
        {
            if (this.Option.Count() > 4)
            {
                throw new Exception("There can be up to 4 options.");
            }

            if (this.Answer.Count() != 1)
            {
                throw new Exception("The question can have only 1 answer.");

            }
        }
    }
}
