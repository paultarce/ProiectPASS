namespace Proiect3Pass
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NrMatricol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNrMatricol = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnAnulare = new System.Windows.Forms.Button();
            this.lblDataSource = new System.Windows.Forms.Label();
            this.btnZiBuna = new System.Windows.Forms.Button();
            this.btnMedieViitor = new System.Windows.Forms.Button();
            this.btnPesteOpt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NrMatricol,
            this.Nume,
            this.Medie});
            this.dataGridView1.Location = new System.Drawing.Point(393, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(343, 272);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // NrMatricol
            // 
            this.NrMatricol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NrMatricol.DataPropertyName = "NrMatricol";
            this.NrMatricol.HeaderText = "NrMatricol";
            this.NrMatricol.Name = "NrMatricol";
            this.NrMatricol.ReadOnly = true;
            // 
            // Nume
            // 
            this.Nume.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nume.DataPropertyName = "Nume";
            this.Nume.HeaderText = "Nume";
            this.Nume.Name = "Nume";
            this.Nume.ReadOnly = true;
            // 
            // Medie
            // 
            this.Medie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Medie.DataPropertyName = "Medie";
            this.Medie.HeaderText = "Medie";
            this.Medie.Name = "Medie";
            this.Medie.ReadOnly = true;
            // 
            // txtNrMatricol
            // 
            this.txtNrMatricol.Location = new System.Drawing.Point(104, 44);
            this.txtNrMatricol.Name = "txtNrMatricol";
            this.txtNrMatricol.Size = new System.Drawing.Size(132, 20);
            this.txtNrMatricol.TabIndex = 1;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(104, 91);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(132, 20);
            this.txtNume.TabIndex = 2;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(104, 139);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(132, 20);
            this.txtMedia.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numar Matricol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Media";
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(23, 201);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(75, 23);
            this.btnSalvare.TabIndex = 7;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(114, 201);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(75, 23);
            this.btnStergere.TabIndex = 8;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnAnulare
            // 
            this.btnAnulare.Location = new System.Drawing.Point(205, 201);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(75, 23);
            this.btnAnulare.TabIndex = 9;
            this.btnAnulare.Text = "Anulare";
            this.btnAnulare.UseVisualStyleBackColor = true;
            this.btnAnulare.Click += new System.EventHandler(this.btnAnulare_Click);
            // 
            // lblDataSource
            // 
            this.lblDataSource.AutoSize = true;
            this.lblDataSource.Location = new System.Drawing.Point(544, 9);
            this.lblDataSource.Name = "lblDataSource";
            this.lblDataSource.Size = new System.Drawing.Size(35, 13);
            this.lblDataSource.TabIndex = 10;
            this.lblDataSource.Text = "label4";
            // 
            // btnZiBuna
            // 
            this.btnZiBuna.Location = new System.Drawing.Point(259, 44);
            this.btnZiBuna.Name = "btnZiBuna";
            this.btnZiBuna.Size = new System.Drawing.Size(98, 32);
            this.btnZiBuna.TabIndex = 11;
            this.btnZiBuna.Text = "Zi Buna?";
            this.btnZiBuna.UseVisualStyleBackColor = true;
            this.btnZiBuna.Click += new System.EventHandler(this.btnZiBuna_Click);
            // 
            // btnMedieViitor
            // 
            this.btnMedieViitor.Location = new System.Drawing.Point(259, 94);
            this.btnMedieViitor.Name = "btnMedieViitor";
            this.btnMedieViitor.Size = new System.Drawing.Size(98, 35);
            this.btnMedieViitor.TabIndex = 12;
            this.btnMedieViitor.Text = "Medie Viitor...";
            this.btnMedieViitor.UseVisualStyleBackColor = true;
            this.btnMedieViitor.Click += new System.EventHandler(this.btnMedieViitor_Click);
            // 
            // btnPesteOpt
            // 
            this.btnPesteOpt.Location = new System.Drawing.Point(23, 264);
            this.btnPesteOpt.Name = "btnPesteOpt";
            this.btnPesteOpt.Size = new System.Drawing.Size(104, 41);
            this.btnPesteOpt.TabIndex = 13;
            this.btnPesteOpt.Text = "Cati Studenti vor avea media > 8";
            this.btnPesteOpt.UseVisualStyleBackColor = true;
            this.btnPesteOpt.Click += new System.EventHandler(this.btnPesteOpt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 381);
            this.Controls.Add(this.btnPesteOpt);
            this.Controls.Add(this.btnMedieViitor);
            this.Controls.Add(this.btnZiBuna);
            this.Controls.Add(this.lblDataSource);
            this.Controls.Add(this.btnAnulare);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtNrMatricol);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Aplicatie PASS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNrMatricol;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnAnulare;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrMatricol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medie;
        private System.Windows.Forms.Label lblDataSource;
        private System.Windows.Forms.Button btnZiBuna;
        private System.Windows.Forms.Button btnMedieViitor;
        private System.Windows.Forms.Button btnPesteOpt;
    }
}

