using MeetApp.Model;
using MeetApp.View;
using System;
using System.Windows.Forms;

namespace MeetApp.Presenter
{
    public class EstrazionePresentatorePresenter : Presenter
    {
        private EstrazionePresentatoreForm estrazionePresentatoreForm;

        public EstrazionePresentatorePresenter(EstrazionePresentatoreForm estrazionePresentatoreForm)
        {
            this.estrazionePresentatoreForm = estrazionePresentatoreForm;

            estrazionePresentatoreForm.Load += EstrazionePresentatoreForm_Load;
            estrazionePresentatoreForm.ButtonAnnulla.Click += ButtonAnnulla_Click;
            estrazionePresentatoreForm.ButtonEstrazione.Click += ButtonEstrazione_Click;
        }

        private void ButtonEstrazione_Click(object sender, System.EventArgs e)
        {
            Incontro incontro = (estrazionePresentatoreForm.ListBox.SelectedItem as Incontro);
            if(incontro != null)
            {
                Random rnd = new Random();
                int rndnumber = rnd.Next(0, incontro.Partecipanti.Count);
                Partecipante partecipante = incontro.Partecipanti[rndnumber];
                estrazionePresentatoreForm.LabelPresentatore.Text = partecipante.Nome + " " + partecipante.Cognome;
            }
            else
            {
                MessageBox.Show("Devi selezionare un incontro!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                estrazionePresentatoreForm.ListBox.Focus();
                return;
            }
        }

        private void ButtonAnnulla_Click(object sender, System.EventArgs e)
        {
            estrazionePresentatoreForm.Close();
        }

        private void EstrazionePresentatoreForm_Load(object sender, System.EventArgs e)
        {
            foreach (Incontro i in Modello.Incontri)
                estrazionePresentatoreForm.ListBox.Items.Add(i);
        }
    }
}