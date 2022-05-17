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
        private string sexo;
        public string  Sexo {
        get {return sexo;}
        set {sexo = value.ToLower();}
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome : {this.Nome}, Idade : {this.Idade}, Sexo : {this.Sexo}");
        }
    }
}