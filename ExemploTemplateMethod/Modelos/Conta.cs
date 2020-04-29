using System;
namespace ExemploTemplateMethod.Modelos
{
    public class Conta
    {
        public Conta(string titular, double saldo, string agencia, string numero)
        {
            Titular = titular;
            Saldo = saldo;
            Agencia = agencia;
            Numero = numero;
        }

        public string Titular { get; private set; }

        public double Saldo { get; private set; }

        public string Agencia { get; private set; }

        public string Numero { get; private set; }
    }
}
