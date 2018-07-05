using LinqToDB.SqlQuery;
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
using System.Data.SqlClient;

namespace progettoDatabes
{
    public partial class Form2 : Form
    {
        string cs = @"server=localhost;userid=root;
                     password=;database=studioprofessionale";
        int codiceSede = -1;
        string codiceFiscale = null;
        char tipoDipendente;
        DateTime inizio=DateTime.Now;
        DateTime fine=DateTime.Now;
        public Form2()
        {
            InitializeComponent();
            disabilitaTutto();
            using (var db = new DataModel.StudioprofessionaleDB())
            {
                var querySede =
                    (from s in db.Sedes
                     select s);
                var queryCliente =
                 (from c in db.Clientes
                  select c);



                foreach (var x in querySede)
                {
                    comboBoxSede.Items.Add(x.CodiceSede + " - " + x.Nome);
                }
                foreach (var x in queryCliente)
                {
                    comboBoxCliente.Items.Add(x.CodiceFiscale + " - " + x.Nominativo);
                }

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonOperazione.Enabled = true;
            switch (comboBox.SelectedIndex)
            {
                case 1:
                    disabilitaTutto();
                    comboBoxSede.Enabled = true;
                break;
                case 5:
                    disabilitaTutto();
                    comboBoxCliente.Enabled = true;
                break;
                case 8:
                    disabilitaTutto();
                    radioButtonPF.Enabled = true;
                    radioButtonAZ.Enabled = true;
                break;
                case 9:
                    disabilitaTutto();
                    radioButtonImpiegato.Enabled = true;
                    radioButtonCollaboratore.Enabled = true;
                    radioButtonImpiegato.Checked = true;
                    dateTimePickerInizio.Enabled = false;
                    dateTimePickerFine.Enabled = false;
                    
                break;
                default:
                    disabilitaTutto();
                break;
            }
           
         
            
        }
        private void comboBoxSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s;
            s = (string)comboBoxSede.SelectedItem;
            codiceSede = Int32.Parse(s.Split('-')[0].Trim(' '));
        }
        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            codiceFiscale = (string)comboBoxCliente.SelectedItem;
            codiceFiscale = codiceFiscale.Split('-')[0].Trim(' ');
        }

        private void buttonOperazione_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {//query 19
                using (var db = new DataModel.StudioprofessionaleDB())
                {
                    var query =
                        (from s in db.Sedes
                         join c in db.Clientes on s.CodiceSede equals c.CodiceSede
                         group s by new { s.CodiceSede, s.Nome, c.Nominativo, c.Citta } into g
                         select new
                         {

                             g.Key.CodiceSede,
                             g.Key.Nome,
                             g.Key.Nominativo,
                             g.Key.Citta

                         });
                    dataGridView1.DataSource = query.ToList();
                }
            }
            else if (comboBox.SelectedIndex == 1)
            {
                //query 15
                using (var db = new DataModel.StudioprofessionaleDB())
                {
                    var query =
                        (from s in db.Sedes
                         join a in db.Allocaziones on s.CodiceSede equals a.CodiceSede
                         join d in db.Dipendentes on a.Matricola equals d.Matricola
                         join r in db.Ruoloes on d.CodiceRuolo equals r.CodiceRuolo
                         where s.CodiceSede == codiceSede
                         select new
                         {
                             Ruolo = r.Nome,
                             d.Matricola,
                             d.Nome,
                             d.Cognome,
                             d.CAP,
                             d.Citta,
                             d.Tipo,
                             d.CostoOrario,
                             d.Stipendio

                         });
                    dataGridView1.DataSource = query.ToList();
                }

            }
            else if (comboBox.SelectedIndex == 2)
            {//query 7

                using (var db = new DataModel.StudioprofessionaleDB())
                {
                    var query =
                        (from s in db.Sedes
                         join cs in db.CostoStruttura on s.CodiceSede equals cs.CodiceSede
                         group s by new { s.CodiceSede, s.Nome, cs.DataPagamento, cs.Costo, cs.Descrizione, cs.Quantita, cs.Tipo } into g
                         select new
                         {

                             g.Key.CodiceSede,
                             g.Key.Nome,
                             g.Key.DataPagamento,
                             g.Key.Costo,
                             g.Key.Descrizione,
                             g.Key.Quantita,
                             g.Key.Tipo

                         });
                    dataGridView1.DataSource = query.ToList();
                }
            }
            else if (comboBox.SelectedIndex == 3)
            { //query 6
                using (var db = new DataModel.StudioprofessionaleDB())
                {
                    var query =
                        (from r in db.Responsabiles

                         join c in db.Clientes on r.CodiceFiscale equals c.CodiceFiscale
                         join d in db.Dipendentes on r.Matricola equals d.Matricola
                         orderby c.CodiceFiscale, r.DataInizio, r.DataFine
                         group r by new { c.CodiceFiscale, c.Nominativo, d.Matricola, d.Nome, d.Cognome, r.DataInizio, r.DataFine } into g
                         select new
                         {
                             g.Key.CodiceFiscale,
                             g.Key.Nominativo,
                             g.Key.Matricola,
                             g.Key.Nome,
                             g.Key.Cognome,
                             g.Key.DataInizio,
                             g.Key.DataFine

                         }
                         );
                    dataGridView1.DataSource = query.ToList();
                }
            }
            else if (comboBox.SelectedIndex == 4)
            {//query 10

                using (var db = new DataModel.StudioprofessionaleDB())
                {
                    var query =
                        (from f in db.Fases
                         join d in db.Dipendentes on f.Matricola equals d.Matricola
                         group f by new { d.Matricola, d.Nome, d.Cognome } into g
                         orderby g.Count(), g.Key.Cognome, g.Key.Nome
                         select new
                         {
                             g.Key.Matricola,
                             g.Key.Nome,
                             g.Key.Cognome,
                             NumeroFasi = g.Count()

                         }
                         ).Take(5);
                    dataGridView1.DataSource = query.ToList();
                }
            }
            else if (comboBox.SelectedIndex == 5)
            {
                //query 8            

                using (var db = new DataModel.StudioprofessionaleDB())
                {
                    var query =
                        (from c in db.Clientes
                         join pa in db.Praticas on c.CodiceFiscale equals pa.CodiceFiscale
                         join pe in db.Prestaziones on new { pa.CodiceFiscale, pa.CodicePratica } equals new { pe.CodiceFiscale, pe.CodicePratica }
                         where c.CodiceFiscale == codiceFiscale
                         group pe by new { pe.Durata, c.CodiceFiscale, c.Nominativo, c.Tipo } into g
                         select new
                         {
                             g.Key.CodiceFiscale,
                             g.Key.Nominativo,
                             g.Key.Tipo,
                             OreDedicate = g.Key.Durata

                         }
                         );
                    var list = query.ToList();
                    var totalSpan = new TimeSpan(list.Sum(r => r.OreDedicate.Ticks));
                    MessageBox.Show(totalSpan.ToString());


                }

            }
            else if (comboBox.SelectedIndex == 6)
            {  //query 13 
                MySqlConnection connection = null;

                try
                {
                    connection = new MySqlConnection(cs);
                    connection.Open();

                    string stm = "SELECT codiceFiscale, codicePratica, codicePrestazione, durata FROM PRESTAZIONE where TIME_TO_SEC(durata) > (select AVG(TIME_TO_SEC(durata)) from PRESTAZIONE) group by codiceFiscale,codicePratica,codicePrestazione,durata";
                    var mySqlDataAdapter = new MySqlDataAdapter(stm, connection);
                    DataSet DS = new DataSet();
                    mySqlDataAdapter.Fill(DS);
                    dataGridView1.DataSource = DS.Tables[0];

                }
                catch (MySqlException ex)
                {


                }
                finally
                {

                    if (connection != null)
                    {
                        connection.Close();
                    }

                }

            }
            else if (comboBox.SelectedIndex == 7)
            {//query 14

                using (var db = new DataModel.StudioprofessionaleDB())
                {



                    var query =
                        (from a in db.Allocaziones
                         join s in db.Sedes on a.CodiceSede equals s.CodiceSede
                         join d in db.Dipendentes on a.Matricola equals d.Matricola
                         select new
                         {
                             d.Matricola,
                             d.Nome,
                             d.Cognome,
                             NomeSede = s.Nome
                         }
                         );

                    dataGridView1.DataSource = query.ToList();

                }


            }
            else if (comboBox.SelectedIndex == 8)
            {
                //query 17
                using (var db = new DataModel.StudioprofessionaleDB())
                {
                    char tipoCliente;
                    if (radioButtonPF.Checked == true)
                    {
                        tipoCliente = 'P';
                    }
                    else
                    {
                        tipoCliente = 'A';
                    }


                    var query =
                        (from c in db.Clientes
                         where c.Tipo == tipoCliente
                         select c
                         );

                    dataGridView1.DataSource = query.ToList();

                }
            }
            else if (comboBox.SelectedIndex == 9)
            {
                //query 18
                if (radioButtonImpiegato.Checked == true)
                {

                    tipoDipendente = 'I';
                    using (var db = new DataModel.StudioprofessionaleDB())
                    {
                        var query = (
                            from d in db.Dipendentes
                            where d.Tipo == tipoDipendente
                            select new
                            {
                                d.Matricola,
                                d.Nome,
                                d.Cognome,
                                d.Stipendio
                            }
                            );
                        dataGridView1.DataSource = query.ToList();

                    }
                }
                else
                {
                    tipoDipendente = 'C';
                    if (inizio > fine)
                    {
                        MessageBox.Show("Errore data");
                    }
                    else
                    {
                        MySqlConnection connection = null;

                        try
                        {
                            connection = new MySqlConnection(cs);
                            connection.Open();

                           //  string stm = "SELECT distinct d.matricola, nome, cognome,(costoOrario/60) * (SELECT(SUM(TIMESTAMPDIFF(MINUTE, inizio, fine)))FROM DIPENDENTE D1, FASE F1 WHERE D.matricola = D1.matricola AND F.matricola = F1.matricola  AND F1.inizio >=@A AND F1.fine <=@B) AS stipendio from dipendente d,fase f where tipo IN('C') and f.matricola = d.matricola";
                            string stm = "SELECT distinct d.matricola, nome, cognome,(costoOrario / 60) * (SELECT(SUM(TIMESTAMPDIFF(MINUTE, inizio, fine)))FROM DIPENDENTE D1, FASE F1 WHERE D.matricola = D1.matricola AND F.matricola = F1.matricola  AND F1.inizio >='" + inizio.ToString("yyyy-MM-dd")+"' AND F1.fine <='"+ fine.ToString("yyyy-MM-dd")+"' )AS stipendio from dipendente d,fase f where tipo IN('C') and f.matricola = d.matricola";
                           // MySqlCommand cmd = new MySqlCommand(stm,connection);
                         //  cmd.Parameters.AddWithValue("@A","'"+inizio.ToString("yyyy-MM-dd")+"'");
                           //   cmd.Parameters.AddWithValue("@B", "'"+fine.ToString("yyyy-MM-dd") + "'");
                          //  MessageBox.Show(cmd.Parameters.ToString());
                          //  var mySqlDataAdapter = new MySqlDataAdapter(cmd);
                            var mySqlDataAdapter = new MySqlDataAdapter(stm,connection);
                            DataSet DS = new DataSet();
                            mySqlDataAdapter.Fill(DS);
                            dataGridView1.DataSource = DS.Tables[0];
                            dataGridView1.ReadOnly = true;
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show(ex.Message.ToString());

                        }
                        finally
                        {

                            if (connection != null)
                            {
                                connection.Close();
                            }

                        }
                    }
                }
            }
            else if (comboBox.SelectedIndex == 10)
            {
                //query 16
                using (var db = new DataModel.StudioprofessionaleDB())
                {/*
                    Visualizzare i dipendenti e le relative responsabilità nel tempo,visualizzando anche chi non le ha mai avute
                    select d.matricola,d.nome,d.cognome,d.tipo,cliente.codiceFiscale,cliente.nominativo,responsabile.dataInizio,responsabile.dataFine from Dipendente d
left join responsabile on d.matricola = responsabile.matricola
left join cliente on responsabile.codiceFiscale = cliente.codiceFiscale
group by d.matricola,d.nome,d.cognome,d.tipo,cliente.codiceFiscale,cliente.nominativo,responsabile.dataInizio,responsabile.dataFine
order by d.matricola,responsabile.dataInizio desc*/
                    var query = (
                        from d in db.Dipendentes
                        join r in db.Responsabiles on d.Matricola equals r.Matricola into j1
                        from r in j1.DefaultIfEmpty()
                        join c in db.Clientes on r.CodiceFiscale equals c.CodiceFiscale into j2
                        from c in j2.DefaultIfEmpty()
                        group c by new { d.Matricola, d.Nome, d.Cognome, d.Tipo, c.CodiceFiscale, c.Nominativo, r.DataInizio, r.DataFine } into g
                        orderby g.Key.Matricola ascending, g.Key.DataInizio descending
                        select new
                        {
                            g.Key.Matricola,
                            g.Key.Nome,
                            g.Key.Cognome,
                            g.Key.Tipo,
                            g.Key.CodiceFiscale,
                            g.Key.Nominativo,
                            g.Key.DataInizio,
                            g.Key.DataFine
                        }
                        );
                    dataGridView1.DataSource = query.ToList();

                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerInizio_ValueChanged(object sender, EventArgs e)
        {
            inizio = dateTimePickerInizio.Value;
        }

        private void dateTimePickerFine_ValueChanged(object sender, EventArgs e)
        {
                fine = dateTimePickerFine.Value;  
        }
        private void disabilitaTutto()
        {
            comboBoxSede.Enabled = false;
            comboBoxCliente.Enabled = false;
            radioButtonAZ.Enabled = false;
            radioButtonPF.Enabled = false;
            radioButtonImpiegato.Enabled = false;
            radioButtonCollaboratore.Enabled = false;
            dateTimePickerInizio.Enabled = false;
            dateTimePickerFine.Enabled = false;
        }

        private void radioButtonCollaboratore_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerInizio.Enabled = true;
            dateTimePickerFine.Enabled = true;
        }

        private void radioButtonImpiegato_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerInizio.Enabled = false;
            dateTimePickerFine.Enabled = false;
        }

      
    }
}
