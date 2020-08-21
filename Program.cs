using System;

namespace POO_Conta
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente c1 = new ContaCorrente("18005", "Erik", 200.00);
            ContaPoupanca c2 = new ContaPoupanca("25968", "Breno", 200.00);

            Console.WriteLine(c1);
            Console.WriteLine("\n" + c2);
        }
    }
}
