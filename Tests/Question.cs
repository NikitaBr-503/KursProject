using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    //класс, который описывает сущность вопроса
    public class Question
    {
        //текст вопроса
        public string Text { get; set; }
        //список ответов
        public  List<Answer> Answers { get; set; }
    }
}
