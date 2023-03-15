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
            this.lbl_citta.Size = new System.Drawing.Size(85, 17);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cerca);
            this.Controls.Add(this.lbl_citta);
            this.Controls.Add(this.txt_citta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_citta;
        private System.Windows.Forms.Button btn_cerca;
        public System.Windows.Forms.TextBox txt_citta;
    }
}

