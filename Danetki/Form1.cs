using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;
using System.Threading.Tasks;
namespace Danetki
{
    public partial class Form1 : Form
    {
        List<string> text = new List<string>();
        List<string> question = new List<string>();
        int index = 0;
        int number = 0;
        int tekindex = 0;
        int kol = 0;
        int ball = 0;
        bool visible = false;
        string last = "";
        public Form1()
        {
            InitializeComponent();
            string path = "Введение в ПИ. Список предметов к данетке.csv";

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string q = line.Split(';')[0].ToLower();
                    string t = line.Split(';')[1].ToLower();
                    text.Add(q);
                    question.Add(t);
                }
            }

            label_text.Text = question[tekindex].Split(':')[number];
            label_q.Text = "Количество вопросов " + Convert.ToString(kol);
            label_b.Text = "Количество баллов  " + Convert.ToString(ball);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_vvod_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<52; i++)
            {
                if (text[i].Contains(textBox1.Text.ToLower()))
                {
                    index = i;
                }
            }
            tekindex = index;
            number = 0;
            label_text.Text = question[tekindex].Split(':')[number];
        }

        private void button_yes_Click(object sender, EventArgs e)
        {
            last += label_text.Text + " ";
        number++;
            try
            {
                label_text.Text = question[tekindex].Split(':')[number];
                kol++;
                if(kol>10)
                {
                    ball -= 1;
                }
            }
            catch
            {
                label_text.Text = text[tekindex];
                if(textBox1.Text.ToLower().Contains(label_text.Text.ToLower()))
                {
                    label_text.Text = "OK";
                    kol = 0;
                    ball += 10;
                    index = 0;
                    tekindex = 0;
                    number = 0;
                    label_text.Text = question[tekindex].Split(':')[number];
                    last = "";
                }
            }

            label_q.Text = "Количество вопросов " + Convert.ToString(kol);
            label_b.Text = "Количество баллов  " + Convert.ToString(ball);
        }

        private void button_no_Click(object sender, EventArgs e)
        {
            tekindex += 1;
            number += 1;
            try
            {
                //for (int i = tekindex-1; i<51; i++)
                //{
                //    if(last.ToLower().Contains(question[i].Split(':')[number-1].ToLower()))
                //    {
                //        tekindex = i;
                //        break;
                //    }
                //}
                label_text.Text = question[tekindex].Split(':')[number];
            }
            catch
            {
                if(tekindex>51)
                {
                    tekindex = 51 - tekindex;
                    label_text.Text = question[tekindex].Split(':')[number];
                }
                else
                {
                    number = 0;
                    label_text.Text = question[tekindex].Split(':')[number];
                }
            }

            kol++;

            if (kol > 10)
            {
                ball -= 1;
            }

            label_q.Text= "Количество вопросов " + Convert.ToString(kol);
            label_b.Text = "Количество баллов  " + Convert.ToString(ball);
        }

    }
}
