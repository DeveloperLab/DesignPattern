using System;
namespace CursoDesignPatters
{
    public interface IDesconto 
    {
        public IDesconto Proximo { get; set; }
        double Desconta(Orcamento orcamento);
    }
}
