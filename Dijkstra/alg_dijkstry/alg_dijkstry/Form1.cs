using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alg_dijkstry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graf graf = new Graf();

            
            Węzeł węzełA = new Węzeł("A");
            Węzeł węzełB = new Węzeł("B");
            Węzeł węzełC = new Węzeł("C");
            Węzeł węzełD = new Węzeł("D");
            Węzeł węzełE = new Węzeł("E");

            
            graf.DodajKrawędź(węzełA, węzełB, 2);
            graf.DodajKrawędź(węzełA, węzełC, 4);
            graf.DodajKrawędź(węzełB, węzełC, 1);
            graf.DodajKrawędź(węzełB, węzełD, 7);
            graf.DodajKrawędź(węzełC, węzełE, 3);
            graf.DodajKrawędź(węzełD, węzełE, 1);

            
            int[] wyniki = Dijkstra(graf, węzełA);

            
            for (int i = 0; i < wyniki.Length; i++)
            {
                Console.WriteLine($"Najkrótsza droga od {węzełA.wartość} do {graf.węzły[i].wartość}: {wyniki[i]}");
            }
        }
        int[] Dijkstra(Graf graf, Węzeł startowy)
        {
            int ilośćWęzłów = graf.węzły.Count;
            int[] odległości = new int[ilośćWęzłów];
            bool[] odwiedzone = new bool[ilośćWęzłów];

            
            for (int i = 0; i < ilośćWęzłów; i++)
            {
                odległości[i] = int.MaxValue;
                odwiedzone[i] = false;
            }

            
            odległości[graf.węzły.IndexOf(startowy)] = 0;

            for (int i = 0; i < ilośćWęzłów - 1; i++)
            {
                
                int minimalnaOdległość = int.MaxValue;
                int indeksMinimalnejOdległości = -1;

                for (int j = 0; j < ilośćWęzłów; j++)
                {
                    if (!odwiedzone[j] && odległości[j] < minimalnaOdległość)
                    {
                        minimalnaOdległość = odległości[j];
                        indeksMinimalnejOdległości = j;
                    }
                }

                
                odwiedzone[indeksMinimalnejOdległości] = true;

                
                for (int j = 0; j < ilośćWęzłów; j++)
                {
                    int wagaKrawędzi = ZnajdźWagęKrawędzi(graf.węzły[indeksMinimalnejOdległości], graf.węzły[j]);

                    if (!odwiedzone[j] && wagaKrawędzi != -1 &&
                        odległości[indeksMinimalnejOdległości] != int.MaxValue &&
                        odległości[indeksMinimalnejOdległości] + wagaKrawędzi < odległości[j])
                    {
                        odległości[j] = odległości[indeksMinimalnejOdległości] + wagaKrawędzi;
                    }
                }
            }

            return odległości;
        }
        int ZnajdźWagęKrawędzi(Węzeł początek, Węzeł koniec)
        {
            foreach (var krawędź in początek.Krawędzie)
            {
                if (krawędź.koniec == koniec)
                {
                    return krawędź.waga;
                }
            }
            return -1; 
        }
    }
}
