using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace progettoDatabes
{
    
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost;Port=3307;database=studioprofessionale;UID=root;password=;SslMode=none";
        List<Tuple<String,String>> listCliente = new List<Tuple<String,String>>();
        public Form1()
        {
            
            InitializeComponent();
        }
        public void queryReaderDataGridView(string query,DataGridView data, List<String> listColumn)
        {

        }
        public void queryReaderComboBox(string query,ComboBox combo,List<String> listColumn)
        {
            string delirio="";
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
                     
                        if(doTrimEnd)
                            delirio = delirio.TrimEnd(new char[]{'-', ' '});

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
            /*
            string prova;
            string codiceFiscale;
            prova = comboboxClienteNominativo.Items[comboboxClienteNominativo.SelectedIndex].ToString();
            //codiceFiscale = prova.Split()
            codiceFiscale = prova.Split('-')[1].ToString();
            codiceFiscale = codiceFiscale.Trim(' ');
            queryReaderComboBox(String.Format("SELECT * FROM pratica where pratica.codiceFiscale=\"{0}\"", codiceFiscale), comboboxNomePratica, new List<string>(new string[] { "nome" })); 
            */
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            queryReaderComboBox(query, comboboxClienteNominativo, new List<string>(new string[] { "nominativo", "codiceFiscale" }));
            queryReaderComboBox(query, comboboxClienteNominativo, new List<string>(new string[] { "nominativo"}));
        }
    }
}
