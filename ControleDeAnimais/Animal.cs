namespace ControleDeAnimais
{
    public class Animal
    {
        private string  nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value.ToLower(); }
        }
        private string tipo;
        public string   Tipo
        {
            get { return tipo; }
            set { if(value == "cachorro"|| value =="gato" || value=="peixe")
            {
            tipo = value;
            }
            else{
                tipo = "peixe";
            } }
        }  
    }
}