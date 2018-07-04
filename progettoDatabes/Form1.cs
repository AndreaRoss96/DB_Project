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
        //string connectionString = "Server=localhost;Port=3306;database=schemaprofessionale;UID=root;password=;SslMode=none";
        int matricola = 1;
        public DataGridView DataGridView1 { get; private set; }

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(0, 0);

        }

        private void comboboxClienteNominativo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nominativoCodiceFiscale;
            string codiceFiscale;
            try
            {
                nominativoCodiceFiscale = comboboxClienteNominativo.Items[comboboxClienteNominativo.SelectedIndex].ToString();
                codiceFiscale = nominativoCodiceFiscale.Split('-')[1].ToString();
                codiceFiscaleSecret.Text = codiceFiscale;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
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

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new DataModel.StudioprofessionaleDB())
            {
                var query =
                    (from pratica in db.Praticas
                     where pratica.CodiceFiscale == codiceFiscaleSecret.Text
                     select new
                     {
                         pratica.Nome,
                         numeroPratica = pratica.CodicePratica,
                         pratica.DataRichiesta
                     });
                dataGridView1.DataSource = query.ToList();
                lblStep.Text = "Step: pratica";
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (lblStep.Text.Equals("Step: pratica"))
            {
                int codicePratica = Int32.Parse(dataGridView1["numeroPratica", e.RowIndex].Value.ToString());
                textBoxNomePratica.Text = dataGridView1["Nome", e.RowIndex].Value.ToString();
                dateTimePickerDataPratica.Text = dataGridView1["DataRichiesta", e.RowIndex].Value.ToString().Replace('/','-');
                using (var db = new DataModel.StudioprofessionaleDB())
                {
                    var qe =
                        (from p in db.Prestaziones
                         join s in db.Sottocategorias on p.CodiceSottocategoria equals s.CodiceSottocategoria
                         join ca in db.Categorias on s.CodiceCategoria equals ca.CodiceCategoria
                         where p.CodiceFiscale == codiceFiscaleSecret.Text
                         where p.CodicePratica == Int32.Parse(dataGridView1["numeroPratica", e.RowIndex].Value.ToString())
                         select new
                         {
                             s.Nome,
                             p.Compenso,
                             p.Durata,
                             p.Pagata,
                             p.Terminata,
                             p.CodicePratica,
                             p.CodicePrestazione,
                             NomeCategoria = ca.Nome
                         }).OrderBy((x) => (x.CodicePrestazione));
                    dataGridView1.DataSource = qe.ToList();
                    dataGridView1.Columns["CodicePrestazione"].Visible = false;
                    dataGridView1.Columns["NomeCategoria"].Visible = true;
                    dataGridView1.Columns["CodicePratica"].Visible = false;
                    lblStep.Text = "Step: prestazione";
                }
               
            }
            else if (lblStep.Text.Equals("Step: prestazione"))
            {
                comboBoxCategoria.Text = dataGridView1["NomeCategoria", e.RowIndex].Value.ToString();
                numericUpDownCompenso.Value = Int32.Parse(dataGridView1["Compenso", e.RowIndex].Value.ToString());
                checkBoxPagata.Checked = (bool)dataGridView1["Pagata", e.RowIndex].Value;
                checkBoxTerminata.Checked = (bool)dataGridView1["Terminata", e.RowIndex].Value;
                textBoxDurata.Text = dataGridView1["Durata", e.RowIndex].Value.ToString();
                comboBoxSottocategoria.Text = dataGridView1["Nome", e.RowIndex].Value.ToString();
                using (var db = new DataModel.StudioprofessionaleDB())
                {
                    var q =
                        (from f in db.Fases
                         join pra in db.Praticas on f.CodicePratica equals pra.CodicePratica
                         join pres in db.Prestaziones on f.CodicePrestazione equals pres.CodicePrestazione
                         join dip in db.Dipendentes on f.Matricola equals dip.Matricola
                         where f.CodicePratica == Int32.Parse(dataGridView1["CodicePratica", e.RowIndex].Value.ToString())
                         where f.CodicePrestazione == Int32.Parse(dataGridView1["CodicePrestazione", e.RowIndex].Value.ToString())
                         select new
                         {
                             dip.Cognome,
                             f.Inizio,
                             f.Fine,
                             f.Descrizione,
                             pres.CodicePratica,
                             pres.CodicePrestazione,
                         });
                    dataGridView1.DataSource = q.ToList();
                    dataGridView1.Columns["CodicePratica"].Visible = false;
                    dataGridView1.Columns["CodicePrestazione"].Visible = false;
                    lblStep.Text = "Step: fase";
                }
            }
            else if (lblStep.Text.Equals("Step: fase"))
            {
                string data = dataGridView1["Inizio", e.RowIndex].Value.ToString().Split(' ')[0].Replace('/','-');
                string inizio = dataGridView1["Inizio", e.RowIndex].Value.ToString().Split(' ')[1];
                string fine = dataGridView1["Fine", e.RowIndex].Value.ToString().Split(' ')[1];
                dateTimeDataFase.Value = DateTime.ParseExact(data,"dd-MM-yyyy",null);
                dateTimePickerInizioFase.Text = inizio;
                dateTimePickerFineFase.Text = fine;
                textBoxDescrizioneFase.Text = dataGridView1["Descrizione", e.RowIndex].Value.ToString();

            }
        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
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
                    //SqlInsertStatement a = new SqlInsertStatement();
                    //a.IsInsert();
                   /*
                    db.Praticas
                        .Value(p => p.Nome, "ciao")
                        .Value(p => p.DataRichiesta, dateTimePickerDataPratica.Value)
                        .Insert();
                    */

                    
                    DataModel.Pratica newPratica = new DataModel.Pratica();
                    newPratica.CodiceFiscale = codiceFiscaleSecret.Text;
                    newPratica.DataRichiesta = dateTimePickerDataPratica.Value;
                    newPratica.Nome = textBoxNomePratica.Text;
                    
                    int mes = db.Insert(newPratica);
                    db.Praticas.DataContext.Insert(newPratica);
                    db.Praticas.DataContext.QueryHints.ForEach(x => MessageBox.Show(x.ToString()));         /*
                    var q =
                   (from pratica in db.Praticas
                    where pratica.CodiceFiscale == codiceFiscaleSecret.Text
                    where pratica.DataRichiesta == dateTimePickerDataPratica.Value
                    where pratica.Nome == textBoxNomePratica.Text
                    select pratica);
                    if(q.ToList().Count==1)
                    {
                        MessageBox.Show("Il record è stato inserito correttamente!");
                    }
                    else
                    {
                        MessageBox.Show("Il record non è stato inserito!");
                    }
                    */
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
               
            }
        }
        
    }
}