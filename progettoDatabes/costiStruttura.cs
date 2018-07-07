using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using LinqToDB.SqlQuery;
using LinqToDB;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progettoDatabes
{
    public partial class costiStruttura : Form
    {
        int dip = -1;
        Form1 mainForm = null;
        public costiStruttura(Form1 callingForm, int matricola)
        {
            dip = matricola;
            mainForm = callingForm;
            InitializeComponent();
        }

        private void costiStruttura_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxTipologia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxTipologia.SelectedItem.Equals("Materiale"))
            {
                numericUpDownQuantita.Enabled = true;
            }
            else
            {
                numericUpDownQuantita.Enabled = false;
            }
        }

        private void costiStruttura_Shown(object sender, EventArgs e)
        {
            using(var db = new DataModel.StudioprofessionaleDB())
            {
                var q = (from s in db.Sedes
                        join a in db.Allocaziones on s.CodiceSede equals a.CodiceSede
                        where a.Matricola == dip
                        select new
                        {
                            s.CodiceSede,
                            s.Nome
                        });
                q.ToList().ForEach(x => comboBoxSede.Items.Add(x.CodiceSede + "-" + x.Nome));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DataModel.StudioprofessionaleDB())
                {
                    DataModel.CostoStruttura newCosto = new DataModel.CostoStruttura();
                    newCosto.CodiceSede = Int32.Parse(comboBoxSede.SelectedItem.ToString().Substring(0, 1));
                    newCosto.DataPagamento = dateTimePickerDataPagamento.Value;
                    newCosto.Tipo = char.Parse(comboBoxTipologia.SelectedItem.ToString().Substring(0, 1));
                    if (newCosto.Tipo == 'M')
                    {
                        newCosto.Quantita = Int32.Parse(numericUpDownQuantita.Value.ToString());
                    }
                    newCosto.Costo = Int32.Parse(numericUpDownCosto.Value.ToString());
                    newCosto.Descrizione = textBoxDescrizione.Text;
                    db.Insert(newCosto);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void costiStruttura_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Visible = true;
        }
    }
}
