namespace isi_grupa_4_ćw_1_algorytmy_i_struktury_danych
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int liczbaN = (int)liczbaN.Value;

            int wynik = fib(6);

            MessageBox.Show(wynik.ToString());
        }

        int fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            return fib(n - 1) + fib(n - 2);
        }

        private void liczbaN_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}