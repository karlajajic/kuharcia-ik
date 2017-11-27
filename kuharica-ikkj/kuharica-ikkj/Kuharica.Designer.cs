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
            this.btnSve = new System.Windows.Forms.Button();
            this.btnNoviRecept = new System.Windows.Forms.Button();
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
            // btnSve
            // 
            this.btnSve.Location = new System.Drawing.Point(194, 171);
            this.btnSve.Name = "btnSve";
            this.btnSve.Size = new System.Drawing.Size(176, 52);
            this.btnSve.TabIndex = 5;
            this.btnSve.Text = "Pregled svih recepata";
            this.btnSve.UseVisualStyleBackColor = true;
            this.btnSve.Click += new System.EventHandler(this.btnSve_Click);
            // 
            // btnNoviRecept
            // 
            this.btnNoviRecept.Location = new System.Drawing.Point(227, 292);
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
            this.Controls.Add(this.btnNoviRecept);
            this.Controls.Add(this.btnSve);
            this.Controls.Add(this.label2);
            this.Name = "Kuharica";
            this.Text = "Kuharica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSve;
        private System.Windows.Forms.Button btnNoviRecept;
    }
}