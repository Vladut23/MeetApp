using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetApp.Model
{
    public class Incontro
    {
        private string _descrizione;
        private DateTime _data;
        private string _ora;
        private string _luogo;
        private List<Partecipante> partecipanti;
        private Dictionary<Partecipante, DateTime> esclusi;
        private List<Partecipante> assenti;

        public Incontro(string descrizione, DateTime data, string ora, string luogo)
        {
            _descrizione = descrizione;
            _data = data;
            _ora = ora;
            _luogo = luogo;
            Partecipanti = new List<Partecipante>();
            Esclusi = new Dictionary<Partecipante, DateTime>();
            Assenti = new List<Partecipante>();
        }

        public string Descrizione { get => _descrizione; set => _descrizione = value; }
        public DateTime Data { get => _data; set => _data = value; }
        public string Ora { get => _ora; set => _ora = value; }
        public string Luogo { get => _luogo; set => _luogo = value; }
        public List<Partecipante> Partecipanti { get => partecipanti; set => partecipanti = value; }
        public Dictionary<Partecipante, DateTime> Esclusi { get => esclusi; set => esclusi = value; }
        public List<Partecipante> Assenti { get => assenti; set => assenti = value; }

        public override string ToString()
        {
            return Descrizione + ", " + Data.ToShortDateString() + ", " + Ora + ", " + Luogo;
        }

    }
}
