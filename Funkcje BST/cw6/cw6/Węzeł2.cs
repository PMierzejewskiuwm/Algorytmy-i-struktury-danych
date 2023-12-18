using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw6
{
    internal class Węzeł2
    {
        public int wartosc;
        public List<Węzeł2> sasiedzi = new List<Węzeł2>();
        public Węzeł2(int liczba)
        {
            this.wartosc = liczba;
        }
    }
}
