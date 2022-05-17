namespace Zoologico
{
    public class Animal
    {
        public Animal()
        {
            this.Especie = "";
            this.Peso = 0;
        }
        public Animal(string especie, double peso)
        {
            this.Especie = especie;
            this.Peso = peso;
        }
        public string Especie{get;set;}
        public double Peso{get;set;}
    }
}