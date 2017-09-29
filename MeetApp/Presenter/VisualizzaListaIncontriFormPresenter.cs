using MeetApp.Model;
using MeetApp.View;
using System.Windows.Forms;

namespace MeetApp.Presenter
{
    public class VisualizzaListaIncontriPresenter : Presenter
    {
        private VisualizzaListaIncontriForm visualizzaListaIncontriForm;
        private GestionePartecipantiForm gestionePartecipantiForm;
        private GestionePartecipantiPresenter gestionePartecipantiPresenter;

        public VisualizzaListaIncontriPresenter(VisualizzaListaIncontriForm visualizzaListaIncontriForm)
        {
            this.visualizzaListaIncontriForm = visualizzaListaIncontriForm;
            visualizzaListaIncontriForm.ButtonGestione.Click += ButtonGestione_Click;
            visualizzaListaIncontriForm.Load += VisualizzaListaIncontriForm_Load;
        }

        private void VisualizzaListaIncontriForm_Load(object sender, System.EventArgs e)
        {
            foreach (Incontro i in Modello.Incontri){
                visualizzaListaIncontriForm.ListBox.Items.Add(i);
            }
        }

        private void ButtonGestione_Click(object sender, System.EventArgs e)
        {
            Incontro incontro = (visualizzaListaIncontriForm.ListBox.SelectedItem as Incontro);
            if (incontro != null)
            {
                gestionePartecipantiForm = new GestionePartecipantiForm();
                gestionePartecipantiForm.MdiParent = visualizzaListaIncontriForm.MdiParent;
                gestionePartecipantiPresenter = new GestionePartecipantiPresenter(gestionePartecipantiForm, incontro);
                gestionePartecipantiPresenter.Modello = Modello;
                gestionePartecipantiForm.Show();
            }
            else
            {
                MessageBox.Show("Devi selezionare un incontro!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                visualizzaListaIncontriForm.ListBox.Focus();
                return;
            }
        }
    }
}