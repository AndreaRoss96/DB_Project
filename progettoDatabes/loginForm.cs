using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progettoDatabes
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new DataModel.StudioprofessionaleDB())
            {
                var q = (from account in db.Accounts
                         where account.Username == textBoxUsername.Text
                         where account.Password == textBoxPassword.Text
                         select account);
                if (q.ToList().Count != 1)
                {
                    MessageBox.Show("Username o password errati!");
                }
                else
                {
                    Form1 mainForm = new Form1(this, q.ToList().First().Matricola, q.ToList().First().Amministratore);
                    mainForm.Show();
                    textBoxPassword.Clear();
                    this.Hide();
                }


            }
        }

        private void loginForm_Shown(object sender, EventArgs e)
        {
            
        }
    }
}
