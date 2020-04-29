using System;
namespace ExemploStrategy
{
    public class Arrojado : Investimento
    {
        public double Investir(Conta conta)
        {
            bool maiorQueTrinta = new Random().Next(101) > 30;
            bool maiorQueVinte = new Random().Next(101) > 20;

            if (maiorQueVinte)
            {
                return conta.Saldo * 0.05;
            } else if (maiorQueTrinta)
            {
                return conta.Saldo * 0.03;
            }
            else
            {
                return conta.Saldo * 0.006;

            }
        }
    }
}
