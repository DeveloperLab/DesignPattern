using System;
using System.Collections.Generic;
using ExemploTemplateMethod.Modelos;

namespace ExemploTemplateMethod
{
    public class RelatorioSimples : TemplateRelatorio
    {
        protected override string MontarCabecalho(Banco banco)
        {
            return $"Banco: {banco.Nome} - Telefone: {banco.Telefone}";
        }

        protected override string MontarCorpo(List<Conta> contas)
        {
            string conteudo = "";

            foreach(var conta in contas)
            {
                conteudo += $"Titular: {conta.Titular} = {conta.Saldo}" + Environment.NewLine;
            }
            return conteudo;
        }

        protected override string MontarRodape(Banco banco)
        {
            return MontarCabecalho(banco);
        }
    }
}
