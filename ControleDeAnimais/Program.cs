using System;
namespace ControleDeAnimais
{
    public class ControleDeAnimais
    {
      public static void Main(string[] args)
      {
          Animal E = new Animal();

          int tiCachorro = 0,tiGato = 0,tiPeixe = 0;

          for(int i = 0; i < 3;i++)
          {

            Console.WriteLine("Controle de animais :");
            Console.WriteLine("===========================================");
            Console.WriteLine("Informe o nome  animal: ");
            E.Nome = Console.ReadLine();
            Console.WriteLine("Informe o tipo do animal : (cachorro, gato ou peixe)");
            E.Tipo = Console.ReadLine();
            if(E.Tipo == "cachorro") tiCachorro++;
            else if(E.Tipo == "gato") tiGato++;
            else tiPeixe++;
            Console.Clear();
          }
          Console.WriteLine($"esse é o total de Cachorro : {tiCachorro}");
          Console.WriteLine($"esse é o total de Gato : {tiGato}");
          Console.WriteLine($"esse é o total de Peixe : {tiPeixe}");
      }
    }
}