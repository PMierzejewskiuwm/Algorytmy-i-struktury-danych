﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw6
{
    public class Węzeł
    {
        public string wartość;
        public List<Krawędź> Krawędzie = new List<Krawędź>();

        public Węzeł(string wartość)
        {
            this.wartość = wartość;
        }
    }
}
