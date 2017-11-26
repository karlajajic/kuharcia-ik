namespace kuharica_ikkj
{
    partial class Recept_unos
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNazivRecepta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPriprema = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSastojci = new System.Windows.Forms.TextBox();
            this.btnGlavniIzbornik = new System.Windows.Forms.Button();
            this.btnUnosNovogRecepta = new System.Windows.Forms.Button();
            this.btnUnesiSliku = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPPriprema = new System.Windows.Forms.TextBox();
            this.cbTipJela = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 141);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbNazivRecepta
            // 
            this.tbNazivRecepta.Location = new System.Drawing.Point(226, 55);
            this.tbNazivRecepta.Name = "tbNazivRecepta";
            this.tbNazivRecepta.Size = new System.Drawing.Size(209, 20);
            this.tbNazivRecepta.TabIndex = 2;
            this.tbNazivRecepta.TextChanged += new System.EventHandler(this.tbNazivRecepta_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vrijeme pripreme:";
            // 
            // tbPriprema
            // 
            this.tbPriprema.Location = new System.Drawing.Point(276, 84);
            this.tbPriprema.Name = "tbPriprema";
            this.tbPriprema.Size = new System.Drawing.Size(159, 20);
            this.tbPriprema.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sastojci :";
            // 
            // tbSastojci
            // 
            this.tbSastojci.Location = new System.Drawing.Point(79, 222);
            this.tbSastojci.Name = "tbSastojci";
            this.tbSastojci.Size = new System.Drawing.Size(356, 20);
            this.tbSastojci.TabIndex = 6;
            // 
            // btnGlavniIzbornik
            // 
            this.btnGlavniIzbornik.Location = new System.Drawing.Point(38, 449);
            this.btnGlavniIzbornik.Name = "btnGlavniIzbornik";
            this.btnGlavniIzbornik.Size = new System.Drawing.Size(125, 35);
            this.btnGlavniIzbornik.TabIndex = 7;
            this.btnGlavniIzbornik.Text = "Glavni izbornik";
            this.btnGlavniIzbornik.UseVisualStyleBackColor = true;
            this.btnGlavniIzbornik.Click += new System.EventHandler(this.btnGlavniIzbornik_Click);
            // 
            // btnUnosNovogRecepta
            // 
            this.btnUnosNovogRecepta.Location = new System.Drawing.Point(186, 449);
            this.btnUnosNovogRecepta.Name = "btnUnosNovogRecepta";
            this.btnUnosNovogRecepta.Size = new System.Drawing.Size(125, 35);
            this.btnUnosNovogRecepta.TabIndex = 8;
            this.btnUnosNovogRecepta.Text = "Unos recepta";
            this.btnUnosNovogRecepta.UseVisualStyleBackColor = true;
            this.btnUnosNovogRecepta.Click += new System.EventHandler(this.btnUnosNovogRecepta_Click);
            // 
            // btnUnesiSliku
            // 
            this.btnUnesiSliku.Location = new System.Drawing.Point(38, 170);
            this.btnUnesiSliku.Name = "btnUnesiSliku";
            this.btnUnesiSliku.Size = new System.Drawing.Size(125, 35);
            this.btnUnesiSliku.TabIndex = 12;
            this.btnUnesiSliku.Text = "Unos slike";
            this.btnUnesiSliku.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Priprema :";
            // 
            // tbPPriprema
            // 
            this.tbPPriprema.Location = new System.Drawing.Point(79, 271);
            this.tbPPriprema.Multiline = true;
            this.tbPPriprema.Name = "tbPPriprema";
            this.tbPPriprema.Size = new System.Drawing.Size(356, 172);
            this.tbPPriprema.TabIndex = 14;
            // 
            // cbTipJela
            // 
            this.cbTipJela.FormattingEnabled = true;
            this.cbTipJela.Items.AddRange(new object[] {
            "Predjelo",
            "Glavno jelo",
            "Desert"});
            this.cbTipJela.Location = new System.Drawing.Point(233, 120);
            this.cbTipJela.Name = "cbTipJela";
            this.cbTipJela.Size = new System.Drawing.Size(162, 21);
            this.cbTipJela.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tip jela:";
            // 
            // Recept_unos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 496);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTipJela);
            this.Controls.Add(this.tbPPriprema);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUnesiSliku);
            this.Controls.Add(this.btnUnosNovogRecepta);
            this.Controls.Add(this.btnGlavniIzbornik);
            this.Controls.Add(this.tbSastojci);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPriprema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNazivRecepta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Recept_unos";
            this.Text = "Recept_unos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNazivRecepta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPriprema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSastojci;
        private System.Windows.Forms.Button btnGlavniIzbornik;
        private System.Windows.Forms.Button btnUnosNovogRecepta;
        private System.Windows.Forms.Button btnUnesiSliku;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPPriprema;
        private System.Windows.Forms.ComboBox cbTipJela;
        private System.Windows.Forms.Label label5;
    }
}