using System;
namespace CursoDesignPatters
{
    public class DescontoVendaCasada : IDesconto
    {
        public DescontoVendaCasada()
        {
        }

        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if(Existe("CANETA", orcamento) && Existe("LAPIS", orcamento))
            {
                return orcamento.Valor * 0.005;
            }

            return Proximo.Desconta(orcamento);
        }

        private bool Existe(string nomeDoItem, Orcamento orcamento)
        {
            foreach(var item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
