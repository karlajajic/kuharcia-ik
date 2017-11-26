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
            this.kuharicaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kuharicaDataSet = new kuharica_ikkj.kuharicaDataSet();
            this.kuharicaDataSet2 = new kuharica_ikkj.kuharicaDataSet2();
            this.receptiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receptiTableAdapter = new kuharica_ikkj.kuharicaDataSet2TableAdapters.ReceptiTableAdapter();
            this.tableAdapterManager = new kuharica_ikkj.kuharicaDataSet2TableAdapters.TableAdapterManager();
            this.receptiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGlavniIzbornik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kuharicaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuharicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuharicaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kuharicaDataSetBindingSource
            // 
            this.kuharicaDataSetBindingSource.DataSource = this.kuharicaDataSet;
            this.kuharicaDataSetBindingSource.Position = 0;
            // 
            // kuharicaDataSet
            // 
            this.kuharicaDataSet.DataSetName = "kuharicaDataSet";
            this.kuharicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kuharicaDataSet2
            // 
            this.kuharicaDataSet2.DataSetName = "kuharicaDataSet2";
            this.kuharicaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receptiBindingSource
            // 
            this.receptiBindingSource.DataMember = "Recepti";
            this.receptiBindingSource.DataSource = this.kuharicaDataSet2;
            // 
            // receptiTableAdapter
            // 
            this.receptiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ReceptiTableAdapter = this.receptiTableAdapter;
            this.tableAdapterManager.UpdateOrder = kuharica_ikkj.kuharicaDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // receptiDataGridView
            // 
            this.receptiDataGridView.AllowUserToAddRows = false;
            this.receptiDataGridView.AllowUserToDeleteRows = false;
            this.receptiDataGridView.AutoGenerateColumns = false;
            this.receptiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receptiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.receptiDataGridView.DataSource = this.receptiBindingSource;
            this.receptiDataGridView.Location = new System.Drawing.Point(1, 1);
            this.receptiDataGridView.Name = "receptiDataGridView";
            this.receptiDataGridView.ReadOnly = true;
            this.receptiDataGridView.Size = new System.Drawing.Size(478, 253);
            this.receptiDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Naziv ";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tip";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tip";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Vrijeme";
            this.dataGridViewTextBoxColumn4.HeaderText = "Vrijeme";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // btnGlavniIzbornik
            // 
            this.btnGlavniIzbornik.Location = new System.Drawing.Point(165, 293);
            this.btnGlavniIzbornik.Name = "btnGlavniIzbornik";
            this.btnGlavniIzbornik.Size = new System.Drawing.Size(125, 35);
            this.btnGlavniIzbornik.TabIndex = 8;
            this.btnGlavniIzbornik.Text = "Glavni izbornik";
            this.btnGlavniIzbornik.UseVisualStyleBackColor = true;
            this.btnGlavniIzbornik.Click += new System.EventHandler(this.btnGlavniIzbornik_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "//NE DIRAJ TABLICU ZIVOTA TI, NIJE OBICN, ZAHTJEVA POSEBNE POTREBE";
            // 
            // Pregled_recepata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGlavniIzbornik);
            this.Controls.Add(this.receptiDataGridView);
            this.Name = "Pregled_recepata";
            this.Text = "Pregled_recepata";
            this.Load += new System.EventHandler(this.Pregled_recepata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kuharicaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuharicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuharicaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource kuharicaDataSetBindingSource;
        private kuharicaDataSet kuharicaDataSet;
        private kuharicaDataSet2 kuharicaDataSet2;
        private System.Windows.Forms.BindingSource receptiBindingSource;
        private kuharicaDataSet2TableAdapters.ReceptiTableAdapter receptiTableAdapter;
        private kuharicaDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView receptiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnGlavniIzbornik;
        private System.Windows.Forms.Label label1;
    }
}