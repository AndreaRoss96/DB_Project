using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progettoDatabes
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new Form2());
           // Application.Run(new FormPerDipendente());
          //  Application.Run(new Form1());
=======

            Application.Run(new FormInserimentiAmministratore());
>>>>>>> a04ac0702f82a0e86da7a6295927bbd4e4f28ae8
        }
    }
}
