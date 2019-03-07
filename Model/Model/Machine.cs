using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Machine
    {
        Dictionary<char, State> states;

        public Machine()
        {
            States = new Dictionary<char, State>();
        }
        internal Dictionary<char, State> States { get => states; set => states = value; }

        public void removeInaccesibleStates()
        {
            foreach (var a in states.Keys.ToList())
            {

            }
        }
    }
}
