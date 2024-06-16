using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MOD4
{
    internal class DoorMachine
    {
        public enum statusPintu
        {
            terkunci, terbuka
        };

        public statusPintu state {get; private set;}

        public DoorMachine() => state = statusPintu.terkunci;

        public void bukaPintu() { 
            state = statusPintu.terbuka;
            Console.WriteLine("pintu terbuka");
        }

        public void kunciPintu() {
            state = statusPintu.terkunci;
            Console.WriteLine("pintu terkunci");
        }
    }
}
