using static Calculadora.Temperatura;
using static Calculadora.Operacoes;
using static Calculadora.Program;
namespace Calculadora
{
    public class Inicio
    {
        public enum OpcoesMenu
        {
            Somar = 1,
            Subtracao = 2,
            Divisao = 3,
            Multiplicacao = 4,
            Media = 5,
        }
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Digite a opção desejada: ");
            Console.WriteLine("1 - Calculadora | 2 - Temperatura");
            var escolha = int.Parse(Console.ReadLine());
            switch(escolha)
            {
            case 0 : System.Environment.Exit(0); break;
            case 1 : MenuCalculadora();break;
            case 2 : MenuTemperatura();break;
            default : Menu();break;

            }

        }
        public static void MenuCalculadora()
        {
            bool continuar = true;
           
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Digite a opção desejada: ");
                Console.WriteLine("1 - Somar ; 2 - Subtração ; 3 - Divisão ; 4 - Multiplicação ; 5 - Media");
                OpcoesMenu opcao = (OpcoesMenu)int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine($"Você escolheu a opçao: {opcao.ToString()}");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("Digite o primeiro numero: ");
                float N1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                float N2 = float.Parse(Console.ReadLine());
                var resultado = Calcula(opcao, N1, N2);
                Console.Clear();
                Console.WriteLine($"A operaçao escolhida foi {opcao} e o resultado é {resultado}");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("1 - Continuar ; 2 - Sair");
                continuar = int.Parse(Console.ReadLine()) == 1 ?  true : false;                
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