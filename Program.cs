

var heroi = new Personagem
{
    Nome = "Link",
    Vida = 100,
    Armadura = 5,
    Ataque = 5,
};

var goblim = new Personagem
{
    Nome = "Goblim",
    Vida = 10,
    Armadura = 0,
    Ataque = 0,
};

var fluxo = new FlowEngine();
fluxo.Fluxo(heroi);

public class Personagem
{
    public string Nome { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }
    public int Armadura { get; set; }

}

