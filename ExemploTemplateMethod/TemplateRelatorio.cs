using System;
using System.Collections.Generic;
using ExemploTemplateMethod.Modelos;

namespace ExemploTemplateMethod
{
    public abstract class TemplateRelatorio
    {
        public string ImprimirRelatorio(Banco banco,List<Conta> contas)
        {
            var relatorio = MontarCabecalho(banco)
                + Environment.NewLine
                + MontarCorpo(contas)
                + MontarRodape(banco);

            return relatorio;
        }

        protected abstract string MontarCabecalho(Banco banco);
        protected abstract string MontarCorpo(List<Conta> contas);
        protected abstract string MontarRodape(Banco banco);
    }
}
