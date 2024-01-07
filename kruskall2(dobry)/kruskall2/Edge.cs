using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kruskall2
{
    public class Edge
    {
        public int poczatek;
        public int koniec;
        public int waga;

        public Edge(int source, int destination, int weight)
        {
            this.poczatek = source;
            this.koniec = destination;
            this.waga = weight;
        }
    }
}
