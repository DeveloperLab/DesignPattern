using System;
namespace ExemploChainOfResposability
{
    public interface IFormato
    {
        public IFormato Proximo { get; set; }

        string MontarResposta(Requisicao requisicao, Conta conta);
    }
}
