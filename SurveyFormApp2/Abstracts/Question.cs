using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Abstracts
{


    /// <summary>
    /// Question adındaki somut sınıfımız.
    /// Questionların text adında soru alanı , liste şeklinde tutulmuş cevapları  vardır.
    /// Questionlardan kalıtım alacak sınıflara yol göstermesi için QuestionValidation methodu oluşturuldu. Validasyon işlemleri yapıldı. 
    /// </summary>
    public abstract class Question
    {
        
        public String Text { get; protected set; }
        public List<String> Answer { get; protected set; }
        public abstract void QuestionValidation();

      
    }
}
