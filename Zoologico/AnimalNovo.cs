using System;

namespace Zoologico
{
    public class AnimalNovo : Animal
    {
        public AnimalNovo(string especie,double peso, string tipoAlimentacao)
            :base(especie,peso)
        {
            this.TipoAlimentacao = tipoAlimentacao;
        }
        public string TipoAlimentacao { get; set; }

        public void ExibirDados()
        {
            
            Console.WriteLine($"Especide : {this.Especie} Peso : {this.Peso} Alimentação : {this.TipoAlimentacao}");
        }
    }
}