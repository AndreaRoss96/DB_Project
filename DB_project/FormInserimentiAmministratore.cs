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
using LinqToDB.SqlQuery;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace progettoDatabes
{
    public partial class FormInserimentiAmministratore : Form
    {
        private string execution;
        private bool tipo;
        private Studio mainForm = null;
        private int matricola;
        public FormInserimentiAmministratore(Studio callingForm, int codiceMatricola)
        {
            mainForm = callingForm;
            matricola = codiceMatricola;
            InitializeComponent();
            this.execution = "";
            this.tipo = false;

            using (var db = new DataModel.StudioprofessionaleDB())
            {
                var queryDipendente =
                    (from d in db.Dipendentes
                     select d);

                var queryCategoria =
                    (from c in db.Categorias
                     select c);
                
                foreach (var x in queryCategoria)
                {
                    comboBoxCategoria.Items.Add(x.CodiceCategoria + " - " + x.Nome);
                }
                foreach (var x in queryDipendente)
                {
                    comboBoxDipendente.Items.Add(x.Matricola + " - " + x.Nome + " " + x.Cognome);
                }
            }
        }

        private void initializeLabels()
        {
            this.execution = " ";
            LabelNome.Enabled = false;
            LabelCognome_e_CF.Visible = false;
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

            LabelRuolo.Visible = true;
            comboBoxRuolo.Visible = true;
            LabelCognome_e_CF.Visible = true;
            comboBoxRuolo.Items.Clear();
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
            initializePersonLabels();
            LabelCognome_e_CF.Visible = true;
            LabelCostoOrario.Visible = true;
            textBoxCostoOrario.Visible = true;
            LabelStipendio.Visible = true;
            LabelStipendio.Enabled = false;
            checkBoxImpiegato.Visible = true;

            LabelRuolo.Text = "Ruolo";

            using (var db = new DataModel.StudioprofessionaleDB())
            {
                var queryRuolo =
                  (from r in db.Ruoloes
                   select r);

                foreach (var x in queryRuolo)
                {
                    comboBoxRuolo.Items.Add(x.CodiceRuolo + " - " + x.Nome);
                }
            }

            this.execution = "Dipendente";
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
            initializePersonLabels();
            LabelP_IVA.Visible = true;
            LabelP_IVA.Enabled = false;
            checkBoxAzienda.Visible = true;

            LabelRuolo.Text = "Sede";
            LabelCognome_e_CF.Text = "Codice fiscale";
            using (var db = new DataModel.StudioprofessionaleDB())
            {
                var queryRuolo =
                  (from r in db.Sedes
                   select r);

                foreach (var x in queryRuolo)
                {
                    comboBoxRuolo.Items.Add(x.CodiceSede + " - " + x.Nome);
                }
            }

            this.execution = "Cliente";
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
            initializePersonLabels();
            textBoxCognomeCF.Visible = false;
            LabelTipo.Visible = false;
            textBoxTipo.Visible = false;
            LabelRuolo.Visible = false;
            comboBoxRuolo.Visible = false;
            this.execution = "Sede";
        }

        private void buttonCategoria_Click(object sender, EventArgs e)
        {
            initializeGeneric();
            this.execution = "Categoria";
        }

        private void buttonSottCategoria_Click(object sender, EventArgs e)
        {
            initializeGeneric();
            LabelCostoFisso.Visible = true;
            textBoxCittàCosto.Visible = true;
            checkBoxAzienda.Visible = true;
            checkBoxPF.Visible = true;

            LabelCategoria.Visible = true;
            comboBoxCategoria.Visible = true;
            this.execution = "SottoCategoria";
        }

        private void buttonRuolo_Click(object sender, EventArgs e)
        {
            initializeLabels();
            LabelNome.Enabled = true;
            textBoxNome.Enabled = true;
            this.execution = "Ruolo";
        }

        private void buttonAllocazione_Click(object sender, EventArgs e)
        {
            initializeLabels();
            groupBoxAllocazione.Visible = true;
            groupBoxAllocazione.Text = "Allocazione dipendente";
            label2.Text = "Seleziona un dipendente ed una o più sedi\rdove verrà allocato.";

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
            this.execution = "Allocazione";
        }

        private void buttonResponsabilità_Click(object sender, EventArgs e)
        {
            initializeLabels();
            dateTimePickerResponsabilità.Enabled = true;
            groupBoxAllocazione.Visible = true;
            groupBoxAllocazione.Text = "Responsabilità dipendente";
            label2.Text = "Seleziona un dipendente ed uno o più clienti\rdei quali sarà responsabile.";

            using (var db = new DataModel.StudioprofessionaleDB())
            {
                /*var queryResponsabilità =
                    (from c in db.Clientes
                     from r in db.Responsabiles
                     where r.CodiceFiscale == c.CodiceFiscale
                     where (r.DataFine == null
                     || !(from r1 in db.Responsabiles
                          where r1.CodiceFiscale == c.CodiceFiscale
                          select r1.CodiceFiscale).Contains(c.CodiceFiscale))
                     group c by new { c.CodiceFiscale, c.Nominativo } into g
                     select new
                     {
                         g.Key.CodiceFiscale,
                         g.Key.Nominativo
                     });*/
                var queryResponsabilità =
               (from c in db.Clientes
                select new
                {
                    c.CodiceFiscale,
                    c.Nominativo
                });


                foreach (var x in queryResponsabilità)
                {
                    checkedListBox.Items.Add(x.Nominativo + " - " + x.CodiceFiscale);
                }
            }
            this.execution = "Responsabilità";
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
                    insertSottoCategoria();
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
                case " ":
                    MessageBox.Show("Scegli un'operazione da eseguire.");
                    break;
            }
            initializeLabels();
        }

        /**************************** QUERY DI INSERIMENTO *************************************/
        private void insertDipendente()
        {
            using (var db = new DataModel.StudioprofessionaleDB())
            {
                try
                {
                    DataModel.Dipendente newElem = new DataModel.Dipendente();
                    newElem.Matricola = matricola;
                    newElem.Nome = textBoxNome.Text;
                    newElem.Cognome = textBoxCognomeCF.Text;
                    newElem.Via = textBoxVia.Text;
                    newElem.Citta = textBoxCittàCosto.Text;
                    newElem.CAP = textBoxCAP.Text;
                    newElem.CostoOrario = Int32.Parse(textBoxCostoOrario.Text);
                    newElem.CodiceRuolo = Int32.Parse(comboBoxRuolo.Text.Split('-')[0].ToString());
                    newElem.Tipo = 'c';
                    if (tipo)
                    {
                        newElem.Tipo = 'i';
                        newElem.Stipendio = Int32.Parse(textBoxTipo.Text);
                    }
                    db.Insert(newElem);
                    MessageBox.Show("Operazione effettuata con successo");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void insertCliente()
        {
            using (var db = new DataModel.StudioprofessionaleDB())
            {
                try
                {
                    DataModel.Cliente newElem = new DataModel.Cliente();
                    newElem.Nominativo = textBoxNome.Text;
                    newElem.CodiceFiscale = textBoxCognomeCF.Text;
                    newElem.Via = textBoxVia.Text;
                    newElem.Citta = textBoxCittàCosto.Text;
                    newElem.CAP = textBoxCAP.Text;
                    newElem.CodiceSede = Int32.Parse(comboBoxRuolo.Text.Split('-')[0].ToString());
                    newElem.Tipo = 'p';
                    if (tipo)
                    {
                        newElem.Tipo = 'a';
                        newElem.PartitaIVA = textBoxTipo.Text;
                    }

                    db.Insert(newElem);
                    MessageBox.Show("Operazione effettuata con successo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void insertSede()
        {
            using (var db = new DataModel.StudioprofessionaleDB())
            {
                try
                {
                    DataModel.Sede newElem = new DataModel.Sede();
                    newElem.Nome = textBoxNome.Text;
                    newElem.Via = textBoxVia.Text;
                    newElem.Citta = textBoxCittàCosto.Text;
                    newElem.CAP = textBoxCAP.Text;

                    db.Insert(newElem);
                    MessageBox.Show("Operazione effettuata con successo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void insertCategoria()
        {
            using (var db = new DataModel.StudioprofessionaleDB())
            {
                try
                {
                    DataModel.Categoria newElem = new DataModel.Categoria();
                    newElem.Nome = textBoxNome.Text;
                    newElem.Descrizione = TextBoxDescrizione.Text;

                    db.Insert(newElem);
                    MessageBox.Show("Operazione effettuata con successo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void insertSottoCategoria()
        {
            using (var db = new DataModel.StudioprofessionaleDB())
            {
                try
                {
                    DataModel.Sottocategoria newElem = new DataModel.Sottocategoria();
                    newElem.Nome = textBoxNome.Text;
                    newElem.Descrizione = TextBoxDescrizione.Text;
                    newElem.CodiceCategoria = Int32.Parse(comboBoxCategoria.Text.Split('-')[0].ToString());
                    newElem.CostoFissoPerCliente = Int32.Parse(textBoxCittàCosto.Text);
                    newElem.TipoAZ = checkBoxAzienda.Checked;
                    newElem.TipoPF = checkBoxPF.Checked;

                    db.Insert(newElem);
                    MessageBox.Show("Operazione effettuata con successo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                }
        }

        private void insertRuolo()
        {
            using (var db = new DataModel.StudioprofessionaleDB())
            {
                try
                {
                    DataModel.Ruolo newElem = new DataModel.Ruolo();
                    newElem.Nome = textBoxNome.Text;

                    db.Insert(newElem);
                    MessageBox.Show("Operazione effettuata con successo");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void insertAllocazione()
        {
            using (var db = new DataModel.StudioprofessionaleDB())
            {
                DataModel.Allocazione newElem = new DataModel.Allocazione();
                try
                {
                    foreach (var c in checkedListBox.CheckedItems)
                    {
                        var s = c.ToString();
                        newElem.Matricola = Int32.Parse(comboBoxDipendente.Text.Split('-')[0].ToString());
                        newElem.CodiceSede = Int32.Parse(s.Split('-')[0].ToString());

                        db.Insert(newElem);
                        MessageBox.Show("Operazione effettuata con successo");
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void insertResponsabilita()
        {
            using (var db = new DataModel.StudioprofessionaleDB())
            {
                DataModel.Responsabile newElem = new DataModel.Responsabile();
                String codFiscale;

                try
                {
                    foreach (var c in checkedListBox.CheckedItems)
                    {
                        codFiscale = c.ToString().Split('-')[1].ToString().Trim(' ');

                        db.Responsabiles
                            .Where(r => r.CodiceFiscale == codFiscale)
                            .Set(p => p.DataFine, dateTimePickerResponsabilità.Value)
                            .Update();

                        newElem.CodiceFiscale = codFiscale;
                        newElem.Matricola = Int32.Parse(comboBoxDipendente.Text.Split('-')[0].ToString());
                        newElem.DataInizio = dateTimePickerResponsabilità.Value;

                        db.Insert(newElem);
                        MessageBox.Show("Operazione effettuata con successo");
                    }
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormInserimentiAmministratore_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Visible = true;
        }

        private void FormInserimentiAmministratore_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxDipendente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
