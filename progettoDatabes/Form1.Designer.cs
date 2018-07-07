namespace progettoDatabes
{
    partial class Form1
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
            this.comboboxClienteNominativo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNomePratica = new System.Windows.Forms.TextBox();
            this.codiceFiscaleSecret = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.dateTimePickerDataPratica = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblNomePratica = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.lblSottocategoria = new System.Windows.Forms.Label();
            this.comboBoxSottocategoria = new System.Windows.Forms.ComboBox();
            this.textBoxDurata = new System.Windows.Forms.TextBox();
            this.lblStato = new System.Windows.Forms.Label();
            this.checkBoxTerminata = new System.Windows.Forms.CheckBox();
            this.checkBoxPagata = new System.Windows.Forms.CheckBox();
            this.numericUpDownCompenso = new System.Windows.Forms.NumericUpDown();
            this.lblDurata = new System.Windows.Forms.Label();
            this.lblCompenso = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelDataFase = new System.Windows.Forms.Label();
            this.dateTimeDataFase = new System.Windows.Forms.DateTimePicker();
            this.button6 = new System.Windows.Forms.Button();
            this.textBoxDescrizioneFase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFineFase = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInizioFase = new System.Windows.Forms.DateTimePicker();
            this.lblOraFine = new System.Windows.Forms.Label();
            this.lblOraInizio = new System.Windows.Forms.Label();
            this.lblStep = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dipendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amministratoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserimentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interrogazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciCostiStrutturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCompenso)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboboxClienteNominativo
            // 
            this.comboboxClienteNominativo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboboxClienteNominativo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboboxClienteNominativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxClienteNominativo.FormattingEnabled = true;
            this.comboboxClienteNominativo.IntegralHeight = false;
            this.comboboxClienteNominativo.Location = new System.Drawing.Point(100, 26);
            this.comboboxClienteNominativo.Name = "comboboxClienteNominativo";
            this.comboboxClienteNominativo.Size = new System.Drawing.Size(246, 24);
            this.comboboxClienteNominativo.TabIndex = 1;
            this.comboboxClienteNominativo.Text = "Seleziona cliente...";
            this.comboboxClienteNominativo.SelectedIndexChanged += new System.EventHandler(this.comboboxClienteNominativo_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNomePratica);
            this.groupBox1.Controls.Add(this.codiceFiscaleSecret);
            this.groupBox1.Controls.Add(this.lblData);
            this.groupBox1.Controls.Add(this.dateTimePickerDataPratica);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.lblNomePratica);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.comboboxClienteNominativo);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pratica";
            // 
            // textBoxNomePratica
            // 
            this.textBoxNomePratica.Location = new System.Drawing.Point(100, 56);
            this.textBoxNomePratica.Name = "textBoxNomePratica";
            this.textBoxNomePratica.Size = new System.Drawing.Size(246, 25);
            this.textBoxNomePratica.TabIndex = 23;
            // 
            // codiceFiscaleSecret
            // 
            this.codiceFiscaleSecret.Location = new System.Drawing.Point(246, 91);
            this.codiceFiscaleSecret.Name = "codiceFiscaleSecret";
            this.codiceFiscaleSecret.Size = new System.Drawing.Size(1, 25);
            this.codiceFiscaleSecret.TabIndex = 2;
            this.codiceFiscaleSecret.Visible = false;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(29, 94);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(35, 20);
            this.lblData.TabIndex = 22;
            this.lblData.Text = "Data";
            // 
            // dateTimePickerDataPratica
            // 
            this.dateTimePickerDataPratica.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.dateTimePickerDataPratica.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateTimePickerDataPratica.CustomFormat = " dd-MM-yyyy";
            this.dateTimePickerDataPratica.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataPratica.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePickerDataPratica.Location = new System.Drawing.Point(100, 90);
            this.dateTimePickerDataPratica.Name = "dateTimePickerDataPratica";
            this.dateTimePickerDataPratica.ShowCheckBox = true;
            this.dateTimePickerDataPratica.Size = new System.Drawing.Size(116, 25);
            this.dateTimePickerDataPratica.TabIndex = 21;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(164, 126);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 28);
            this.button5.TabIndex = 5;
            this.button5.Text = "inserisci";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "visualizza";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblNomePratica
            // 
            this.lblNomePratica.AutoSize = true;
            this.lblNomePratica.Location = new System.Drawing.Point(6, 60);
            this.lblNomePratica.Name = "lblNomePratica";
            this.lblNomePratica.Size = new System.Drawing.Size(84, 20);
            this.lblNomePratica.TabIndex = 3;
            this.lblNomePratica.Text = "Nome pratica";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(25, 30);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(48, 20);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(380, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 630);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.lblCategoria);
            this.groupBox2.Controls.Add(this.comboBoxCategoria);
            this.groupBox2.Controls.Add(this.lblSottocategoria);
            this.groupBox2.Controls.Add(this.comboBoxSottocategoria);
            this.groupBox2.Controls.Add(this.textBoxDurata);
            this.groupBox2.Controls.Add(this.lblStato);
            this.groupBox2.Controls.Add(this.checkBoxTerminata);
            this.groupBox2.Controls.Add(this.checkBoxPagata);
            this.groupBox2.Controls.Add(this.numericUpDownCompenso);
            this.groupBox2.Controls.Add(this.lblDurata);
            this.groupBox2.Controls.Add(this.lblCompenso);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 215);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prestazione";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(124, 179);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 28);
            this.button4.TabIndex = 13;
            this.button4.Text = "inserisci";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(15, 117);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(63, 20);
            this.lblCategoria.TabIndex = 11;
            this.lblCategoria.Text = "Categoria";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(107, 114);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(239, 24);
            this.comboBoxCategoria.TabIndex = 6;
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoria_SelectedIndexChanged);
            // 
            // lblSottocategoria
            // 
            this.lblSottocategoria.AutoSize = true;
            this.lblSottocategoria.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSottocategoria.Location = new System.Drawing.Point(6, 153);
            this.lblSottocategoria.Name = "lblSottocategoria";
            this.lblSottocategoria.Size = new System.Drawing.Size(89, 20);
            this.lblSottocategoria.TabIndex = 9;
            this.lblSottocategoria.Text = "Sottocategoria";
            // 
            // comboBoxSottocategoria
            // 
            this.comboBoxSottocategoria.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSottocategoria.FormattingEnabled = true;
            this.comboBoxSottocategoria.Location = new System.Drawing.Point(107, 149);
            this.comboBoxSottocategoria.Name = "comboBoxSottocategoria";
            this.comboBoxSottocategoria.Size = new System.Drawing.Size(239, 24);
            this.comboBoxSottocategoria.TabIndex = 7;
            // 
            // textBoxDurata
            // 
            this.textBoxDurata.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDurata.Location = new System.Drawing.Point(106, 54);
            this.textBoxDurata.Name = "textBoxDurata";
            this.textBoxDurata.ReadOnly = true;
            this.textBoxDurata.Size = new System.Drawing.Size(100, 25);
            this.textBoxDurata.TabIndex = 7;
            this.textBoxDurata.TabStop = false;
            this.textBoxDurata.Text = "00:00";
            // 
            // lblStato
            // 
            this.lblStato.AutoSize = true;
            this.lblStato.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStato.Location = new System.Drawing.Point(29, 90);
            this.lblStato.Name = "lblStato";
            this.lblStato.Size = new System.Drawing.Size(37, 20);
            this.lblStato.TabIndex = 6;
            this.lblStato.Text = "Stato";
            // 
            // checkBoxTerminata
            // 
            this.checkBoxTerminata.AutoSize = true;
            this.checkBoxTerminata.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTerminata.Location = new System.Drawing.Point(106, 86);
            this.checkBoxTerminata.Name = "checkBoxTerminata";
            this.checkBoxTerminata.Size = new System.Drawing.Size(86, 24);
            this.checkBoxTerminata.TabIndex = 4;
            this.checkBoxTerminata.Text = "Terminata";
            this.checkBoxTerminata.UseVisualStyleBackColor = true;
            // 
            // checkBoxPagata
            // 
            this.checkBoxPagata.AutoSize = true;
            this.checkBoxPagata.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPagata.Location = new System.Drawing.Point(197, 86);
            this.checkBoxPagata.Name = "checkBoxPagata";
            this.checkBoxPagata.Size = new System.Drawing.Size(67, 24);
            this.checkBoxPagata.TabIndex = 5;
            this.checkBoxPagata.Text = "Pagata";
            this.checkBoxPagata.UseVisualStyleBackColor = true;
            // 
            // numericUpDownCompenso
            // 
            this.numericUpDownCompenso.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCompenso.Location = new System.Drawing.Point(107, 22);
            this.numericUpDownCompenso.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownCompenso.Name = "numericUpDownCompenso";
            this.numericUpDownCompenso.Size = new System.Drawing.Size(106, 25);
            this.numericUpDownCompenso.TabIndex = 3;
            // 
            // lblDurata
            // 
            this.lblDurata.AutoSize = true;
            this.lblDurata.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurata.Location = new System.Drawing.Point(29, 54);
            this.lblDurata.Name = "lblDurata";
            this.lblDurata.Size = new System.Drawing.Size(46, 20);
            this.lblDurata.TabIndex = 3;
            this.lblDurata.Text = "Durata";
            // 
            // lblCompenso
            // 
            this.lblCompenso.AutoSize = true;
            this.lblCompenso.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompenso.Location = new System.Drawing.Point(15, 24);
            this.lblCompenso.Name = "lblCompenso";
            this.lblCompenso.Size = new System.Drawing.Size(70, 20);
            this.lblCompenso.TabIndex = 2;
            this.lblCompenso.Text = "Compenso";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelDataFase);
            this.groupBox3.Controls.Add(this.dateTimeDataFase);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.textBoxDescrizioneFase);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dateTimePickerFineFase);
            this.groupBox3.Controls.Add(this.dateTimePickerInizioFase);
            this.groupBox3.Controls.Add(this.lblOraFine);
            this.groupBox3.Controls.Add(this.lblOraInizio);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 418);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 250);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fase";
            // 
            // labelDataFase
            // 
            this.labelDataFase.AutoSize = true;
            this.labelDataFase.Location = new System.Drawing.Point(17, 25);
            this.labelDataFase.Name = "labelDataFase";
            this.labelDataFase.Size = new System.Drawing.Size(35, 20);
            this.labelDataFase.TabIndex = 21;
            this.labelDataFase.Text = "Data";
            // 
            // dateTimeDataFase
            // 
            this.dateTimeDataFase.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.dateTimeDataFase.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateTimeDataFase.CustomFormat = " dd-MM-yyyy";
            this.dateTimeDataFase.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDataFase.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimeDataFase.Location = new System.Drawing.Point(97, 20);
            this.dateTimeDataFase.Name = "dateTimeDataFase";
            this.dateTimeDataFase.Size = new System.Drawing.Size(116, 25);
            this.dateTimeDataFase.TabIndex = 20;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(130, 215);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 28);
            this.button6.TabIndex = 19;
            this.button6.Text = "inserisci";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBoxDescrizioneFase
            // 
            this.textBoxDescrizioneFase.Location = new System.Drawing.Point(10, 108);
            this.textBoxDescrizioneFase.MaxLength = 1024;
            this.textBoxDescrizioneFase.Multiline = true;
            this.textBoxDescrizioneFase.Name = "textBoxDescrizioneFase";
            this.textBoxDescrizioneFase.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescrizioneFase.Size = new System.Drawing.Size(348, 101);
            this.textBoxDescrizioneFase.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Descrizione";
            // 
            // dateTimePickerFineFase
            // 
            this.dateTimePickerFineFase.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.dateTimePickerFineFase.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateTimePickerFineFase.CustomFormat = "HH:mm";
            this.dateTimePickerFineFase.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFineFase.Location = new System.Drawing.Point(270, 57);
            this.dateTimePickerFineFase.Name = "dateTimePickerFineFase";
            this.dateTimePickerFineFase.ShowUpDown = true;
            this.dateTimePickerFineFase.Size = new System.Drawing.Size(62, 25);
            this.dateTimePickerFineFase.TabIndex = 14;
            // 
            // dateTimePickerInizioFase
            // 
            this.dateTimePickerInizioFase.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.dateTimePickerInizioFase.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateTimePickerInizioFase.CustomFormat = "HH:mm";
            this.dateTimePickerInizioFase.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerInizioFase.Location = new System.Drawing.Point(97, 56);
            this.dateTimePickerInizioFase.Name = "dateTimePickerInizioFase";
            this.dateTimePickerInizioFase.ShowUpDown = true;
            this.dateTimePickerInizioFase.Size = new System.Drawing.Size(63, 25);
            this.dateTimePickerInizioFase.TabIndex = 13;
            // 
            // lblOraFine
            // 
            this.lblOraFine.AutoSize = true;
            this.lblOraFine.Location = new System.Drawing.Point(230, 61);
            this.lblOraFine.Name = "lblOraFine";
            this.lblOraFine.Size = new System.Drawing.Size(34, 20);
            this.lblOraFine.TabIndex = 3;
            this.lblOraFine.Text = "Fine";
            // 
            // lblOraInizio
            // 
            this.lblOraInizio.AutoSize = true;
            this.lblOraInizio.Location = new System.Drawing.Point(17, 62);
            this.lblOraInizio.Name = "lblOraInizio";
            this.lblOraInizio.Size = new System.Drawing.Size(37, 20);
            this.lblOraInizio.TabIndex = 2;
            this.lblOraInizio.Text = "Inizio";
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Location = new System.Drawing.Point(920, 22);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(64, 13);
            this.lblStep.TabIndex = 2;
            this.lblStep.Text = "Step: active";
            this.lblStep.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operazioniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operazioniToolStripMenuItem
            // 
            this.operazioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dipendenteToolStripMenuItem,
            this.amministratoreToolStripMenuItem});
            this.operazioniToolStripMenuItem.Name = "operazioniToolStripMenuItem";
            this.operazioniToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.operazioniToolStripMenuItem.Text = "Operazioni";
            // 
            // dipendenteToolStripMenuItem
            // 
            this.dipendenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserisciCostiStrutturaToolStripMenuItem});
            this.dipendenteToolStripMenuItem.Name = "dipendenteToolStripMenuItem";
            this.dipendenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dipendenteToolStripMenuItem.Text = "Dipendente";
            this.dipendenteToolStripMenuItem.Click += new System.EventHandler(this.dipendenteToolStripMenuItem_Click);
            // 
            // amministratoreToolStripMenuItem
            // 
            this.amministratoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserimentiToolStripMenuItem,
            this.interrogazioniToolStripMenuItem});
            this.amministratoreToolStripMenuItem.Name = "amministratoreToolStripMenuItem";
            this.amministratoreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.amministratoreToolStripMenuItem.Text = "Amministratore";
            // 
            // inserimentiToolStripMenuItem
            // 
            this.inserimentiToolStripMenuItem.Name = "inserimentiToolStripMenuItem";
            this.inserimentiToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.inserimentiToolStripMenuItem.Text = "Inserimenti";
            this.inserimentiToolStripMenuItem.Click += new System.EventHandler(this.inserimentiToolStripMenuItem_Click);
            // 
            // interrogazioniToolStripMenuItem
            // 
            this.interrogazioniToolStripMenuItem.Name = "interrogazioniToolStripMenuItem";
            this.interrogazioniToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.interrogazioniToolStripMenuItem.Text = "Interrogazioni";
            this.interrogazioniToolStripMenuItem.Click += new System.EventHandler(this.interrogazioniToolStripMenuItem_Click);
            // 
            // inserisciCostiStrutturaToolStripMenuItem
            // 
            this.inserisciCostiStrutturaToolStripMenuItem.Name = "inserisciCostiStrutturaToolStripMenuItem";
            this.inserisciCostiStrutturaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.inserisciCostiStrutturaToolStripMenuItem.Text = "Inserisci costi struttura";
            this.inserisciCostiStrutturaToolStripMenuItem.Click += new System.EventHandler(this.inserisciCostiStrutturaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 671);
            this.Controls.Add(this.lblStep);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Studio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCompenso)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboboxClienteNominativo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblNomePratica;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownCompenso;
        private System.Windows.Forms.Label lblDurata;
        private System.Windows.Forms.Label lblCompenso;
        private System.Windows.Forms.TextBox textBoxDurata;
        private System.Windows.Forms.Label lblStato;
        private System.Windows.Forms.CheckBox checkBoxTerminata;
        private System.Windows.Forms.CheckBox checkBoxPagata;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label lblSottocategoria;
        private System.Windows.Forms.ComboBox comboBoxSottocategoria;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblOraFine;
        private System.Windows.Forms.Label lblOraInizio;
        private System.Windows.Forms.DateTimePicker dateTimePickerInizioFase;
        private System.Windows.Forms.DateTimePicker dateTimePickerFineFase;
        private System.Windows.Forms.TextBox textBoxDescrizioneFase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelDataFase;
        private System.Windows.Forms.DateTimePicker dateTimeDataFase;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataPratica;
        private System.Windows.Forms.TextBox codiceFiscaleSecret;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.TextBox textBoxNomePratica;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dipendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amministratoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserimentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interrogazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserisciCostiStrutturaToolStripMenuItem;
    }
}

