using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dijkstra2
{
    public class Krawędź
    {
        public int waga;
        public Węzeł poczatek;
        public Węzeł koniec;

        public Krawędź(int waga, Węzeł poczatek, Węzeł koniec)
        {
            this.waga = waga;
            this.poczatek = poczatek;
            this.koniec = koniec;
        }
    }
}
