using System;
namespace CursoDesignPatters
{
    public class SemDesconto : IDesconto
    {
        public SemDesconto()
        {
        }

        public IDesconto Proximo { get ; set ; }

        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}
