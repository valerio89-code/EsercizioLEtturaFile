namespace EsercizioLEtturaFile
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_caricaFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_leggi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_scrivi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_caricaFile
            // 
            this.btn_caricaFile.Location = new System.Drawing.Point(52, 32);
            this.btn_caricaFile.Name = "btn_caricaFile";
            this.btn_caricaFile.Size = new System.Drawing.Size(163, 102);
            this.btn_caricaFile.TabIndex = 0;
            this.btn_caricaFile.Text = "Carica file";
            this.btn_caricaFile.UseVisualStyleBackColor = true;
            this.btn_caricaFile.Click += new System.EventHandler(this.btn_caricaFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "(*.txt)|*.txt";
            this.openFileDialog1.InitialDirectory = "C:\\Corso c#";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btn_leggi
            // 
            this.btn_leggi.Location = new System.Drawing.Point(52, 170);
            this.btn_leggi.Name = "btn_leggi";
            this.btn_leggi.Size = new System.Drawing.Size(163, 102);
            this.btn_leggi.TabIndex = 2;
            this.btn_leggi.Text = "Leggi file";
            this.btn_leggi.UseVisualStyleBackColor = true;
            this.btn_leggi.Click += new System.EventHandler(this.btn_leggi_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(292, 127);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(465, 286);
            this.textBox1.TabIndex = 3;
            // 
            // btn_scrivi
            // 
            this.btn_scrivi.Location = new System.Drawing.Point(52, 311);
            this.btn_scrivi.Name = "btn_scrivi";
            this.btn_scrivi.Size = new System.Drawing.Size(163, 102);
            this.btn_scrivi.TabIndex = 4;
            this.btn_scrivi.Text = "Scrivi file";
            this.btn_scrivi.UseVisualStyleBackColor = true;
            this.btn_scrivi.Click += new System.EventHandler(this.btn_scrivi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_scrivi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_leggi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_caricaFile);
            this.Name = "Form1";
            this.Text = "Carica file";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_caricaFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_leggi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_scrivi;
    }
}

