using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    //класс, который описывает сущность ответа
    public class Answer
    {
        //текст ответа
        public string Text { get; set; }
        //верный ли ответ
        public bool isTrue { get; set; }
    }
}
