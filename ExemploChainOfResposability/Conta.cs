using System;
namespace ExemploChainOfResposability
{
    public class Conta
    {
        public Conta(string titular, double saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }

        public string Titular { get; set; }
        public double Saldo { get; set; }
    }
}
