

var heroi = new Personagem{
    Nome = "Link",
    Vida = 100,
    Armadura = 5,
    Ataque = 5,
};

var goblim = new Personagem{
    Nome = "Goblim",
    Vida = 10,
    Armadura = 0,
    Ataque = 0,
};


// tomou um hit
var dano = 15;
heroi.Vida = heroi.Vida - dano;


Console.WriteLine($"Olá {heroi.Nome}, você tem {heroi.Vida} de vida.");


// ganhou uma poção de cura


Console.WriteLine($"Olá {heroi.Nome}, você tem {heroi.Vida} de vida.");

void PocaodeCura(Personagem heroi){
    
    heroi.Vida = heroi.Vida + 50;



}

public class Personagem {
    public string Nome { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }
    public int Armadura { get; set; }

}