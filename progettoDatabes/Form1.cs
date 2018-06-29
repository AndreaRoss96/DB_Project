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
        List<Tuple<String, String>> listCliente = new List<Tuple<String, String>>();

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
                        foreach (String x in listColumn)
                        {
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

            string prova;
            string codiceFiscale;
            prova = comboboxClienteNominativo.Items[comboboxClienteNominativo.SelectedIndex].ToString();
            codiceFiscale = prova.Split('-')[1].ToString();
            codiceFiscaleSecret.Text = codiceFiscale;

        }

        private void Form1_Shown(object sender, EventArgs e)
        {

            using (var db = new DataModel.StudioprofessionaleDB())
            {
                var q =
                    from c in db.Clientes
                    select c;

                foreach (var c in q)
                    comboboxClienteNominativo.Items.Add(c.Nominativo + "-" + c.CodiceFiscale);
            }
            //queryReaderComboBox("SELECT * FROM cliente", comboboxClienteNominativo, new List<string>(new string[] { "nominativo", "codiceFiscale" }));


        }

        private void button2_Click(object sender, EventArgs e)
        {


            /*
            String query = String.Format(@"SELECT * FROM prestazione, sottocategoria WHERE prestazione.codiceSottocategoria = sottocategoria.codiceSottocategoria AND prestazione.codiceFiscale = ""{0}"";",  codiceFiscaleSecret.Text );
            queryReaderDataGridView(query, dataGridView1, new List<string>(new string[] { "nome","compenso", "durata", "pagata", "terminata"}));
            *///queryReaderComboBox("SELECT * FROM cliente WHERE clien", comboboxClienteNominativo, new List<string>(new string[] { "nominativo", "codiceFiscale" }));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var db = new DataModel.StudioprofessionaleDB())
            {
                var q =
                    (from p in db.Prestaziones
                     join s in db.Sottocategorias on p.CodiceSottocategoria equals s.CodiceSottocategoria
                     where p.CodiceFiscale == codiceFiscaleSecret.Text
                     where p.CodicePratica == dataGridView1["codicePratica", e.RowIndex].Value
                     select new
                     {
                         p.CodicePratica,
                         p.CodicePrestazione,
                         s.Nome,
                         p.Compenso,
                         p.Durata,
                         p.Pagata,
                         p.Terminata,
                     });

                dataGridView1.DataSource = q.ToList();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}