using System;
namespace ExemploChainOfResposability
{
    public class XML : IFormato
    {

        public XML(IFormato proximo)
        {
            Proximo = proximo;
        }

        public IFormato Proximo { get; set; }

        public string MontarResposta(Requisicao requisicao, Conta conta)
        {
            if(requisicao.Formato == Formato.XML)
            {
                return "<conta>" +
                    $"<Titular>{conta.Titular}</Titular>" +
                    $"<Saldo>{conta.Saldo}</Saldo>" +
                    "</conta>";
            }

            return Proximo.MontarResposta(requisicao, conta);
        }
    }
}
