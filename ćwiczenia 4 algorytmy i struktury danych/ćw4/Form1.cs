namespace ćw4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int[] tab = {5,3,7,2,1};
            selectionSort(tab);
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
            for(int i = startIndex; i < tab.Length;i++)
            {
                if (tab[i] < tab[minIndex])
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }

        /*do domu sortowanie przez:
        -wstawanie(insert)
        -scalanie(merge)
        -szybkie(quick)
        */
    }
}