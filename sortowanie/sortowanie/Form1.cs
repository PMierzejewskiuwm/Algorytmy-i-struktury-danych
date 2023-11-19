using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sortowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] tab = { 4,2,6,7,1,435,123,5,4,1,5,4,2};
            //mergeSort(tab,0,tab.Length-1);
            insertSort(tab);
            MessageBox.Show(ToString(tab));
        }
        string ToString(int[] tab)
        {
            string wynik = "";
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i].ToString();
                wynik = wynik + tab[i] + " ";
            }
            return wynik;
        }
        void insertSort(int[] arr)
        {
            
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
        void mergeSort(int[] array, int startIndex, int endIndex)
        {
            if (startIndex < endIndex)
            {
                int middle = (startIndex + endIndex) / 2;

                
                mergeSort(array, startIndex, middle);
                mergeSort(array, middle + 1, endIndex);

                
                Merge(array, startIndex, middle, endIndex);
            }
        }

        void Merge(int[] array, int startIndex, int middleIndex, int endIndex)
        {
            int n1 = middleIndex - startIndex + 1;
            int n2 = endIndex - middleIndex;

            
            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            
            for (int i = 0; i < n1; i++)
                leftArray[i] = array[startIndex + i];
            for (int j = 0; j < n2; j++)
                rightArray[j] = array[middleIndex + 1 + j];

            

            
            int iLeft = 0, jRight = 0;

            
            int k = startIndex;
            while (iLeft < n1 && jRight < n2)
            {
                if (leftArray[iLeft] <= rightArray[jRight])
                {
                    array[k] = leftArray[iLeft];
                    iLeft++;
                }
                else
                {
                    array[k] = rightArray[jRight];
                    jRight++;
                }
                k++;
            }

            
            while (iLeft < n1)
            {
                array[k] = leftArray[iLeft];
                iLeft++;
                k++;
            }

            
            while (jRight < n2)
            {
                array[k] = rightArray[jRight];
                jRight++;
                k++;
            }
        }
        void quickSort(int[] arr, int startIndex, int endIndex)
        {
            if (startIndex < endIndex)
            {
                int partitionIndex = Partition(arr, startIndex, endIndex);

                quickSort(arr, startIndex, partitionIndex - 1);
                quickSort(arr, partitionIndex + 1, endIndex);
            }
        }

        int Partition(int[] arr, int startIndex, int endIndex)
        {
            int pivot = arr[endIndex];
            int i = startIndex - 1;

            for (int j = startIndex; j < endIndex; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, endIndex);

            return i + 1;
        }

        void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        void selectionSort(int[] tab)
        {

            for (int i = 0; i < tab.Length - 1; i++)
            {
                var minindex = minIndex(tab, i);
                int temp = tab[i];
                tab[i] = tab[minindex];
                tab[minindex] = temp;
            }
        }
        int minIndex(int[] tab, int startIndex)
        {
            int minIndex = startIndex;
            for (int i = startIndex; i < tab.Length; i++)
            {
                if (tab[i] < tab[minIndex])
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }
        void bubbleSort(int[] tab)
        {

            bool cbz = false;
            do
            {
                cbz = false;
                int temp;

                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        cbz = true;
                        temp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = temp;

                    }
                }
            } while (cbz);

        }
    }
}
