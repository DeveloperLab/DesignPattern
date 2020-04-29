using System;
namespace CursoDesignPatters
{
    public class CalculadorDeDescontos
    {
        public CalculadorDeDescontos()
        {
        }

        public double Calcula(Orcamento orcamento)
        {
            //Chain of Responsability
            //declarar todos os descontos e chamar o método

            DescontoPorCincoItens d1 = new DescontoPorCincoItens();
            DescontoPorQuinhentosReais d2 = new DescontoPorQuinhentosReais();
            DescontoVendaCasada d3 = new DescontoVendaCasada();
            SemDesconto d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            return d1.Desconta(orcamento);
        }
    }
}
