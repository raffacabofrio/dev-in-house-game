
class FlowEngine
{
    private BattleEngine batalha;
    private MonsterEngine monstro;
    private ItemEngine item;
    private GameStoryTeller storyTeller;

    public FlowEngine()
    {
        batalha = new BattleEngine();
        monstro = new MonsterEngine();
        item = new ItemEngine();
        storyTeller = new GameStoryTeller();
    }

    public void Historia()
    {    
        //storyTeller.Speak("Qual e o seu nome heroi ? ");
        //var nome = Console.ReadLine();

        var nome = "Linq";

        var heroi = new Personagem
        {
            Nome = nome,
            Vida = 50,
            Armadura = 5,
            Ataque = 200,
            AtaqueCritico = 400,
        };

        storyTeller.Speak("Lutas em sequência pra testar a frase de morte.");

        Turno(heroi, "Goblin");
        Turno(heroi, "Goblin");
        Turno(heroi, "Ganon");

        GameOver("TESTE DO DEV");


      

        storyTeller.Speak(@"Na cidade de Gerudo um anão chamado Gundren tenta lhe contratar para escoltar uma carroça de suprimentos até a vila sem lei de Phandalin,
        que fica há dois dias e viagem a sudeste da cidade.");

        storyTeller.Speak("Voce aceitará o contrato?");

        var caminho = Fluxo(heroi, "Sim", "Não");
        item.PegaItem("SimpleSword");
        if (caminho == 1)
        {
            storyTeller.Speak("Descontente com sua resposta, Grunden , que na verdade é Ganon, te ataca pelas costas!!");
            batalha.Turno(monstro.ObterMonstro("Ganon"), heroi);
            if (heroi.Vida <= 0)
            {
                GameOver($"Voce foi morto pelo {monstro.ObterMonstro("Ganon").Nome}");
            }
        }
        ContarHistoria(@$"Gundren fica bem animado por {heroi.Nome} ter aceito o contrato e começa a contar sobre a viagem,dizendo apenas que ele e seus irmãos haviam encontrado “algo grande”, e vai pagar dez peças de ouro a você para escoltar os suprimentos em segurança até a Barthen Provisões, um posto de troca em Phandalin.");

        ContarHistoria(@$"A jornada o leva ao sul pela Estrada Alta até a Trilha Triboar, que fica ao leste. Perto do meio dia , vocês são emboscados por goblins saqueadores da tribo Dentefi .");

        storyTeller.Speak($"O que {heroi.Nome} fará: ");

        caminho = Fluxo(heroi, "Lutar", "Correr");

        if (caminho == 1)
        {
            storyTeller.Speak("Descontente com sua resposta, Grunden , que na verdade é Ganon, te ataca pelas costas!!");
            batalha.Turno(monstro.Ganon(), heroi);
            if (heroi.Vida <= 0)
            {
                GameOver($"Voce foi morto pelo {monstro.ObterMonstro("Ganon").Nome}");
            }
        }


        Turno(heroi, "Goblin");

        if (heroi.Vida <= 0)
        {
            GameOver($"Voce foi morto pelo {monstro.ObterMonstro("Goblin").Nome}");
        }

        Console.WriteLine($"Após saquear o corpo de {monstro.ObterMonstro("Goblin").Nome} ");
        //item.SimpleSword(heroi);
        item.PegaItem("SimpleSword");

        Console.WriteLine($"Após a batalha, {heroi.Nome} e Grunden chegam em segurança até a Barthen Provisões");
        Console.WriteLine($"{heroi.Nome} recebe 10 moedas de ouro.");
        Console.WriteLine("Continua ...");
    }
    public int Fluxo(Personagem heroi, string opcao_1, string opcao_2)
    {

        var decisao = 1;
        bool inputValido2 = false;

        List<string> caminhos = new List<string> { opcao_1, opcao_2 };
        do
        {

            int x = 0;
            foreach (string opcoes in caminhos)
            {
                Console.WriteLine($"{opcoes} [{x}]");
                x++;
            }
            var NumeroValido = Int32.TryParse(Console.ReadLine(), out decisao);
            if (!NumeroValido || decisao >= caminhos.Count)
            {
                Console.WriteLine("Voce nao  digitou uma opcao valida!!, Digite novamente");
            }
            else
            {
                inputValido2 = true;
            }
        } while (!inputValido2);

        return decisao;

    }

    public void ContarHistoria(string historia)
    {
        historia = historia.Replace("  ", " ");
        // historia = historia.Replace("\n" , "");
        Console.WriteLine(historia);
        Console.WriteLine("Pressione enter para continuar");
        Console.ReadKey();

    }
    public void GameOver(string mensagem)
    {
        Console.WriteLine(mensagem);
        Environment.Exit(0);
    }

    private void Turno(Personagem p1, String nomeMonstro)
    {
        var p2 = monstro.ObterMonstro(nomeMonstro);
        batalha.Turno(p1, p2);
    }

}
