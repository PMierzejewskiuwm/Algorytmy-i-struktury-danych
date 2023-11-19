using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mergeSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] tab = { 1, 7, 2, 8, 10, 56 };
            mergeSort(tab, 0, tab.Length - 1);
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

        void merge(int[] arr, int startIndex, int middleIndex, int endIndex)
        {
            int n1 = middleIndex - startIndex + 1;
            int n2 = endIndex - middleIndex;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for(int i = 0; i < n1; i++)
            {
                leftArray[i] = arr[startIndex + i];
            }
            for(int j = 0; j < n2; j++)
            {
                rightArray[j] = arr[middleIndex + j + 1];
            }

            int iLeft = 0, jRight = 0, k = startIndex;

            while(iLeft < n1 && jRight < n2)
            {
                if(leftArray[iLeft] <= rightArray[jRight])
                {
                    arr[k] = leftArray[iLeft];
                    iLeft++;
                }
                else
                {
                    arr[k] = rightArray[jRight];
                    jRight++;
                }
                k++;
            }

            while(iLeft < n1)
            {
                arr[k] = leftArray[iLeft];
                iLeft++;
                k++;
            }

            while(jRight < n2)
            {
                arr[k] = rightArray[jRight];
                jRight++;
                k++;
            }
        }
       void mergeSort(int[] arr,int startIndex, int endIndex)
        {
            int middleIndex = (startIndex + endIndex) / 2;
            if(startIndex < endIndex)
            {
                mergeSort(arr, startIndex, middleIndex);
                mergeSort(arr, middleIndex + 1, endIndex);
                merge(arr, startIndex, middleIndex, endIndex);
            }
        }
    }
}
