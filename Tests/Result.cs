using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    //класс, который описывает сутность результата
    public class Result
    {
        //имя пользователя
        public string Name { get; set; }
        //оценка
        public double Mark { get; set; }
        //время, которое было выделено пользователю
        public double Time { get; set; }
        //дата прохождения
        public DateTime Date { get; set; }
        //название теста
        public string TestName { get; set; }
        //название предмета
        public string SubjectName { get; set; }
    }
}
