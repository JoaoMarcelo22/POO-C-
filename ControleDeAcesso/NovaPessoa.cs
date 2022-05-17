using System;
namespace ControleDeAcesso
{
    public class NovaPessoa : Pessoa
    {
        public NovaPessoa(): base()
        {
            this.Sexo = "";
        }
        public NovaPessoa(string nome, int idade, string sexo) :base(nome,idade)
        {
            this.Sexo= sexo;
        }
        public string Sexo {get; set;}

        public void ExibirDados()
        {
            Console.WriteLine($"Nome : {this.Nome}, Idade : {this.Idade}, Sexo : {this.Sexo}");
        }
    }
}