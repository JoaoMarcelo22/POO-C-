using static Calculadora.Operacoes;
using static Calculadora.Program;
namespace Calculadora
{
    public class Inicio
    {
        public static void Menu()
            {
             Console.Clear();
             Console.WriteLine("Digite a opção desejada: ");
             Console.WriteLine("0 - Sair ; 1 - Somar ; 2 - Subtração ; 3 - Divisão ; 4 - Multiplicação ; 5 - Media");

            int.TryParse(Console.ReadLine(), out int opcao);
            switch(opcao){
            case 0 : System.Environment.Exit(0); break;
            case 1 : Soma();break;
            case 2 : Subtracao(); break;
            case 3 : Divisao(); break;
            case 4 : Multiplicacao();break;
            case 5 : Media1();break;
            default : Menu();break;
            }
        }
    }
}