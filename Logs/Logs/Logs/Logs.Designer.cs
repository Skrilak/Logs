namespace Logs
{
    partial class Logs
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxJournaux = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBoxEvenement = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxBoutons = new System.Windows.Forms.GroupBox();
            this.comboBoxFilterType = new System.Windows.Forms.ComboBox();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.buttonToutSuppr = new System.Windows.Forms.Button();
            this.buttonSuppr = new System.Windows.Forms.Button();
            this.buttonFiltrer = new System.Windows.Forms.Button();
            this.buttonExporter = new System.Windows.Forms.Button();
            this.sauvegarder1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxJournaux.SuspendLayout();
            this.groupBoxEvenement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxBoutons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.30893F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.69107F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxJournaux, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxEvenement, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxBoutons, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.86348F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.13652F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1386, 564);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxJournaux
            // 
            this.groupBoxJournaux.Controls.Add(this.listBox1);
            this.groupBoxJournaux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxJournaux.Location = new System.Drawing.Point(3, 3);
            this.groupBoxJournaux.Name = "groupBoxJournaux";
            this.groupBoxJournaux.Size = new System.Drawing.Size(455, 444);
            this.groupBoxJournaux.TabIndex = 0;
            this.groupBoxJournaux.TabStop = false;
            this.groupBoxJournaux.Text = "Journaux d\'évenement";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(449, 423);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBoxEvenement
            // 
            this.groupBoxEvenement.Controls.Add(this.dataGridView1);
            this.groupBoxEvenement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEvenement.Location = new System.Drawing.Point(464, 3);
            this.groupBoxEvenement.Name = "groupBoxEvenement";
            this.groupBoxEvenement.Size = new System.Drawing.Size(919, 444);
            this.groupBoxEvenement.TabIndex = 1;
            this.groupBoxEvenement.TabStop = false;
            this.groupBoxEvenement.Text = "Evenement";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(913, 423);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBoxBoutons
            // 
            this.groupBoxBoutons.Controls.Add(this.buttonExporter);
            this.groupBoxBoutons.Controls.Add(this.comboBoxFilterType);
            this.groupBoxBoutons.Controls.Add(this.buttonQuitter);
            this.groupBoxBoutons.Controls.Add(this.buttonToutSuppr);
            this.groupBoxBoutons.Controls.Add(this.buttonSuppr);
            this.groupBoxBoutons.Controls.Add(this.buttonFiltrer);
            this.groupBoxBoutons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBoutons.Location = new System.Drawing.Point(464, 453);
            this.groupBoxBoutons.Name = "groupBoxBoutons";
            this.groupBoxBoutons.Size = new System.Drawing.Size(919, 108);
            this.groupBoxBoutons.TabIndex = 2;
            this.groupBoxBoutons.TabStop = false;
            this.groupBoxBoutons.Text = "Boutons";
            // 
            // comboBoxFilterType
            // 
            this.comboBoxFilterType.FormattingEnabled = true;
            this.comboBoxFilterType.Location = new System.Drawing.Point(20, 78);
            this.comboBoxFilterType.Name = "comboBoxFilterType";
            this.comboBoxFilterType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFilterType.TabIndex = 1;
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.AutoSize = true;
            this.buttonQuitter.Location = new System.Drawing.Point(390, 21);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(124, 62);
            this.buttonQuitter.TabIndex = 3;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // buttonToutSuppr
            // 
            this.buttonToutSuppr.AutoSize = true;
            this.buttonToutSuppr.Location = new System.Drawing.Point(266, 21);
            this.buttonToutSuppr.Name = "buttonToutSuppr";
            this.buttonToutSuppr.Size = new System.Drawing.Size(118, 62);
            this.buttonToutSuppr.TabIndex = 2;
            this.buttonToutSuppr.Text = "Tout supprimer";
            this.buttonToutSuppr.UseVisualStyleBackColor = true;
            this.buttonToutSuppr.Click += new System.EventHandler(this.buttonToutSuppr_Click);
            // 
            // buttonSuppr
            // 
            this.buttonSuppr.AutoSize = true;
            this.buttonSuppr.Location = new System.Drawing.Point(150, 21);
            this.buttonSuppr.Name = "buttonSuppr";
            this.buttonSuppr.Size = new System.Drawing.Size(110, 62);
            this.buttonSuppr.TabIndex = 1;
            this.buttonSuppr.Text = "Supprimer";
            this.buttonSuppr.UseVisualStyleBackColor = true;
            this.buttonSuppr.Click += new System.EventHandler(this.buttonSuppr_Click);
            // 
            // buttonFiltrer
            // 
            this.buttonFiltrer.AutoSize = true;
            this.buttonFiltrer.Location = new System.Drawing.Point(20, 21);
            this.buttonFiltrer.Name = "buttonFiltrer";
            this.buttonFiltrer.Size = new System.Drawing.Size(124, 62);
            this.buttonFiltrer.TabIndex = 0;
            this.buttonFiltrer.Text = "Filtrer";
            this.buttonFiltrer.UseVisualStyleBackColor = true;
            this.buttonFiltrer.Click += new System.EventHandler(this.buttonFiltrer_Click);
            // 
            // buttonExporter
            // 
            this.buttonExporter.AutoSize = true;
            this.buttonExporter.Location = new System.Drawing.Point(520, 21);
            this.buttonExporter.Name = "buttonExporter";
            this.buttonExporter.Size = new System.Drawing.Size(120, 62);
            this.buttonExporter.TabIndex = 1;
            this.buttonExporter.Text = "Exporter";
            this.buttonExporter.UseVisualStyleBackColor = true;
            this.buttonExporter.Click += new System.EventHandler(this.buttonExporter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 564);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxJournaux.ResumeLayout(false);
            this.groupBoxEvenement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxBoutons.ResumeLayout(false);
            this.groupBoxBoutons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxJournaux;
        private System.Windows.Forms.GroupBox groupBoxEvenement;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxBoutons;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Button buttonToutSuppr;
        private System.Windows.Forms.Button buttonSuppr;
        private System.Windows.Forms.Button buttonFiltrer;
        private System.Windows.Forms.ComboBox comboBoxFilterType;
        private System.Windows.Forms.Button buttonExporter;
        private System.Windows.Forms.SaveFileDialog sauvegarder1;
    }
}