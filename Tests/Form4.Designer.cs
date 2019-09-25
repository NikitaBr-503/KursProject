namespace Tests
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.timerText = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.counter = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.question = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // timerText
            // 
            this.timerText.AutoSize = true;
            this.timerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerText.Location = new System.Drawing.Point(306, 9);
            this.timerText.Name = "timerText";
            this.timerText.Size = new System.Drawing.Size(76, 29);
            this.timerText.TabIndex = 0;
            this.timerText.Text = "00:00";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(559, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "Закончить тест";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ответить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.counter.Location = new System.Drawing.Point(319, 38);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(48, 29);
            this.counter.TabIndex = 3;
            this.counter.Text = "0/0";
            this.counter.Click += new System.EventHandler(this.counter_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // question
            // 
            this.question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.question.Location = new System.Drawing.Point(12, 86);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(615, 67);
            this.question.TabIndex = 5;
            // 
            // gb
            // 
            this.gb.Location = new System.Drawing.Point(12, 156);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(680, 221);
            this.gb.TabIndex = 7;
            this.gb.TabStop = false;
            this.gb.Text = "Варианты ответов";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 440);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.question);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.timerText);
            this.Name = "Form4";
            this.Text = "ProgressTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timerText;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.GroupBox gb;
    }
}