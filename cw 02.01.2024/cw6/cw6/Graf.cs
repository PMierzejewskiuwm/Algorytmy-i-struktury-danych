using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw6
{
    public class Graf
    {
        public List<Węzeł> węzły = new List<Węzeł>();
        public List<Krawędź> krawędzie = new List<Krawędź>();

        public void DodajWęzeł(Węzeł węzeł)
        {
            węzły.Add(węzeł);
        }
        public void Add(Graf g)
        {

        }
        
        public void dodajKrawędź(Węzeł początek, Węzeł koniec, int waga)
        {
            Krawędź krawędź = new Krawędź(początek, koniec, waga);
            krawędzie.Add(krawędź);
            początek.Krawędzie.Add(krawędź);
        }

        public Graf()
        {
        }

        int sprawdz(Krawędź k)
        {
            int wynik = 0;
            if (this.węzły.Contains(k.początek))
            {
                wynik++;
            }
            if (this.węzły.Contains(k.koniec))
            {
                wynik++;
            }
            return wynik;
        }
    }
}
