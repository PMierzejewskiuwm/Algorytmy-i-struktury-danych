namespace ćwiczenia2_algorytmy_i_stuktury_danych
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int p = (int)liczbaN.Value;
            int wynik = fib2(p);
            MessageBox.Show(wynik.ToString());
        }

        

        private void liczbaN_ValueChanged(object sender, EventArgs e)
        {

        }

        int fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            return fib(n - 1) + fib(n - 2);
        }
        int fib2(int n)
        {
            int[] wyrazy = new int[n + 1];

            wyrazy[0] = 0;
            wyrazy[1] = 1;
            for(int i = 2;i <= n; i++)
            {
                wyrazy[i] = wyrazy[i - 1] + wyrazy[i - 2];
            }
            return wyrazy[n];
            
        }
    }
}