using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.IO;

namespace LabaRab2
{
    public partial class Form1 : Form
    {
        private int numberFile = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())// создание нового OpenFileDialog
            {
                dialog.Filter = "Текстовые файлы|*.txt"; // отображение файлов с расширением .txt
                if (dialog.ShowDialog() == DialogResult.OK) // если выбираем файл и нажимаем кнопку ОК
                {
                    richTextBox.Text = File.ReadAllText(dialog.FileName);// вывод в текст бокс файла, 
                                                                         // предварительно считав с него текст
                    richTextBox.Text += ' ';                                           
                }
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            labelResult.Text = "Результат: ";
            labelTime.Text = "Время выполнения программы: ";

            string num = "";
            int count = 0;

            int? minNum = null;
            int maxNum = 0;

            numberFile++;

            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            for (int i=0; i<=richTextBox.TextLength-1; i++)
            {
                if (richTextBox.Text[i] == ' ' || richTextBox.Text[i] == '\n' || richTextBox.Text[i] >= 'a' && richTextBox.Text[i] <= 'z')
                {
                    if (num != "")
                    {
                        count++;
                        if (maxNum < Convert.ToInt32(num)) maxNum = Convert.ToInt32(num);
                        if (minNum == null) minNum = Convert.ToInt32(num);
                        else if (minNum > Convert.ToInt32(num)) minNum = Convert.ToInt32(num);
                        num = "";
                    }    
                } else if (richTextBox.Text[i] >= '0' && richTextBox.Text[i] <= '9') num+=richTextBox.Text[i];
            }

            using (StreamWriter sw = new StreamWriter(@"C:\Users\Hrankin Aleksandr\source\repos\NetLR02\LabaRab2\files\result\Result" + numberFile + ".txt", false, System.Text.Encoding.Default))
            {
                sw.WriteLine(Convert.ToString(count));
            }

            watch.Stop();
            var time = watch.Elapsed;

            labelResult.Text = labelResult.Text + count + " чисел. Max number " + maxNum + ". Min number " + minNum;
            labelTime.Text = labelTime.Text + time;

            
        }
        //*************************************************************************************************************


    }
}
