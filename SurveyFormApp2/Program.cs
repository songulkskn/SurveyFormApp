using SurveyFormApp.Models;
using SurveyFormApp.Repository;
using SurveyFormApp.Services;
using System;

namespace SurveyFormApp
{
    class Program
    {
        static void Main(string[] args)
        {


            var questionRepo = new QuestionRepository();
            var questions = questionRepo.GetData();

            var surveryService = new SurveyService();
            var survey = surveryService.SurveyEvaluate(new DateTime(2015, 12, 31), "İlk Anket", "Anket açıklama", new User("Songül", "Keskin"), questions);


            surveryService.printSurvey(survey);

        }
    }
}
