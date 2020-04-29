using System;
namespace ExemploTemplateMethod.Modelos
{
    public class Banco
    {
        public Banco(string nome, string telefone, string endereco, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Email = email;
            DiaAtual = DateTime.Now;
        }

        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public string Endereco { get; private set; }
        public string Email { get; private set; }
        public DateTime DiaAtual { get; private set; }
    }
}
