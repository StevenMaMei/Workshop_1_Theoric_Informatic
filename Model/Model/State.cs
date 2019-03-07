using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class State
    {
        char name;
        Boolean isInitial;
        Dictionary<char, char> nextStateFunction;
        Dictionary<char, char> outPutFunction;
        bool visited;

        public bool IsInitial { get => isInitial; set => isInitial = value; }
        public Dictionary<char, char> OutPutFunction { get => outPutFunction; set => outPutFunction = value; }
        public Dictionary<char, char> NextStateFunction { get => nextStateFunction; set => nextStateFunction = value; }
        public char Name { get => name; set => name = value; }
        public bool Visited { get => visited; set => visited = value; }

        public State(char n, bool isInit,List<char> inputs, List<char> outputs, List<char> states)
        {
            name = n;
            IsInitial = isInit;
            NextStateFunction = new Dictionary<char, char>();
            OutPutFunction = new Dictionary<char, char>();
            for (int i = 0; i < inputs.Count; i++)
            {
                NextStateFunction.Add(inputs[i], states[i]);
                OutPutFunction.Add(inputs[i], outputs[i]);
            }

        }



    }
}
