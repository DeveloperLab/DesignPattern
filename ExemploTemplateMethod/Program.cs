using System;
using System.Collections.Generic;
using ExemploTemplateMethod.Modelos;

namespace ExemploTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta("Guilherme", 100, "9812", "12131");
            Conta c2 = new Conta("Cesar", 200, "9822", "12132");
            Conta c3 = new Conta("Augusto", 300, "9842", "12133");
            Conta c4 = new Conta("Foda-se", 500, "9852", "12134");

            List<Conta> contas = new List<Conta>();

            contas.Add(c1);
            contas.Add(c2);
            contas.Add(c3);
            contas.Add(c4);

            Banco banco = new Banco("Banco Generico", "11 123456789", "Rua fodase, 100", "alguem@bancogenerico.com.br");

            Console.WriteLine(new RelatorioSimples().ImprimirRelatorio(banco,contas));
            Console.WriteLine("=======");
            Console.WriteLine(new RelatorioComplexo().ImprimirRelatorio(banco, contas));
        }
    }
}
