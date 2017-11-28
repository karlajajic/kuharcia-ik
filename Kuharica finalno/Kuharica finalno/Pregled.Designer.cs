namespace Kuharica_finalno
{
    partial class Pregled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pregled));
            this.lbPopisR = new System.Windows.Forms.ListBox();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPopisR
            // 
            this.lbPopisR.FormattingEnabled = true;
            this.lbPopisR.Location = new System.Drawing.Point(1, 12);
            this.lbPopisR.Name = "lbPopisR";
            this.lbPopisR.Size = new System.Drawing.Size(483, 186);
            this.lbPopisR.TabIndex = 2;
            // 
            // btnPovratak
            // 
            this.btnPovratak.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPovratak.Image = global::Kuharica_finalno.Properties.Resources.home_3;
            this.btnPovratak.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPovratak.Location = new System.Drawing.Point(270, 209);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(124, 109);
            this.btnPovratak.TabIndex = 4;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnDetalji
            // 
            this.btnDetalji.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDetalji.Image = global::Kuharica_finalno.Properties.Resources.search;
            this.btnDetalji.Location = new System.Drawing.Point(88, 209);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(135, 109);
            this.btnDetalji.TabIndex = 3;
            this.btnDetalji.Text = "Detaljnije";
            this.btnDetalji.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click_1);
            // 
            // Pregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 330);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.lbPopisR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pregled";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Koji kukac ?";
            this.Load += new System.EventHandler(this.Pregled_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.ListBox lbPopisR;
        private System.Windows.Forms.Button btnPovratak;
    }
}