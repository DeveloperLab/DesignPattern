using System;
namespace ExemploStrategy
{
    public class RealizadorDeInvestimentos
    {
        public void Investir(Conta conta, Investimento investimento)
        {
            var lucro = investimento.Investir(conta);

            var valor = lucro * 0.75;

            Console.WriteLine(valor);
        }
    }
}
