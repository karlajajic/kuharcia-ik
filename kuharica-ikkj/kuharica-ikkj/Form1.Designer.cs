namespace kuharica_ikkj
{
    partial class form1
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkLRegistrirajSe = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLZaboravljeno = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKIme = new System.Windows.Forms.TextBox();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(183, 192);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 32);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Registracija";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linkLRegistrirajSe
            // 
            this.linkLRegistrirajSe.AutoSize = true;
            this.linkLRegistrirajSe.Location = new System.Drawing.Point(119, 227);
            this.linkLRegistrirajSe.Name = "linkLRegistrirajSe";
            this.linkLRegistrirajSe.Size = new System.Drawing.Size(70, 13);
            this.linkLRegistrirajSe.TabIndex = 2;
            this.linkLRegistrirajSe.TabStop = true;
            this.linkLRegistrirajSe.Text = "Registriraj se ";
            this.linkLRegistrirajSe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLRegistrirajSe_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "//ubaci logo, izbrisi ovaj label nakon";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLZaboravljeno
            // 
            this.linkLZaboravljeno.AutoSize = true;
            this.linkLZaboravljeno.Location = new System.Drawing.Point(102, 249);
            this.linkLZaboravljeno.Name = "linkLZaboravljeno";
            this.linkLZaboravljeno.Size = new System.Drawing.Size(105, 13);
            this.linkLZaboravljeno.TabIndex = 4;
            this.linkLZaboravljeno.TabStop = true;
            this.linkLZaboravljeno.Text = "Zaboravljena lozinka";
            this.linkLZaboravljeno.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLZaboravljeno_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Korisničko ime :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lozinka :";
            // 
            // tbKIme
            // 
            this.tbKIme.Location = new System.Drawing.Point(109, 116);
            this.tbKIme.Name = "tbKIme";
            this.tbKIme.Size = new System.Drawing.Size(156, 20);
            this.tbKIme.TabIndex = 7;
            // 
            // tbLozinka
            // 
            this.tbLozinka.Location = new System.Drawing.Point(78, 153);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(156, 20);
            this.tbLozinka.TabIndex = 8;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 287);
            this.Controls.Add(this.tbLozinka);
            this.Controls.Add(this.tbKIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLZaboravljeno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLRegistrirajSe);
            this.Controls.Add(this.btnLogin);
            this.Name = "form1";
            this.Text = "Kuharica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkLRegistrirajSe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLZaboravljeno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKIme;
        private System.Windows.Forms.TextBox tbLozinka;
    }
}

