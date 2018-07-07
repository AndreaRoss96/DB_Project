namespace progettoDatabes
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonImpiegato = new System.Windows.Forms.RadioButton();
            this.radioButtonCollaboratore = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonPF = new System.Windows.Forms.RadioButton();
            this.radioButtonAZ = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerFine = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInizio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSede = new System.Windows.Forms.ComboBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOperazione = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(368, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(394, 496);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePickerFine);
            this.groupBox1.Controls.Add(this.dateTimePickerInizio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxSede);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 220);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Azioni disponibili";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radioButtonImpiegato);
            this.panel2.Controls.Add(this.radioButtonCollaboratore);
            this.panel2.Location = new System.Drawing.Point(128, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 15);
            this.panel2.TabIndex = 17;
            // 
            // radioButtonImpiegato
            // 
            this.radioButtonImpiegato.AutoSize = true;
            this.radioButtonImpiegato.Checked = true;
            this.radioButtonImpiegato.Location = new System.Drawing.Point(-1, -1);
            this.radioButtonImpiegato.Name = "radioButtonImpiegato";
            this.radioButtonImpiegato.Size = new System.Drawing.Size(71, 17);
            this.radioButtonImpiegato.TabIndex = 10;
            this.radioButtonImpiegato.TabStop = true;
            this.radioButtonImpiegato.Text = "Impiegato";
            this.radioButtonImpiegato.UseVisualStyleBackColor = true;
            this.radioButtonImpiegato.CheckedChanged += new System.EventHandler(this.radioButtonImpiegato_CheckedChanged);
            // 
            // radioButtonCollaboratore
            // 
            this.radioButtonCollaboratore.AutoSize = true;
            this.radioButtonCollaboratore.Location = new System.Drawing.Point(99, -1);
            this.radioButtonCollaboratore.Name = "radioButtonCollaboratore";
            this.radioButtonCollaboratore.Size = new System.Drawing.Size(87, 17);
            this.radioButtonCollaboratore.TabIndex = 11;
            this.radioButtonCollaboratore.Text = "Collaboratore";
            this.radioButtonCollaboratore.UseVisualStyleBackColor = true;
            this.radioButtonCollaboratore.CheckedChanged += new System.EventHandler(this.radioButtonCollaboratore_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButtonPF);
            this.panel1.Controls.Add(this.radioButtonAZ);
            this.panel1.Location = new System.Drawing.Point(127, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 15);
            this.panel1.TabIndex = 16;
            // 
            // radioButtonPF
            // 
            this.radioButtonPF.AutoSize = true;
            this.radioButtonPF.Checked = true;
            this.radioButtonPF.Location = new System.Drawing.Point(0, -2);
            this.radioButtonPF.Name = "radioButtonPF";
            this.radioButtonPF.Size = new System.Drawing.Size(91, 17);
            this.radioButtonPF.TabIndex = 6;
            this.radioButtonPF.TabStop = true;
            this.radioButtonPF.Text = "Persona fisica";
            this.radioButtonPF.UseVisualStyleBackColor = true;
            // 
            // radioButtonAZ
            // 
            this.radioButtonAZ.AutoSize = true;
            this.radioButtonAZ.Location = new System.Drawing.Point(101, -2);
            this.radioButtonAZ.Name = "radioButtonAZ";
            this.radioButtonAZ.Size = new System.Drawing.Size(63, 17);
            this.radioButtonAZ.TabIndex = 7;
            this.radioButtonAZ.Text = "Azienda";
            this.radioButtonAZ.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fine periodo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Inizio periodo";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dateTimePickerFine
            // 
            this.dateTimePickerFine.Location = new System.Drawing.Point(127, 184);
            this.dateTimePickerFine.Name = "dateTimePickerFine";
            this.dateTimePickerFine.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFine.TabIndex = 13;
            this.dateTimePickerFine.ValueChanged += new System.EventHandler(this.dateTimePickerFine_ValueChanged);
            // 
            // dateTimePickerInizio
            // 
            this.dateTimePickerInizio.Location = new System.Drawing.Point(127, 158);
            this.dateTimePickerInizio.Name = "dateTimePickerInizio";
            this.dateTimePickerInizio.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerInizio.TabIndex = 12;
            this.dateTimePickerInizio.ValueChanged += new System.EventHandler(this.dateTimePickerInizio_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipologia dipendente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipologia cliente";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Scegliere il cliente";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(0, 81);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(333, 21);
            this.comboBoxCliente.TabIndex = 2;
            this.comboBoxCliente.SelectedIndexChanged += new System.EventHandler(this.comboBoxCliente_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Scegliere la sede";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxSede
            // 
            this.comboBoxSede.FormattingEnabled = true;
            this.comboBoxSede.Location = new System.Drawing.Point(3, 37);
            this.comboBoxSede.Name = "comboBoxSede";
            this.comboBoxSede.Size = new System.Drawing.Size(330, 21);
            this.comboBoxSede.TabIndex = 0;
            this.comboBoxSede.SelectedIndexChanged += new System.EventHandler(this.comboBoxSede_SelectedIndexChanged);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Visualizzare per ogni sede le città dei relativi clienti",
            "Visualizzare per una certa sede i dipendendenti ed il relativo ruolo",
            "Visualizzare per ogni sede i relativi costi struttura",
            "Visualizzare per ogni cliente il relativo storico dei responsabili",
            "Visualizzare i 5 dipendenti che hanno fatto meno fasi",
            "Visualizzare il totale delle ore dedicate ad un cliente",
            "Visualizzare le prestazioni  la cui durata supera la durata media delle prestazio" +
                "ni",
            "Visualizzare i dipendenti e le relative allocazioni",
            "Visualizzare l\'elenco dei clienti di una certa tipologia",
            "Visualizzare gli stipendi,se si sceglie collaboratore selezionare anche il period" +
                "o",
            "Visualizzare i dipendenti e le relative responsabilità nel tempo,visualizzando an" +
                "che chi non le ha mai avute",
            "Visualizzare tutte le fasi svolte per un determinato cliente e info su di esso,su" +
                "lla prestazione e sulla pratica"});
            this.comboBox.Location = new System.Drawing.Point(12, 251);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(314, 21);
            this.comboBox.TabIndex = 3;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Scegli l\'operazione da eseguire";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonOperazione
            // 
            this.buttonOperazione.Enabled = false;
            this.buttonOperazione.Location = new System.Drawing.Point(12, 278);
            this.buttonOperazione.Name = "buttonOperazione";
            this.buttonOperazione.Size = new System.Drawing.Size(150, 23);
            this.buttonOperazione.TabIndex = 5;
            this.buttonOperazione.Text = "Esegui";
            this.buttonOperazione.UseVisualStyleBackColor = true;
            this.buttonOperazione.Click += new System.EventHandler(this.buttonOperazione_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 497);
            this.Controls.Add(this.buttonOperazione);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOperazione;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSede;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonAZ;
        private System.Windows.Forms.RadioButton radioButtonPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerFine;
        private System.Windows.Forms.DateTimePicker dateTimePickerInizio;
        private System.Windows.Forms.RadioButton radioButtonCollaboratore;
        private System.Windows.Forms.RadioButton radioButtonImpiegato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}