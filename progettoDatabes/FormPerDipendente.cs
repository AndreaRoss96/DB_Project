using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace progettoDatabes
{
    public partial class FormPerDipendente : Form
    {
        //string connectionString = "Server=localhost;Port=3306;database=studioprofessionale;UID=root;password=;SslMode=none";
        private List<Tuple<String, String>> listCliente = new List<Tuple<String, String>>();
        private string codiceCliente = null;
        private int codicePratica=-1;
        private int matricola;
        private Studio mainForm = null;
        public FormPerDipendente(Studio callingForm, int codiceMatricola)
        {
            mainForm = callingForm;
            matricola = codiceMatricola;
            InitializeComponent();
            using (var db = new DataModel.StudioprofessionaleDB())
            {
                var queryCliente =
                    (from c in db.Clientes
                     select c);

                var queryPratica =
                    (from p in db.Praticas
                     select p);

                foreach (var x in queryCliente)
                {
                    comboboxCliente.Items.Add(x.Nominativo + " - " + x.CodiceFiscale);
                }
                foreach (var x in queryPratica)
                {
                    comboboxPratica.Items.Add(x.CodicePratica + " - " + x.Nome + " - " + x.DataRichiesta.ToShortDateString());
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboboxOperazioni_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonOperazione.Enabled = true;
            if (comboboxOperazioni.SelectedIndex == 1)
            {
                comboboxPratica.Enabled = true;
                labelPratica.Enabled = true;
                comboboxCliente.Enabled = true;
                labelCliente.Enabled = true;
            }
            else if (comboboxOperazioni.SelectedIndex == 2)
            {
                comboboxPratica.Enabled = false;
                labelPratica.Enabled = false;
                comboboxCliente.Enabled = true;
                labelCliente.Enabled = true;
            }
            else
            {
                comboboxPratica.Enabled = false;
                labelPratica.Enabled = false;
                comboboxCliente.Enabled = false;
                labelCliente.Enabled = false;
            }
        }

        private void comboboxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {   //query 20
            codiceCliente = (string)comboboxCliente.SelectedItem;
            codiceCliente = codiceCliente.Split('-')[1].Trim(' ');
        }
        private void comboboxPratica_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s;
            s = (string)comboboxPratica.SelectedItem;
            s = s.Split('-')[0].Trim(' ');
            codicePratica = int.Parse(s);
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboboxOperazioni.SelectedIndex == 0)
            {
                //query 2
                using (var db = new DataModel.StudioprofessionaleDB())
                {
                    var query =
                        (from c in db.Clientes
                         join pa in db.Praticas on c.CodiceFiscale equals pa.CodiceFiscale
                         join f in db.Fases on new { pa.CodicePratica, pa.CodiceFiscale } equals new { f.CodicePratica, f.CodiceFiscale }
                         where f.Matricola == matricola
                         select new
                         {
                             c.CodiceFiscale,
                             c.Nominativo,
                             pa.CodicePratica,
                             pa.Nome,
                             f.CodicePrestazione,
                             f.Inizio,
                             f.Fine,
                             f.Descrizione

                         });
                
                    dataGridView1.DataSource = query.ToList();
                }
            }
            else if (comboboxOperazioni.SelectedIndex == 1)
            {
                //query 3
                using (var db = new DataModel.StudioprofessionaleDB())
                {
                    var query =
                        (from p in db.Prestaziones
                         join s in db.Sottocategorias on p.CodiceSottocategoria equals s.CodiceSottocategoria
                         where p.CodicePratica == codicePratica
                         where p.CodiceFiscale == codiceCliente
                         select new
                         {
                             p.CodiceFiscale,
                             p.CodicePrestazione,
                             p.Compenso,
                             CompensoTotale = p.Compenso + s.CostoFissoPerCliente,
                             p.Pagata,
                             p.Terminata

                         });
                    dataGridView1.DataSource = query.ToList();
                }

            }
            else 
            {
                //query 20
                using (var db = new DataModel.StudioprofessionaleDB())
                {
                    var query =
                        (from f in db.Fases
                         join pa in db.Praticas on new { f.CodiceFiscale, f.CodicePratica } equals new { pa.CodiceFiscale, pa.CodicePratica }
                         join pe in db.Prestaziones on new { f.CodiceFiscale, f.CodicePratica, f.CodicePrestazione } equals new { pe.CodiceFiscale, pe.CodicePratica, pe.CodicePrestazione }
                         join s in db.Sottocategorias on pe.CodiceSottocategoria equals s.CodiceSottocategoria
                         //  join pe in db.Prestaziones on f.CodiceFiscale equals pe.CodiceFiscale 
                         //   join pa in db.Praticas on pe.CodicePratica equals pa.CodicePratica
                     where f.Matricola == matricola
                         where f.CodiceFiscale == codiceCliente
                     // where f.CodicePratica == pe.CodicePratica
                     // where pa.CodiceFiscale == pe.CodiceFiscale
                     select new
                         {
                             f.Matricola,
                             pa.Nome,
                             pa.CodicePratica,
                             pe.CodicePrestazione,
                             pe.CodiceSottocategoria,
                             pe.Compenso,
                             CompensoTotale=pe.Compenso+s.CostoFissoPerCliente,
                             pe.Durata,
                             pe.Pagata,
                             pe.Terminata
                         }).Distinct();
                    dataGridView1.DataSource = query.ToList();
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FormPerDipendente_Load(object sender, EventArgs e)
        {

        }

        private void FormPerDipendente_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Visible = true;
        }
    }
}