﻿namespace progettoDatabes
{
    partial class FormPerDipendente
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
            this.groupboxDipendente = new System.Windows.Forms.GroupBox();
            this.comboboxPratica = new System.Windows.Forms.ComboBox();
            this.labelPratica = new System.Windows.Forms.Label();
            this.comboboxCliente = new System.Windows.Forms.ComboBox();
            this.labelCliente = new System.Windows.Forms.Label();
            this.comboboxOperazioni = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonOperazione = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupboxDipendente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupboxDipendente
            // 
            this.groupboxDipendente.Controls.Add(this.comboboxPratica);
            this.groupboxDipendente.Controls.Add(this.labelPratica);
            this.groupboxDipendente.Controls.Add(this.comboboxCliente);
            this.groupboxDipendente.Controls.Add(this.labelCliente);
            this.groupboxDipendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxDipendente.Location = new System.Drawing.Point(13, 13);
            this.groupboxDipendente.Name = "groupboxDipendente";
            this.groupboxDipendente.Size = new System.Drawing.Size(482, 191);
            this.groupboxDipendente.TabIndex = 0;
            this.groupboxDipendente.TabStop = false;
            this.groupboxDipendente.Text = "Azioni disponibili";
            this.groupboxDipendente.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboboxPratica
            // 
            this.comboboxPratica.Enabled = false;
            this.comboboxPratica.FormattingEnabled = true;
            this.comboboxPratica.Location = new System.Drawing.Point(6, 135);
            this.comboboxPratica.Name = "comboboxPratica";
            this.comboboxPratica.Size = new System.Drawing.Size(470, 28);
            this.comboboxPratica.TabIndex = 2;
            this.comboboxPratica.SelectedIndexChanged += new System.EventHandler(this.comboboxPratica_SelectedIndexChanged);
            // 
            // labelPratica
            // 
            this.labelPratica.AutoSize = true;
            this.labelPratica.Enabled = false;
            this.labelPratica.Location = new System.Drawing.Point(6, 111);
            this.labelPratica.Name = "labelPratica";
            this.labelPratica.Size = new System.Drawing.Size(226, 20);
            this.labelPratica.TabIndex = 0;
            this.labelPratica.Text = "Seleziona la pratica desiderata";
            // 
            // comboboxCliente
            // 
            this.comboboxCliente.Enabled = false;
            this.comboboxCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxCliente.FormattingEnabled = true;
            this.comboboxCliente.Location = new System.Drawing.Point(6, 56);
            this.comboboxCliente.Name = "comboboxCliente";
            this.comboboxCliente.Size = new System.Drawing.Size(470, 28);
            this.comboboxCliente.TabIndex = 1;
            this.comboboxCliente.SelectedIndexChanged += new System.EventHandler(this.comboboxCliente_SelectedIndexChanged);
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Enabled = false;
            this.labelCliente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(7, 32);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(190, 20);
            this.labelCliente.TabIndex = 1;
            this.labelCliente.Text = "Seleziona il cliente desiderato";
            this.labelCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboboxOperazioni
            // 
            this.comboboxOperazioni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboboxOperazioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxOperazioni.FormattingEnabled = true;
            this.comboboxOperazioni.Items.AddRange(new object[] {
            "Visualizzare tutte le prestazioni e le relative fasi fatte da questo dipendente e" +
                "d info sul cliente",
            "Visualizzare compensi e dettagli di una certa pratica",
            "Visualizzare le prestazioni per un cliente eseguite da questo dipendente"});
            this.comboboxOperazioni.Location = new System.Drawing.Point(19, 246);
            this.comboboxOperazioni.Name = "comboboxOperazioni";
            this.comboboxOperazioni.Size = new System.Drawing.Size(394, 24);
            this.comboboxOperazioni.TabIndex = 4;
            this.comboboxOperazioni.SelectedIndexChanged += new System.EventHandler(this.comboboxOperazioni_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(501, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(514, 299);
            this.dataGridView1.TabIndex = 5;
            // 
            // buttonOperazione
            // 
            this.buttonOperazione.Enabled = false;
            this.buttonOperazione.Location = new System.Drawing.Point(19, 276);
            this.buttonOperazione.Name = "buttonOperazione";
            this.buttonOperazione.Size = new System.Drawing.Size(125, 23);
            this.buttonOperazione.TabIndex = 6;
            this.buttonOperazione.Text = "Esegui";
            this.buttonOperazione.UseVisualStyleBackColor = true;
            this.buttonOperazione.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Scegli azione da eseguire";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FormPerDipendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOperazione);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboboxOperazioni);
            this.Controls.Add(this.groupboxDipendente);
            this.Name = "FormPerDipendente";
            this.Text = "FormPerDipendente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPerDipendente_FormClosing);
            this.Load += new System.EventHandler(this.FormPerDipendente_Load);
            this.groupboxDipendente.ResumeLayout(false);
            this.groupboxDipendente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupboxDipendente;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.ComboBox comboboxPratica;
        private System.Windows.Forms.Label labelPratica;
        private System.Windows.Forms.ComboBox comboboxCliente;
        private System.Windows.Forms.ComboBox comboboxOperazioni;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonOperazione;
        private System.Windows.Forms.Label label1;
    }
}