using System;
namespace ExemploChainOfResposability
{
    public class Porcento : IFormato
    {
        public Porcento(IFormato proximo)
        {
            Proximo = proximo;
        }

        public IFormato Proximo { get; set; }

        public string MontarResposta(Requisicao requisicao, Conta conta)
        {
            if(requisicao.Formato == Formato.PORCENTO)
            {
                return $"{conta.Titular}%{conta.Saldo}";
            }

            if(Proximo != null)
            {
                return Proximo.MontarResposta(requisicao, conta);
            }
            else
            {
                return $"Titular: {conta.Titular}, Saldo: {conta.Saldo}";
            }
            
        }
    }
}
