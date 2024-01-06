using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dijkstra2
{
    public class Węzeł
    {
        public int wartosc;
        public List<Krawędź> krawędzie;

        public Węzeł(int liczba)
        {
            this.wartosc = liczba;
            this.krawędzie = new List<Krawędź>();
        }
    }
}
