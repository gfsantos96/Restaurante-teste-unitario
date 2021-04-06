using System;

namespace Restaurantes.Classes
{
    public class Restaurante
    {
public string Nome {get; private set;}        
public Prato PratoPrincipal {get; private set;}
public int HoraAbertura {get; private set;}
public int HoraFechamento {get; private set;}

public Restaurante(string nome)
{
    this.Nome = nome;
}

public void DefinirPratoPrincipal(Prato pratoPrincipal)
{
    this.PratoPrincipal = pratoPrincipal;
}

public void DefinirHorarioFuncionamento(int horaAbertura, int horaFechamento)
{
this.HoraAbertura = horaAbertura;
this.HoraFechamento = horaFechamento;
}

public override string ToString()
{
    string texto = "";

    texto = this.Nome + Environment.NewLine;
    texto += "Horário de funcionamento: das " + this.HoraAbertura + " às " + this.HoraFechamento + Environment.NewLine;
    texto += "Prato principal: " + this.PratoPrincipal;
    return texto;
}
    }
}