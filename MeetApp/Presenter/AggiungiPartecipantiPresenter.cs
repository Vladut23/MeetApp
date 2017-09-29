using MeetApp.Model;
using MeetApp.View;
using System.Collections.Generic;

namespace MeetApp.Presenter
{
    internal class AggiungiPartecipantiPresenter : Presenter
    {
        private AggiungiPartecipantiForm aggiungiPartecipantiForm;
        private Incontro incontro;

        public AggiungiPartecipantiPresenter(AggiungiPartecipantiForm aggiungiPartecipantiForm, Incontro incontro)
        {
            this.aggiungiPartecipantiForm = aggiungiPartecipantiForm;
            this.incontro = incontro;
            aggiungiPartecipantiForm.ButtonAggiungi.Click += ButtonAggiungi_Click;
            aggiungiPartecipantiForm.ButtonAnnulla.Click += ButtonAnnulla_Click;
            aggiungiPartecipantiForm.Load += AggiungiPartecipantiForm_Load;
        }

        private void AggiungiPartecipantiForm_Load(object sender, System.EventArgs e)
        {
            foreach (Partecipante p in Modello.PossibiliPartecipanti)
            {
                if (!incontro.Partecipanti.Contains(p) && !incontro.Assenti.Contains(p) && !incontro.Esclusi.ContainsKey(p))
                {
                    aggiungiPartecipantiForm.CheckedListBox.Items.Add(p);
                }
            }
        }

        private void ButtonAnnulla_Click(object sender, System.EventArgs e)
        {
            aggiungiPartecipantiForm.Close();
        }

        private void ButtonAggiungi_Click(object sender, System.EventArgs e)
        {
            List<Partecipante> partecipanti = new List<Partecipante>();
            foreach (object itemChecked in aggiungiPartecipantiForm.CheckedListBox.CheckedItems)
            {
                partecipanti.Add(itemChecked as Partecipante);
            }

            foreach(Partecipante p in partecipanti)
                incontro.Partecipanti.Add(p);

            aggiungiPartecipantiForm.Close();
        }
    }
}