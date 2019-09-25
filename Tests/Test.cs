using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    //класс, который описывает сутность теста
    public class Test
    {
        //имя теста
        public string Name { get; set; }
        //имя предмета
        public string Subject { get; set; }
        //список вопросов
        public List<Question> Questions { get; set; }
    }
}
