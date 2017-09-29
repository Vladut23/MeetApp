using MeetApp.Model;
using MeetApp.Presenter;
using MeetApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetApp
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
            IPersistence persistence = new XMLPersistence();
            Modello modello = new Modello(persistence);
            MainForm mainForm = new MainForm();
            MainFormPresenter mainFormPresenter = new MainFormPresenter(mainForm);
            mainFormPresenter.Modello = modello;
            Application.Run(mainForm);
        }
    }
}
