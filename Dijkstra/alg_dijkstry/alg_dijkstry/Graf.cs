using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alg_dijkstry
{
    class Graf
    {
        public List<Węzeł> węzły = new List<Węzeł>();
        public List<Krawędź> krawędzie = new List<Krawędź>();

        public void DodajWęzeł(Węzeł węzeł)
        {
            węzły.Add(węzeł);
        }

        public void DodajKrawędź(Węzeł początek, Węzeł koniec, int waga)
        {
            Krawędź krawędź = new Krawędź(początek, koniec, waga);
            krawędzie.Add(krawędź);
            początek.Krawędzie.Add(krawędź);
        }
    }
}
