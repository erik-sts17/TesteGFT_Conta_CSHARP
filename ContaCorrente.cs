using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Conta
{
    class ContaCorrente : Conta, Imposto
    {
      public ContaCorrente(string numero, string titular, double saldo) : base(numero, titular, saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        private double _impostos;


        public override double Rendimento()
        {
            Saldo += Saldo * 0.03;
            return Saldo;
        }

        public double CalculaImposto()
        {
            _impostos = Rendimento() * 0.25;
            return _impostos;
        }

        public override string ToString()
        {
            return "Conta: " + Numero +
                "\nTitular: " + Titular +
                "\nSaldo inicial: " + Saldo +
                "\nRendimento: " + Rendimento() +
                 "\nImpostos: " + CalculaImposto();
        }

        

    }
}

