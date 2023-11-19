using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insertSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] tab = { 1, 6, 9, 2, 8, 12 };
            insertSort(tab);
            MessageBox.Show(toString(tab));
        }

        string toString(int[] tab)
        {
            string result = "";
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i].ToString();
                result += tab[i];
                result += " ";
            }
            return result;
        }
        void insertSort(int[] tab)
        {
            for(int i = 1; i < tab.Length; i++)
            {
                int temp = tab[i];
                int j = i - 1;
                while(j >= 0 && tab[j] > temp)
                {
                    tab[j + 1] = tab[j];
                    j--;
                }
                tab[j + 1] = temp;
            }
        }
    }
}
