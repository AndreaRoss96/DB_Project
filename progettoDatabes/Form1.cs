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

    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost;Port=3307;database=studioprofessionale;UID=root;password=;SslMode=none";

        public DataGridView DataGridView1 { get; private set; }

        public Form1()
        {

            InitializeComponent();
        }
        public void queryReaderDataGridView(String query, DataGridView data, List<String> listColumn)
        {
            /*string delirio = "";
            bool doTrimEnd = false;
           
            if (listColumn.Count > 1)
                doTrimEnd = true;
            */
            DataTable dataT = new DataTable();
            string[] row = new string[listColumn.Count];
            int i = 0;
            foreach (String x in listColumn)
            {
                dataT.Columns.Add(x);
            }
            data.DataSource = dataT;
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                using (var command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        i = 0;
                        foreach (String column in listColumn)
                        {
                            if (!reader.IsDBNull(listColumn.IndexOf(column)))
                            {
                                row[i] = reader.GetString(column);
                            }
                            i++;
                        }
                        dataT.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex2)
            {
                // Handle any exception.
                MessageBox.Show(ex2.ToString());
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataT;
        }
        public void queryReaderComboBox(string query, ComboBox combo, List<String> listColumn)
        {
            string delirio = "";
            bool doTrimEnd = false;
            if (listColumn.Count > 1)
                doTrimEnd = true;
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                using (var command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        foreach (String x in listColumn) {
                            delirio = delirio + reader.GetString(x);
                            if (doTrimEnd)
                                delirio = delirio + " - ";
                        }

                        if (doTrimEnd)
                            delirio = delirio.TrimEnd(new char[] { '-', ' ' });

                        combo.Items.Add(delirio);
                        delirio = "";

                    }
                }
            }
            catch (Exception ex2)
            {
                // Handle any exception.
                MessageBox.Show(ex2.ToString());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(0, 0);
            /*
            string query = "SELECT * FROM cliente";
            string appogio;
            queryReaderComboBox(query, comboboxClienteNominativo,new List<string>(new string[]{"nominativo","codiceFiscale"}));
            */

        }

        private void comboboxClienteNominativo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nominativoCodiceFiscale;
            string codiceFiscale;
            nominativoCodiceFiscale = comboboxClienteNominativo.Items[comboboxClienteNominativo.SelectedIndex].ToString();
            codiceFiscale = nominativoCodiceFiscale.Split('-')[1].ToString();
            codiceFiscaleSecret.Text = codiceFiscale;
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
            }
            lblStep.Text = "Step: pratica";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DA PRATICHE -> VISUALZIZA E FILL GROUPBOX PRESTAZIONE
            if(lblStep.Text.Equals("Step: active"))
            {

            }
            else if(lblStep.Text.Equals("Step: pratica"))
            {
                using (var db = new DataModel.StudioprofessionaleDB())
                {
                    var q =
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
                             p.CodicePrestazione,
                             NomeCategoria = ca.Nome
                         }).OrderBy((x) => (x.CodicePrestazione));
                    dataGridView1.DataSource = q.ToList();
                    dataGridView1.Columns["CodicePrestazione"].Visible = false;
                    dataGridView1.Columns["NomeCategoria"].Visible = false;
                    lblStep.Text = "Step: prestazione";
                }
            }
            else if(lblStep.Text.Equals("Step: prestazione"))
            {
                comboBoxCategoria.SelectedText = dataGridView1["NomeCategoria", e.RowIndex].Value.ToString();
                numericUpDownCompenso.Value = Int32.Parse(dataGridView1["Compenso", e.RowIndex].Value.ToString());
                checkBoxPagata.Checked = (bool) dataGridView1["Pagata", e.RowIndex].Value;
                checkBoxTerminata.Checked = (bool)dataGridView1["Terminata", e.RowIndex].Value;
                textBoxDurata.Text = dataGridView1["Durata", e.RowIndex].Value.ToString();
                comboBoxSottocategoria.SelectedText = dataGridView1["Nome", e.RowIndex].Value.ToString();
            }
            

            //PRESTAZIONI -> FILL FASE
        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSottocategoria.Items.Clear();
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
    }
}