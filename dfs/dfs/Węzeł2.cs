using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dfs
{
    internal class Węzeł2
    {
        public int wartosc;
        public bool odwiedzony = false;
        public List<Węzeł2> sasiedzi = new List<Węzeł2>();
        public Węzeł2(int liczba)
        {
            this.wartosc = liczba;
        }
    }
}
