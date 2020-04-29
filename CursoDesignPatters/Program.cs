using System;

namespace CursoDesignPatters
{
    class Program
    {
        static void Main(string[] args)
        {
            //var iss = new ISS();
            //var icsm = new ICMS();
            //var iccc = new ICCC();

            //Orcamento orcamento = new Orcamento(2000.0);

            //Console.WriteLine(iss.Calcula(orcamento));
            //Console.WriteLine(icsm.Calcula(orcamento));
            //Console.WriteLine(iccc.Calcula(orcamento));


            //CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            //Orcamento orcamento = new Orcamento(500.0);
            //orcamento.AdicionaItem(new Item("CANETA", 250.0));
            //orcamento.AdicionaItem(new Item("LAPIS", 250.0));

            //double desconto = calculador.Calcula(orcamento);


            //Template Method
            Orcamento orcamento = new Orcamento(500.0);
            orcamento.AdicionaItem(new Item("CANETA", 500.0));
            orcamento.AdicionaItem(new Item("LAPIS", 250.0));

            var icpp = new ICPP();


            CalculadorDeImpostos calculador = new CalculadorDeImpostos();


            calculador.RealizaCalculo(orcamento, icpp);


        }
    }
}
