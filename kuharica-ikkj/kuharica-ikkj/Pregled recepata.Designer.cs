namespace kuharica_ikkj
{
    partial class Pregled_recepata
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
            this.components = new System.ComponentModel.Container();
            this.ReceptiDataGridView = new System.Windows.Forms.DataGridView();
            this.kuharicaDataSet1 = new kuharica_ikkj.kuharicaDataSet1();
            this.kuharicaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ReceptiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuharicaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuharicaDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReceptiDataGridView
            // 
            this.ReceptiDataGridView.AllowUserToAddRows = false;
            this.ReceptiDataGridView.AllowUserToDeleteRows = false;
            this.ReceptiDataGridView.AutoGenerateColumns = false;
            this.ReceptiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReceptiDataGridView.DataSource = this.kuharicaDataSet1BindingSource;
            this.ReceptiDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ReceptiDataGridView.Name = "ReceptiDataGridView";
            this.ReceptiDataGridView.ReadOnly = true;
            this.ReceptiDataGridView.Size = new System.Drawing.Size(687, 362);
            this.ReceptiDataGridView.TabIndex = 0;
            // 
            // kuharicaDataSet1
            // 
            this.kuharicaDataSet1.DataSetName = "kuharicaDataSet1";
            this.kuharicaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kuharicaDataSet1BindingSource
            // 
            this.kuharicaDataSet1BindingSource.DataSource = this.kuharicaDataSet1;
            this.kuharicaDataSet1BindingSource.Position = 0;
            // 
            // Pregled_recepata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 386);
            this.Controls.Add(this.ReceptiDataGridView);
            this.Name = "Pregled_recepata";
            this.Text = "Pregled_recepata";
            this.Load += new System.EventHandler(this.Pregled_recepata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReceptiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuharicaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuharicaDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ReceptiDataGridView;
        private System.Windows.Forms.BindingSource kuharicaDataSet1BindingSource;
        private kuharicaDataSet1 kuharicaDataSet1;
    }
}