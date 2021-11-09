namespace Danetki
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_q = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.label_text = new System.Windows.Forms.Label();
            this.button_vvod = new System.Windows.Forms.Button();
            this.button_yes = new System.Windows.Forms.Button();
            this.button_no = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(27, 28);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(231, 20);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Введите название предмета";
            this.label_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label_q
            // 
            this.label_q.AutoSize = true;
            this.label_q.Location = new System.Drawing.Point(399, 111);
            this.label_q.Name = "label_q";
            this.label_q.Size = new System.Drawing.Size(175, 20);
            this.label_q.TabIndex = 2;
            this.label_q.Text = "Количество вопросов";
            this.label_q.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Location = new System.Drawing.Point(399, 157);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(160, 20);
            this.label_b.TabIndex = 3;
            this.label_b.Text = "Количество баллов";
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Location = new System.Drawing.Point(31, 132);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(51, 20);
            this.label_text.TabIndex = 4;
            this.label_text.Text = "label4";
            // 
            // button_vvod
            // 
            this.button_vvod.Location = new System.Drawing.Point(392, 17);
            this.button_vvod.Name = "button_vvod";
            this.button_vvod.Size = new System.Drawing.Size(108, 43);
            this.button_vvod.TabIndex = 5;
            this.button_vvod.Text = "Запомнить";
            this.button_vvod.UseVisualStyleBackColor = true;
            this.button_vvod.Click += new System.EventHandler(this.button_vvod_Click);
            // 
            // button_yes
            // 
            this.button_yes.Location = new System.Drawing.Point(31, 210);
            this.button_yes.Name = "button_yes";
            this.button_yes.Size = new System.Drawing.Size(75, 48);
            this.button_yes.TabIndex = 6;
            this.button_yes.Text = "Да";
            this.button_yes.UseVisualStyleBackColor = true;
            this.button_yes.Click += new System.EventHandler(this.button_yes_Click);
            // 
            // button_no
            // 
            this.button_no.Location = new System.Drawing.Point(245, 210);
            this.button_no.Name = "button_no";
            this.button_no.Size = new System.Drawing.Size(75, 48);
            this.button_no.TabIndex = 7;
            this.button_no.Text = "Нет";
            this.button_no.UseVisualStyleBackColor = true;
            this.button_no.Click += new System.EventHandler(this.button_no_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.button_no);
            this.Controls.Add(this.button_yes);
            this.Controls.Add(this.button_vvod);
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label_q);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_q;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.Button button_vvod;
        private System.Windows.Forms.Button button_yes;
        private System.Windows.Forms.Button button_no;
    }
}

