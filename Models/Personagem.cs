public class Personagem
{
    protected int _vida;
    
    public string Nome { get; set; } = "";
    public virtual int Vida { get => _vida; set => _vida = value; }
    public int Ataque { get; set; }
    public int Armadura { get; set; }
    public int AtaqueCritico { get; set; }

}

public class Heroi : Personagem
{
    public int XpGanho { get; set; } = 0;
    public int Nivel { get; set; } = 0;
}


public class Monstro : Personagem
{
    private StoryTellerEngine _storyTeller;

    public string FraseDeMorte { get; set; } = "FRASE DE MORTE PADRÃO.";
    public int Xp { get; set; } = 10;

    public override int Vida
    {
        get => _vida;
        set
        {
            if (value <= 0)
                Morte();

            _vida = value;
        }
    }


    public Monstro()
    {
        _storyTeller = new MonsterStoryTeller();
    }

    public Monstro(Monstro monstro) : this()
    {
        Nome = monstro.Nome;
        Vida = monstro.Vida;
        Ataque = monstro.Ataque;
        AtaqueCritico = monstro.AtaqueCritico;
        Armadura = monstro.Armadura;
        FraseDeMorte = monstro.FraseDeMorte;
        Xp = monstro.Xp;
        
    }

    private void Morte()
    {
        _storyTeller.Narrador = $"[{Nome}]: ";
        _storyTeller.Speak(FraseDeMorte);
    }


}