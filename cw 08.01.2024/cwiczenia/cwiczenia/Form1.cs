using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cwiczenia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NWP("abaabbaaa", "babab");
        }
        
        //najwiekszy wspolny podciag
        public void NWP(string str1, string str2)
        {

            int[,] tab = new int[str1.Length+1, str2.Length+1];
            int i, j,result = 0;
            for(i = 1; i < tab.GetLength(0); i++)
            {
                for(j = 1; j < tab.GetLength(1); j++)
                {
                    if (str1[i-1] == str2[j-1])
                    {
                        tab[i, j] = tab[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        tab[i, j] = Math.Max(tab[i - 1, j], tab[i, j - 1]);
                    }
                }
                result = tab[i-1, j-1]; //dlugosc najwiekszego wspolnego podciagu
                
            }
            MessageBox.Show(result.ToString());

        }
        //NWP odczytujemy od ostatniej wartosci idziemy:
        //-jesli jest ta sama wartosc u gory lub po lewej to ide to gory lub w lewo
        //-jesli jest inna wartosc u gory lub po lewej to ide po przekatnej do gory
        //-przy zmianie wartosci odczytuje literke
        
        //wypelnianie tablicy:
        //-jesli te same litery to dodajemy 1 po przekatnej
        //-jesli inne litery to bierzemy max z dwoch na gorze i na dole

        //przechodzenie WGŁĄB:
        //1.preorder najpierw rodzic potem dzieci
        //2.inorder najpierw lewe dziecko potem rodzic potem prawe dziecko
        //3.post order najpierw dzieci pozniej rodzic

        //graf pelny
        //graf C5
    }
}
