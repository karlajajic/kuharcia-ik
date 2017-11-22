namespace kuharica_ikkj
{
    partial class Kuharica
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPredjelo = new System.Windows.Forms.Button();
            this.btnGlavnoJelo = new System.Windows.Forms.Button();
            this.btnDesert = new System.Windows.Forms.Button();
            this.btnSve = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNoviRecept = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(129, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "//ubaci logo, izbrisi ovaj label nakon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " // ovo je panel, pogledaj po yt o UI designingu";
            // 
            // btnPredjelo
            // 
            this.btnPredjelo.Location = new System.Drawing.Point(128, 38);
            this.btnPredjelo.Name = "btnPredjelo";
            this.btnPredjelo.Size = new System.Drawing.Size(109, 52);
            this.btnPredjelo.TabIndex = 1;
            this.btnPredjelo.Text = "Predjelo";
            this.btnPredjelo.UseVisualStyleBackColor = true;
            // 
            // btnGlavnoJelo
            // 
            this.btnGlavnoJelo.Location = new System.Drawing.Point(243, 38);
            this.btnGlavnoJelo.Name = "btnGlavnoJelo";
            this.btnGlavnoJelo.Size = new System.Drawing.Size(109, 52);
            this.btnGlavnoJelo.TabIndex = 2;
            this.btnGlavnoJelo.Text = "Glavno jelo";
            this.btnGlavnoJelo.UseVisualStyleBackColor = true;
            // 
            // btnDesert
            // 
            this.btnDesert.Location = new System.Drawing.Point(358, 38);
            this.btnDesert.Name = "btnDesert";
            this.btnDesert.Size = new System.Drawing.Size(109, 52);
            this.btnDesert.TabIndex = 3;
            this.btnDesert.Text = "Desert";
            this.btnDesert.UseVisualStyleBackColor = true;
            // 
            // btnSve
            // 
            this.btnSve.Location = new System.Drawing.Point(209, 160);
            this.btnSve.Name = "btnSve";
            this.btnSve.Size = new System.Drawing.Size(176, 52);
            this.btnSve.TabIndex = 5;
            this.btnSve.Text = "Pregled svih recepata";
            this.btnSve.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNoviRecept);
            this.panel1.Controls.Add(this.btnDesert);
            this.panel1.Controls.Add(this.btnGlavnoJelo);
            this.panel1.Controls.Add(this.btnPredjelo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 172);
            this.panel1.TabIndex = 0;
            // 
            // btnNoviRecept
            // 
            this.btnNoviRecept.Location = new System.Drawing.Point(243, 107);
            this.btnNoviRecept.Name = "btnNoviRecept";
            this.btnNoviRecept.Size = new System.Drawing.Size(109, 52);
            this.btnNoviRecept.TabIndex = 6;
            this.btnNoviRecept.Text = "Novi recept";
            this.btnNoviRecept.UseVisualStyleBackColor = true;
            this.btnNoviRecept.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kuharica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 389);
            this.Controls.Add(this.btnSve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Kuharica";
            this.Text = "Kuharica";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPredjelo;
        private System.Windows.Forms.Button btnGlavnoJelo;
        private System.Windows.Forms.Button btnDesert;
        private System.Windows.Forms.Button btnSve;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNoviRecept;
    }
}