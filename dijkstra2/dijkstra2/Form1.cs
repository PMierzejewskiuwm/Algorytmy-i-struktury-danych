using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dijkstra2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graf graph = new Graf();

            for (int i = 0; i < 6; i++)
            {
                graph.dodajWęzeł(new Węzeł(i));
            }

            graph.dodajKrawędź(3, graph.węzły[0], graph.węzły[1]);
            graph.dodajKrawędź(3, graph.węzły[0], graph.węzły[4]);
            graph.dodajKrawędź(6, graph.węzły[0], graph.węzły[5]);
            graph.dodajKrawędź(1, graph.węzły[1], graph.węzły[2]);
            graph.dodajKrawędź(4, graph.węzły[1], graph.węzły[3]);
            graph.dodajKrawędź(3, graph.węzły[2], graph.węzły[3]);
            graph.dodajKrawędź(1, graph.węzły[2], graph.węzły[5]);
            graph.dodajKrawędź(1, graph.węzły[5], graph.węzły[3]);
            graph.dodajKrawędź(2, graph.węzły[4], graph.węzły[5]);
            
            
            graph.Dijkstra(graph.węzły[0]);

        }

    }
}
