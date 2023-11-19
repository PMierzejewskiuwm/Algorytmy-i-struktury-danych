using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quickSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 6, 8, 2, 7 };
            quickSort(arr,0,arr.Length-1);
            MessageBox.Show(toString(arr));
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
        void swap(int[] arr,int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        int partition(int[] arr,int startIndex, int endIndex)
        {
            int pivot = arr[endIndex];
            int i = startIndex - 1;
            
            for(int j = startIndex; j < endIndex; j++)
            {
                if(arr[j] < pivot)
                {
                    i++;
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, endIndex);
            return i + 1;
        }

        void quickSort(int[] arr, int startIndex, int endIndex)
        {
            if(startIndex < endIndex)
            {
                int partitionIndex = partition(arr, startIndex, endIndex);
                quickSort(arr, startIndex, partitionIndex - 1);
                quickSort(arr, partitionIndex + 1,endIndex);
            }
        }
    }
}
