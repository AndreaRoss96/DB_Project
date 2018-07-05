using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using LinqToDB;
using LinqToDB.SqlQuery;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace progettoDatabes
{
    

    public partial class Form1 : Form
    {
        string codiceFiscaleSelected;
        int codicePraticaSelected;
        int codicePrestazioneSelected;
        int matricola = 1;

        public Form1()
        {

            InitializeComponent();
        }

        public void emptyValuesIntoGroupBox(GroupBox gb)
        {
            foreach(Control c in gb.Controls)
            {
                if(c is TextBox)
                {
                    if(c.Name.Contains("Durata"))
                    {
                        c.Text = "00:00";
                    }
                    else
                    {
                        c.ResetText();
                    }
                }
                else if(c is NumericUpDown)
                {
                    ((NumericUpDown) c).Value = 0;
                }
                else if(c is DateTimePicker)
                {
                    ((DateTimePicker)c).Value = (DateTime.Today);
                }
                else if(c is ComboBox)
                {
                    c.ResetText();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(0, 0);

        }

        private void comboboxClienteNominativo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            try
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                using (var db = new DataModel.StudioprofessionaleDB())
                {
                    var queryCliente =
                        (from c in db.Clientes
                         select new
                         {
                             c.Nominativo,
                             c.CodiceFiscale
                         });

                    var queryCategoria =
                       (from c in db.Categorias
                        select new
                        {
                            c.CodiceCategoria,
                            c.Nome
                        }).OrderBy(x => x.CodiceCategoria);

                    foreach (var c in queryCliente)
                        comboboxClienteNominativo.Items.Add(c.Nominativo + "-" + c.CodiceFiscale);

                    foreach (var ca in queryCategoria)
                        comboBoxCategoria.Items.Add(ca.Nome);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nominativoCodiceFiscale;
            try
            {
                emptyValuesIntoGroupBox(groupBox2);
                emptyValuesIntoGroupBox(groupBox3);
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                nominativoCodiceFiscale = comboboxClienteNominativo.Items[comboboxClienteNominativo.SelectedIndex].ToString();
                codiceFiscaleSelected = nominativoCodiceFiscale.Split('-')[1].ToString();
                using (var db = new DataModel.StudioprofessionaleDB())
                {
                    var query =
                        (from pratica in db.Praticas
                         where pratica.CodiceFiscale == codiceFiscaleSelected
                         select new
                         {
                             pratica.Nome,
                             numeroPratica = pratica.CodicePratica,
                             pratica.DataRichiesta
                         });
                    dataGridView1.DataSource = query.ToList();
                    lblStep.Text = "Step: pratica";
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                if (lblStep.Text.Equals("Step: pratica"))
                {
                    
                    int codicePratica = Int32.Parse(dataGridView1["numeroPratica", e.RowIndex].Value.ToString());
                    codicePraticaSelected = codicePratica;
                    textBoxNomePratica.Text = dataGridView1["Nome", e.RowIndex].Value.ToString();
                    dateTimePickerDataPratica.Text = dataGridView1["DataRichiesta", e.RowIndex].Value.ToString().Replace('/', '-');
                    using (var db = new DataModel.StudioprofessionaleDB())
                    {
                        var qe =
                            (from p in db.Prestaziones
                             join s in db.Sottocategorias on p.CodiceSottocategoria equals s.CodiceSottocategoria
                             join ca in db.Categorias on s.CodiceCategoria equals ca.CodiceCategoria
                             where p.CodiceFiscale == codiceFiscaleSelected
                             where p.CodicePratica == codicePraticaSelected
                             select new
                             {
                                 s.Nome,
                                 p.Compenso,
                                 p.Durata,
                                 p.Pagata,
                                 p.Terminata,
                                 p.CodicePrestazione,
                                 NomeCategoria = ca.Nome
                             }).OrderBy((x) => (x.CodicePrestazione));
                        dataGridView1.DataSource = qe.ToList();
                        dataGridView1.Columns["CodicePrestazione"].Visible = false;
                        dataGridView1.Columns["NomeCategoria"].Visible = true;
                        lblStep.Text = "Step: prestazione";
                        groupBox2.Enabled = true;
                    }

                }
                else if (lblStep.Text.Equals("Step: prestazione"))
                {
                    comboBoxCategoria.Text = dataGridView1["NomeCategoria", e.RowIndex].Value.ToString();
                    numericUpDownCompenso.Value = Int32.Parse(dataGridView1["Compenso", e.RowIndex].Value.ToString());
                    checkBoxPagata.Checked = (bool)dataGridView1["Pagata", e.RowIndex].Value;
                    checkBoxTerminata.Checked = (bool)dataGridView1["Terminata", e.RowIndex].Value;
                    textBoxDurata.Text = dataGridView1["Durata", e.RowIndex].Value.ToString().Substring(0,5);
                    comboBoxSottocategoria.Text = dataGridView1["Nome", e.RowIndex].Value.ToString();
                    codicePrestazioneSelected = Int32.Parse(dataGridView1["CodicePrestazione", e.RowIndex].Value.ToString());
                    using (var db = new DataModel.StudioprofessionaleDB())
                    {
                        var q =
                            (from f in db.Fases
                             join dip in db.Dipendentes on f.Matricola equals dip.Matricola
                             where f.CodiceFiscale == codiceFiscaleSelected
                             where f.CodicePratica == codicePraticaSelected
                             where f.CodicePrestazione == codicePrestazioneSelected
                             select new
                             {
                                 dip.Cognome,
                                 f.Inizio,
                                 f.Fine,
                                 f.Descrizione,
                             });
                        dataGridView1.DataSource = q.ToList();
                        lblStep.Text = "Step: fase";
                        groupBox3.Enabled = true;
                    }
                }
                else if (lblStep.Text.Equals("Step: fase"))
                {
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = true;
                    string data = dataGridView1["Inizio", e.RowIndex].Value.ToString().Split(' ')[0].Replace('/', '-');
                    string inizio = dataGridView1["Inizio", e.RowIndex].Value.ToString().Split(' ')[1];
                    string fine = dataGridView1["Fine", e.RowIndex].Value.ToString().Split(' ')[1];
                    dateTimeDataFase.Value = DateTime.ParseExact(data, "dd-MM-yyyy", null);
                    dateTimePickerInizioFase.Text = inizio;
                    dateTimePickerFineFase.Text = fine;
                    textBoxDescrizioneFase.Text = dataGridView1["Descrizione", e.RowIndex].Value.ToString();

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                comboBoxSottocategoria.Items.Clear();
                comboBoxSottocategoria.Text = "";
                using (var db = new DataModel.StudioprofessionaleDB())
                {
                    var querySottocategoria =
                        (from sc in db.Sottocategorias
                         join ca in db.Categorias on sc.CodiceCategoria equals ca.CodiceCategoria
                         where sc.CodiceCategoria == comboBoxCategoria.SelectedIndex + 1
                         select new
                         {
                             Attivita = sc.Nome,
                             sc.CodiceSottocategoria
                         }).OrderBy(x => x.CodiceSottocategoria);

                    foreach (var x in querySottocategoria)
                    {
                        comboBoxSottocategoria.Items.Add(x.Attivita);
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePickerDataPratica_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var db = new DataModel.StudioprofessionaleDB())
            {
                try
                { 
                    DataModel.Pratica newPratica = new DataModel.Pratica();
                    newPratica.CodiceFiscale = codiceFiscaleSelected;
                    newPratica.DataRichiesta = dateTimePickerDataPratica.Value;
                    newPratica.Nome = textBoxNomePratica.Text;
                    
                    db.Insert(newPratica);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int codiceSottocategoria;
            using (var db = new DataModel.StudioprofessionaleDB())
            {
                try
                {
                    //ottengo il codice della sottocategoria tramite query
                    var querySottocategoria =
                             (from sc in db.Sottocategorias
                              where sc.Nome == comboBoxSottocategoria.Text
                              select new
                              {
                                  sc.CodiceSottocategoria
                              });

                    codiceSottocategoria = querySottocategoria.ToList().First().CodiceSottocategoria;

                    DataModel.Prestazione newPrestazione = new DataModel.Prestazione();
                    
                    newPrestazione.CodiceFiscale = codiceFiscaleSelected;
                    newPrestazione.CodicePratica = codicePraticaSelected;
                    newPrestazione.CodiceSottocategoria = codiceSottocategoria;
                    newPrestazione.Pagata = checkBoxPagata.Checked;
                    newPrestazione.Terminata = checkBoxTerminata.Checked;
                    newPrestazione.Durata = TimeSpan.ParseExact(textBoxDurata.Text,"hh\\:mm",null);
                    newPrestazione.Compenso = float.Parse(numericUpDownCompenso.Value.ToString());
                    db.Insert(newPrestazione);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            using (var db = new DataModel.StudioprofessionaleDB())
            {
                try
                {
                    DataModel.Fase newFase = new DataModel.Fase();

                    newFase.CodiceFiscale = codiceFiscaleSelected;
                    newFase.CodicePratica = codicePraticaSelected;
                    newFase.CodicePrestazione = codicePrestazioneSelected;
                    newFase.Descrizione = textBoxDescrizioneFase.Text;
                    newFase.Matricola = matricola;
                    newFase.Inizio = DateTime.ParseExact(dateTimeDataFase.Value + " " + dateTimePickerInizioFase.Value, "dd\\-MM\\-yyyy hh\\:mm", null);
                    newFase.Fine = DateTime.ParseExact(dateTimeDataFase.Value + " " + dateTimePickerFineFase.Value, "dd\\-MM\\-yyyy hh\\:mm", null);

                    db.Insert(newFase);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}