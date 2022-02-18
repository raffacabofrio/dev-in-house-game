class FlowEngine
{
    public void Historia()
    {
        var batalha = new BattleEngine();
        var monstro = new MonsterEngine();

        Console.WriteLine("Qual e o seu nome heroi ? ");
        var nome = Console.ReadLine();
        var heroi = new Personagem
        {
            Nome = nome,
            Vida = 100,
            Armadura = 5,
            Ataque = 5,
            AtaqueCritico = 10,
        };

        Console.WriteLine(@"Na cidade de Neverwinter um anão chamado Gundren
                            Buscapedra tenta lhe contratar para escoltar uma carroça de
                            suprimentos, até a vila sem lei de Phandalin, que fica
                            há dois dias e viagem a sudeste da cidade. Voce aceitara* o contrato? " );
                            

        var caminho = Fluxo(heroi,"sim","nao"); 
        if(caminho == 1) {
            Console.WriteLine("Grunden na verdade era Ganon e quando voce vira as costas ele te ataca");   
            batalha.Turno(monstro.Ganon(), heroi);
            if(heroi.Vida <= 0) {
                GameOver($"Voce foi morto pelo {monstro.Ganon().Nome}");
            }
        }                  

    }
    public int Fluxo(Personagem heroi, string opcao_1, string opcao_2 )
    {
        
        var decisao = 1;
        bool inputValido2 = false;

        List<string> caminhos = new List<string> { opcao_1, opcao_2};
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
    
   
    public void GameOver(string mensagem) {
        Console.WriteLine(mensagem);
        Environment.Exit(0);
    }

}
