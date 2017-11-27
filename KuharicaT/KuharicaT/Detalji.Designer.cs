namespace KuharicaT
{
    partial class Detalji
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPtime = new System.Windows.Forms.TextBox();
            this.tbCourse = new System.Windows.Forms.TextBox();
            this.tbPreparation = new System.Windows.Forms.TextBox();
            this.tbIngrediant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(39, 33);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(0, 13);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Click += new System.EventHandler(this.lblNaziv_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(80, 30);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(130, 20);
            this.tbName.TabIndex = 1;
            // 
            // tbPtime
            // 
            this.tbPtime.Location = new System.Drawing.Point(111, 72);
            this.tbPtime.Name = "tbPtime";
            this.tbPtime.ReadOnly = true;
            this.tbPtime.ShortcutsEnabled = false;
            this.tbPtime.Size = new System.Drawing.Size(90, 20);
            this.tbPtime.TabIndex = 2;
            // 
            // tbCourse
            // 
            this.tbCourse.Location = new System.Drawing.Point(80, 109);
            this.tbCourse.Name = "tbCourse";
            this.tbCourse.ReadOnly = true;
            this.tbCourse.Size = new System.Drawing.Size(176, 20);
            this.tbCourse.TabIndex = 3;
            // 
            // tbPreparation
            // 
            this.tbPreparation.Location = new System.Drawing.Point(75, 213);
            this.tbPreparation.Multiline = true;
            this.tbPreparation.Name = "tbPreparation";
            this.tbPreparation.ReadOnly = true;
            this.tbPreparation.Size = new System.Drawing.Size(275, 238);
            this.tbPreparation.TabIndex = 4;
            this.tbPreparation.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tbIngrediant
            // 
            this.tbIngrediant.Location = new System.Drawing.Point(80, 152);
            this.tbIngrediant.Name = "tbIngrediant";
            this.tbIngrediant.ReadOnly = true;
            this.tbIngrediant.Size = new System.Drawing.Size(342, 20);
            this.tbIngrediant.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vrijeme pripreme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sastojci";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Priprema";
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(396, 421);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(122, 29);
            this.btnPovratak.TabIndex = 10;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // Detalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 495);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIngrediant);
            this.Controls.Add(this.tbPreparation);
            this.Controls.Add(this.tbCourse);
            this.Controls.Add(this.tbPtime);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblNaziv);
            this.Name = "Detalji";
            this.Text = "Detalji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPtime;
        private System.Windows.Forms.TextBox tbCourse;
        private System.Windows.Forms.TextBox tbPreparation;
        private System.Windows.Forms.TextBox tbIngrediant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPovratak;
    }
}