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

namespace EsercizioLEtturaFile
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private StreamReader fileStream;
        private void btn_caricaFile_Click(object sender, EventArgs e)
        {
            var dlgResult = openFileDialog1.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                label1.Text = openFileDialog1.FileName;
                fileStream = new StreamReader(openFileDialog1.FileName);
            }
            else
            {
                label1.Text = "nessun file scelto";
            }
        }

        private void btn_leggiRiga_Click(object sender, EventArgs e)
        {
            if(fileStream != null)
            {
                textBox1.Text += $"{Environment.NewLine}{fileStream.ReadLine()}";
            }          
        }
    }
}
