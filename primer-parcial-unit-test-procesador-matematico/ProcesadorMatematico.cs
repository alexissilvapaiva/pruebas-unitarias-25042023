﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial_unit_test_procesador_matematico
{
    public class ProcesadorMatematico
    {
        private int _resultado;

        public int Sumar(int primerNumero, int segundoNumero)
        {
            this._resultado = primerNumero + segundoNumero;
            return this._resultado;
        }

        public int Dividir(int dividendo, int divisor)
        {
            if (divisor == 0)
            {
               return this._resultado = -1;
            }else
            {
                this._resultado = dividendo / divisor;
                return this._resultado;
            }
        }
        private bool EsNegativo()
        {
            return (this._resultado < 0);
        }

        public int CalcularMayor(int primerNumero, int segundoNumero)
        {
            if (primerNumero > segundoNumero)
            {
                return this._resultado = primerNumero;
            }
            else if (primerNumero < segundoNumero)
            {
                return this._resultado = segundoNumero;
            }
            else
            {
              return  this._resultado = segundoNumero;
            }
        }
    }
}
