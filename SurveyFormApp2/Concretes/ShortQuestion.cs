using SurveyFormApp.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Concretes
{
    public class ShortQuestion : Question
    {
        public ShortQuestion(String text, List<String> answer)
        {
            this.Text = text;
            this.Answer = answer;
        }
        /// <summary>
        /// Girilen cevabın 30 karakteri aşıp aşmadığı kontrolü yapılır.
        /// </summary>
        public override void QuestionValidation()
        {
            if (this.Answer.First().Length > 30)
            {
                throw new Exception("Your answer should not exceed 30 characters.");
            }

        }
    }
}
