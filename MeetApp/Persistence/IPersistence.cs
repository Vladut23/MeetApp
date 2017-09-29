using System.Collections.Generic;

namespace MeetApp.Model
{
    public interface IPersistence
    {
        List<Incontro> GetIncontri();
        List<Partecipante> GetPossibiliPartecipanti();
        void SalvaCambiamenti(Modello modello);
    }
}