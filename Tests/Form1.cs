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
    public partial class TestForm : Form
    {
        //список доступных тестов
        List<Test> tests;
        public TestForm()
        {
            InitializeComponent();

            //начальная инициализация
            tests = new List<Test>();
            funcReadAllTests();
            radioPerQuestion.Checked = true;
            radioButton2.Checked = true;
        }
        
        void funcReadAllTests()
        {
            //очистили список тестов
            tests.Clear();
            dataGridView1.Rows.Clear();
            //считали путь к поточной директории
            string path = Environment.CurrentDirectory;
            //считали информацию про директорию
            DirectoryInfo di = new DirectoryInfo(path);
            //считали все файлы с этой директории с расширением тхт
            FileInfo[] files = di.GetFiles("*.txt");

            //проходимся по этих файлах и забиваем наш список доступных тестов
            foreach (var el in files)
            {
                //открываем файл
                using (StreamReader sr = new StreamReader(el.Name))
                {
                    string text = sr.ReadToEnd();
                    try
                    {
                        //конвертируем из JSON формата в наш тип
                        Test test = JsonConvert.DeserializeObject<Test>(text);
                        //и добавляем в список
                        tests.Add(test);
                        dataGridView1.Rows.Add(test.Name, test.Subject, test.Questions.Count.ToString());
                    }
                    catch
                    {
                    }
                }
            }
        }

        //добавить тест
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Show();
            funcReadAllTests();
        }

        //редактировать тест
        private void button3_Click(object sender, EventArgs e)
        {
            //взяли индекс выбраного теста
            int indexR = dataGridView1.CurrentCell.RowIndex;
            if (indexR >= 0 && indexR < tests.Count())
            {
                this.Hide();
                //передали его в форму2
                Form2 form2 = new Form2(tests[indexR]);
                form2.ShowDialog();
                this.Show();
                funcReadAllTests();
            }
        }

        //удалить тест
        private void button4_Click(object sender, EventArgs e)
        {
            int indexR = dataGridView1.CurrentCell.RowIndex;
            if (indexR >= 0)
            {
                //удаляем тест с папки 
                File.Delete(tests[indexR].Name + "_" + tests[indexR].Subject + ".txt");
                dataGridView1.Rows.RemoveAt(indexR);
            }
        }

        //пройти тест
        private void button1_Click(object sender, EventArgs e)
        {
            //переменная, в которой будут все ошибки
            string error = string.Empty;
            int indexR = dataGridView1.CurrentCell.RowIndex;
            if (indexR >= 0 && indexR < tests.Count())
            {
                //смотрим корекно ли заданы все поля. иначе добавляем ошибку.
                if(string.IsNullOrEmpty(UserName.Text))
                {
                    error += "* Введите свое имя \n";
                }
                if (string.IsNullOrEmpty(Mark.Text))
                {
                    error += "* Заполните поле Оценка \n";
                }
                else
                {
                    try
                    {
                        double mark = Convert.ToDouble(Mark.Text);
                        if (mark < 0)
                        {
                            error += "* Значение поля Оценка должно быть > 0 \n";
                        }
                    }
                    catch
                    {
                        error += "* Неверный формат поля Оценка \n";
                    }
                }
                if (string.IsNullOrEmpty(Time.Text))
                {
                    error += "* Заполните поле Время \n";
                }
                else
                {
                    try
                    {
                        double time = Convert.ToInt32(Time.Text);
                        if(time < 0)
                        {
                            error += "* Значение поля Время должно быть > 0 \n";
                        }
                    }
                    catch
                    {
                        error += "* Неверный формат поля Время \n";
                    }
                }

                //если ошибок нет, то запускаем форму прохождение теста и передаем туда все необходимые данные.
                if(string.IsNullOrEmpty(error))
                {
                    this.Hide();
                    Form4 form4 = new Form4(tests[indexR], UserName.Text ,Convert.ToDouble(Mark.Text), Convert.ToInt32(Time.Text), radioPerQuestion.Checked, radioButton2.Checked);
                    form4.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show(error);
                }
            }
            else
            {
                MessageBox.Show("Выберите тест для прохождения!");
            }
        }

        //посмотреть результаты
        private void button5_Click(object sender, EventArgs e)
        {
            int indexR = dataGridView1.CurrentCell.RowIndex;
            if (indexR >= 0 && indexR < tests.Count())
            {
                this.Hide();
                Form3 form3 = new Form3(tests[indexR]);
                form3.ShowDialog();
                this.Show();
            }
        }
    }
}
