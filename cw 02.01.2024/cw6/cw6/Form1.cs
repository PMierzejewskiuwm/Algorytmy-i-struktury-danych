using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var w0 = new Węzeł("0");
            var w1 = new Węzeł("1");
            var w2 = new Węzeł("2");
            var w3 = new Węzeł("3");
            var w4 = new Węzeł("4");
            var w5 = new Węzeł("5");
            var w6 = new Węzeł("6");
            var w7 = new Węzeł("7");

            var k1 = new Krawędź(w4,w6, 1);
            var k2 = new Krawędź(w4, w5, 2);
            var k3 = new Krawędź(w2, w7, 3);
            var k4 = new Krawędź(w0, w6, 3);
            var k5 = new Krawędź(w2, w4, 4);
            var k6 = new Krawędź(w0, w1, 5);
            var k7 = new Krawędź(w2, w6, 5);
            var k8 = new Krawędź(w1, w5, 6);
            var k9 = new Krawędź(w5, w6, 6);
            var k10 = new Krawędź(w1, w7, 7);
            var k11 = new Krawędź(w1, w4, 8);
            var k12 = new Krawędź(w3, w6, 8);
            var k13 = new Krawędź(w0, w3, 9);
            var k14 = new Krawędź(w1, w2, 9);
            var k15 = new Krawędź(w2, w3, 9);
            var k16 = new Krawędź(w6, w7, 9);

            Graf g = new Graf();
            g.węzły.Add(w0);
            g.węzły.Add(w1);
            g.węzły.Add(w2);
            g.węzły.Add(w3);
            g.węzły.Add(w4);
            g.węzły.Add(w5);
            g.węzły.Add(w6);
            g.węzły.Add(w7);

            g.krawędzie.Add(k1);
            g.krawędzie.Add(k2);
            g.krawędzie.Add(k3);
            g.krawędzie.Add(k4);
            g.krawędzie.Add(k5);
            g.krawędzie.Add(k6);
            g.krawędzie.Add(k7);
            g.krawędzie.Add(k8);
            g.krawędzie.Add(k9);
            g.krawędzie.Add(k10);
            g.krawędzie.Add(k11);
            g.krawędzie.Add(k12);
            g.krawędzie.Add(k13);
            g.krawędzie.Add(k14);
            g.krawędzie.Add(k15);
            g.krawędzie.Add(k16);


        }
        
        //1. konstruktor grafu na bazie krawedzi zrobi graf
        //2. sprawdzamy ktora z mozliwosci
        //3.liczymy liczbe wierzcholkow (czy poczatek lub koniec krawedzi jest w liscie wierzcholkow)
    }
    //minimalne drzewo rozpinajace (Algorytm Kruscala) wynikiem jest Graf 
    //jak dodajemy 2 nowe krawedzie to tworzymy nowy graf
}
