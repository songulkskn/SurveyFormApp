using SurveyFormApp.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Models
{
    public class Survey
    {
        /// <summary>
        /// Const değer ile sabit soru sayısı tanımlanmıştır.
        /// </summary>
        public const int FixedNumberofQuestions = 10;
        /// <summary>
        /// Anketin Tarihi vardır.
        /// </summary>
        public DateTime Date { get; private set; }
        /// <summary>
        /// Anketin Başlığı vardır.
        /// </summary>
        public string Title { get; private set; }
        /// <summary>
        /// anketin Açıklaması vardır.
        /// </summary>
        public string Description { get; private set; }
        /// <summary>
        /// User classından userlar alındı.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Question sınıfından liste şeklinde sorular alındı.
        /// Hashset yapıldı ki aynı sorular tekrardan eklenmesin.
        /// </summary>
        private HashSet<Question> questions = new HashSet<Question>();
        public IReadOnlySet<Question> Questions => questions;

        public Survey(DateTime date, string title, string description, User user)
        {
            Date = date;
            Title = title;
            Description = description;
            User = user;
        }

        /// <summary>
        /// Soru ekleme methodudur.
        /// Const değeri ile belirlediğimiz değer kadar soru eklenebilir.
        /// Fazladan soru eklenirse hata mesajı verir.
        /// Question abstract sınıfındaki QuestionValidation() fonskiyonu çağırılarak Question listesine sorular eklenir.
        /// </summary>
        /// <param name="question"></param>
        public void AddQuestion(Question question)
        {

            if (questions.Count > FixedNumberofQuestions)
            {
                throw new Exception($"The number of questions cannot exceed {FixedNumberofQuestions}");
            }
            else
            {
                question.QuestionValidation();
                questions.Add(question);

            }
        }
    }
}
