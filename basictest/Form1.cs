using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;


namespace basictest
{
    public partial class Form1 : Form
    {

        public Form1(string file)
        {
         
                    InitializeComponent();
            if (System.IO.File.Exists(file))
            {
                string text = System.IO.File.ReadAllText(file);
                textBox1.Text = text;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Basic Text File (*.cep)|*.cep|All files (*.*)|*.*";
            saveFileDialog1.ShowDialog();
            System.IO.File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
        }
    }
}
