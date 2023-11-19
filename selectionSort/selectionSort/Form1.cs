using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace selectionSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] tab = { 1, 4, 7, 8, 3, 0 };
            selectionSort(tab);
            MessageBox.Show(toString(tab));
        }

        string toString(int[] tab)
        {
            string result = "";
            for(int i = 0; i < tab.Length; i++)
            {
                tab[i].ToString();
                result += tab[i];
                result += " ";
            }
            return result;
        }
        
        void selectionSort(int[] tab)
        {
            for(int i = 0; i < tab.Length; i++)
            {
                var index = minIndex(tab, i);
                int temp = tab[i];
                tab[i] = tab[index];
                tab[index] = temp;
            }
        }

        int minIndex(int[] tab, int startIndex)
        {
            int minIndex = startIndex;
            for(int i = startIndex; i < tab.Length; i++)
            {
                if(tab[i] < tab[minIndex])
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }
    }
}
