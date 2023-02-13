using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Originator
    {
        public string State { get; set; }

        public void SetState(string state)
        {
            Console.WriteLine("Originator: Setting state to " + state);
            this.State = state;
        }

        public Memento SaveState()
        {
            Console.WriteLine("Originator: Saving to Memento.");
            return new Memento(State);
        }

        public void RestoreState(Memento memento)
        {
            this.State = memento.State;
            Console.WriteLine("Originator: State after restoring from Memento: " + State);
        }
    }
}
