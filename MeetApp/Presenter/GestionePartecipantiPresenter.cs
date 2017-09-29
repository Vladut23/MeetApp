using MeetApp.Model;
using MeetApp.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MeetApp.Presenter
{
    public class GestionePartecipantiPresenter: Presenter
    {
        private GestionePartecipantiForm gestionePartecipantiForm;
        private AggiungiPartecipantiForm aggiungiPartecipantiForm;
        private AggiungiPartecipantiPresenter aggiungiPartecipantiPresenter;
        private Incontro incontro;

        public GestionePartecipantiPresenter(GestionePartecipantiForm gestionePartecipantiForm, Incontro incontro)
        {
            this.gestionePartecipantiForm = gestionePartecipantiForm;
            this.incontro = incontro;

            gestionePartecipantiForm.Load += GestionePartecipantiForm_Load;
            gestionePartecipantiForm.ButtonBack.Click += ButtonBack_Click;
            gestionePartecipantiForm.ButtonEscludi.Click += ButtonEscludi_Click;
            gestionePartecipantiForm.ButtonAssenza.Click += ButtonAssenza_Click;
            gestionePartecipantiForm.ButtonRimuovi.Click += ButtonRimuovi_Click;
            gestionePartecipantiForm.ButtonAggiungi.Click += ButtonAggiungi_Click;
        }

        private void GestionePartecipantiForm_Load(object sender, System.EventArgs e)
        {
            gestionePartecipantiForm.LabelIncontro.Text = incontro.ToString();

            gestionePartecipantiForm.ListBoxPartecipanti.Items.Clear();
            foreach (Partecipante p in incontro.Partecipanti)
                gestionePartecipantiForm.ListBoxPartecipanti.Items.Add(p);

            gestionePartecipantiForm.ListBoxAssenti.Items.Clear();
            foreach (Partecipante p in incontro.Assenti)
                gestionePartecipantiForm.ListBoxAssenti.Items.Add(p);

            gestionePartecipantiForm.ListBoxEsclusi.Items.Clear();
            foreach (KeyValuePair<Partecipante, DateTime> kvp in incontro.Esclusi)
                gestionePartecipantiForm.ListBoxEsclusi.Items.Add(kvp);
        }

        private void ButtonAggiungi_Click(object sender, EventArgs e)
        {
            aggiungiPartecipantiForm = new AggiungiPartecipantiForm();
            aggiungiPartecipantiForm.MdiParent = gestionePartecipantiForm.MdiParent;
            aggiungiPartecipantiPresenter = new AggiungiPartecipantiPresenter(aggiungiPartecipantiForm, incontro);
            aggiungiPartecipantiPresenter.Modello = Modello;
            aggiungiPartecipantiForm.FormClosing += AggiungiPartecipantiForm_FormClosing;
            aggiungiPartecipantiForm.Show();
        }

        private void AggiungiPartecipantiForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GestionePartecipantiForm_Load(this, new EventArgs());
        }

        private void ButtonRimuovi_Click(object sender, EventArgs e)
        {
            if (gestionePartecipantiForm.ListBoxPartecipanti.SelectedItems.Count != 0)
            {
                foreach (object itemSelected in gestionePartecipantiForm.ListBoxPartecipanti.SelectedItems)
                {
                    incontro.Partecipanti.Remove(itemSelected as Partecipante);
                }
                GestionePartecipantiForm_Load(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Devi selezionare almeno un partecipante!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gestionePartecipantiForm.ListBoxPartecipanti.Focus();
                return;
            }
        }

        private void ButtonAssenza_Click(object sender, System.EventArgs e)
        {
            if (gestionePartecipantiForm.ListBoxPartecipanti.SelectedItems.Count != 0)
            {
                foreach (object itemSelected in gestionePartecipantiForm.ListBoxPartecipanti.SelectedItems)
                {
                    incontro.Assenti.Add(itemSelected as Partecipante);
                    incontro.Partecipanti.Remove(itemSelected as Partecipante);
                }
                GestionePartecipantiForm_Load(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Devi selezionare almeno un partecipante!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gestionePartecipantiForm.ListBoxPartecipanti.Focus();
                return;
            }
        }

        private void ButtonEscludi_Click(object sender, System.EventArgs e)
        {
            if (gestionePartecipantiForm.ListBoxPartecipanti.SelectedItems.Count != 0)
            {
                foreach (object itemSelected in gestionePartecipantiForm.ListBoxPartecipanti.SelectedItems)
            {
                incontro.Esclusi.Add((itemSelected as Partecipante), DateTime.Now);
                incontro.Partecipanti.Remove(itemSelected as Partecipante);
            }
            GestionePartecipantiForm_Load(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Devi selezionare almeno un partecipante!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gestionePartecipantiForm.ListBoxPartecipanti.Focus();
                return;
            }
        }

        private void ButtonBack_Click(object sender, System.EventArgs e)
        {
            gestionePartecipantiForm.Close();
        }
    }
}