using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tests
{
    public partial class Form4 : Form
    {
        double mark;
        int time;
        string name;
        bool perAnswer;
        bool perQuestion;
        Test test;

        int mm;
        int ss;
        int current;

        double totalMark = 0.0;
        public Form4(Test test, string name, double mark, int time, bool perAnswer, bool perQuestion)
        {
            InitializeComponent();
            //начальная инициализация
            this.mark = mark;
            this.time = time;
            this.name = name;
            this.perAnswer = perAnswer;
            this.perQuestion = perQuestion;
            this.test = test;
            mm = time - 1;
            ss = 59;
            current = 0;

            changeTimerText();
            printAns();

            timer1.Enabled = true;
        }

        //функция, которая изменяет поточное значение таймера
        public void changeTimerText()
        {
            string t = string.Empty;
            if (mm < 10)
                t += "0";
            t += mm + ":";
            if (ss < 10)
                t += "0";
            t += ss;
            timerText.Text = t;
        }

        //выводим список ответов к текущему вопросу
        public void printAns()
        {
            if (current >= test.Questions.Count())
                return;
            question.Text = test.Questions[current].Text;
            counter.Text = (current + 1) + "/" + test.Questions.Count();

            //очищаем гроуп бокс
            gb.Controls.Clear();
            //смотрим сколько ответов в вопроса
            var c = test.Questions.ToList()[current].Answers.ToList().Where(m => m.isTrue == true).ToList();

            //если один, то используем радио кнопку
            if (c.Count == 1)
            {
                for (int i = 0; i < test.Questions[current].Answers.Count(); i++)
                {
                    RadioButton rb = new RadioButton();
                    rb.Top += i * 20 + 20;
                    rb.Left += 20;
                    rb.Text = test.Questions[current].Answers[i].Text;
                    gb.Controls.Add(rb);
                }
            }
            else //иначе чек бокс
            {
                for (int i = 0; i < test.Questions[current].Answers.Count(); i++)
                {
                    CheckBox rb = new CheckBox();
                    rb.Top += i * 20 + 20;
                    rb.Left += 20;
                    rb.Text = test.Questions[current].Answers[i].Text;
                    gb.Controls.Add(rb);
                }
            }
        }

        //сохраняем результаты в файл с результатами
        public void SaveResult()
        {
            //создали обьект текущего результата
            Result res = new Result() { Name = name, Mark = totalMark, Time = perQuestion ? time * test.Questions.Count() : time, Date = DateTime.Now, TestName = test.Name, SubjectName = test.Name };
            
            //считали предыдущие результаты
            List<Result> results = new List<Result>();
            try
            {
                using (StreamReader sr = new StreamReader("Results.txt"))
                {
                    string text = sr.ReadToEnd();
                    results = JsonConvert.DeserializeObject<List<Result>>(text);
                }
            }
            catch
            {

            }
            results.Add(res);
            //записали оновленный список
            using (StreamWriter sr = new StreamWriter("Results.txt"))
            {
                string json = JsonConvert.SerializeObject(results);
                sr.Write(json);
            }
            MessageBox.Show("Ваша оценка : " + totalMark);
            this.Close();
        }

        //кнопка ответить
        private void button2_Click(object sender, EventArgs e)
        {
            //вычисляем оценку за правильный ответ
            double tmpMark = perAnswer ? mark : mark / test.Questions.Count();
            //кол-во правильных ответов в текущего вопроса
            int count = test.Questions[current].Answers.Where(m => m.isTrue == true).Count();
            //проверяем все 
            for (int i=0;i<gb.Controls.Count;i++)
            {
                //радио кнопки на совпадение с списком ответов
                if (count == 1)
                {
                    //если есть одно не совпадение, то за ответ получаем 0 балов
                    if (((RadioButton)gb.Controls[i]).Checked != test.Questions[current].Answers[i].isTrue)
                    {
                        tmpMark = 0;
                        break;
                    }
                }
                else //чекбоксы
                {
                    //за каждое несовпадение минус доля одного правильного ответа 
                    if (((CheckBox)gb.Controls[i]).Checked != test.Questions[current].Answers[i].isTrue)
                    {
                        tmpMark -= tmpMark / count;
                        break;
                    }
                }
            }

            //додаем полученную оценку за вопрос к общей оценке
            totalMark += tmpMark;
            //переходим к следуйщему вопросу
            current++;

            //если вопросы закончились, сохраняем результат
            if (current == test.Questions.Count())
            {
                SaveResult();
            }
            printAns();
            if(perAnswer)
            {
                timer1.Enabled = false;
                mm = time - 1;
                ss = 59;
                changeTimerText();
                timer1.Enabled = true;
            }
        }

        //функция, которая собственно и описывает один тик таймера
        private void timer1_Tick(object sender, EventArgs e)
        {
            ss--;
            if (ss == -1)
            {
                //если вышло время, нужно перейти на след вопрос. или закончить тест
                if (mm == 0)
                {
                    if (!perQuestion)
                        SaveResult();
                    button2_Click(sender, e);
                    return;
                }
                mm--;
                ss = 59;
            }
            changeTimerText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveResult();
        }

        private void counter_Click(object sender, EventArgs e)
        {

        }
    }
}
