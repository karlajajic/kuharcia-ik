namespace Kuharica_finalno
{
    partial class Coolinarka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Coolinarka));
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.tbKIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLZaboravljeno = new System.Windows.Forms.LinkLabel();
            this.linkLRegistrirajSe = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLozinka
            // 
            this.tbLozinka.Location = new System.Drawing.Point(121, 313);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(156, 20);
            this.tbLozinka.TabIndex = 15;
            // 
            // tbKIme
            // 
            this.tbKIme.Location = new System.Drawing.Point(160, 275);
            this.tbKIme.Name = "tbKIme";
            this.tbKIme.Size = new System.Drawing.Size(156, 20);
            this.tbKIme.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(44, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Lozinka :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(44, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Korisničko ime :";
            // 
            // linkLZaboravljeno
            // 
            this.linkLZaboravljeno.AutoSize = true;
            this.linkLZaboravljeno.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linkLZaboravljeno.LinkColor = System.Drawing.Color.Teal;
            this.linkLZaboravljeno.Location = new System.Drawing.Point(159, 415);
            this.linkLZaboravljeno.Name = "linkLZaboravljeno";
            this.linkLZaboravljeno.Size = new System.Drawing.Size(105, 13);
            this.linkLZaboravljeno.TabIndex = 11;
            this.linkLZaboravljeno.TabStop = true;
            this.linkLZaboravljeno.Text = "Zaboravljena lozinka";
            this.linkLZaboravljeno.VisitedLinkColor = System.Drawing.Color.Maroon;
            this.linkLZaboravljeno.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLZaboravljeno_LinkClicked);
            // 
            // linkLRegistrirajSe
            // 
            this.linkLRegistrirajSe.ActiveLinkColor = System.Drawing.Color.Teal;
            this.linkLRegistrirajSe.AutoSize = true;
            this.linkLRegistrirajSe.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linkLRegistrirajSe.LinkColor = System.Drawing.Color.Teal;
            this.linkLRegistrirajSe.Location = new System.Drawing.Point(174, 390);
            this.linkLRegistrirajSe.Name = "linkLRegistrirajSe";
            this.linkLRegistrirajSe.Size = new System.Drawing.Size(70, 13);
            this.linkLRegistrirajSe.TabIndex = 10;
            this.linkLRegistrirajSe.TabStop = true;
            this.linkLRegistrirajSe.Text = "Registriraj se ";
            this.linkLRegistrirajSe.VisitedLinkColor = System.Drawing.Color.Maroon;
            this.linkLRegistrirajSe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLRegistrirajSe_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogin.Location = new System.Drawing.Point(293, 345);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 32);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Registracija";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Coolinarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(467, 458);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbLozinka);
            this.Controls.Add(this.tbKIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLZaboravljeno);
            this.Controls.Add(this.linkLRegistrirajSe);
            this.Controls.Add(this.btnLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Coolinarka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Koji cookac ?";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.TextBox tbKIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLZaboravljeno;
        private System.Windows.Forms.LinkLabel linkLRegistrirajSe;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

