using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw6
{
    internal class Węzeł3
    {
        public int wartosc;
        public Węzeł3 rodzic;
        public Węzeł3 leweDziecko;
        public Węzeł3 praweDziecko;
        
        public Węzeł3(int liczba)
        {
            this.wartosc = liczba;
        }
        public override string ToString()
        {
            return this.wartosc.ToString();
        }

        internal void Add(int liczba)
        {
            if (liczba < this.wartosc)
            {
                if (leweDziecko == null)
                {
                    leweDziecko = new Węzeł3(liczba);
                    leweDziecko.rodzic = this;
                }
                else
                {
                    leweDziecko.Add(liczba);
                }
            }
            else
            {
                if (praweDziecko == null)
                {
                    praweDziecko = new Węzeł3(liczba);
                    praweDziecko.rodzic = this;
                }
                else
                {
                    praweDziecko.Add(liczba);
                }
            }
        }
    }
}
