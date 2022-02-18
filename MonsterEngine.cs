public class MonsterEngine {

    public Personagem Goblin() {
        var goblin = new Personagem{
        Nome = "Goblin",
        Vida = 10,
        Armadura = 0,
        Ataque = 0,
        AtaqueCritico = 2,
        };
        return goblin;
    }

     public Personagem Orc() {
        var orc = new Personagem{
        Nome = "Orc",
        Vida = 15,
        Armadura =  13,
        Ataque = 5,
        AtaqueCritico = 10,
        };
        return orc;
    }

public Personagem Lobo() {
        var lobo = new Personagem{
        Nome = "Lobo",
        Vida = 11,
        Armadura =   13,
        Ataque = 4,
        AtaqueCritico = 10,
        };
        return lobo;
    }
public Personagem Ganon() {
        var ganon = new Personagem{
        Nome = "Ganon",
        Vida = 290,
        Armadura =  19,
        Ataque = 16,
        AtaqueCritico = 32,
        };
        return ganon;
    }
}