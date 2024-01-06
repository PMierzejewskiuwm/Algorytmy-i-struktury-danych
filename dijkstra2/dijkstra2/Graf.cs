using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dijkstra2
{
    public class Graf
    {
        public List<Węzeł> węzły;
        public List<Krawędź> krawędzie;

        public Graf()
        {
            węzły = new List<Węzeł>();
            krawędzie = new List<Krawędź>();
        }

        public void dodajWęzeł(Węzeł node)
        {
            węzły.Add(node);
        }

        public void dodajKrawędź(int waga, Węzeł poczatek, Węzeł koniec)
        {
            Krawędź krawedz = new Krawędź(waga,poczatek,koniec);
            krawędzie.Add(krawedz);
            poczatek.krawędzie.Add(krawedz);
        }
        public int MinDistance(int[] odleglosci, bool[] odwiedzone)
        {
            int min = int.MaxValue, minIndex = -1;

            for (int v = 0; v < odleglosci.Length; v++)
            {
                if (!odwiedzone[v] && odleglosci[v] <= min)
                {
                    min = odleglosci[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }
        void DisplayResult(int[] dist)
        {
            string result = "Węzeł     Odległość od początku\n";
            for (int i = 0; i < dist.Length; i++)
            {
                result += i + "\t\t" + dist[i]+"\n";
            }

            MessageBox.Show(result);
        }
        public void Dijkstra(Węzeł poczatek)
        {
            int[] odleglosci = new int[węzły.Count];
            bool[] odwiedzone = new bool[węzły.Count];

            for (int i = 0; i < węzły.Count; i++)
            {
                odleglosci[i] = int.MaxValue;
                odwiedzone[i] = false;
            }

            odleglosci[poczatek.wartosc] = 0;

            for (int count = 0; count < węzły.Count - 1; count++)
            {
                int u = MinDistance(odleglosci, odwiedzone);
                odwiedzone[u] = true;

                foreach (var krawędź in węzły[u].krawędzie)
                {
                    int v = krawędź.koniec.wartosc;

                    if (!odwiedzone[v] && odleglosci[u] != int.MaxValue && odleglosci[u] + krawędź.waga < odleglosci[v])
                    {
                        odleglosci[v] = odleglosci[u] + krawędź.waga;
                    }
                }
            }

            DisplayResult(odleglosci);
        }
    }
}
