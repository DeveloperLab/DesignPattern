using System;
namespace ExemploStrategy
{
    public class Conservador : Investimento
    {
        public double Investir(Conta conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}
