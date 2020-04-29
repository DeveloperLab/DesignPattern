using System;
namespace ExemploChainOfResposability
{
    public class Requisicao
    {

        public Requisicao(Formato formato)
        {
            Formato = formato;
        }

        public Formato Formato { get; set; }

    }

    public enum Formato
    {
        XML,
        CSV,
        PORCENTO
    }
}
