using MeetApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetApp.Presenter
{
    public abstract class Presenter
    {
        private Modello _modello;

        public Modello Modello { get => _modello; set => _modello = value; }
    }
}
