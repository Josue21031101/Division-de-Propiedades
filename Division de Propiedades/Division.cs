﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division_de_Propiedades
{
    internal class Division
    {
        double v1, v2;

        public double V1 { get => v1; set => v1 = value; }
        public double V2 { get => v2; set => v2 = value; }

        public double Dividir()
        {
            return V1 / V2;
        }

    }

}
