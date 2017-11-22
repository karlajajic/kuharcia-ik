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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGlavniIzbornik = new System.Windows.Forms.Button();
            this.btnUnosNovogRecepta = new System.Windows.Forms.Button();
            this.rbPredjelo = new System.Windows.Forms.RadioButton();
            this.rbGlavnoJelo = new System.Windows.Forms.RadioButton();
            this.rbDesert = new System.Windows.Forms.RadioButton();
            this.btnUnesiSliku = new System.Windows.Forms.Button();
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
            this.tbNazivRecepta.Size = new System.Drawing.Size(173, 20);
            this.tbNazivRecepta.TabIndex = 2;
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
            this.tbPriprema.Size = new System.Drawing.Size(123, 20);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 222);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 6;
            // 
            // btnGlavniIzbornik
            // 
            this.btnGlavniIzbornik.Location = new System.Drawing.Point(38, 377);
            this.btnGlavniIzbornik.Name = "btnGlavniIzbornik";
            this.btnGlavniIzbornik.Size = new System.Drawing.Size(125, 35);
            this.btnGlavniIzbornik.TabIndex = 7;
            this.btnGlavniIzbornik.Text = "Glavni izbornik";
            this.btnGlavniIzbornik.UseVisualStyleBackColor = true;
            this.btnGlavniIzbornik.Click += new System.EventHandler(this.btnGlavniIzbornik_Click);
            // 
            // btnUnosNovogRecepta
            // 
            this.btnUnosNovogRecepta.Location = new System.Drawing.Point(186, 377);
            this.btnUnosNovogRecepta.Name = "btnUnosNovogRecepta";
            this.btnUnosNovogRecepta.Size = new System.Drawing.Size(125, 35);
            this.btnUnosNovogRecepta.TabIndex = 8;
            this.btnUnosNovogRecepta.Text = "Unos recepta";
            this.btnUnosNovogRecepta.UseVisualStyleBackColor = true;
            // 
            // rbPredjelo
            // 
            this.rbPredjelo.AutoSize = true;
            this.rbPredjelo.Location = new System.Drawing.Point(186, 127);
            this.rbPredjelo.Name = "rbPredjelo";
            this.rbPredjelo.Size = new System.Drawing.Size(63, 17);
            this.rbPredjelo.TabIndex = 9;
            this.rbPredjelo.TabStop = true;
            this.rbPredjelo.Text = "Predjelo";
            this.rbPredjelo.UseVisualStyleBackColor = true;
            // 
            // rbGlavnoJelo
            // 
            this.rbGlavnoJelo.AutoSize = true;
            this.rbGlavnoJelo.Location = new System.Drawing.Point(186, 150);
            this.rbGlavnoJelo.Name = "rbGlavnoJelo";
            this.rbGlavnoJelo.Size = new System.Drawing.Size(78, 17);
            this.rbGlavnoJelo.TabIndex = 10;
            this.rbGlavnoJelo.TabStop = true;
            this.rbGlavnoJelo.Text = "GlavnoJelo";
            this.rbGlavnoJelo.UseVisualStyleBackColor = true;
            this.rbGlavnoJelo.CheckedChanged += new System.EventHandler(this.rbGlavnoJelo_CheckedChanged);
            // 
            // rbDesert
            // 
            this.rbDesert.AutoSize = true;
            this.rbDesert.Location = new System.Drawing.Point(186, 173);
            this.rbDesert.Name = "rbDesert";
            this.rbDesert.Size = new System.Drawing.Size(56, 17);
            this.rbDesert.TabIndex = 11;
            this.rbDesert.TabStop = true;
            this.rbDesert.Text = "Desert";
            this.rbDesert.UseVisualStyleBackColor = true;
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
            // Recept_unos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 441);
            this.Controls.Add(this.btnUnesiSliku);
            this.Controls.Add(this.rbDesert);
            this.Controls.Add(this.rbGlavnoJelo);
            this.Controls.Add(this.rbPredjelo);
            this.Controls.Add(this.btnUnosNovogRecepta);
            this.Controls.Add(this.btnGlavniIzbornik);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGlavniIzbornik;
        private System.Windows.Forms.Button btnUnosNovogRecepta;
        private System.Windows.Forms.RadioButton rbPredjelo;
        private System.Windows.Forms.RadioButton rbGlavnoJelo;
        private System.Windows.Forms.RadioButton rbDesert;
        private System.Windows.Forms.Button btnUnesiSliku;
    }
}