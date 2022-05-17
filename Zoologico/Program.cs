using System;
using System.Collections.Generic;

namespace Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AnimalNovo> animais = new List<AnimalNovo>();
            int CarnivoroQtd =0, HerbivoroQtd = 0;
            Console.WriteLine("Programa que conta quantos animais são carniviros e herbivoros");
            for(int i = 0; i < 4; i++)
            {
                AnimalNovo animal = new AnimalNovo();
                Console.Write("Especie: ");
                animal.Especie = Console.ReadLine();
                Console.Write("Peso: ");
                animal.Peso = Convert.ToDouble (Console.ReadLine());
                Console.Write("Tipo alimentação: ");
                animal.TipoAlimentacao = Console.ReadLine();
                if(animal.TipoAlimentacao == "carnivoro")
                {
                    CarnivoroQtd++;
                }
                else
                {
                    HerbivoroQtd++;
                }
                animais.Add(animal);
            }
            Console.Clear();
            Console.WriteLine($"Total de animais : {animais}");
            Console.WriteLine($"Total de animais carnivoros : {CarnivoroQtd}");
            Console.WriteLine($"Total de animais herbivoro : {HerbivoroQtd}");

        }
    }
}
