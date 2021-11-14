using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Models
{
    public class User
    {
        /// <summary>
        /// Kullanıcının Adı ve Soyadı alınan Sınıftır.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        public User(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
