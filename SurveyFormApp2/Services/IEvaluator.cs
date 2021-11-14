using SurveyFormApp.Abstracts;
using SurveyFormApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Services
{
    public interface IEvaluator
    {
        /// <summary>
        /// Anket oluşturma Fonskiyonudur.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="user"></param>
        /// <param name="questions"></param>
        /// <returns></returns>
        Survey SurveyEvaluate(DateTime date, String title, String description, User user, List<Question> questions);

    }
}
