namespace GitCommander
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gitpath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.workingdir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.commitname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gitpath
            // 
            this.gitpath.Location = new System.Drawing.Point(62, 12);
            this.gitpath.Name = "gitpath";
            this.gitpath.Size = new System.Drawing.Size(431, 20);
            this.gitpath.TabIndex = 0;
            this.gitpath.TextChanged += new System.EventHandler(this.gitpath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Git path";
            // 
            // workingdir
            // 
            this.workingdir.Location = new System.Drawing.Point(81, 38);
            this.workingdir.Name = "workingdir";
            this.workingdir.Size = new System.Drawing.Size(412, 20);
            this.workingdir.TabIndex = 3;
            this.workingdir.TextChanged += new System.EventHandler(this.workingdir_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Working Dir";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 587);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(481, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // commitname
            // 
            this.commitname.Location = new System.Drawing.Point(91, 64);
            this.commitname.Name = "commitname";
            this.commitname.Size = new System.Drawing.Size(331, 20);
            this.commitname.TabIndex = 9;
            this.commitname.Text = "commit_name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Commit_name";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 115);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(239, 61);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 174);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(239, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "EXEC WITH GIT";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "EXEC WITH GIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(257, 115);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(236, 61);
            this.richTextBox2.TabIndex = 15;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 508);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(481, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "EXEC WITH GIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(15, 318);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(481, 192);
            this.richTextBox3.TabIndex = 19;
            this.richTextBox3.Text = "";
            this.richTextBox3.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(481, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "EXEC WITH GIT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(12, 205);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(481, 86);
            this.richTextBox4.TabIndex = 17;
            this.richTextBox4.Text = "";
            this.richTextBox4.TextChanged += new System.EventHandler(this.richTextBox4_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(428, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 49);
            this.button5.TabIndex = 21;
            this.button5.Text = "PULL ADD COMMIT PUSH";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 20);
            this.textBox1.TabIndex = 22;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(351, 88);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 23);
            this.button6.TabIndex = 23;
            this.button6.Text = "< EXEC";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(15, 537);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(481, 44);
            this.button8.TabIndex = 24;
            this.button8.Text = "Save";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 640);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.commitname);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.workingdir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gitpath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gitpath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox workingdir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox commitname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
    }
}

