namespace progettoDatabes
{
    partial class FormInserimentiAmministratore
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
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInserimentiAmministratore));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxRuolo = new System.Windows.Forms.ComboBox();
            this.LabelRuolo = new System.Windows.Forms.Label();
            this.LabelCostoFisso = new System.Windows.Forms.Label();
            this.LabelCategoria = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.TextBoxDescrizione = new System.Windows.Forms.RichTextBox();
            this.LabelDescrizione = new System.Windows.Forms.Label();
            this.checkBoxAzienda = new System.Windows.Forms.CheckBox();
            this.LabelP_IVA = new System.Windows.Forms.Label();
            this.LabelCodiceFiscale = new System.Windows.Forms.Label();
            this.LabelStipendio = new System.Windows.Forms.Label();
            this.checkBoxImpiegato = new System.Windows.Forms.CheckBox();
            this.textBoxTipo = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxCognomeCF = new System.Windows.Forms.TextBox();
            this.textBoxVia = new System.Windows.Forms.TextBox();
            this.textBoxCittàCosto = new System.Windows.Forms.TextBox();
            this.textBoxCAP = new System.Windows.Forms.TextBox();
            this.textBoxCostoOrario = new System.Windows.Forms.TextBox();
            this.LabelVia = new System.Windows.Forms.Label();
            this.LabelCostoOrario = new System.Windows.Forms.Label();
            this.LabelTipo = new System.Windows.Forms.Label();
            this.LabelCittà = new System.Windows.Forms.Label();
            this.LabelCAP = new System.Windows.Forms.Label();
            this.LabelCognomeDipendente = new System.Windows.Forms.Label();
            this.LabelNome = new System.Windows.Forms.Label();
            this.buttonDipendente = new System.Windows.Forms.Button();
            this.buttonRuolo = new System.Windows.Forms.Button();
            this.buttonSottCategoria = new System.Windows.Forms.Button();
            this.buttonCategoria = new System.Windows.Forms.Button();
            this.buttonSede = new System.Windows.Forms.Button();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonEsegui = new System.Windows.Forms.Button();
            this.buttonAllocazione = new System.Windows.Forms.Button();
            this.buttonResponsabilità = new System.Windows.Forms.Button();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.comboBoxDipendente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxAllocazione = new System.Windows.Forms.GroupBox();
            this.checkBoxPF = new System.Windows.Forms.CheckBox();
            this.dateTimePickerResponsabilità = new System.Windows.Forms.DateTimePicker();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxAllocazione.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(343, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(97, 83);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBoxPF);
            this.groupBox1.Controls.Add(this.comboBoxRuolo);
            this.groupBox1.Controls.Add(this.LabelRuolo);
            this.groupBox1.Controls.Add(this.LabelCostoFisso);
            this.groupBox1.Controls.Add(this.LabelCategoria);
            this.groupBox1.Controls.Add(this.comboBoxCategoria);
            this.groupBox1.Controls.Add(this.TextBoxDescrizione);
            this.groupBox1.Controls.Add(this.LabelDescrizione);
            this.groupBox1.Controls.Add(this.checkBoxAzienda);
            this.groupBox1.Controls.Add(this.LabelP_IVA);
            this.groupBox1.Controls.Add(this.LabelCodiceFiscale);
            this.groupBox1.Controls.Add(this.LabelStipendio);
            this.groupBox1.Controls.Add(this.checkBoxImpiegato);
            this.groupBox1.Controls.Add(this.textBoxTipo);
            this.groupBox1.Controls.Add(this.textBoxNome);
            this.groupBox1.Controls.Add(this.textBoxCognomeCF);
            this.groupBox1.Controls.Add(this.textBoxVia);
            this.groupBox1.Controls.Add(this.textBoxCittàCosto);
            this.groupBox1.Controls.Add(this.textBoxCAP);
            this.groupBox1.Controls.Add(this.textBoxCostoOrario);
            this.groupBox1.Controls.Add(this.LabelVia);
            this.groupBox1.Controls.Add(this.LabelCostoOrario);
            this.groupBox1.Controls.Add(this.LabelTipo);
            this.groupBox1.Controls.Add(this.LabelCittà);
            this.groupBox1.Controls.Add(this.LabelCAP);
            this.groupBox1.Controls.Add(this.LabelCognomeDipendente);
            this.groupBox1.Controls.Add(this.LabelNome);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserimento dei dati";
            // 
            // comboBoxRuolo
            // 
            this.comboBoxRuolo.FormattingEnabled = true;
            this.comboBoxRuolo.Location = new System.Drawing.Point(140, 230);
            this.comboBoxRuolo.Name = "comboBoxRuolo";
            this.comboBoxRuolo.Size = new System.Drawing.Size(234, 24);
            this.comboBoxRuolo.TabIndex = 6;
            this.comboBoxRuolo.Visible = false;
            // 
            // LabelRuolo
            // 
            this.LabelRuolo.AutoSize = true;
            this.LabelRuolo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRuolo.Location = new System.Drawing.Point(7, 232);
            this.LabelRuolo.Name = "LabelRuolo";
            this.LabelRuolo.Size = new System.Drawing.Size(46, 17);
            this.LabelRuolo.TabIndex = 24;
            this.LabelRuolo.Text = "Ruolo";
            this.LabelRuolo.Visible = false;
            // 
            // LabelCostoFisso
            // 
            this.LabelCostoFisso.AutoSize = true;
            this.LabelCostoFisso.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCostoFisso.Location = new System.Drawing.Point(7, 127);
            this.LabelCostoFisso.Name = "LabelCostoFisso";
            this.LabelCostoFisso.Size = new System.Drawing.Size(82, 17);
            this.LabelCostoFisso.TabIndex = 23;
            this.LabelCostoFisso.Text = "Costo fisso";
            this.LabelCostoFisso.Visible = false;
            // 
            // LabelCategoria
            // 
            this.LabelCategoria.AutoSize = true;
            this.LabelCategoria.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCategoria.Location = new System.Drawing.Point(7, 94);
            this.LabelCategoria.Name = "LabelCategoria";
            this.LabelCategoria.Size = new System.Drawing.Size(71, 17);
            this.LabelCategoria.TabIndex = 22;
            this.LabelCategoria.Text = "Categoria";
            this.LabelCategoria.Visible = false;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(140, 92);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(234, 24);
            this.comboBoxCategoria.TabIndex = 2;
            this.comboBoxCategoria.Visible = false;
            // 
            // TextBoxDescrizione
            // 
            this.TextBoxDescrizione.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDescrizione.Enabled = false;
            this.TextBoxDescrizione.Location = new System.Drawing.Point(403, 131);
            this.TextBoxDescrizione.Name = "TextBoxDescrizione";
            this.TextBoxDescrizione.Size = new System.Drawing.Size(367, 127);
            this.TextBoxDescrizione.TabIndex = 11;
            this.TextBoxDescrizione.Text = "";
            // 
            // LabelDescrizione
            // 
            this.LabelDescrizione.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDescrizione.AutoSize = true;
            this.LabelDescrizione.Enabled = false;
            this.LabelDescrizione.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LabelDescrizione.Location = new System.Drawing.Point(546, 112);
            this.LabelDescrizione.Name = "LabelDescrizione";
            this.LabelDescrizione.Size = new System.Drawing.Size(76, 16);
            this.LabelDescrizione.TabIndex = 19;
            this.LabelDescrizione.Text = "Descrizione";
            // 
            // checkBoxAzienda
            // 
            this.checkBoxAzienda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAzienda.AutoSize = true;
            this.checkBoxAzienda.Location = new System.Drawing.Point(577, 17);
            this.checkBoxAzienda.Name = "checkBoxAzienda";
            this.checkBoxAzienda.Size = new System.Drawing.Size(74, 20);
            this.checkBoxAzienda.TabIndex = 7;
            this.checkBoxAzienda.Text = "Azienda";
            this.checkBoxAzienda.UseVisualStyleBackColor = true;
            this.checkBoxAzienda.Visible = false;
            this.checkBoxAzienda.CheckedChanged += new System.EventHandler(this.checkBoxAzienda_CheckedChanged);
            // 
            // LabelP_IVA
            // 
            this.LabelP_IVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelP_IVA.AutoSize = true;
            this.LabelP_IVA.Location = new System.Drawing.Point(546, 62);
            this.LabelP_IVA.Name = "LabelP_IVA";
            this.LabelP_IVA.Size = new System.Drawing.Size(70, 16);
            this.LabelP_IVA.TabIndex = 17;
            this.LabelP_IVA.Text = "Partita IVA";
            this.LabelP_IVA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelP_IVA.Visible = false;
            // 
            // LabelCodiceFiscale
            // 
            this.LabelCodiceFiscale.AutoSize = true;
            this.LabelCodiceFiscale.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCodiceFiscale.Location = new System.Drawing.Point(7, 62);
            this.LabelCodiceFiscale.Name = "LabelCodiceFiscale";
            this.LabelCodiceFiscale.Size = new System.Drawing.Size(100, 17);
            this.LabelCodiceFiscale.TabIndex = 16;
            this.LabelCodiceFiscale.Text = "Codice fiscale";
            this.LabelCodiceFiscale.Visible = false;
            // 
            // LabelStipendio
            // 
            this.LabelStipendio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelStipendio.AutoSize = true;
            this.LabelStipendio.Location = new System.Drawing.Point(546, 62);
            this.LabelStipendio.Name = "LabelStipendio";
            this.LabelStipendio.Size = new System.Drawing.Size(62, 16);
            this.LabelStipendio.TabIndex = 15;
            this.LabelStipendio.Text = "Stipendio";
            this.LabelStipendio.Visible = false;
            // 
            // checkBoxImpiegato
            // 
            this.checkBoxImpiegato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxImpiegato.AutoSize = true;
            this.checkBoxImpiegato.Location = new System.Drawing.Point(577, 18);
            this.checkBoxImpiegato.Name = "checkBoxImpiegato";
            this.checkBoxImpiegato.Size = new System.Drawing.Size(80, 20);
            this.checkBoxImpiegato.TabIndex = 14;
            this.checkBoxImpiegato.Text = "Impegato";
            this.checkBoxImpiegato.UseVisualStyleBackColor = true;
            this.checkBoxImpiegato.Visible = false;
            this.checkBoxImpiegato.CheckedChanged += new System.EventHandler(this.checkBoxImpiegato_CheckedChanged);
            // 
            // textBoxTipo
            // 
            this.textBoxTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTipo.Location = new System.Drawing.Point(480, 87);
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.Size = new System.Drawing.Size(202, 22);
            this.textBoxTipo.TabIndex = 8;
            this.textBoxTipo.Visible = false;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Enabled = false;
            this.textBoxNome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(140, 21);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(234, 25);
            this.textBoxNome.TabIndex = 0;
            // 
            // textBoxCognomeCF
            // 
            this.textBoxCognomeCF.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCognomeCF.Location = new System.Drawing.Point(140, 56);
            this.textBoxCognomeCF.Name = "textBoxCognomeCF";
            this.textBoxCognomeCF.Size = new System.Drawing.Size(234, 25);
            this.textBoxCognomeCF.TabIndex = 1;
            this.textBoxCognomeCF.Visible = false;
            // 
            // textBoxVia
            // 
            this.textBoxVia.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVia.Location = new System.Drawing.Point(140, 91);
            this.textBoxVia.Name = "textBoxVia";
            this.textBoxVia.Size = new System.Drawing.Size(234, 25);
            this.textBoxVia.TabIndex = 10;
            this.textBoxVia.Visible = false;
            // 
            // textBoxCittàCosto
            // 
            this.textBoxCittàCosto.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCittàCosto.Location = new System.Drawing.Point(140, 124);
            this.textBoxCittàCosto.Name = "textBoxCittàCosto";
            this.textBoxCittàCosto.Size = new System.Drawing.Size(234, 25);
            this.textBoxCittàCosto.TabIndex = 3;
            this.textBoxCittàCosto.Visible = false;
            // 
            // textBoxCAP
            // 
            this.textBoxCAP.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCAP.Location = new System.Drawing.Point(140, 161);
            this.textBoxCAP.Name = "textBoxCAP";
            this.textBoxCAP.Size = new System.Drawing.Size(234, 25);
            this.textBoxCAP.TabIndex = 4;
            this.textBoxCAP.Visible = false;
            // 
            // textBoxCostoOrario
            // 
            this.textBoxCostoOrario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCostoOrario.Location = new System.Drawing.Point(140, 195);
            this.textBoxCostoOrario.Name = "textBoxCostoOrario";
            this.textBoxCostoOrario.Size = new System.Drawing.Size(234, 25);
            this.textBoxCostoOrario.TabIndex = 5;
            this.textBoxCostoOrario.Visible = false;
            // 
            // LabelVia
            // 
            this.LabelVia.AutoSize = true;
            this.LabelVia.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVia.Location = new System.Drawing.Point(7, 92);
            this.LabelVia.Name = "LabelVia";
            this.LabelVia.Size = new System.Drawing.Size(28, 17);
            this.LabelVia.TabIndex = 6;
            this.LabelVia.Text = "Via";
            this.LabelVia.Visible = false;
            // 
            // LabelCostoOrario
            // 
            this.LabelCostoOrario.AutoSize = true;
            this.LabelCostoOrario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCostoOrario.Location = new System.Drawing.Point(7, 198);
            this.LabelCostoOrario.Name = "LabelCostoOrario";
            this.LabelCostoOrario.Size = new System.Drawing.Size(88, 17);
            this.LabelCostoOrario.TabIndex = 5;
            this.LabelCostoOrario.Text = "Costo orario";
            this.LabelCostoOrario.Visible = false;
            // 
            // LabelTipo
            // 
            this.LabelTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTipo.AutoSize = true;
            this.LabelTipo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTipo.Location = new System.Drawing.Point(515, 18);
            this.LabelTipo.Name = "LabelTipo";
            this.LabelTipo.Size = new System.Drawing.Size(32, 16);
            this.LabelTipo.TabIndex = 4;
            this.LabelTipo.Text = "Tipo";
            this.LabelTipo.Visible = false;
            // 
            // LabelCittà
            // 
            this.LabelCittà.AutoSize = true;
            this.LabelCittà.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCittà.Location = new System.Drawing.Point(7, 127);
            this.LabelCittà.Name = "LabelCittà";
            this.LabelCittà.Size = new System.Drawing.Size(38, 17);
            this.LabelCittà.TabIndex = 3;
            this.LabelCittà.Text = "Città";
            this.LabelCittà.Visible = false;
            // 
            // LabelCAP
            // 
            this.LabelCAP.AutoSize = true;
            this.LabelCAP.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCAP.Location = new System.Drawing.Point(6, 164);
            this.LabelCAP.Name = "LabelCAP";
            this.LabelCAP.Size = new System.Drawing.Size(38, 17);
            this.LabelCAP.TabIndex = 2;
            this.LabelCAP.Text = "CAP";
            this.LabelCAP.Visible = false;
            // 
            // LabelCognomeDipendente
            // 
            this.LabelCognomeDipendente.AutoSize = true;
            this.LabelCognomeDipendente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCognomeDipendente.Location = new System.Drawing.Point(6, 59);
            this.LabelCognomeDipendente.Name = "LabelCognomeDipendente";
            this.LabelCognomeDipendente.Size = new System.Drawing.Size(72, 17);
            this.LabelCognomeDipendente.TabIndex = 1;
            this.LabelCognomeDipendente.Text = "Cognome";
            this.LabelCognomeDipendente.Visible = false;
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNome.Location = new System.Drawing.Point(7, 24);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(47, 17);
            this.LabelNome.TabIndex = 0;
            this.LabelNome.Text = "Nome";
            // 
            // buttonDipendente
            // 
            this.buttonDipendente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDipendente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDipendente.Location = new System.Drawing.Point(22, 276);
            this.buttonDipendente.Name = "buttonDipendente";
            this.buttonDipendente.Size = new System.Drawing.Size(139, 50);
            this.buttonDipendente.TabIndex = 0;
            this.buttonDipendente.Text = "Inserisci dipendente";
            this.buttonDipendente.UseVisualStyleBackColor = true;
            this.buttonDipendente.Click += new System.EventHandler(this.buttonDipendente_Click);
            // 
            // buttonRuolo
            // 
            this.buttonRuolo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRuolo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRuolo.Location = new System.Drawing.Point(188, 388);
            this.buttonRuolo.Name = "buttonRuolo";
            this.buttonRuolo.Size = new System.Drawing.Size(139, 50);
            this.buttonRuolo.TabIndex = 5;
            this.buttonRuolo.Text = "Inserisci ruolo";
            this.buttonRuolo.UseVisualStyleBackColor = true;
            this.buttonRuolo.Click += new System.EventHandler(this.buttonRuolo_Click);
            // 
            // buttonSottCategoria
            // 
            this.buttonSottCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSottCategoria.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSottCategoria.Location = new System.Drawing.Point(188, 332);
            this.buttonSottCategoria.Name = "buttonSottCategoria";
            this.buttonSottCategoria.Size = new System.Drawing.Size(139, 50);
            this.buttonSottCategoria.TabIndex = 4;
            this.buttonSottCategoria.Text = "Inserisci sotto categoria";
            this.buttonSottCategoria.UseVisualStyleBackColor = true;
            this.buttonSottCategoria.Click += new System.EventHandler(this.buttonSottCategoria_Click);
            // 
            // buttonCategoria
            // 
            this.buttonCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCategoria.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCategoria.Location = new System.Drawing.Point(188, 276);
            this.buttonCategoria.Name = "buttonCategoria";
            this.buttonCategoria.Size = new System.Drawing.Size(139, 50);
            this.buttonCategoria.TabIndex = 3;
            this.buttonCategoria.Text = "Inserisci categoria";
            this.buttonCategoria.UseVisualStyleBackColor = true;
            this.buttonCategoria.Click += new System.EventHandler(this.buttonCategoria_Click);
            // 
            // buttonSede
            // 
            this.buttonSede.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSede.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSede.Location = new System.Drawing.Point(21, 388);
            this.buttonSede.Name = "buttonSede";
            this.buttonSede.Size = new System.Drawing.Size(139, 50);
            this.buttonSede.TabIndex = 2;
            this.buttonSede.Text = "Inserisci sede";
            this.buttonSede.UseVisualStyleBackColor = true;
            this.buttonSede.Click += new System.EventHandler(this.buttonSede_Click);
            // 
            // buttonCliente
            // 
            this.buttonCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCliente.Location = new System.Drawing.Point(21, 332);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(139, 50);
            this.buttonCliente.TabIndex = 1;
            this.buttonCliente.Text = "Inserisci Cliente";
            this.buttonCliente.UseVisualStyleBackColor = true;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
            // 
            // buttonEsegui
            // 
            this.buttonEsegui.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEsegui.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonEsegui.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEsegui.Location = new System.Drawing.Point(655, 388);
            this.buttonEsegui.Name = "buttonEsegui";
            this.buttonEsegui.Size = new System.Drawing.Size(126, 49);
            this.buttonEsegui.TabIndex = 8;
            this.buttonEsegui.Text = "Esegui";
            this.buttonEsegui.UseVisualStyleBackColor = false;
            this.buttonEsegui.Click += new System.EventHandler(this.buttonEsegui_Click);
            // 
            // buttonAllocazione
            // 
            this.buttonAllocazione.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAllocazione.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllocazione.Location = new System.Drawing.Point(355, 276);
            this.buttonAllocazione.Name = "buttonAllocazione";
            this.buttonAllocazione.Size = new System.Drawing.Size(139, 50);
            this.buttonAllocazione.TabIndex = 6;
            this.buttonAllocazione.Text = "Inserisci allocazione";
            this.buttonAllocazione.UseVisualStyleBackColor = true;
            this.buttonAllocazione.Click += new System.EventHandler(this.buttonAllocazione_Click);
            // 
            // buttonResponsabilità
            // 
            this.buttonResponsabilità.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonResponsabilità.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResponsabilità.Location = new System.Drawing.Point(355, 333);
            this.buttonResponsabilità.Name = "buttonResponsabilità";
            this.buttonResponsabilità.Size = new System.Drawing.Size(139, 50);
            this.buttonResponsabilità.TabIndex = 7;
            this.buttonResponsabilità.Text = "assegna reponsabilità";
            this.buttonResponsabilità.UseVisualStyleBackColor = true;
            this.buttonResponsabilità.Click += new System.EventHandler(this.buttonResponsabilità_Click);
            // 
            // checkedListBox
            // 
            this.checkedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(505, 20);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(257, 229);
            this.checkedListBox.Sorted = true;
            this.checkedListBox.TabIndex = 1;
            // 
            // comboBoxDipendente
            // 
            this.comboBoxDipendente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDipendente.FormattingEnabled = true;
            this.comboBoxDipendente.Location = new System.Drawing.Point(9, 54);
            this.comboBoxDipendente.Name = "comboBoxDipendente";
            this.comboBoxDipendente.Size = new System.Drawing.Size(263, 24);
            this.comboBoxDipendente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleziona dipendente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleziona un dipendente ed una o più sedi";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "dove allorcarlo ";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seleziona un dipendente ed uno o più clienti";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "dei quali sarà responsabile";
            this.label5.Visible = false;
            // 
            // groupBoxAllocazione
            // 
            this.groupBoxAllocazione.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAllocazione.AutoSize = true;
            this.groupBoxAllocazione.Controls.Add(this.dateTimePickerResponsabilità);
            this.groupBoxAllocazione.Controls.Add(this.label5);
            this.groupBoxAllocazione.Controls.Add(this.label4);
            this.groupBoxAllocazione.Controls.Add(this.label3);
            this.groupBoxAllocazione.Controls.Add(this.label2);
            this.groupBoxAllocazione.Controls.Add(this.label1);
            this.groupBoxAllocazione.Controls.Add(this.comboBoxDipendente);
            this.groupBoxAllocazione.Controls.Add(pictureBox1);
            this.groupBoxAllocazione.Controls.Add(this.checkedListBox);
            this.groupBoxAllocazione.Location = new System.Drawing.Point(12, 0);
            this.groupBoxAllocazione.Name = "groupBoxAllocazione";
            this.groupBoxAllocazione.Size = new System.Drawing.Size(781, 270);
            this.groupBoxAllocazione.TabIndex = 9;
            this.groupBoxAllocazione.TabStop = false;
            this.groupBoxAllocazione.Text = "Allocazione dipendente";
            this.groupBoxAllocazione.Visible = false;
            // 
            // checkBoxPF
            // 
            this.checkBoxPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPF.AutoSize = true;
            this.checkBoxPF.Location = new System.Drawing.Point(462, 17);
            this.checkBoxPF.Name = "checkBoxPF";
            this.checkBoxPF.Size = new System.Drawing.Size(109, 20);
            this.checkBoxPF.TabIndex = 26;
            this.checkBoxPF.Text = "Persona fisica";
            this.checkBoxPF.UseVisualStyleBackColor = true;
            this.checkBoxPF.Visible = false;
            // 
            // dateTimePickerResponsabilità
            // 
            this.dateTimePickerResponsabilità.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateTimePickerResponsabilità.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerResponsabilità.Enabled = false;
            this.dateTimePickerResponsabilità.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerResponsabilità.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerResponsabilità.Location = new System.Drawing.Point(325, 109);
            this.dateTimePickerResponsabilità.Name = "dateTimePickerResponsabilità";
            this.dateTimePickerResponsabilità.Size = new System.Drawing.Size(128, 22);
            this.dateTimePickerResponsabilità.TabIndex = 9;
            // 
            // FormInserimentiAmministratore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonResponsabilità);
            this.Controls.Add(this.groupBoxAllocazione);
            this.Controls.Add(this.buttonAllocazione);
            this.Controls.Add(this.buttonEsegui);
            this.Controls.Add(this.buttonCliente);
            this.Controls.Add(this.buttonSede);
            this.Controls.Add(this.buttonCategoria);
            this.Controls.Add(this.buttonSottCategoria);
            this.Controls.Add(this.buttonRuolo);
            this.Controls.Add(this.buttonDipendente);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormInserimentiAmministratore";
            this.Text = "FormInserimentiAmministratore";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxAllocazione.ResumeLayout(false);
            this.groupBoxAllocazione.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabelNome;
        private System.Windows.Forms.Label LabelStipendio;
        private System.Windows.Forms.CheckBox checkBoxImpiegato;
        private System.Windows.Forms.TextBox textBoxTipo;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxCognomeCF;
        private System.Windows.Forms.TextBox textBoxVia;
        private System.Windows.Forms.TextBox textBoxCittàCosto;
        private System.Windows.Forms.TextBox textBoxCAP;
        private System.Windows.Forms.TextBox textBoxCostoOrario;
        private System.Windows.Forms.Label LabelVia;
        private System.Windows.Forms.Label LabelCostoOrario;
        private System.Windows.Forms.Label LabelTipo;
        private System.Windows.Forms.Label LabelCittà;
        private System.Windows.Forms.Label LabelCAP;
        private System.Windows.Forms.Label LabelCognomeDipendente;
        private System.Windows.Forms.CheckBox checkBoxAzienda;
        private System.Windows.Forms.Label LabelP_IVA;
        private System.Windows.Forms.Label LabelCodiceFiscale;
        private System.Windows.Forms.Label LabelCostoFisso;
        private System.Windows.Forms.Label LabelCategoria;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.RichTextBox TextBoxDescrizione;
        private System.Windows.Forms.Label LabelDescrizione;
        private System.Windows.Forms.Button buttonDipendente;
        private System.Windows.Forms.Button buttonRuolo;
        private System.Windows.Forms.Button buttonSottCategoria;
        private System.Windows.Forms.Button buttonCategoria;
        private System.Windows.Forms.Button buttonSede;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Button buttonEsegui;
        private System.Windows.Forms.Button buttonAllocazione;
        private System.Windows.Forms.Label LabelRuolo;
        private System.Windows.Forms.Button buttonResponsabilità;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.ComboBox comboBoxDipendente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxRuolo;
        private System.Windows.Forms.GroupBox groupBoxAllocazione;
        private System.Windows.Forms.CheckBox checkBoxPF;
        private System.Windows.Forms.DateTimePicker dateTimePickerResponsabilità;
    }
}