using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alg_dijkstry
{
    class Krawędź
    {
        public Węzeł początek;
        public Węzeł koniec;
        public int waga;

        public Krawędź(Węzeł początek, Węzeł koniec, int waga)
        {
            this.początek = początek;
            this.koniec = koniec;
            this.waga = waga;
        }
    }
}
