using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_processes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StreamWriter sw;
        string filename, filepath;

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = folderBrowserDialog1.SelectedPath.ToString();
                textBox2.Text = filepath;
            } // fayli yaratmaq ucun

        }
        private void button2_Click(object sender, EventArgs e) //Kaydetmek
        {
            filename = textBox1.Text;
            sw = File.CreateText(filepath + "\\" + filename + ".txt");
            sw.Close();
            MessageBox.Show("Fayllariniz olusturuldu!");
        }
        private void button3_Click(object sender, EventArgs e) //Fayl oxumaq
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                 StreamReader oku=new StreamReader(openFileDialog1.FileName);
                string satir=oku.ReadLine();
                while (satir!= null)
                {
                    listBox1.Items.Add(satir);
                    satir= oku.ReadLine();
                }
            }
        }
    }
}
