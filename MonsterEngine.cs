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

    public Personagem Banshee() {
        var banshee = new Personagem{
        Nome = "Banshee",
        Vida = 58,
        Armadura =   12,
        Ataque = 4,
        AtaqueCritico = 8,
        };
        return banshee;
    }

    public Personagem Bugbear() {
        var bugbear = new Personagem{
        Nome = "Bugbear",
        Vida = 27,
        Armadura =   16,
        Ataque = 4,
        AtaqueCritico = 8,
        };
        return bugbear;
    }
    public Personagem DragaoVerde() {
        var dragaoVerde = new Personagem{
        Nome = "Dragao Verde",
        Vida = 207,
        Armadura = 19,
        Ataque = 11,
        AtaqueCritico = 22,
        };
        return dragaoVerde;
    }
     public Personagem Esqueleto() {
        var Esqueleto = new Personagem{
        Nome = "Esqueleto",
        Vida = 13,
        Armadura = 13,
        Ataque = 4,
        AtaqueCritico = 8,
        };
        return Esqueleto;
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