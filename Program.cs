

var heroi = new Personagem{
    Nome = "Link",
    Vida = 100,
    Armadura = 5,
    Ataque = 5,
    AtaqueCritico = 10,
};

var goblim = new Personagem{
    Nome = "Goblim",
    Vida = 10,
    Armadura = 0,
    Ataque = 0,
    AtaqueCritico = 2,
};

void ataque(Personagem p1, Personagem p2) {
    int vidaInicialp2 = p2.Vida;
    
    Random number = new Random();
    int resultadoDado = number.Next(11);

    Console.WriteLine($"Resultado do dado: {resultadoDado}");

    int atk;

    if (resultadoDado == 10) {
        Console.WriteLine($"Wow, {p1.Nome} fez um ataque crítico!");
        atk = resultadoDado + p1.AtaqueCritico;
    } else {
        atk = resultadoDado + p1.Ataque;
    }

    atk -= p2.Armadura;

    if (atk <= 0) {
        Console.WriteLine($"{p1.Nome} errou o golpe.");
        return;
    }

    p2.Vida -= atk;

    Console.WriteLine($"{p1.Nome} atacou {p2.Nome} com sucesso. {p2.Nome} recebeu {atk} de dano.");
};

void turno(Personagem p1, Personagem p2) {
    ataque(p1, p2);
    if(p2.Vida <= 0) {
        Console.WriteLine($"{p2.Nome} morreu!");
        return;
    } 

    ataque(p2, p1);
    if(p1.Vida <= 0) {
        Console.WriteLine($"{p1.Nome} morreu!");
        return;
    }
}


while(heroi.Vida > 0 && goblim.Vida > 0) {
    turno(heroi, goblim);
}

public class Personagem {
    public string Nome { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }
    public int Armadura { get; set; }
    public int AtaqueCritico { get; set; }
}

