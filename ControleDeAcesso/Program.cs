
namespace ControleDeAcesso
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<NovaPessoa> pessoas = new List<NovaPessoa>();
            int QTDhomem = 0 , QTDMulher = 0, QTDmaiores = 0;

            Console.WriteLine("CONTROLE DE ACESSO :");
            Console.WriteLine("------------------------------------------------");

            for(int i = 0; i < 3; i++)
            {
                NovaPessoa pessoa = new NovaPessoa();
                Console.WriteLine("Nome : ");
                pessoa.Nome = Console.ReadLine();
                Console.WriteLine("Idade : ");
                pessoa.Idade = Convert.ToInt32( Console.ReadLine());
                Console.WriteLine("Sexo : ");
                pessoa.Sexo = Console.ReadLine();
                if(pessoa.Sexo == "Homem")
                {
                    QTDhomem++;
                }
                else if(pessoa.Sexo =="Mulher")
                {
                    QTDMulher++;
                }
                if(pessoa.Idade >= 18)
                {
                    QTDmaiores++;
                }
                Console.Clear();
            }
            Console.WriteLine($"Totais de Homens : {QTDhomem} | Totais de Mulheres : {QTDMulher} | Totais Maiores de idade : {QTDmaiores} |");
        }
    }
}