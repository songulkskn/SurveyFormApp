using SurveyFormApp.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Concretes
{
    public class CheckBoxQuestion : Question
    {

        public CheckBoxQuestion(String text, List<String> option, List<String> answer)
        {
            this.Text = text;
            this.Option = option;
            this.Answer = answer;
        }
        public List<String> Option { get; protected set; }


        /// <summary>
        /// Burada  en fazala 5 seçeneğin ve en fazla 4'nün işaretlenebileceği validasyon gerçekleştirilmiştir.
        /// </summary>
        public override void QuestionValidation()
        {

            if (this.Option.Count() > 5)
            {
                throw new Exception("Up to 5 options can be entered.");

            }


            if (this.Answer.Count() > 4)
            {
                throw new Exception("Up to 4 answer can not be entered.");

            }

            this.changedSelectedValue();

        }

        /// <summary>
        /// Hiçbiri seçeneği işaretlendiğinde tüm seçeneklerdeki cevaplar
        /// kalkacak ve hiçbiri seçeneği cevap listesine eklenecektir.
        /// </summary>
        public void changedSelectedValue()
        {
            foreach(var item in this.Answer.ToList())
            {
                if (item == "Hiçbiri")
                {
                    Answer.Clear();
                    Answer.Add("Hiçbiri");

                }
            }
        }

    }
}
