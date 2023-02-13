using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            originator.SetState("State1");
            originator.SetState("State2");
            Caretaker caretaker = new Caretaker();
            caretaker.Memento = originator.SaveState();
            originator.SetState("State3");
            originator.RestoreState(caretaker.Memento);
            Console.ReadKey();
        }
    }
}
