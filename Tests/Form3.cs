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
    public partial class Form3 : Form
    {
        List<Result> results;
        public Form3(Test test)
        {
            InitializeComponent();
            // аналогично читаем из JSON в стринг, только уже из файла результатов
            results = new List<Result>();
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

            //и отображаем на форме
            TestName.Text = test.Name;
            PredmetName.Text = test.Subject;
            results = results.Where(m => m.TestName == test.Name && m.SubjectName == test.Subject).ToList();
            foreach(var el in results)
            {
                dataGridView1.Rows.Add(el.Name, el.Mark.ToString(), el.Time.ToString(), el.Date.ToShortDateString());
            }
        }
    }
}
