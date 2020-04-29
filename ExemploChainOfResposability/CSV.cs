
namespace ExemploChainOfResposability
{
        public class CSV : IFormato
        {
            public CSV(IFormato proximo)
            {
                Proximo = proximo;
            }

            public IFormato Proximo { get; set; }

            public string MontarResposta(Requisicao requisicao, Conta conta)
            {
                if(requisicao.Formato == Formato.CSV)
                {
                    return $"{conta.Titular};{conta.Saldo}";
                }

                return Proximo.MontarResposta(requisicao, conta);
            }
        }
}
