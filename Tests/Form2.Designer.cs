namespace Tests
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listQuestions = new System.Windows.Forms.ListBox();
            this.listAnswers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddQuestion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TestName = new System.Windows.Forms.TextBox();
            this.PredmetName = new System.Windows.Forms.TextBox();
            this.DeleteQuestion = new System.Windows.Forms.Button();
            this.DeleteAnswer = new System.Windows.Forms.Button();
            this.AddAnswer = new System.Windows.Forms.Button();
            this.SaveTest = new System.Windows.Forms.Button();
            this.groupIsTrue = new System.Windows.Forms.GroupBox();
            this.radioYes = new System.Windows.Forms.RadioButton();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.textQuestion = new System.Windows.Forms.TextBox();
            this.textAnswer = new System.Windows.Forms.TextBox();
            this.groupIsTrue.SuspendLayout();
            this.SuspendLayout();
            // 
            // listQuestions
            // 
            this.listQuestions.FormattingEnabled = true;
            this.listQuestions.HorizontalScrollbar = true;
            this.listQuestions.Location = new System.Drawing.Point(11, 63);
            this.listQuestions.Name = "listQuestions";
            this.listQuestions.Size = new System.Drawing.Size(274, 199);
            this.listQuestions.TabIndex = 0;
            this.listQuestions.SelectedIndexChanged += new System.EventHandler(this.listQuestions_SelectedIndexChanged);
            // 
            // listAnswers
            // 
            this.listAnswers.FormattingEnabled = true;
            this.listAnswers.HorizontalScrollbar = true;
            this.listAnswers.Location = new System.Drawing.Point(319, 63);
            this.listAnswers.Name = "listAnswers";
            this.listAnswers.Size = new System.Drawing.Size(274, 199);
            this.listAnswers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список вопросов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Список ответов";
            // 
            // AddQuestion
            // 
            this.AddQuestion.Location = new System.Drawing.Point(11, 315);
            this.AddQuestion.Name = "AddQuestion";
            this.AddQuestion.Size = new System.Drawing.Size(75, 23);
            this.AddQuestion.TabIndex = 4;
            this.AddQuestion.Text = "Добавить";
            this.AddQuestion.UseVisualStyleBackColor = true;
            this.AddQuestion.Click += new System.EventHandler(this.AddQuestion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Название";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Предмет";
            // 
            // TestName
            // 
            this.TestName.Location = new System.Drawing.Point(76, 9);
            this.TestName.Name = "TestName";
            this.TestName.Size = new System.Drawing.Size(209, 20);
            this.TestName.TabIndex = 7;
            // 
            // PredmetName
            // 
            this.PredmetName.Location = new System.Drawing.Point(374, 9);
            this.PredmetName.Name = "PredmetName";
            this.PredmetName.Size = new System.Drawing.Size(219, 20);
            this.PredmetName.TabIndex = 8;
            // 
            // DeleteQuestion
            // 
            this.DeleteQuestion.Location = new System.Drawing.Point(92, 315);
            this.DeleteQuestion.Name = "DeleteQuestion";
            this.DeleteQuestion.Size = new System.Drawing.Size(75, 23);
            this.DeleteQuestion.TabIndex = 10;
            this.DeleteQuestion.Text = "Удалить";
            this.DeleteQuestion.UseVisualStyleBackColor = true;
            this.DeleteQuestion.Click += new System.EventHandler(this.DeleteQuestion_Click);
            // 
            // DeleteAnswer
            // 
            this.DeleteAnswer.Location = new System.Drawing.Point(400, 315);
            this.DeleteAnswer.Name = "DeleteAnswer";
            this.DeleteAnswer.Size = new System.Drawing.Size(75, 23);
            this.DeleteAnswer.TabIndex = 12;
            this.DeleteAnswer.Text = "Удалить";
            this.DeleteAnswer.UseVisualStyleBackColor = true;
            this.DeleteAnswer.Click += new System.EventHandler(this.DeleteAnswer_Click);
            // 
            // AddAnswer
            // 
            this.AddAnswer.Location = new System.Drawing.Point(319, 315);
            this.AddAnswer.Name = "AddAnswer";
            this.AddAnswer.Size = new System.Drawing.Size(75, 23);
            this.AddAnswer.TabIndex = 11;
            this.AddAnswer.Text = "Добавить";
            this.AddAnswer.UseVisualStyleBackColor = true;
            this.AddAnswer.Click += new System.EventHandler(this.AddAnswer_Click);
            // 
            // SaveTest
            // 
            this.SaveTest.Location = new System.Drawing.Point(174, 348);
            this.SaveTest.Name = "SaveTest";
            this.SaveTest.Size = new System.Drawing.Size(254, 32);
            this.SaveTest.TabIndex = 13;
            this.SaveTest.Text = "Сохранить тест";
            this.SaveTest.UseVisualStyleBackColor = true;
            this.SaveTest.Click += new System.EventHandler(this.SaveTest_Click);
            // 
            // groupIsTrue
            // 
            this.groupIsTrue.Controls.Add(this.radioNo);
            this.groupIsTrue.Controls.Add(this.radioYes);
            this.groupIsTrue.Location = new System.Drawing.Point(524, 268);
            this.groupIsTrue.Name = "groupIsTrue";
            this.groupIsTrue.Size = new System.Drawing.Size(69, 70);
            this.groupIsTrue.TabIndex = 14;
            this.groupIsTrue.TabStop = false;
            this.groupIsTrue.Text = "Верно?";
            // 
            // radioYes
            // 
            this.radioYes.AutoSize = true;
            this.radioYes.Location = new System.Drawing.Point(7, 20);
            this.radioYes.Name = "radioYes";
            this.radioYes.Size = new System.Drawing.Size(40, 17);
            this.radioYes.TabIndex = 0;
            this.radioYes.TabStop = true;
            this.radioYes.Text = "Да";
            this.radioYes.UseVisualStyleBackColor = true;
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Location = new System.Drawing.Point(6, 43);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(44, 17);
            this.radioNo.TabIndex = 1;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "Нет";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // textQuestion
            // 
            this.textQuestion.Location = new System.Drawing.Point(11, 268);
            this.textQuestion.Multiline = true;
            this.textQuestion.Name = "textQuestion";
            this.textQuestion.Size = new System.Drawing.Size(274, 41);
            this.textQuestion.TabIndex = 15;
            // 
            // textAnswer
            // 
            this.textAnswer.Location = new System.Drawing.Point(319, 268);
            this.textAnswer.Multiline = true;
            this.textAnswer.Name = "textAnswer";
            this.textAnswer.Size = new System.Drawing.Size(199, 41);
            this.textAnswer.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 383);
            this.Controls.Add(this.textAnswer);
            this.Controls.Add(this.textQuestion);
            this.Controls.Add(this.groupIsTrue);
            this.Controls.Add(this.SaveTest);
            this.Controls.Add(this.DeleteAnswer);
            this.Controls.Add(this.AddAnswer);
            this.Controls.Add(this.DeleteQuestion);
            this.Controls.Add(this.PredmetName);
            this.Controls.Add(this.TestName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listAnswers);
            this.Controls.Add(this.listQuestions);
            this.Name = "Form2";
            this.Text = "Тест";
            this.groupIsTrue.ResumeLayout(false);
            this.groupIsTrue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listQuestions;
        private System.Windows.Forms.ListBox listAnswers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TestName;
        private System.Windows.Forms.TextBox PredmetName;
        private System.Windows.Forms.Button DeleteQuestion;
        private System.Windows.Forms.Button DeleteAnswer;
        private System.Windows.Forms.Button AddAnswer;
        private System.Windows.Forms.Button SaveTest;
        private System.Windows.Forms.GroupBox groupIsTrue;
        private System.Windows.Forms.RadioButton radioNo;
        private System.Windows.Forms.RadioButton radioYes;
        private System.Windows.Forms.TextBox textQuestion;
        private System.Windows.Forms.TextBox textAnswer;
    }
}