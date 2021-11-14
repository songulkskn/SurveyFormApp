using SurveyFormApp.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Concretes
{
    public class YesNoQuestion : Question
    {

        public YesNoQuestion(String text, List<String> option, List<String> answer)
        {
            this.Text = text;
            this.Option = option;
            this.Answer = answer;
        }
        public List<String> Option { get; protected set; }

        /// <summary>
        /// Burada en fazla 2 seçeneğin ve 1 tane cevabın olduğu kontrol edilmiştir.
        /// </summary>
        public override void QuestionValidation()
        {
            if (this.Option.Count() != 2)
            {
                throw new Exception("There must be 2 options");
            }

            if (this.Answer.Count() != 1)
            {
                throw new Exception("The question can have only 1 answer.");

            }
        }
    }
}
