using static Calculadora.Inicio;
using static Calculadora.Program;
namespace Calculadora
{
    public class Operacoes
    {
        public static float Calcula(OpcoesMenu opcao, float n1, float n2)
        {          
            float resultado = opcao switch
            {
                OpcoesMenu.Somar => n1 + n2,
                OpcoesMenu.Subtracao => n1 - n2,
                OpcoesMenu.Divisao => n1 / n2,
                OpcoesMenu.Multiplicacao => n1 * n2,
                OpcoesMenu.Media => (n1 + n2) / 2,
                _ => 0
            };

            return resultado;
        }
    }
}