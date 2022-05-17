namespace ControleDeAcesso
{
    public class Pessoa
    {
        public Pessoa()
        {
            this.Nome = "";
            this.Idade = 0;
        }
        public Pessoa(string nome,int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
        private string nome;
        public string Nome{get;set;}
        public int Idade{get;set;}
    }
}