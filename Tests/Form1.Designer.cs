namespace Tests
{
    partial class TestForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.MarkGroup = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioPerQuestion = new System.Windows.Forms.RadioButton();
            this.radioPerTest = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.Mark = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MarkGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestName,
            this.Subject,
            this.CountQuestion});
            this.dataGridView1.Location = new System.Drawing.Point(178, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(446, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Пройти тест";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить тест";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 26);
            this.button3.TabIndex = 3;
            this.button3.Text = "Редактировать тест";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 26);
            this.button4.TabIndex = 4;
            this.button4.Text = "Удалить тест";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MarkGroup
            // 
            this.MarkGroup.Controls.Add(this.Mark);
            this.MarkGroup.Controls.Add(this.radioPerTest);
            this.MarkGroup.Controls.Add(this.radioPerQuestion);
            this.MarkGroup.Location = new System.Drawing.Point(13, 141);
            this.MarkGroup.Name = "MarkGroup";
            this.MarkGroup.Size = new System.Drawing.Size(159, 97);
            this.MarkGroup.TabIndex = 5;
            this.MarkGroup.TabStop = false;
            this.MarkGroup.Text = "Оценка";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Time);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Location = new System.Drawing.Point(13, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 98);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Время, мин";
            // 
            // radioPerQuestion
            // 
            this.radioPerQuestion.AutoSize = true;
            this.radioPerQuestion.Location = new System.Drawing.Point(6, 19);
            this.radioPerQuestion.Name = "radioPerQuestion";
            this.radioPerQuestion.Size = new System.Drawing.Size(134, 17);
            this.radioPerQuestion.TabIndex = 0;
            this.radioPerQuestion.TabStop = true;
            this.radioPerQuestion.Text = "За правильный ответ";
            this.radioPerQuestion.UseVisualStyleBackColor = true;
            // 
            // radioPerTest
            // 
            this.radioPerTest.AutoSize = true;
            this.radioPerTest.Location = new System.Drawing.Point(6, 42);
            this.radioPerTest.Name = "radioPerTest";
            this.radioPerTest.Size = new System.Drawing.Size(63, 17);
            this.radioPerTest.TabIndex = 1;
            this.radioPerTest.TabStop = true;
            this.radioPerTest.Text = "За тест";
            this.radioPerTest.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 109);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 26);
            this.button5.TabIndex = 7;
            this.button5.Text = "Посмотреть результаты";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Mark
            // 
            this.Mark.Location = new System.Drawing.Point(7, 66);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(146, 20);
            this.Mark.TabIndex = 2;
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(8, 66);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(146, 20);
            this.Time.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "На тест";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "На один вопрос";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите ваше полное имя : ";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(333, 17);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(291, 20);
            this.UserName.TabIndex = 3;
            // 
            // TestName
            // 
            this.TestName.HeaderText = "Название";
            this.TestName.Name = "TestName";
            this.TestName.ReadOnly = true;
            this.TestName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TestName.Width = 150;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Предмет";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Subject.Width = 150;
            // 
            // CountQuestion
            // 
            this.CountQuestion.HeaderText = "Кол-во вопросов";
            this.CountQuestion.Name = "CountQuestion";
            this.CountQuestion.ReadOnly = true;
            this.CountQuestion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 346);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.MarkGroup);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TestForm";
            this.Text = "Система тестирования";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MarkGroup.ResumeLayout(false);
            this.MarkGroup.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox MarkGroup;
        private System.Windows.Forms.TextBox Mark;
        private System.Windows.Forms.RadioButton radioPerTest;
        private System.Windows.Forms.RadioButton radioPerQuestion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountQuestion;
    }
}

