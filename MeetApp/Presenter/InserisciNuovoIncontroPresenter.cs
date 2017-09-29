using MeetApp.Model;
using MeetApp.View;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MeetApp.Presenter
{
    public class InserisciNuovoIncontroPresenter : Presenter
    {
        private InserisciNuovoIncontroForm inserisciNuovoIncontroForm;

        public InserisciNuovoIncontroPresenter(InserisciNuovoIncontroForm inserisciNuovoIncontroForm)
        {
            this.inserisciNuovoIncontroForm = inserisciNuovoIncontroForm;
            inserisciNuovoIncontroForm.ButtonInserisci.Click += ButtonInserisci_Click;
            inserisciNuovoIncontroForm.ButtonAnnulla.Click += ButtonAnnulla_Click;
            inserisciNuovoIncontroForm.Load += InserisciNuovoIncontroForm_Load;
        }

        private void InserisciNuovoIncontroForm_Load(object sender, System.EventArgs e)
        {
            foreach (Partecipante p in Modello.PossibiliPartecipanti) { 
                inserisciNuovoIncontroForm.CheckedListBox.Items.Add(p);
            }
        }

        private void ButtonAnnulla_Click(object sender, System.EventArgs e)
        {
            inserisciNuovoIncontroForm.Close();
        }

        private void ButtonInserisci_Click(object sender, System.EventArgs e)
        {
            string descrizione = inserisciNuovoIncontroForm.TextBoxDescrizione.Text;
            DateTime data = inserisciNuovoIncontroForm.DateTimePicker.Value.Date;
            string ora = inserisciNuovoIncontroForm.TextBoxOra.Text;
            if (!Regex.Match(ora, @"^[0-2][0-9]:[0-5][0-9]$").Success)
            {
                MessageBox.Show("Ora non valida!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inserisciNuovoIncontroForm.TextBoxOra.Focus();
                return;
            }
            string luogo = inserisciNuovoIncontroForm.TextBoxLuogo.Text;
            List<Partecipante> partecipanti = new List<Partecipante>();
            foreach (object itemChecked in inserisciNuovoIncontroForm.CheckedListBox.CheckedItems)
            {
                partecipanti.Add(itemChecked as Partecipante);
            }

            Incontro incontro = new Incontro(descrizione, data, ora, luogo);
            incontro.Partecipanti = partecipanti;
            Modello.Incontri.Add(incontro);

            MessageBox.Show("Incontro Inserito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            inserisciNuovoIncontroForm.Close();
        }
    }
}