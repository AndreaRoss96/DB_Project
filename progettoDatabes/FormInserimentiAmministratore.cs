using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToDB;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace progettoDatabes
{
    public partial class FormInserimentiAmministratore : Form
    {
        private string execution;
        private bool tipo;
        public FormInserimentiAmministratore()
        {
            InitializeComponent();
            this.execution = " ";
            this.tipo = false;

            using (var db = new DataModel.StudioprofessionaleDB())
            {
                var queryDipendente =
                    (from d in db.Dipendentes
                     select d);

                var queryCategoria =
                    (from c in db.Categorias
                     select c);

                var queryRuolo =
                    (from r in db.Ruoloes
                     select r);

                foreach (var x in queryCategoria)
                {
                    comboBoxCategoria.Items.Add(x.CodiceCategoria + " - " + x.Nome);
                }
                foreach (var x in queryDipendente)
                {
                    comboBoxDipendente.Items.Add(x.Matricola + " - " + x.Nome + " " + x.Cognome);
                }
                foreach (var x in queryRuolo)
                {
                    comboBoxRuolo.Items.Add(x.CodiceRuolo + " - " + x.Nome);
                }
            }
        }

        private void initializeLabels()
        {
            this.execution = " ";
            LabelNome.Enabled = false;
            LabelCognomeDipendente.Visible = false;
            LabelCodiceFiscale.Visible = false;
            LabelVia.Visible = false;
            LabelCategoria.Visible = false;
            LabelCittà.Visible = false;
            LabelCostoFisso.Visible = false;
            LabelCAP.Visible = false;
            LabelCostoOrario.Visible = false;
            LabelTipo.Visible = false;
            LabelStipendio.Visible = false;
            LabelP_IVA.Visible = false;
            LabelDescrizione.Enabled = false;
            LabelRuolo.Visible = false;

            textBoxNome.Enabled = false;
            textBoxNome.Clear();
            textBoxCognomeCF.Visible = false;
            textBoxCognomeCF.Clear();
            textBoxVia.Visible = false;
            textBoxVia.Clear();
            comboBoxCategoria.Visible = false;
            comboBoxCategoria.ResetText();
            textBoxCittàCosto.Visible = false;
            textBoxCittàCosto.Clear();
            textBoxCAP.Visible = false;
            textBoxCAP.Clear();
            textBoxCostoOrario.Visible = false;
            textBoxCostoOrario.Clear();
            textBoxTipo.Visible = false;
            textBoxTipo.Clear();
            TextBoxDescrizione.Enabled = false;
            TextBoxDescrizione.Clear();
            comboBoxRuolo.Visible = false;
            comboBoxRuolo.ResetText();

            checkBoxAzienda.Visible = false;
            checkBoxAzienda.Checked = false;
            checkBoxImpiegato.Visible = false;
            checkBoxImpiegato.Checked = false;
            checkBoxPF.Visible = false;
            checkBoxPF.Checked = false;

            this.tipo = false;

            groupBoxAllocazione.Visible = false;
            comboBoxDipendente.ResetText();
            checkedListBox.Items.Clear();
            dateTimePickerResponsabilità.Enabled = false;
        }

        private void initializePersonLabels()
        {
            initializeLabels();
            LabelNome.Enabled = true;
            LabelVia.Visible = true;
            LabelCittà.Visible = true;
            LabelCAP.Visible = true;
            LabelTipo.Visible = true;

            textBoxNome.Enabled = true;
            textBoxCognomeCF.Visible = true;
            textBoxVia.Visible = true;
            textBoxCittàCosto.Visible = true;
            textBoxCAP.Visible = true;
            textBoxTipo.Visible = true;
            textBoxTipo.Enabled = false;
        }

        private void initializeGeneric()
        {
            initializeLabels();
            LabelNome.Enabled = true;
            textBoxNome.Enabled = true;
            LabelDescrizione.Enabled = true;
            TextBoxDescrizione.Enabled = true;
        }

        private void buttonDipendente_Click(object sender, EventArgs e)
        {
            this.execution = "Dipendente";
            initializePersonLabels();
            LabelCognomeDipendente.Visible = true;
            LabelCostoOrario.Visible = true;
            textBoxCostoOrario.Visible = true;
            LabelStipendio.Visible = true;
            LabelStipendio.Enabled = false;
            checkBoxImpiegato.Visible = true;
            LabelRuolo.Visible = true;
            comboBoxRuolo.Visible = true;
        }

        private void checkBoxImpiegato_CheckedChanged(object sender, EventArgs e)
        {
            if (tipo == false)
            {
                LabelStipendio.Enabled = true;
                textBoxTipo.Enabled = true;
                this.tipo = true;
            } else
            {
                LabelStipendio.Enabled = false;
                textBoxTipo.Enabled = false;
                this.tipo = false;
            }
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            this.execution = "Cliente";
            initializePersonLabels();
            LabelCodiceFiscale.Visible = true;
            LabelP_IVA.Visible = true;
            LabelP_IVA.Enabled = false;
            checkBoxAzienda.Visible = true;
        }

        private void checkBoxAzienda_CheckedChanged(object sender, EventArgs e)
        {
            if (tipo == false)
            {
                LabelP_IVA.Enabled = true;
                textBoxTipo.Enabled = true;
                this.tipo = true;
            }
            else
            {
                LabelP_IVA.Enabled = false;
                textBoxTipo.Enabled = false;
                this.tipo = false;
            }
        }

        private void buttonSede_Click(object sender, EventArgs e)
        {
            this.execution = "Sede";
            initializePersonLabels();
            textBoxCognomeCF.Visible = false;
            LabelTipo.Visible = false;
            textBoxTipo.Visible = false;
        }

        private void buttonCategoria_Click(object sender, EventArgs e)
        {
            this.execution = "Categoria";
            initializeGeneric();
        }

        private void buttonSottCategoria_Click(object sender, EventArgs e)
        {
            this.execution = "SottoCategoria";
            initializeGeneric();
            LabelCostoFisso.Visible = true;
            textBoxCittàCosto.Visible = true;
            checkBoxAzienda.Visible = false;
            checkBoxPF.Visible = false;

            LabelCategoria.Visible = true;
            comboBoxCategoria.Visible = true;
        }

        private void buttonRuolo_Click(object sender, EventArgs e)
        {
            this.execution = "Ruolo";
            initializeLabels();
            LabelNome.Enabled = true;
            textBoxNome.Enabled = true;
        }

        private void buttonAllocazione_Click(object sender, EventArgs e)
        {
            this.execution = "Allocazione";
            initializeLabels();
            groupBoxAllocazione.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;

            using (var db = new DataModel.StudioprofessionaleDB())
            {
                var querySede =
                  (from p in db.Sedes
                   select p);
                foreach (var x in querySede)
                {
                    checkedListBox.Items.Add(x.CodiceSede + " - " + x.Nome + " " + x.Via + " " + x.Citta + " " + x.CAP);
                }
            }
        }

        private void buttonResponsabilità_Click(object sender, EventArgs e)
        {
            this.execution = "Responsabilità";
            initializeLabels();
            dateTimePickerResponsabilità.Enabled = true;
            groupBoxAllocazione.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label2.Visible = false;
            label3.Visible = false;

            using (var db = new DataModel.StudioprofessionaleDB())
            {
                var queryResponsabilità =
                    (from c in db.Clientes
                    where !(from r in db.Responsabiles
                            where r.CodiceFiscale == c.CodiceFiscale
                            select c.CodiceFiscale).Contains(c.CodiceFiscale)
                    select c);

                foreach (var x in queryResponsabilità)
                {
                    checkedListBox.Items.Add(x.Nominativo + " - " + x.CodiceFiscale);
                }
            }
        }

        private void buttonEsegui_Click(object sender, EventArgs e)
        {
            switch (this.execution)
            {
                case "Dipendente":
                    insertDipendente();
                    break;
                case "Cliente":
                    insertCliente();
                    break;
                case "Sede":
                    insertSede();
                    break;
                case "Categoria":
                    insertCategoria();
                    break;
                case "SottoCategoria":
                    insertCategoria();
                    break;
                case "Ruolo":
                    insertRuolo();
                    break;
                case "Allocazione":
                    insertAllocazione();
                    break;
                case "Responsabilità":
                    insertResponsabilita();
                    break;
            }
            initializeLabels();
        }

        /**************************** QUERY DI INSERIMENTO *************************************/
        private void insertDipendente()
        {
            using (var db = new DataModel.StudioprofessionaleDB())
            {
                DataModel.Dipendente newElem = new DataModel.Dipendente();
                newElem.Nome = textBoxNome.Text;
                newElem.Cognome = textBoxCognomeCF.Text;
                newElem.Via = textBoxVia.Text;
                newElem.Citta = textBoxCittàCosto.Text;
                newElem.CAP = textBoxCAP.Text;
                newElem.CostoOrario = Int32.Parse(textBoxCostoOrario.Text);
                newElem.CodiceRuolo = 33;//Int32.Parse(comboBoxRuolo.Text.TrimEnd(new char[] { '-', ' ' }));
                newElem.Tipo = 'c';
                if (tipo)
                {
                    newElem.Tipo = 'i';
                    newElem.Stipendio = Int32.Parse(textBoxTipo.Text);
                }

                db.Insert(newElem);
            }
        }

        private void insertCliente()
        {
            using (var db = new DataModel.StudioprofessionaleDB())
            {
                DataModel.Cliente newElem = new DataModel.Cliente();
                newElem.Nominativo = textBoxNome.Text;
                newElem.CodiceFiscale = textBoxCognomeCF.Text;
                newElem.Via = textBoxVia.Text;
                newElem.Citta = textBoxCittàCosto.Text;
                newElem.CAP = textBoxCAP.Text;
                newElem.Tipo = 'p';
                if (tipo)
                {
                    newElem.Tipo = 'a';
                    newElem.PartitaIVA = textBoxTipo.Text;
                }

                db.Insert(newElem);
            }
        }

        private void insertSede()
        {
            using (var db = new DataModel.StudioprofessionaleDB())
            {
                DataModel.Sede newElem = new DataModel.Sede();
                newElem.Nome = textBoxNome.Text;
                newElem.Via = textBoxVia.Text;
                newElem.Citta = textBoxCittàCosto.Text;
                newElem.CAP = textBoxCAP.Text;

                db.Insert(newElem);
            }
        }

        private void insertCategoria()
        {
            using (var db = new DataModel.StudioprofessionaleDB())
            {
                DataModel.Categoria newElem = new DataModel.Categoria();
                newElem.Nome = textBoxNome.Text;
                newElem.Descrizione = TextBoxDescrizione.Text;

                db.Insert(newElem);
            }
        }

        private void insertSottoCategoria()
        {
            using (var db = new DataModel.StudioprofessionaleDB())
            {
                DataModel.Sottocategoria newElem = new DataModel.Sottocategoria();
                newElem.Nome = textBoxNome.Text;
                newElem.Descrizione = TextBoxDescrizione.Text;
                newElem.CodiceCategoria = Int32.Parse(comboBoxCategoria.Text.TrimEnd(new char[] {' ', '-'}));
                newElem.TipoAZ = checkBoxAzienda.Checked;
                newElem.TipoPF = checkBoxPF.Checked;
              
                db.Insert(newElem);
            }
        }

        private void insertRuolo()
        {
            using (var db = new DataModel.StudioprofessionaleDB())
            {
                DataModel.Ruolo newElem = new DataModel.Ruolo();
                newElem.Nome = textBoxNome.Text;
                /*il codice dovrebbe essere incrementale*/

                db.Insert(newElem);
            }
        }

        private void insertAllocazione()
        {
            using (var db = new DataModel.StudioprofessionaleDB())
            {
                /*da rivedere*/
                DataModel.Allocazione newElem = new DataModel.Allocazione();
                foreach (var c in checkedListBox.CheckedItems)
                {
                    var s = c.ToString();
                    newElem.Matricola = Int32.Parse(comboBoxDipendente.Text.TrimEnd(new char[] { ' ', '-' }));
                    newElem.CodiceSede = Int32.Parse(s.TrimEnd(new char[] { ' ', '-' }));
                }
                
                db.Insert(newElem);
            }
        }

        private void insertResponsabilita()
        {
            using (var db = new DataModel.StudioprofessionaleDB())
            {
                /*da rivedere*/
                DataModel.Responsabile newElem = new DataModel.Responsabile();
                foreach (var c in checkedListBox.CheckedItems)
                {
                    var s = c.ToString();
                    newElem.CodiceFiscale = s.TrimEnd(new char[] { ' ', '-' });
                    newElem.Matricola = Int32.Parse(comboBoxDipendente.Text.TrimEnd(new char[] { ' ', '-' }));
                    newElem.DataFine = dateTimePickerResponsabilità.Value;
                }

                db.Insert(newElem);
            }
        }

    }
}
