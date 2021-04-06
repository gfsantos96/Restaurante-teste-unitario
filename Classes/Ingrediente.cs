namespace Restaurantes.Classes
{
    public class Ingrediente
    {
        public string Nome {get; private set;}
        public int Quantidade {get; private set;}

        public Ingrediente(string nome, int quantidade)
        {
            this.Nome = nome;
            this.Quantidade = quantidade;
        }

        public override string ToString()
        {
            return this.Nome + "; Quantidade: " + this.Quantidade;
        }
    }
}