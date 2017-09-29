using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetApp.Model
{
    public class Modello
    {
        private IPersistence persistence;
        private List<Incontro> incontri;
        private List<Partecipante> possibiliPartecipanti;  // Esempio: lista di tutti i lavoratori di un azienda
                                                                    // lista di tutti i studenti di una scuola
        public Modello(IPersistence persistence)
        {
            this.persistence = persistence;
            Incontri = persistence.GetIncontri();
            PossibiliPartecipanti = persistence.GetPossibiliPartecipanti();
        }

        public List<Incontro> Incontri { get => incontri; set => incontri = value; }
        public List<Partecipante> PossibiliPartecipanti { get => possibiliPartecipanti; set => possibiliPartecipanti = value; }
        public void SalvaCambiamenti()
        {
            persistence.SalvaCambiamenti(this);
        }
    }
}
