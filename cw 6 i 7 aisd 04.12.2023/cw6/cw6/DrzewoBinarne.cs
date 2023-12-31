﻿using System;
using System.Collections.Generic;
using System.Linq;
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

        private Węzeł3 ZnajdzRodzica(int liczba)
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

        /*public Węzeł3 Znajdz(int liczba)
        {

        }
        zwrocic wezel ktory ma ta wartosc ktora szukamy
        podobna funkcja do tej ktora byla, trzeba sprawdzac czy juz znalezlismy wartosc, czy mozna pojsc dalej i w ktora strone isc
        */

        /* public Węzeł3 ZnajdzMin(int liczba)
          {

          }
         znalezc minimalna wartosc czyli isc maksymalnie w lewo dopoki mozemy przejsc
        */
        /*public Węzeł3 ZnajdzMax(int liczba)
        {

        }
        znalezc maksymalna wartosc czyli isc maksymalnie w prawo dopoki mozemy przejsc (zaczynamy od wezla a nie od korzenia, przypisujemy w do roota)
        */
        /* public Węzeł3 Nastepnik(Węzeł3 w)
        {

        }
        1. jezeli jest prawe dziecko to znajdzMin(w.leweDziecko) <- następnik
        2. gdy nie ma prawego dziecka to idz do gory
        a) jezeli nie mozesz to nie ma nastepnika
        b) jezeli mozesz isc do gory to idz tak dlugo az wyjdziesz jako lewe dziecko, wtedy nastepnik to rodzic w ktorym wyszedles
        */
          
    }
}
