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
            var w1 = new Węzeł2(5);
            var w2 = new Węzeł2(1);
            var w3 = new Węzeł2(3);
            var w4 = new Węzeł2(2);
            var w5 = new Węzeł2(8);
            var w6 = new Węzeł2(4);
            w1.sasiedzi.Add(w3);
            w3.sasiedzi.Add(w1);
            w1.sasiedzi.Add(w2);
            w2.sasiedzi.Add(w1);
            w3.sasiedzi.Add(w6);
            w6.sasiedzi.Add(w3);
            w3.sasiedzi.Add(w4);
            w4.sasiedzi.Add(w3);
            w2.sasiedzi.Add(w5);
            w5.sasiedzi.Add(w2);
            w6.sasiedzi.Add(w5);
            w5.sasiedzi.Add(w6);


            var odwiedzoneDFS = new List<Węzeł2>();
            var odwiedzoneBFS = new List<Węzeł2>() { w1 };
            //BFS(odwiedzoneBFS);
            var d = new DrzewoBinarne(5);
            d.Add(4);
            d.Add(9);
            d.Add(5);
            d.Add(2);
            d.Add(1);
            d.Add(7);
            d.Add(8);
            d.Add(6);
            d.Add(3);
            d.Add(5);
            d.Add(10);
            d.Add(5);
            
            Węzeł3 w = d.korzeń.praweDziecko;
            MessageBox.Show(d.korzeń.praweDziecko.leweDziecko.praweDziecko.ToString());
            MessageBox.Show(d.Nastepnik(w).ToString());

        }
        
        void DFS(Węzeł2 w, List<Węzeł2> odwiedzone)
        {
            odwiedzone.Add(w);
            MessageBox.Show(w.wartosc.ToString());

            foreach (var sasiad in w.sasiedzi)
            {
                if (!odwiedzone.Contains(sasiad))
                {
                    DFS(sasiad,odwiedzone);
                }
            }
        }
        void BFS(List<Węzeł2> odwiedzone)
        {
            for(int i = 0; i < odwiedzone.Count; i++)
            {
                var odwiedzony = odwiedzone[i];
                MessageBox.Show(odwiedzony.wartosc.ToString());
                foreach(var sasiad in odwiedzony.sasiedzi)
                {
                    if (!odwiedzone.Contains(sasiad))
                    {
                        odwiedzone.Add(sasiad);
                    }
                }
            }
        }
    }
}
