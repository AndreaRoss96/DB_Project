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
        List<Tuple<String, String>> listCliente = new List<Tuple<String, String>>();
        public FormPerDipendente()
        {
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
            if (comboboxOperazioni.SelectedIndex == 1)
            {
                comboboxPratica.Enabled = true;
                labelPratica.Enabled = true;
                comboboxCliente.Enabled = false;
                labelCliente.Enabled = false;
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
            string codiceCliente = (string)comboboxCliente.SelectedItem;
            codiceCliente = codiceCliente.Split('-')[1];
            codiceCliente = codiceCliente.Trim(' ');
            using (var db = new DataModel.StudioprofessionaleDB())
            {
                var query =
                    (from f in db.Fases
                     join pa in db.Praticas on new { f.CodiceFiscale,f.CodicePratica } equals new { pa.CodiceFiscale,pa.CodicePratica }
                     join pe in db.Prestaziones on new { f.CodiceFiscale, f.CodicePratica,f.CodicePrestazione } equals new { pe.CodiceFiscale, pe.CodicePratica,pe.CodicePrestazione }
                      //  join pe in db.Prestaziones on f.CodiceFiscale equals pe.CodiceFiscale 
                    //   join pa in db.Praticas on pe.CodicePratica equals pa.CodicePratica
                     where f.Matricola == 3
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
                         pe.Durata,
                         pe.Pagata,
                         pe.Terminata
                     }).Distinct();
                dataGridView1.DataSource = query.ToList();
               // dataGridView1.Columns["pagata"].ReadOnly = true;
               // dataGridView1.Columns["terminata"].ReadOnly = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}