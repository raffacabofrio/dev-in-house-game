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
    public string FraseDeMorte { get; set; } = "FRASE DE MORTE PADRÃO.";

    ~Monstro()
    {
        //  TODO: verificar a Vida se o monstro realmente morreu.

        // TODO: usar o storyTeller
        Console.WriteLine(FraseDeMorte);
    }
}