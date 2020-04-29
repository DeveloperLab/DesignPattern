using System;

namespace ExemploStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var conservador = new Conservador();
            var moderado = new Moderado();
            var arrojado = new Arrojado();

            Conta conta = new Conta(100);

            var investidor = new RealizadorDeInvestimentos();

            investidor.Investir(conta, conservador);
            investidor.Investir(conta, moderado);
            investidor.Investir(conta, arrojado);

        }
    }
}
