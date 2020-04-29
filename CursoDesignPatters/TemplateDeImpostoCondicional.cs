using System;
namespace CursoDesignPatters
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }

            return MinimaTaxacao(orcamento);
        }

        //Esse método é bem similar as duas classes
        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        //e as duas classes tem retornos maximos e minimos
        protected abstract double MaximaTaxacao(Orcamento orcamento);
        protected abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
