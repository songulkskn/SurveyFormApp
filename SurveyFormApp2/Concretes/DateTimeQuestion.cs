using SurveyFormApp.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Concretes
{
    public class DateTimeQuestion : Question
    {
        public DateTimeQuestion(String text, List<String> answer)
        {
            this.Text = text;
            this.Answer = answer;
        }

        /// <summary>
        /// Sadece DateTime verisi girilebileceği validasyonu yapılır.
        /// </summary>
        public override void QuestionValidation()
        {
            if (this.Answer.First().GetType() != typeof(DateTime))
            {
                throw new Exception("only date must be entered");
            }

        }
    }
}

