using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace cw6
{
    public class DrzewoBinarne
    {
        public Węzeł3 korzeń;
        public DrzewoBinarne(int liczba)
        {
            this.korzeń = new Węzeł3(liczba);
        }
        public void Add(int liczba)
        {
            Węzeł3 rodzic = this.ZnajdzRodzica(liczba);
            rodzic.Add(liczba);
        }

        public Węzeł3 ZnajdzRodzica(int liczba)
        {
            var w = this.korzeń;

            while (true)
            {
                if (liczba < w.wartosc)
                {
                    if (w.leweDziecko == null)
                    {
                        return w;
                    }
                    else
                    {
                        w = w.leweDziecko;
                    }
                }
                else
                {
                    if (w.praweDziecko == null)
                    {
                        return w;
                    }
                    else
                    {
                        w = w.praweDziecko;
                    }
                }
            }

        }
        //BST

        public Węzeł3 Znajdz(int liczba)
        {
            var w = this.korzeń;
            
            while (true)
            {
                if (w.wartosc == liczba)
                {
                    return w;
                }
                if (liczba < w.wartosc)
                {
                    if (w.leweDziecko != null)
                    {
                        w = w.leweDziecko;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    if (w.praweDziecko != null)
                    {
                        w = w.praweDziecko;
                    }
                    else
                    {
                        return null;
                    }
                }
            }

        }

        //zwrocic wezel ktory ma ta wartosc ktora szukamy
        //podobna funkcja do tej ktora byla, trzeba sprawdzac czy juz znalezlismy wartosc, czy mozna pojsc dalej i w ktora strone isc
        

        public Węzeł3 ZnajdzMin(Węzeł3 w)
        {
            while (w.leweDziecko != null)
            {
                w = w.leweDziecko;
            }
            return w;
        }
        //znalezc minimalna wartosc czyli isc maksymalnie w lewo dopoki mozemy przejsc
        
        public Węzeł3 ZnajdzMax(Węzeł3 w)
        {
            while(w.praweDziecko != null)
            {
                w = w.praweDziecko;
            }
            return w;
        }
        //znalezc maksymalna wartosc czyli isc maksymalnie w prawo dopoki mozemy przejsc

        public Węzeł3 Nastepnik(Węzeł3 w)
        {
            if (w.praweDziecko != null)
            {
                return this.ZnajdzMin(w.praweDziecko);
            }

            while (w.rodzic != null)
            {

                if (w.rodzic.leweDziecko == w)
                {
                    return w.rodzic;
                }
                w = w.rodzic;
            }
            return null;
        }
        //poprzednik zamiast prawe to lewe i zamiast min to max
        /*
        1. jezeli jest prawe dziecko to znajdzMin(w.praweDziecko) <- następnik
        2. gdy nie ma prawego dziecka to idz do gory
        a) jezeli nie mozesz to nie ma nastepnika
        b) jezeli mozesz isc do gory to idz tak dlugo az wyjdziesz jako lewe dziecko, wtedy nastepnik to rodzic w ktorym wyszedles
        */
        public Węzeł3 Usuń(Węzeł3 w)
        {
            switch (w.GetLiczbaDzieci())
            {
                case 0:
                    w = this.UsuńGdy0(w);
                    break;
                case 1:
                    w = this.UsuńGdy1(w);
                    break;
                case 2:
                    w = this.UsuńGdy2(w);
                    break;
            }
            return w;
        }
        public Węzeł3 UsuńGdy0(Węzeł3 w) //3 mozliwosci kiedy nie ma dzieci
        {
            if(w.rodzic == null)             //jesli wezel w nie ma rodzica to jest korzeniem
            {
                this.korzeń = null;
                return w;
            }
            if(w.rodzic.leweDziecko == w)               //usuwamy strzalke od rodzica do dziecka
            {
                w.rodzic.leweDziecko = null;
            }
            else
            {
                w.rodzic.praweDziecko = null;
            }
            w.rodzic = null;      //usuwamy strzalke od dziecka do rodzica
            return w;
        }
        public Węzeł3 UsuńGdy1(Węzeł3 w) //6 mozliwosci kiedy ma 1 dziecko
        {
            Węzeł3 dziecko = null;
            if(w.leweDziecko != null)
            {
                dziecko = w.leweDziecko;
                w.leweDziecko = null;
            }
            else
            {
                dziecko = w.praweDziecko;
                w.praweDziecko = null;
            }
            dziecko.rodzic = w.rodzic; //dziecko przestaje pokazywac na w, a zaczyna na rodzica
            if(w.rodzic == null) //korzeń
            {
                this.korzeń = dziecko;
            }
            else
            {
                if(w.rodzic.leweDziecko == w)
                {
                    w.rodzic.leweDziecko = dziecko;
                }
                else
                {
                    w.rodzic.praweDziecko = dziecko;
                }
                w.rodzic = null;
            }
            return w;
        }
        public Węzeł3 UsuńGdy2(Węzeł3 w)
        {
            Węzeł3 zamiennik = this.Nastepnik(w);
            zamiennik = this.Usuń(zamiennik);
            if(w.leweDziecko != null)
            {
                zamiennik.leweDziecko = w.leweDziecko;
                w.leweDziecko.rodzic = zamiennik;
                w.leweDziecko = null;
            }
            if(w.praweDziecko != null)
            {
                zamiennik.praweDziecko = w.praweDziecko;
                w.praweDziecko.rodzic = zamiennik;
                w.leweDziecko = null;
            }
            if(w.rodzic == null)
            {
                this.korzeń = zamiennik;
            }
            else
            {
                if(w == w.rodzic.leweDziecko)
                {
                    w.rodzic.leweDziecko = zamiennik;
                }
                else
                {
                    w.rodzic.praweDziecko = zamiennik;
                }
                zamiennik.rodzic = w.rodzic;
                w.rodzic = null;
            }
            return w;
        }
        
    }
}
