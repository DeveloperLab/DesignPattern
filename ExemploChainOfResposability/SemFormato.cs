using System;
namespace ExemploChainOfResposability
{
    public class SemFormato : IFormato
    {
        public IFormato Proximo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string MontarResposta(Requisicao requisicao, Conta conta)
        {
            return $"Titular: {conta.Titular}, Saldo: {conta.Saldo}";
        }
    }
}
