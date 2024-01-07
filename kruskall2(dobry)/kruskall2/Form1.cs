using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kruskall2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Edge> krawędzie = new List<Edge>
        {
            new Edge(4,6,1),
            new Edge(4,5,2),
            new Edge(2,7,3),
            new Edge(0,6,3),
            new Edge(2,4,4),
            new Edge(0,1,5),
            new Edge(2,6,5),
            new Edge(1,5,6),
            new Edge(5,6,6),
            new Edge(1,7,7),
            new Edge(1,4,8),
            new Edge(3,6,8),
            new Edge(0,3,9),
            new Edge(1,2,9),
            new Edge(2,3,9),
            new Edge(6,7,9),
        };
            int liczbaWierzcholkow = 8;
            List<Edge> minimumSpanningTree = MinimumSpanningTree.KruskalMST(krawędzie, liczbaWierzcholkow);

            
            string result = "Krawedzie w minimalnym drzewie rozpinajacym:\n";
            foreach (var edge in minimumSpanningTree)
            {
                result += edge.poczatek + " - " + edge.koniec + " waga: " + edge.waga + "\n";
            }
            MessageBox.Show(result);
        }
    }
}
