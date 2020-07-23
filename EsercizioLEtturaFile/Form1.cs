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
        private void btn_caricaFile_Click(object sender, EventArgs e)
        {
            var dlgResult = openFileDialog1.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                label1.Text = openFileDialog1.FileName;
            }
            else
            {
                label1.Text = "nessun file scelto";
            }
        }

        private void btn_leggi_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            using (StreamReader fileStream = new StreamReader(openFileDialog1.FileName))
            {
                string line;
                while ((line = fileStream.ReadLine()) != null)
                {
                    textBox1.Text += $"{line}{Environment.NewLine}";
                }
                textBox1.Text += "FINE DEL FILE";
            }
        }

        private void btn_scrivi_Click(object sender, EventArgs e)
        {
            using (StreamWriter streamWriter = new StreamWriter(openFileDialog1.FileName,true))
            {
                streamWriter.WriteLine("riga inserita da codice");
                streamWriter.WriteLine("altra riga inserita da codice");
                streamWriter.Flush();
                streamWriter.WriteLine("ennesima riga inserita da codice");
            }
        }
    }
}
