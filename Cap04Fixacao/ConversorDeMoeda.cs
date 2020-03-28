using System;
using System.Collections.Generic;
using System.Text;

namespace Cap04Fixacao
{
    public class ConversorDeMoeda
    {
        public double Valor;
        public double Quantidade;

        public double ValorPago()
        {
            return (Valor * Quantidade)* 1.06;

        }


    }
}
