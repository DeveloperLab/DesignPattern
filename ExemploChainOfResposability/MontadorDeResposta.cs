using System;
namespace ExemploChainOfResposability
{
    public class MontadorDeResposta
    {
        public string Montar(Requisicao requisicao, Conta conta)
        {
            SemFormato f4 = new SemFormato();
            Porcento f3 = new Porcento(f4);
            XML f2 = new XML(f3);
            CSV f1 = new CSV(f2);

            return f1.MontarResposta(requisicao, conta);
        }
    }
}
