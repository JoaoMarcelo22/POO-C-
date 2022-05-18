using static Calculadora.Inicio;

namespace Calculadora
{
    public class Temperatura
    {
        public static void CelsiusParaF()
        {
            Console.Clear();
            Console.WriteLine("Digite o  Valor : ");
            float.TryParse(Console.ReadLine(),out float N1);

            var  resultado = ((N1 * 1.8)+32);

            Console.WriteLine($"{resultado}(°F)");
            Console.ReadKey();
            Menu();
        }
        public static void CelsiusParaK()
        {
            Console.Clear();
            Console.WriteLine("Digite o  Valor : ");
            float.TryParse(Console.ReadLine(),out float N1);

            var resultado = (N1 + 273.15);    

            Console.WriteLine($"{resultado}(°K)");
            Console.ReadKey();
            Menu();
        }
        public static void FarenheightParaC()
        {
            Console.Clear();
            Console.WriteLine("Digite o  Valor : ");
            float.TryParse(Console.ReadLine(),out float N1);

            var resultado = ((N1-32)/1.8);

            Console.WriteLine($"{resultado}(°C)");
            Console.ReadKey();
            Menu();
        }
        public static void FarenheightParaK()
        {
            Console.Clear();
            Console.WriteLine("Digite o  Valor : ");
            float.TryParse(Console.ReadLine(),out float N1);

            var resultado = (((N1-32)* 0.55555556) + 273.15);

            Console.WriteLine($"{resultado}(°C)");
            Console.ReadKey();
            Menu();
            //erro de calculo
        }
        public static void KelvinParaC()
        {
            Console.Clear();
            Console.WriteLine("Digite o  Valor : ");
            float.TryParse(Console.ReadLine(),out float N1);

            var resultado = N1 - 273.15;

            Console.WriteLine($"{resultado}(°C)");
            Console.ReadKey();
            Menu();
        }
        public static void KelvinParaF()
        {
            Console.Clear();
            Console.WriteLine("Digite o  Valor : ");
            float.TryParse(Console.ReadLine(),out float N1);

            var resultado = ((N1-273.15) * 1.8 ) + 32;

            Console.WriteLine($"{resultado}(°C)");
            Console.ReadKey();
            Menu();
        }
    }
}