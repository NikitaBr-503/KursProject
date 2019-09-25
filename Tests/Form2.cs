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
    public partial class Form2 : Form
    {
        Test test;
        public Form2(Test testt = null) 
        {
            InitializeComponent();

            //так же начальная инициализация
            test = new Test();
            test.Questions = new List<Question>();
            radioYes.Checked = true;

            //если пришел тест(нажали редактировать, а не добавить тест), то добвляем информацию, которая пришла.
            if (testt != null)
            {
                this.test = testt;
                TestName.Text = test.Name;
                PredmetName.Text = test.Subject;
                foreach(var el in test.Questions)
                {
                    listQuestions.Items.Add(el.Text);
                }
            }
        }
        //добавляем вопрос в список
        private void AddQuestion_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textQuestion.Text))
            {
                listQuestions.Items.Add(textQuestion.Text);
                test.Questions.Add(new Question() { Text = textQuestion.Text, Answers = new List<Answer>() });
                textQuestion.Text = "";
            }
        }
        //удаляем вопрос из списка
        private void DeleteQuestion_Click(object sender, EventArgs e)
        {
            int index = listQuestions.SelectedIndex;
            if(index >= 0)
            {
                test.Questions.RemoveAt(index);
                listQuestions.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Выберите вопрос");
            }
        }
        //добавляем ответ в список (важно : каждому вопросу - свой список ответов)
        private void AddAnswer_Click(object sender, EventArgs e)
        {
            int index = listQuestions.SelectedIndex;
            if (index >= 0)
            {
                if (!string.IsNullOrEmpty(textAnswer.Text))
                {
                    string text = radioYes.Checked ? "true\t" + textAnswer.Text : "false\t" + textAnswer.Text;
                    test.Questions[index].Answers.Add(new Answer() { Text = textAnswer.Text, isTrue = radioYes.Checked });
                    listAnswers.Items.Add(text);
                    textAnswer.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Выберите вопрос");
            }
        }
        //удаляем ответ из списка
        private void DeleteAnswer_Click(object sender, EventArgs e)
        {
            int index = listAnswers.SelectedIndex;
            if (index >= 0)
            {
                test.Questions[listQuestions.SelectedIndex].Answers.RemoveAt(index);
                listAnswers.Items.RemoveAt(index);
            }
        }
        //если поменялся индекс выбраного елемента списка вопросов, то просто читаем заново список ответов
        private void listQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            listAnswers.Items.Clear();
            int index = listQuestions.SelectedIndex;
            if (index >= 0)
            {
                foreach (var el in test.Questions[index].Answers)
                {
                    string text = el.isTrue ? "true\t" + el.Text : "false\t" + el.Text;
                    listAnswers.Items.Add(text);
                }
            }
        }
        //сохраняем тест
        private void SaveTest_Click(object sender, EventArgs e)
        {
            //аналогично обрабатываем ошибки
            string error = string.Empty;
            if(string.IsNullOrEmpty(TestName.Text))
            {
                error += "* введите название теста\n";
            }
            if (string.IsNullOrEmpty(PredmetName.Text))
            {
                error += "* введите название предмета\n";
            }
            if (test.Questions.Count < 10)
                error += "* минимальное количество вопросов : 10\n";
            int i = 1;
            foreach (var el in test.Questions)
            {
                if (el.Answers.Count < 2)
                    error += "* вопрос #" + i + " минимальное количество ответов : 2\n";
                var el2 = el.Answers.FirstOrDefault(m => m.isTrue == true);
                if(el2 == null)
                    error += "* вопрос #" + i + " должен быть хотя бы один правильный ответ\n";
                i++;
            }
            //если ошибок нету, то сохраняем
            if (string.IsNullOrEmpty(error))
            {
                test.Name = TestName.Text;
                test.Subject = PredmetName.Text;
                //конвертируем из стринг в JSON
                string json = JsonConvert.SerializeObject(test);
                //и пишем в файл
                using (StreamWriter sr = new StreamWriter(TestName.Text + "_" + PredmetName.Text + ".txt"))
                {
                    sr.Write(json);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show(error);
            }
        }
    }
}
