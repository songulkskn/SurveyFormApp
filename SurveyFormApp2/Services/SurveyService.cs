using SurveyFormApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Services
{
    class SurveyService : IEvaluator
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="user"></param>
        /// <param name="questions"></param>
        /// <returns></returns>
        public Survey SurveyEvaluate(DateTime date, string title, string description, User user, List<Abstracts.Question> questions)
        {
            var survey = new Survey(date, title, description, user);
            foreach (var item in questions)
            {
                survey.AddQuestion(item);
            }

            return survey;
        }


        /// <summary>
        /// Oluşan surveyimizi ekrana bastırma fonskiyonudur.
        /// </summary>
        /// <param name="survey"></param>
        public void printSurvey(Survey survey)
        {
            Console.WriteLine(survey.Title + " Anketine Hoş Geldiniz" + " " + survey.User.Name + "   " + survey.User.Surname + " " + survey.Date);

            foreach (var item in survey.Questions)
            {

                Console.WriteLine("\n");
                Console.WriteLine(item.Text);

           

                Console.WriteLine("\n");
                var survey_answers = item.Answer;
                if (survey_answers.Count > 0)
                {
                    Console.WriteLine("Cevap/Cevaplar");
                    foreach (var answer_survey in survey_answers)
                    {
                        Console.WriteLine(answer_survey);
                    }
                }

            }


        }

     
    }
}
