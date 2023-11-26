using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dfs
{
    internal class Węzeł
    {
        public int wartosc;
        public List<Węzeł> dzieci = new List<Węzeł>();
        public Węzeł(int liczba)
        {
            this.wartosc = liczba;
        }
    }
}
