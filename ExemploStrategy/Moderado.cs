using System;
namespace ExemploStrategy
{
    public class Moderado : Investimento
    {
        public double Investir(Conta conta)
        {
            bool escolhido = new Random().Next(101) > 50;
            if (escolhido)
            {
                return conta.Saldo * 0.025;
            }
            else
            {
                return conta.Saldo * 0.007;
            }
        }
    }
}
