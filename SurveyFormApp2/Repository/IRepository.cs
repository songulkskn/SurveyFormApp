using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Repository
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Dataları ÇEktiğimiz Fonskiyon.
        /// </summary>
        /// <returns></returns>
        List<T> GetData();
    }
}
