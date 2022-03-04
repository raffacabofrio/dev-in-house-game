public class Personagem
{
    public string Nome { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }
    public int Armadura { get; set; }
    public int AtaqueCritico { get; set; }

}


public class Monstro : Personagem
{
    private StoryTellerEngine _storyTeller;

    public string FraseDeMorte { get; set; } = "FRASE DE MORTE PADRÃO.";


    public Monstro()
    {
        _storyTeller = new MonsterStoryTeller();
    }

    ~Monstro()
    {
        if (Vida <= 0)
        {
            _storyTeller.Narrador = $"[{Nome}]: ";
            _storyTeller.Speak(FraseDeMorte);
        }
    }
}