using SurveyFormApp.Abstracts;
using SurveyFormApp.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Repository
{
    class QuestionRepository : IRepository<Question>
    {

        private List<Question> _questions = new List<Question>();
        /// <summary>
        /// Soru tiplerine soruları cevapları ve optionları eklenmiştir.
        /// </summary>
        public QuestionRepository()
        {
            var shortQuestion = new ShortQuestion("Kısa soru", new List<String>() { "kısasoru cevabı" });
            var longQuestion = new LongQuestion("Uzun soru", new List<String>() { "Uzun soru cevap" });
            var checkBoxQuestion = new CheckBoxQuestion("Checkbox soru", new List<String>() { "A", "B", "C", "D", "Hiçbiri" }, new List<String>() { "2" });
            //var dateQuestion = new DateTimeQuestion("Datetype soru", new List<String>() { new DateTime(12 / 11 / 2021).ToString() });
            var yesnoQuestion = new YesNoQuestion("Yes/No soru", new List<String>() { "Evet", "Hayır" }, new List<String>() { "Evet" });
            var multipleQuestion = new MultipleChoiceQuestion("Multiple soru", new List<String>() { "1", "2", "3" }, new List<String>() { "1" });


            _questions.Add(shortQuestion);
            _questions.Add(longQuestion);
            _questions.Add(checkBoxQuestion);
           // _questions.Add(dateQuestion);
            _questions.Add(yesnoQuestion);
            _questions.Add(multipleQuestion);
        }

        public List<Question> GetData()
        {

            return this._questions.ToList();

        }





    }
}
