using System;
using System.Collections.Generic;

namespace Restaurantes.Classes
{
    public class Prato
    {
    public string Nome {get; private set;}    
    public List<Ingrediente> Ingredientes {get; private set;}

    public Prato(string nome)
    {
        this.Nome = nome;
        this.Ingredientes = new List<Ingrediente>();
    }

public void AdicionarIngrediente(Ingrediente ingrediente)
{
    Ingredientes.Add(ingrediente);
}

        public override string ToString()
        {
            string texto = "";

            texto = this.Nome + Environment.NewLine;
            texto += "Ingredientes: " + Environment.NewLine;
            foreach(var ingrediente in Ingredientes)
            {
                texto += ingrediente + Environment.NewLine;
            }

            return texto;
        }
    }
}