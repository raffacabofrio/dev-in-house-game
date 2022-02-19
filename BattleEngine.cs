public class BattleEngine
{
    public void Turno(Personagem p1, Personagem p2)
    {
        var contadorTurno = 1;
        do{
            Thread.Sleep(900);
            Ataque(p1, p2);
            if (p2.Vida <= 0)
            {
                Console.WriteLine($"{p2.Nome} morreu!");
                return;
            }

            Thread.Sleep(2000);
            Ataque(p2, p1);
            if (p1.Vida <= 0)
            {
                Console.WriteLine($"{p1.Nome} morreu!");
                return;
            }
            
            Console.WriteLine($"O turno {contadorTurno} acabou!");
            contadorTurno++;
            Thread.Sleep(500);
            Console.WriteLine("Pressione 'Enter' para rodar o dado...");
            Console.ReadKey();

        } while (p1.Vida > 0 && p2.Vida > 0 );
    }
    public void Ataque(Personagem atacante, Personagem oponente)
    {

        Random number = new Random();
        int resultadoDado = number.Next(11);
        int maxDuracao = 3;

        Console.WriteLine($"Resultado do dado: {resultadoDado}");
        Thread.Sleep(maxDuracao * resultadoDado * 100);

        int atk;

        if (resultadoDado == 10)
        {
            Console.WriteLine($"Wow, {atacante.Nome} fez um ataque crítico!");
            atk = resultadoDado + atacante.AtaqueCritico;
        }
        else
        {
            atk = resultadoDado + atacante.Ataque;
        }

        atk -= oponente.Armadura;

        if (atk <= 0)
        {
            Console.WriteLine($"{atacante.Nome} errou o golpe.");
            return;
        }

        oponente.Vida -= atk;

        Console.WriteLine($"{atacante.Nome} atacou {oponente.Nome} com sucesso. {oponente.Nome} recebeu {atk} de dano.");
    }

};