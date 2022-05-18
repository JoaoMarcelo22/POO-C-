using static Calculadora.Inicio;
using static Calculadora.Program;
namespace Calculadora
{
    public class Operacoes
    {
        
        public static void Divisao()
        { 
            Console.Clear();
            Console.WriteLine("Digite o primeiro numero : ");
            float.TryParse(Console.ReadLine(),out float N1);

            Console.WriteLine("Digite o segundo numero : ");
            float.TryParse(Console.ReadLine(),out float N2);
        
            float resultado = N1 / N2;
            Console.WriteLine("");
            
            Console.WriteLine($"O resultado da divisão é : {resultado}");
            Console.ReadKey();
            Menu();
        }
        public static void Media1()
        { 
            Console.Clear();
            Console.WriteLine("Digite o primeiro numero : ");
            float.TryParse(Console.ReadLine(),out float N1);

            Console.WriteLine("Digite o segundo numero : ");
            float.TryParse(Console.ReadLine(),out float N2);

            float resultado = (N1 + N2)/2;
            Console.WriteLine("");

            Console.WriteLine($"O resultado da media é : {resultado}");
            Console.ReadKey();
            Menu();
        }
        public static void Multiplicacao()
        { 
            Console.Clear();
            Console.WriteLine("Digite o primeiro numero : ");
            float.TryParse(Console.ReadLine(),out float N1);

            Console.WriteLine("Digite o segundo numero : ");
            float.TryParse(Console.ReadLine(),out float N2);

            float resultado = N1 * N2;
            Console.WriteLine("");

            Console.WriteLine($"O resultado da multiplicação é : {resultado}");
            Console.ReadKey();
            Menu();
        }
        public static void Soma()
        { 
            Console.Clear();
            Console.WriteLine("Digite o primeiro numero : ");
            float.TryParse(Console.ReadLine(),out float N1);

            Console.WriteLine("Digite o segundo numero : ");
            float.TryParse(Console.ReadLine(),out float N2);

            float resultado = N1 + N2;
            Console.WriteLine("");

            Console.WriteLine($"O resultado da soma é : {resultado}");
            Console.ReadKey();
            Menu();
        }
        public static void Subtracao()
        { 
            Console.Clear();
            Console.WriteLine("Digite o primeiro numero : ");
            float.TryParse(Console.ReadLine(),out float N1);

            Console.WriteLine("Digite o segundo numero : ");
            float.TryParse(Console.ReadLine(),out float N2);

            float resultado = N1 - N2;

            Console.WriteLine("");

            Console.WriteLine($"O resultado é : {resultado}");
            Console.ReadKey();
            Menu();
            
        }
        public static void Texto()
        {
            

            
        }
    }
}