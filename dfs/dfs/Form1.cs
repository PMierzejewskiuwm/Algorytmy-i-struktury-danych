using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dfs
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
            var w3 = new Węzeł2(2);
            var w4 = new Węzeł2(3);
            var w5 = new Węzeł2(8);
            var w6 = new Węzeł2(4);
            w1.sasiedzi.Add(w2);
            w1.sasiedzi.Add(w3);
            w2.sasiedzi.Add(w4);
            w2.sasiedzi.Add(w5);
            w3.sasiedzi.Add(w6);

            DFS(w1);
            
        }

        void DFS(Węzeł2 w)
        {
            if (w.odwiedzony == true)
            {
                return;
            }
            w.odwiedzony = true;
            MessageBox.Show(w.wartosc.ToString());

            foreach (var dziecko in w.sasiedzi)
            {
                DFS(dziecko);
            }
        }

        void A(Węzeł w)
        {
            MessageBox.Show(w.wartosc.ToString());
            foreach (var dziecko in w.dzieci)
            {
                A(dziecko);
            }
            /* w domu
             * zrobic klase Węzeł2 (dzieci = sąsiedzi)
             * graf może zawierać cykle
             * w1.sąsiedzi.Add(w2) -> w2 jest sąsiadem w1, ale w2 nie ma zadnego sasiada
             * wykonac DFS na podanym grafie , z zajec przyklad(5,1,3,4,2,8)
            */
        }
    }
}
