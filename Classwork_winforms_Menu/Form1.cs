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

namespace Classwork_winforms_Menu
{
    public partial class Form1 : Form
    {
        string current_file;

        public Form1()
        {
            InitializeComponent();

            textBox1.Visible = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();

            current_file = fileDialog.FileName;

            StreamReader sr = new StreamReader(fileDialog.FileName);

            textBox1.Text = sr.ReadToEnd();

            sr.Close();

            textBox1.Visible = true;
        }



        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (current_file!=null)
            {
                StreamWriter sw = new StreamWriter(current_file);

                sw.Write(textBox1.Text);

                sw.Close();

                textBox1.Visible = false;
            }
            else
            {
                MessageBox.Show("Вы ещё не начали работу с файлом");
            }


        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();


            StreamWriter sw = new StreamWriter(fileDialog.FileName);

            sw.Write(textBox1.Text);

            sw.Close();

            textBox1.Visible = false;
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Visible = true;
        }
    }
}
