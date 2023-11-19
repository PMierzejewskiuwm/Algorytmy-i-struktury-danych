using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bubbleSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] tab = { 4, 7, 1, 2, 7, 34 };
            bubbleSort(tab);
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

        void bubbleSort(int[] tab)
        {
            bool cbz = false;
            do
            {
                cbz = false;
                for(int i = 0; i < tab.Length-1; i++)
                {
                    if(tab[i] > tab[i + 1])
                    {
                        cbz = true;
                        int temp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = temp;
                    }
                }
            } while (cbz);
        }
    }
}
