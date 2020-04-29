using System;

namespace ExemploChainOfResposability
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta("Guilherme", 5500);

            Requisicao req1 = new Requisicao(Formato.CSV);
            Requisicao req2 = new Requisicao(Formato.XML);
            Requisicao req3 = new Requisicao(Formato.PORCENTO);

            MontadorDeResposta montador = new MontadorDeResposta();

            Console.WriteLine(montador.Montar(req1, conta));
            Console.WriteLine(montador.Montar(req2, conta));
            Console.WriteLine(montador.Montar(req3, conta));

        }
    }
}
