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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_ora_1 = new System.Windows.Forms.Label();
            this.lbl_temp_1 = new System.Windows.Forms.Label();
            this.lbl_data_1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_ora_2 = new System.Windows.Forms.Label();
            this.lbl_temp_2 = new System.Windows.Forms.Label();
            this.lbl_data_2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_ora_4 = new System.Windows.Forms.Label();
            this.lbl_temp_4 = new System.Windows.Forms.Label();
            this.lbl_data_4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_ora_3 = new System.Windows.Forms.Label();
            this.lbl_temp_3 = new System.Windows.Forms.Label();
            this.lbl_data_3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_ora_7 = new System.Windows.Forms.Label();
            this.lbl_temp_7 = new System.Windows.Forms.Label();
            this.lbl_data_7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_ora_5 = new System.Windows.Forms.Label();
            this.lbl_temp_5 = new System.Windows.Forms.Label();
            this.lbl_data_5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_ora_6 = new System.Windows.Forms.Label();
            this.lbl_temp_6 = new System.Windows.Forms.Label();
            this.lbl_data_6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_current = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
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
            this.txt_citta.Location = new System.Drawing.Point(143, 51);
            this.txt_citta.Name = "txt_citta";
            this.txt_citta.Size = new System.Drawing.Size(182, 22);
            this.txt_citta.TabIndex = 0;
            // 
            // lbl_citta
            // 
            this.lbl_citta.AutoSize = true;
            this.lbl_citta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_citta.Location = new System.Drawing.Point(11, 51);
            this.lbl_citta.Name = "lbl_citta";
            this.lbl_citta.Size = new System.Drawing.Size(116, 20);
            this.lbl_citta.TabIndex = 1;
            this.lbl_citta.Text = "Inserire citta";
            // 
            // btn_cerca
            // 
            this.btn_cerca.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_cerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerca.Location = new System.Drawing.Point(377, 44);
            this.btn_cerca.Name = "btn_cerca";
            this.btn_cerca.Size = new System.Drawing.Size(82, 40);
            this.btn_cerca.TabIndex = 2;
            this.btn_cerca.Text = "cerca";
            this.btn_cerca.UseVisualStyleBackColor = false;
            this.btn_cerca.Click += new System.EventHandler(this.btn_cerca_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_ora_1);
            this.panel1.Controls.Add(this.lbl_temp_1);
            this.panel1.Controls.Add(this.lbl_data_1);
            this.panel1.Location = new System.Drawing.Point(15, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 476);
            this.panel1.TabIndex = 9;
            // 
            // lbl_ora_1
            // 
            this.lbl_ora_1.AutoSize = true;
            this.lbl_ora_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ora_1.Location = new System.Drawing.Point(2, 20);
            this.lbl_ora_1.Name = "lbl_ora_1";
            this.lbl_ora_1.Size = new System.Drawing.Size(45, 18);
            this.lbl_ora_1.TabIndex = 18;
            this.lbl_ora_1.Text = "Ora1";
            // 
            // lbl_temp_1
            // 
            this.lbl_temp_1.AutoSize = true;
            this.lbl_temp_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_temp_1.Location = new System.Drawing.Point(74, 20);
            this.lbl_temp_1.Name = "lbl_temp_1";
            this.lbl_temp_1.Size = new System.Drawing.Size(59, 18);
            this.lbl_temp_1.TabIndex = 17;
            this.lbl_temp_1.Text = "Temp1";
            // 
            // lbl_data_1
            // 
            this.lbl_data_1.AutoSize = true;
            this.lbl_data_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_1.Location = new System.Drawing.Point(4, 0);
            this.lbl_data_1.Name = "lbl_data_1";
            this.lbl_data_1.Size = new System.Drawing.Size(48, 16);
            this.lbl_data_1.TabIndex = 16;
            this.lbl_data_1.Text = "Data1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_ora_2);
            this.panel2.Controls.Add(this.lbl_temp_2);
            this.panel2.Controls.Add(this.lbl_data_2);
            this.panel2.Location = new System.Drawing.Point(196, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 476);
            this.panel2.TabIndex = 10;
            // 
            // lbl_ora_2
            // 
            this.lbl_ora_2.AutoSize = true;
            this.lbl_ora_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ora_2.Location = new System.Drawing.Point(3, 20);
            this.lbl_ora_2.Name = "lbl_ora_2";
            this.lbl_ora_2.Size = new System.Drawing.Size(45, 18);
            this.lbl_ora_2.TabIndex = 19;
            this.lbl_ora_2.Text = "Ora2";
            // 
            // lbl_temp_2
            // 
            this.lbl_temp_2.AutoSize = true;
            this.lbl_temp_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_temp_2.Location = new System.Drawing.Point(70, 20);
            this.lbl_temp_2.Name = "lbl_temp_2";
            this.lbl_temp_2.Size = new System.Drawing.Size(59, 18);
            this.lbl_temp_2.TabIndex = 18;
            this.lbl_temp_2.Text = "Temp2";
            // 
            // lbl_data_2
            // 
            this.lbl_data_2.AutoSize = true;
            this.lbl_data_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_2.Location = new System.Drawing.Point(0, 0);
            this.lbl_data_2.Name = "lbl_data_2";
            this.lbl_data_2.Size = new System.Drawing.Size(48, 16);
            this.lbl_data_2.TabIndex = 17;
            this.lbl_data_2.Text = "Data2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_ora_4);
            this.panel3.Controls.Add(this.lbl_temp_4);
            this.panel3.Controls.Add(this.lbl_data_4);
            this.panel3.Location = new System.Drawing.Point(558, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 476);
            this.panel3.TabIndex = 12;
            // 
            // lbl_ora_4
            // 
            this.lbl_ora_4.AutoSize = true;
            this.lbl_ora_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ora_4.Location = new System.Drawing.Point(3, 20);
            this.lbl_ora_4.Name = "lbl_ora_4";
            this.lbl_ora_4.Size = new System.Drawing.Size(45, 18);
            this.lbl_ora_4.TabIndex = 21;
            this.lbl_ora_4.Text = "Ora4";
            // 
            // lbl_temp_4
            // 
            this.lbl_temp_4.AutoSize = true;
            this.lbl_temp_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_temp_4.Location = new System.Drawing.Point(84, 20);
            this.lbl_temp_4.Name = "lbl_temp_4";
            this.lbl_temp_4.Size = new System.Drawing.Size(59, 18);
            this.lbl_temp_4.TabIndex = 19;
            this.lbl_temp_4.Text = "Temp4";
            // 
            // lbl_data_4
            // 
            this.lbl_data_4.AutoSize = true;
            this.lbl_data_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_4.Location = new System.Drawing.Point(0, 0);
            this.lbl_data_4.Name = "lbl_data_4";
            this.lbl_data_4.Size = new System.Drawing.Size(48, 16);
            this.lbl_data_4.TabIndex = 18;
            this.lbl_data_4.Text = "Data4";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_ora_3);
            this.panel4.Controls.Add(this.lbl_temp_3);
            this.panel4.Controls.Add(this.lbl_data_3);
            this.panel4.Location = new System.Drawing.Point(377, 108);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 476);
            this.panel4.TabIndex = 11;
            // 
            // lbl_ora_3
            // 
            this.lbl_ora_3.AutoSize = true;
            this.lbl_ora_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ora_3.Location = new System.Drawing.Point(3, 20);
            this.lbl_ora_3.Name = "lbl_ora_3";
            this.lbl_ora_3.Size = new System.Drawing.Size(45, 18);
            this.lbl_ora_3.TabIndex = 20;
            this.lbl_ora_3.Text = "Ora3";
            // 
            // lbl_temp_3
            // 
            this.lbl_temp_3.AutoSize = true;
            this.lbl_temp_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_temp_3.Location = new System.Drawing.Point(78, 20);
            this.lbl_temp_3.Name = "lbl_temp_3";
            this.lbl_temp_3.Size = new System.Drawing.Size(59, 18);
            this.lbl_temp_3.TabIndex = 19;
            this.lbl_temp_3.Text = "Temp3";
            // 
            // lbl_data_3
            // 
            this.lbl_data_3.AutoSize = true;
            this.lbl_data_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_3.Location = new System.Drawing.Point(0, 0);
            this.lbl_data_3.Name = "lbl_data_3";
            this.lbl_data_3.Size = new System.Drawing.Size(48, 16);
            this.lbl_data_3.TabIndex = 19;
            this.lbl_data_3.Text = "Data3";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbl_ora_7);
            this.panel5.Controls.Add(this.lbl_temp_7);
            this.panel5.Controls.Add(this.lbl_data_7);
            this.panel5.Location = new System.Drawing.Point(1101, 110);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(175, 476);
            this.panel5.TabIndex = 15;
            // 
            // lbl_ora_7
            // 
            this.lbl_ora_7.AutoSize = true;
            this.lbl_ora_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ora_7.Location = new System.Drawing.Point(3, 20);
            this.lbl_ora_7.Name = "lbl_ora_7";
            this.lbl_ora_7.Size = new System.Drawing.Size(45, 18);
            this.lbl_ora_7.TabIndex = 24;
            this.lbl_ora_7.Text = "Ora7";
            // 
            // lbl_temp_7
            // 
            this.lbl_temp_7.AutoSize = true;
            this.lbl_temp_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_temp_7.Location = new System.Drawing.Point(62, 20);
            this.lbl_temp_7.Name = "lbl_temp_7";
            this.lbl_temp_7.Size = new System.Drawing.Size(59, 18);
            this.lbl_temp_7.TabIndex = 23;
            this.lbl_temp_7.Text = "Temp7";
            // 
            // lbl_data_7
            // 
            this.lbl_data_7.AutoSize = true;
            this.lbl_data_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_7.Location = new System.Drawing.Point(0, 0);
            this.lbl_data_7.Name = "lbl_data_7";
            this.lbl_data_7.Size = new System.Drawing.Size(48, 16);
            this.lbl_data_7.TabIndex = 20;
            this.lbl_data_7.Text = "Data7";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbl_ora_5);
            this.panel6.Controls.Add(this.lbl_temp_5);
            this.panel6.Controls.Add(this.lbl_data_5);
            this.panel6.Location = new System.Drawing.Point(739, 108);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(175, 476);
            this.panel6.TabIndex = 13;
            // 
            // lbl_ora_5
            // 
            this.lbl_ora_5.AutoSize = true;
            this.lbl_ora_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ora_5.Location = new System.Drawing.Point(3, 20);
            this.lbl_ora_5.Name = "lbl_ora_5";
            this.lbl_ora_5.Size = new System.Drawing.Size(45, 18);
            this.lbl_ora_5.TabIndex = 22;
            this.lbl_ora_5.Text = "Ora5";
            // 
            // lbl_temp_5
            // 
            this.lbl_temp_5.AutoSize = true;
            this.lbl_temp_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_temp_5.Location = new System.Drawing.Point(81, 20);
            this.lbl_temp_5.Name = "lbl_temp_5";
            this.lbl_temp_5.Size = new System.Drawing.Size(59, 18);
            this.lbl_temp_5.TabIndex = 20;
            this.lbl_temp_5.Text = "Temp5";
            // 
            // lbl_data_5
            // 
            this.lbl_data_5.AutoSize = true;
            this.lbl_data_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_5.Location = new System.Drawing.Point(0, 0);
            this.lbl_data_5.Name = "lbl_data_5";
            this.lbl_data_5.Size = new System.Drawing.Size(48, 16);
            this.lbl_data_5.TabIndex = 22;
            this.lbl_data_5.Text = "Data5";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbl_ora_6);
            this.panel7.Controls.Add(this.lbl_temp_6);
            this.panel7.Controls.Add(this.lbl_data_6);
            this.panel7.Location = new System.Drawing.Point(920, 110);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(175, 476);
            this.panel7.TabIndex = 14;
            // 
            // lbl_ora_6
            // 
            this.lbl_ora_6.AutoSize = true;
            this.lbl_ora_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ora_6.Location = new System.Drawing.Point(3, 20);
            this.lbl_ora_6.Name = "lbl_ora_6";
            this.lbl_ora_6.Size = new System.Drawing.Size(45, 18);
            this.lbl_ora_6.TabIndex = 23;
            this.lbl_ora_6.Text = "Ora6";
            // 
            // lbl_temp_6
            // 
            this.lbl_temp_6.AutoSize = true;
            this.lbl_temp_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_temp_6.Location = new System.Drawing.Point(75, 20);
            this.lbl_temp_6.Name = "lbl_temp_6";
            this.lbl_temp_6.Size = new System.Drawing.Size(59, 18);
            this.lbl_temp_6.TabIndex = 22;
            this.lbl_temp_6.Text = "Temp6";
            // 
            // lbl_data_6
            // 
            this.lbl_data_6.AutoSize = true;
            this.lbl_data_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_6.Location = new System.Drawing.Point(0, 0);
            this.lbl_data_6.Name = "lbl_data_6";
            this.lbl_data_6.Size = new System.Drawing.Size(48, 16);
            this.lbl_data_6.TabIndex = 21;
            this.lbl_data_6.Text = "Data6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1090, -17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // btn_current
            // 
            this.btn_current.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_current.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_current.Location = new System.Drawing.Point(558, 38);
            this.btn_current.Name = "btn_current";
            this.btn_current.Size = new System.Drawing.Size(135, 52);
            this.btn_current.TabIndex = 17;
            this.btn_current.Text = "Vedere tempo attuale";
            this.btn_current.UseVisualStyleBackColor = false;
            this.btn_current.Click += new System.EventHandler(this.btn_current_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 13);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(92, 16);
            this.lbl_title.TabIndex = 18;
            this.lbl_title.Text = "PREVISIONI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1389, 596);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_current);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cerca);
            this.Controls.Add(this.lbl_citta);
            this.Controls.Add(this.txt_citta);
            this.MaximumSize = new System.Drawing.Size(1407, 643);
            this.MinimumSize = new System.Drawing.Size(1407, 643);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_data_2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_data_4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_data_3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_data_7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_data_5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_data_6;
        public System.Windows.Forms.Label lbl_data_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_temp_1;
        private System.Windows.Forms.Label lbl_temp_2;
        private System.Windows.Forms.Label lbl_temp_4;
        private System.Windows.Forms.Label lbl_temp_3;
        private System.Windows.Forms.Label lbl_temp_7;
        private System.Windows.Forms.Label lbl_temp_5;
        private System.Windows.Forms.Label lbl_temp_6;
        private System.Windows.Forms.Label lbl_ora_1;
        private System.Windows.Forms.Label lbl_ora_2;
        private System.Windows.Forms.Label lbl_ora_4;
        private System.Windows.Forms.Label lbl_ora_3;
        private System.Windows.Forms.Label lbl_ora_7;
        private System.Windows.Forms.Label lbl_ora_5;
        private System.Windows.Forms.Label lbl_ora_6;
        private System.Windows.Forms.Button btn_current;
        private System.Windows.Forms.Label lbl_title;
    }
}

