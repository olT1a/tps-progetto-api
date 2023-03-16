namespace Rocchi_meteo
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_citta = new System.Windows.Forms.TextBox();
            this.lbl_citta = new System.Windows.Forms.Label();
            this.btn_cerca = new System.Windows.Forms.Button();
            this.lbl_c_weather = new System.Windows.Forms.Label();
            this.lbl_c_temperature = new System.Windows.Forms.Label();
            this.lbl_c_time = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_windspeed = new System.Windows.Forms.Label();
            this.lbl_c_windspeed = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_lunedi = new System.Windows.Forms.Label();
            this.lbl_martedì = new System.Windows.Forms.Label();
            this.lbl_mercoledì = new System.Windows.Forms.Label();
            this.lbl_giovedì = new System.Windows.Forms.Label();
            this.lbl_venerdì = new System.Windows.Forms.Label();
            this.lbl_sabato = new System.Windows.Forms.Label();
            this.lbl_domenica = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_citta
            // 
            this.txt_citta.Location = new System.Drawing.Point(23, 50);
            this.txt_citta.Name = "txt_citta";
            this.txt_citta.Size = new System.Drawing.Size(100, 22);
            this.txt_citta.TabIndex = 0;
            // 
            // lbl_citta
            // 
            this.lbl_citta.AutoSize = true;
            this.lbl_citta.Location = new System.Drawing.Point(20, 31);
            this.lbl_citta.Name = "lbl_citta";
            this.lbl_citta.Size = new System.Drawing.Size(78, 16);
            this.lbl_citta.TabIndex = 1;
            this.lbl_citta.Text = "Inserire citta";
            // 
            // btn_cerca
            // 
            this.btn_cerca.Location = new System.Drawing.Point(23, 78);
            this.btn_cerca.Name = "btn_cerca";
            this.btn_cerca.Size = new System.Drawing.Size(75, 23);
            this.btn_cerca.TabIndex = 2;
            this.btn_cerca.Text = "cerca";
            this.btn_cerca.UseVisualStyleBackColor = true;
            this.btn_cerca.Click += new System.EventHandler(this.btn_cerca_Click);
            // 
            // lbl_c_weather
            // 
            this.lbl_c_weather.AutoSize = true;
            this.lbl_c_weather.Location = new System.Drawing.Point(23, 145);
            this.lbl_c_weather.Name = "lbl_c_weather";
            this.lbl_c_weather.Size = new System.Drawing.Size(100, 16);
            this.lbl_c_weather.TabIndex = 3;
            this.lbl_c_weather.Text = "current weather:";
            // 
            // lbl_c_temperature
            // 
            this.lbl_c_temperature.AutoSize = true;
            this.lbl_c_temperature.Location = new System.Drawing.Point(130, 145);
            this.lbl_c_temperature.Name = "lbl_c_temperature";
            this.lbl_c_temperature.Size = new System.Drawing.Size(0, 16);
            this.lbl_c_temperature.TabIndex = 4;
            // 
            // lbl_c_time
            // 
            this.lbl_c_time.AutoSize = true;
            this.lbl_c_time.Location = new System.Drawing.Point(26, 185);
            this.lbl_c_time.Name = "lbl_c_time";
            this.lbl_c_time.Size = new System.Drawing.Size(41, 16);
            this.lbl_c_time.TabIndex = 5;
            this.lbl_c_time.Text = "Time:";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(86, 185);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(0, 16);
            this.lbl_time.TabIndex = 6;
            // 
            // lbl_windspeed
            // 
            this.lbl_windspeed.AutoSize = true;
            this.lbl_windspeed.Location = new System.Drawing.Point(112, 227);
            this.lbl_windspeed.Name = "lbl_windspeed";
            this.lbl_windspeed.Size = new System.Drawing.Size(0, 16);
            this.lbl_windspeed.TabIndex = 8;
            // 
            // lbl_c_windspeed
            // 
            this.lbl_c_windspeed.AutoSize = true;
            this.lbl_c_windspeed.Location = new System.Drawing.Point(26, 227);
            this.lbl_c_windspeed.Name = "lbl_c_windspeed";
            this.lbl_c_windspeed.Size = new System.Drawing.Size(80, 16);
            this.lbl_c_windspeed.TabIndex = 7;
            this.lbl_c_windspeed.Text = "Windspeed:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_lunedi);
            this.panel1.Location = new System.Drawing.Point(12, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 171);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_martedì);
            this.panel2.Location = new System.Drawing.Point(190, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 171);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_giovedì);
            this.panel3.Location = new System.Drawing.Point(546, 288);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(172, 171);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_mercoledì);
            this.panel4.Location = new System.Drawing.Point(368, 288);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(172, 171);
            this.panel4.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbl_domenica);
            this.panel5.Location = new System.Drawing.Point(1080, 288);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(172, 171);
            this.panel5.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbl_venerdì);
            this.panel6.Location = new System.Drawing.Point(724, 288);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(172, 171);
            this.panel6.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbl_sabato);
            this.panel7.Location = new System.Drawing.Point(902, 288);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(172, 171);
            this.panel7.TabIndex = 14;
            // 
            // lbl_lunedi
            // 
            this.lbl_lunedi.AutoSize = true;
            this.lbl_lunedi.Location = new System.Drawing.Point(53, 12);
            this.lbl_lunedi.Name = "lbl_lunedi";
            this.lbl_lunedi.Size = new System.Drawing.Size(47, 16);
            this.lbl_lunedi.TabIndex = 16;
            this.lbl_lunedi.Text = "Lunedì";
            // 
            // lbl_martedì
            // 
            this.lbl_martedì.AutoSize = true;
            this.lbl_martedì.Location = new System.Drawing.Point(55, 12);
            this.lbl_martedì.Name = "lbl_martedì";
            this.lbl_martedì.Size = new System.Drawing.Size(52, 16);
            this.lbl_martedì.TabIndex = 17;
            this.lbl_martedì.Text = "Martedì";
            // 
            // lbl_mercoledì
            // 
            this.lbl_mercoledì.AutoSize = true;
            this.lbl_mercoledì.Location = new System.Drawing.Point(47, 12);
            this.lbl_mercoledì.Name = "lbl_mercoledì";
            this.lbl_mercoledì.Size = new System.Drawing.Size(67, 16);
            this.lbl_mercoledì.TabIndex = 19;
            this.lbl_mercoledì.Text = "Mercoledì";
            // 
            // lbl_giovedì
            // 
            this.lbl_giovedì.AutoSize = true;
            this.lbl_giovedì.Location = new System.Drawing.Point(52, 12);
            this.lbl_giovedì.Name = "lbl_giovedì";
            this.lbl_giovedì.Size = new System.Drawing.Size(54, 16);
            this.lbl_giovedì.TabIndex = 18;
            this.lbl_giovedì.Text = "Giovedì";
            // 
            // lbl_venerdì
            // 
            this.lbl_venerdì.AutoSize = true;
            this.lbl_venerdì.Location = new System.Drawing.Point(56, 12);
            this.lbl_venerdì.Name = "lbl_venerdì";
            this.lbl_venerdì.Size = new System.Drawing.Size(54, 16);
            this.lbl_venerdì.TabIndex = 22;
            this.lbl_venerdì.Text = "Venerdì";
            // 
            // lbl_sabato
            // 
            this.lbl_sabato.AutoSize = true;
            this.lbl_sabato.Location = new System.Drawing.Point(56, 12);
            this.lbl_sabato.Name = "lbl_sabato";
            this.lbl_sabato.Size = new System.Drawing.Size(51, 16);
            this.lbl_sabato.TabIndex = 21;
            this.lbl_sabato.Text = "Sabato";
            // 
            // lbl_domenica
            // 
            this.lbl_domenica.AutoSize = true;
            this.lbl_domenica.Location = new System.Drawing.Point(49, 12);
            this.lbl_domenica.Name = "lbl_domenica";
            this.lbl_domenica.Size = new System.Drawing.Size(69, 16);
            this.lbl_domenica.TabIndex = 20;
            this.lbl_domenica.Text = "Domenica";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 471);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_windspeed);
            this.Controls.Add(this.lbl_c_windspeed);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_c_time);
            this.Controls.Add(this.lbl_c_temperature);
            this.Controls.Add(this.lbl_c_weather);
            this.Controls.Add(this.btn_cerca);
            this.Controls.Add(this.lbl_citta);
            this.Controls.Add(this.txt_citta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_citta;
        private System.Windows.Forms.Button btn_cerca;
        public System.Windows.Forms.TextBox txt_citta;
        private System.Windows.Forms.Label lbl_c_weather;
        private System.Windows.Forms.Label lbl_c_temperature;
        private System.Windows.Forms.Label lbl_c_time;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_windspeed;
        private System.Windows.Forms.Label lbl_c_windspeed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_lunedi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_martedì;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_giovedì;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_mercoledì;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_domenica;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_venerdì;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_sabato;
    }
}

