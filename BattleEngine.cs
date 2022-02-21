public class BattleEngine
{
    private BattleStoryTeller BattleStoryTeller = new();

    public void Turno(Personagem p1, Personagem p2)
    {
        var contadorTurno = 1;
        do{
            Console.WriteLine("Pressione 'Enter' para rodar o dado...");
            Console.ReadKey();

            Thread.Sleep(900);
            Ataque(p1, p2);
            if (p2.Vida <= 0)
            {
                BattleStoryTeller.Speak($"{p2.Nome} morreu!");
                return;
            }

            Thread.Sleep(2000);
            Ataque(p2, p1);
            if (p1.Vida <= 0)
            {
                BattleStoryTeller.Speak($"{p1.Nome} morreu!");
                return;
            }
            
            BattleStoryTeller.Speak($"O turno {contadorTurno} acabou!");
            contadorTurno++;
            Thread.Sleep(500);
          
        } while (p1.Vida > 0 && p2.Vida > 0 );
    }
    public void Ataque(Personagem atacante, Personagem oponente)
    {

        Random number = new Random();
        int resultadoDado = number.Next(11);
        int maxDuracao = 3;

       BattleStoryTeller.Speak($"Resultado do dado: {resultadoDado}");
        Thread.Sleep(maxDuracao * resultadoDado * 100);

        int atk;

        if (resultadoDado == 10)
        {
           BattleStoryTeller.Speak($"Wow, {atacante.Nome} fez um ataque crítico!");
            atk = resultadoDado + atacante.AtaqueCritico;
        }
        else
        {
            atk = resultadoDado + atacante.Ataque;
        }

        atk -= oponente.Armadura;

        if (atk <= 0)
        {
           BattleStoryTeller.Speak($"{atacante.Nome} errou o golpe.");
            return;
        }

        oponente.Vida -= atk;

        BattleStoryTeller.Speak($"{atacante.Nome} atacou {oponente.Nome} com sucesso. {oponente.Nome} recebeu {atk} de dano.");
    }

};