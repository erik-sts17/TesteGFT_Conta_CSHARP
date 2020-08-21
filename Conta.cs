using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Conta
{
    public abstract class Conta
    {
        public string Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        protected Conta(string numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public abstract double Rendimento();

    }
}
