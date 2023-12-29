
namespace RicercaSostituzioni
{
    partial class frmGestioneSostituzioni
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestioneSostituzioni));
            this.dgUtenti = new System.Windows.Forms.DataGridView();
            this.cesarDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cesarDataSet = new RicercaSostituzioni.cesarDataSet();
            this.dtUtentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taUtenti = new RicercaSostituzioni.cesarDataSetTableAdapters.taUtenti();
            this.idprogressivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cittaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btChiusura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cesarDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cesarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtUtentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgUtenti
            // 
            this.dgUtenti.AutoGenerateColumns = false;
            this.dgUtenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUtenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUtenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprogressivoDataGridViewTextBoxColumn,
            this.cognomeDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cittaDataGridViewTextBoxColumn});
            this.dgUtenti.DataSource = this.dtUtentiBindingSource;
            this.dgUtenti.Location = new System.Drawing.Point(21, 30);
            this.dgUtenti.Name = "dgUtenti";
            this.dgUtenti.RowHeadersVisible = false;
            this.dgUtenti.Size = new System.Drawing.Size(340, 502);
            this.dgUtenti.TabIndex = 0;
            this.dgUtenti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUtenti_CellContentClick);
            // 
            // cesarDataSetBindingSource
            // 
            this.cesarDataSetBindingSource.DataSource = this.cesarDataSet;
            this.cesarDataSetBindingSource.Position = 0;
            // 
            // cesarDataSet
            // 
            this.cesarDataSet.DataSetName = "cesarDataSet";
            this.cesarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtUtentiBindingSource
            // 
            this.dtUtentiBindingSource.DataMember = "dtUtenti";
            this.dtUtentiBindingSource.DataSource = this.cesarDataSetBindingSource;
            // 
            // taUtenti
            // 
            this.taUtenti.ClearBeforeFill = true;
            // 
            // idprogressivoDataGridViewTextBoxColumn
            // 
            this.idprogressivoDataGridViewTextBoxColumn.DataPropertyName = "id_progressivo";
            this.idprogressivoDataGridViewTextBoxColumn.FillWeight = 10F;
            this.idprogressivoDataGridViewTextBoxColumn.HeaderText = "id";
            this.idprogressivoDataGridViewTextBoxColumn.Name = "idprogressivoDataGridViewTextBoxColumn";
            // 
            // cognomeDataGridViewTextBoxColumn
            // 
            this.cognomeDataGridViewTextBoxColumn.DataPropertyName = "cognome";
            this.cognomeDataGridViewTextBoxColumn.FillWeight = 50F;
            this.cognomeDataGridViewTextBoxColumn.HeaderText = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.Name = "cognomeDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.FillWeight = 50F;
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // cittaDataGridViewTextBoxColumn
            // 
            this.cittaDataGridViewTextBoxColumn.DataPropertyName = "citta";
            this.cittaDataGridViewTextBoxColumn.FillWeight = 25F;
            this.cittaDataGridViewTextBoxColumn.HeaderText = "Città";
            this.cittaDataGridViewTextBoxColumn.Name = "cittaDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(367, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(574, 204);
            this.dataGridView1.TabIndex = 1;
            // 
            // btChiusura
            // 
            this.btChiusura.BackColor = System.Drawing.Color.Transparent;
            this.btChiusura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btChiusura.BackgroundImage")));
            this.btChiusura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btChiusura.FlatAppearance.BorderSize = 0;
            this.btChiusura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChiusura.Location = new System.Drawing.Point(868, 679);
            this.btChiusura.Name = "btChiusura";
            this.btChiusura.Size = new System.Drawing.Size(73, 93);
            this.btChiusura.TabIndex = 2;
            this.btChiusura.UseVisualStyleBackColor = false;
            this.btChiusura.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmGestioneSostituzioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 815);
            this.Controls.Add(this.btChiusura);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgUtenti);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestioneSostituzioni";
            this.Text = "Ricerca Personale Sostituzioni";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUtenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cesarDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cesarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtUtentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgUtenti;
        private System.Windows.Forms.BindingSource cesarDataSetBindingSource;
        private cesarDataSet cesarDataSet;
        private System.Windows.Forms.BindingSource dtUtentiBindingSource;
        private cesarDataSetTableAdapters.taUtenti taUtenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprogressivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cittaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btChiusura;
    }
}

