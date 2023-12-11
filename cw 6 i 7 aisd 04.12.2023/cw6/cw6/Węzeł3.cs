﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw6
{
    public class Węzeł3
    {
        public int wartosc;
        public Węzeł3 rodzic;
        public Węzeł3 leweDziecko;
        public Węzeł3 praweDziecko;
        
        public Węzeł3(int liczba)
        {
            this.wartosc = liczba;
        }
        public override string ToString()
        {
            return this.wartosc.ToString();
        }

        public void Add(int liczba)
        {
            var dziecko = new Węzeł3(liczba);
            dziecko.rodzic = this;
            if(liczba < this.wartosc)
            {
                this.leweDziecko = dziecko;
            }
            else
            {
                this.praweDziecko = dziecko;
            }
            
        }
    }
}

