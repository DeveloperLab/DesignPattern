using System;
namespace ExemploStrategy
{
    public class Conta
    {
        public double Saldo { get; private set; }

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

    }
}
