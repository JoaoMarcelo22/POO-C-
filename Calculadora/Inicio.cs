using static Calculadora.Temperatura;
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
             Console.WriteLine("0 - Sair ; 1 - Somar ; 2 - Subtração ; 3 - Divisão ; 4 - Multiplicação ; 5 - Media ;  6 - Temperatura");

            int.TryParse(Console.ReadLine(), out int opcao);
            switch(opcao){
            case 0 : System.Environment.Exit(0); break;
            case 1 : Soma();break;
            case 2 : Subtracao(); break;
            case 3 : Divisao(); break;
            case 4 : Multiplicacao();break;
            case 5 : Media1();break;
            case 6 : MenuTemperatura();break;
            default : Menu();break;
            }
        }
        public static void MenuTemperatura()
            {
             Console.Clear();
             Console.WriteLine("Digite a opção desejada: (°C) Celsius ; Farenheight(°F) ; Kelvin(°K) ");
             Console.WriteLine("0 - Sair ;\n 1 - (°C) - > (°F) |\n 2 - (°C) - > (°K) |\n 3 - (°F) - > (°C) |\n 4 - (°F) - > (°K) |\n 5 - (°K) - > (°C) |\n 6 - (°K) - > (°F) |");

            int.TryParse(Console.ReadLine(), out int opcao);
            switch(opcao){
            case 0 : System.Environment.Exit(0); break;
            case 1 : CelsiusParaF();break;
            case 2 : CelsiusParaK(); break;
            case 3 : FarenheightParaC(); break;
            case 4 : FarenheightParaK(); break;
            case 5 : KelvinParaC(); break;
            case 6 : KelvinParaF(); break;
            default : Menu();break;
            }
        }
    }
}