using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace progettoDatabes
{
    public partial class FormPerDipendente : Form
    {
        string connectionString = "Server=localhost;Port=3307;database=studioprofessionale;UID=root;password=;SslMode=none";
        List<Tuple<String, String>> listCliente = new List<Tuple<String, String>>();
        public FormPerDipendente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            string query = "SELECT nominativo, codiceFiscale FROM cliente";
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                using (var command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        comboboxCliente.Items.Add(reader.GetString("nominativo") + " - " + reader.GetString("codiceFiscale"));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboboxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
