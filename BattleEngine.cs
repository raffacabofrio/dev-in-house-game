public class BattleEngine
{
    public void ataque(Personagem p1, Personagem p2)
    {
        int vidaInicialp2 = p2.Vida;

        Random number = new Random();
        int resultadoDado = number.Next(11);

        Console.WriteLine($"Resultado do dado: {resultadoDado}");

        int atk;

        if (resultadoDado == 10)
        {
            Console.WriteLine($"Wow, {p1.Nome} fez um ataque crítico!");
            atk = resultadoDado + p1.AtaqueCritico;
        }
        else
        {
            atk = resultadoDado + p1.Ataque;
        }

        atk -= p2.Armadura;

        if (atk <= 0)
        {
            Console.WriteLine($"{p1.Nome} errou o golpe.");
            return;
        }

        p2.Vida -= atk;

        Console.WriteLine($"{p1.Nome} atacou {p2.Nome} com sucesso. {p2.Nome} recebeu {atk} de dano.");
    }

    public void turno(Personagem p1, Personagem p2)
    {
        ataque(p1, p2);
        if (p2.Vida <= 0)
        {
            Console.WriteLine($"{p2.Nome} morreu!");
            return;
        }

        ataque(p2, p1);
        if (p1.Vida <= 0)
        {
            Console.WriteLine($"{p1.Nome} morreu!");
            return;
        }
    }
};