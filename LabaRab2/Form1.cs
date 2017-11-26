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

        private void btnSum_Click(object sender, EventArgs e)
        {
            labelResult.Text = "Результат: ";
            string num = "";
            int count = 0;

            for (int i=0; i<=richTextBox.TextLength-1; i++)
            {
                if (richTextBox.Text[i] == ' ' || richTextBox.Text[i] == '\n' || richTextBox.Text[i] >= 'a' && richTextBox.Text[i] <= 'z')
                {
                    if (num != "")
                    {
                        count++;
                        num = "";
                    }
                    
                } else if (richTextBox.Text[i] >= '0' && richTextBox.Text[i] <= '9') num+=richTextBox.Text[i];
            }
            labelResult.Text = labelResult.Text + Convert.ToString(count) + " чисел.";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            richTextBox.Enabled = true;
        }

        private void сохранитьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String FileName = saveFileDialog1.FileName;
                FileStream myStream = new FileStream(FileName, FileMode.Create);
                StreamWriter SW = new StreamWriter(myStream);
                SW.Write(richTextBox.Text);
                SW.Close();
                myStream.Close();
            }
        }

        //*************************************************************************************************************
    }
}
