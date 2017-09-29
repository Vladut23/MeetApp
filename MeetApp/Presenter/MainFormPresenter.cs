using MeetApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetApp.Presenter
{
    public class MainFormPresenter : Presenter
    {
        private MainForm _mainForm;

        private EstrazionePresentatoreForm estrazionePresentatoreForm;
        private InserisciNuovoIncontroForm inserisciNuovoIncontroForm;
        private VisualizzaListaIncontriForm visualizzaListaIncontriForm;

        private InserisciNuovoIncontroPresenter inserisciNuovoIncontroPresenter;
        private VisualizzaListaIncontriPresenter visualizzaListaIncontriPresenter;
        private EstrazionePresentatorePresenter estrazionePresentatorePresenter;

        public MainFormPresenter(MainForm mainForm)
        {
            _mainForm = mainForm;

            foreach (ToolStripMenuItem toolStripItem in _mainForm.MenuStrip.Items)
            {
                foreach (ToolStripMenuItem toolStripMenuItem in toolStripItem.DropDownItems)
                {
                    toolStripMenuItem.Click += OnToolStripMenuItemClick;
                }
            }   
            _mainForm.Show();
            _mainForm.Load += _mainForm_Load;
            _mainForm.FormClosing += _mainForm_FormClosing;
        }

        private void _mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modello.SalvaCambiamenti();
        }

        private void _mainForm_Load(object sender, EventArgs e)
        {
            _mainForm.VisualizzaListaIncontriToolStripMenuItem.PerformClick();
        }

        

        private void Form_Loaded(object sender, EventArgs e)
        {
            foreach (Form frm in _mainForm.MdiChildren)
            {
                if (frm != sender)
                    frm.Close();
            }
        }

        private void OnToolStripMenuItemClick(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;

            switch (toolStripMenuItem.Name)
            {
                case "inserisciNuovoIncontroToolStripMenuItem":
                    if (inserisciNuovoIncontroForm == null)
                    {
                        inserisciNuovoIncontroForm = new InserisciNuovoIncontroForm();
                        inserisciNuovoIncontroForm.MdiParent = _mainForm;
                        inserisciNuovoIncontroPresenter = new InserisciNuovoIncontroPresenter(inserisciNuovoIncontroForm);
                        inserisciNuovoIncontroPresenter.Modello = Modello;
                        inserisciNuovoIncontroForm.Load += Form_Loaded;
                        inserisciNuovoIncontroForm.FormClosed += InserisciNuovoIncontroForm_FormClosed;
                        inserisciNuovoIncontroForm.Show();
                    }
                    break;
                case "visualizzaListaIncontriToolStripMenuItem":
                    if (visualizzaListaIncontriForm == null)
                    {
                        visualizzaListaIncontriForm = new VisualizzaListaIncontriForm();
                        visualizzaListaIncontriForm.MdiParent = _mainForm;
                        visualizzaListaIncontriPresenter = new VisualizzaListaIncontriPresenter(visualizzaListaIncontriForm);
                        visualizzaListaIncontriPresenter.Modello = Modello;
                        visualizzaListaIncontriForm.Load += Form_Loaded;
                        visualizzaListaIncontriForm.FormClosed += VisualizzaListaIncontriForm_FormClosed;
                        visualizzaListaIncontriForm.Show();
                    }
                    break;
                case "estrazionePresentatoreToolStripMenuItem":
                    if (estrazionePresentatoreForm == null)
                    {
                        estrazionePresentatoreForm = new EstrazionePresentatoreForm();
                        estrazionePresentatoreForm.MdiParent = _mainForm;
                        estrazionePresentatorePresenter = new EstrazionePresentatorePresenter(estrazionePresentatoreForm);
                        estrazionePresentatorePresenter.Modello = Modello;
                        estrazionePresentatoreForm.Load += Form_Loaded;
                        estrazionePresentatoreForm.FormClosed += EstrazionePresentatoreForm_FormClosed;
                        estrazionePresentatoreForm.Show();
                    }
                    break;

            }
        }

        private void EstrazionePresentatoreForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            estrazionePresentatoreForm = null;
        }

        private void VisualizzaListaIncontriForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            visualizzaListaIncontriForm = null;
        }

        private void InserisciNuovoIncontroForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            inserisciNuovoIncontroForm = null;
        }
    }
}
