using System;
using System.Collections.Generic;
using ExemploTemplateMethod.Modelos;

namespace ExemploTemplateMethod
{
    public class RelatorioComplexo : TemplateRelatorio
    {

        protected override string MontarCabecalho(Banco banco)
        {
            return $"Banco: {banco.Nome} - Telefone: {banco.Telefone} - Endereço: {banco.Endereco}";
        }

        protected override string MontarCorpo(List<Conta> contas)
        {
            string conteudo = "";

            foreach (var conta in contas)
            {
                conteudo += $"Titular: {conta.Titular}: {conta.Agencia}-{conta.Numero} = {conta.Saldo}" + Environment.NewLine;
            }
            return conteudo;
        }

        protected override string MontarRodape(Banco banco)
        {
            return $"E-mail: {banco.Email} - Data: {banco.DiaAtual}";
        }
    }
}
