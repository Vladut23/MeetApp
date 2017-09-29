using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetApp.Model
{
    public class Partecipante
    {
        private string _nome;
        private string _cognome;
        private string _email;

        public Partecipante(string nome, string cognome, string email)
        {
            _nome = nome;
            _cognome = cognome;
            _email = email;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public string Cognome { get => _cognome; set => _cognome = value; }
        public string Email { get => _email; set => _email = value; }

        public override string ToString()
        {
            return Nome + " " + Cognome + " : " + Email;
        }
    }
}
