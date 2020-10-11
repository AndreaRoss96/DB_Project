namespace progettoDatabes
{
    partial class costiStruttura
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
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePickerDataPagamento = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownCosto = new System.Windows.Forms.NumericUpDown();
            this.textBoxDescrizione = new System.Windows.Forms.TextBox();
            this.comboBoxTipologia = new System.Windows.Forms.ComboBox();
            this.numericUpDownQuantita = new System.Windows.Forms.NumericUpDown();
            this.comboBoxSede = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantita)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inserisci";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePickerDataPagamento
            // 
            this.dateTimePickerDataPagamento.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerDataPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataPagamento.Location = new System.Drawing.Point(104, 12);
            this.dateTimePickerDataPagamento.Name = "dateTimePickerDataPagamento";
            this.dateTimePickerDataPagamento.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerDataPagamento.TabIndex = 1;
            // 
            // numericUpDownCosto
            // 
            this.numericUpDownCosto.Location = new System.Drawing.Point(104, 41);
            this.numericUpDownCosto.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownCosto.Name = "numericUpDownCosto";
            this.numericUpDownCosto.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownCosto.TabIndex = 2;
            // 
            // textBoxDescrizione
            // 
            this.textBoxDescrizione.Location = new System.Drawing.Point(104, 158);
            this.textBoxDescrizione.Multiline = true;
            this.textBoxDescrizione.Name = "textBoxDescrizione";
            this.textBoxDescrizione.Size = new System.Drawing.Size(255, 81);
            this.textBoxDescrizione.TabIndex = 3;
            // 
            // comboBoxTipologia
            // 
            this.comboBoxTipologia.FormattingEnabled = true;
            this.comboBoxTipologia.Items.AddRange(new object[] {
            "Materiale",
            "Imprevisto",
            "Periodico"});
            this.comboBoxTipologia.Location = new System.Drawing.Point(104, 71);
            this.comboBoxTipologia.Name = "comboBoxTipologia";
            this.comboBoxTipologia.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipologia.TabIndex = 4;
            this.comboBoxTipologia.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipologia_SelectedIndexChanged);
            // 
            // numericUpDownQuantita
            // 
            this.numericUpDownQuantita.Location = new System.Drawing.Point(104, 100);
            this.numericUpDownQuantita.Name = "numericUpDownQuantita";
            this.numericUpDownQuantita.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownQuantita.TabIndex = 5;
            // 
            // comboBoxSede
            // 
            this.comboBoxSede.FormattingEnabled = true;
            this.comboBoxSede.Location = new System.Drawing.Point(104, 131);
            this.comboBoxSede.Name = "comboBoxSede";
            this.comboBoxSede.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSede.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data pagamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Costo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quantità";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sede";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Descrizione";
            // 
            // costiStruttura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 277);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSede);
            this.Controls.Add(this.numericUpDownQuantita);
            this.Controls.Add(this.comboBoxTipologia);
            this.Controls.Add(this.textBoxDescrizione);
            this.Controls.Add(this.numericUpDownCosto);
            this.Controls.Add(this.dateTimePickerDataPagamento);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "costiStruttura";
            this.Text = "costiStruttura";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.costiStruttura_FormClosing);
            this.Load += new System.EventHandler(this.costiStruttura_Load);
            this.Shown += new System.EventHandler(this.costiStruttura_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataPagamento;
        private System.Windows.Forms.NumericUpDown numericUpDownCosto;
        private System.Windows.Forms.TextBox textBoxDescrizione;
        private System.Windows.Forms.ComboBox comboBoxTipologia;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantita;
        private System.Windows.Forms.ComboBox comboBoxSede;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}