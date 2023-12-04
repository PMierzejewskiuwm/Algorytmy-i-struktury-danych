using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw6
{
    internal class DrzewoBinarne
    {
        public Węzeł3 korzeń;
        public DrzewoBinarne(int liczba)
        {
            this.korzeń = new Węzeł3(liczba);
        }
        void Add(int liczba)
        {
            Węzeł3 rodzic = this.ZnajdzRodzica(liczba);
            rodzic.Add(liczba);
        }

        private Węzeł3 ZnajdzRodzica(int liczba)
        {
            throw new NotImplementedException();
        }
        //BST
    }
}
