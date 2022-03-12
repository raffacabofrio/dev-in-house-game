using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

public class FlowEngine
{
    private List<AventuraPasso> _aventura;
    private GameStoryTeller _storyTeller = new GameStoryTeller();
    private Personagem heroi;
    private BattleEngine batalha;
    private MonsterEngine monstro;

    public FlowEngine()
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";"
        };

        using (var reader = new StreamReader(Directory.GetCurrentDirectory() + "/Csv/Aventuras/O templo do Dragão das Névoas.csv"))
        using (var csv = new CsvReader(reader, config))
        {
            _aventura = csv.GetRecords<AventuraPasso>().ToList();
        }

        heroi = new Personagem
        {
            Nome = "andre",
            Vida = 20,
            Armadura = 5,
            Ataque = 10,
            AtaqueCritico = 20,
        };

        batalha = new BattleEngine();
        monstro = new MonsterEngine();
    }

    public void ContaHistoria()
    {     
        var fim = false;
        var passoAtual = new AventuraPasso();
        var passoAtualIndex = 1;

        while (!fim)
        {

            passoAtual = ObterPassoAtual(passoAtualIndex);

            if (passoAtual.Acao == "ESTORIA")
            {
                _storyTeller.Speak(passoAtual.Param1);
                passoAtualIndex++;
            }

            if (passoAtual.Acao == "DECISAO")
            {
                passoAtualIndex = Decisao(passoAtual.Param1);
            }

            if (passoAtual.Acao == "BATALHA")
            {
                Batalha(heroi, passoAtual.Param1);
                passoAtualIndex++;
            }


            if (passoAtual.Acao == "GAMEOVER")
            {
                GameOver(passoAtual.Param1);
                fim = true;
            }


        }
        // acaba com o loop, acredito que a criação do loop aconteceu pq as chamadas das funçoes ficavam em pilha.
        Environment.Exit(0);
    }

    private AventuraPasso ObterPassoAtual(int passoAtualIndex)
    {
        var passo = _aventura.FirstOrDefault(a => a.Passo == passoAtualIndex);

        if (passo == null) return new AventuraPasso { Acao = "GameOver", Param1 = $"Ocorreu um erro. Passo não encontrado ({passoAtualIndex})." };

        return passo;
    }

    private int Decisao(string param1)
    {
        string[] paramVetor = param1.Split(",");
        List<int> passos = new List<int>();
        List<string> opcoes = new List<string>();

        // defini os ponteiros e as opcoes
        foreach (string param in paramVetor)
        {
            var vetor2 = param.Split(":");
            passos.Add(int.Parse(vetor2[0]));
            opcoes.Add(vetor2[1]);
        }


        var decisao = 1;
        bool inputValido = false;

        do
        {

            int x = 0;
            foreach (string opcao in opcoes)
            {
                Console.WriteLine($"{opcao} [{x}]");
                x++;
            }

            var NumeroValido = Int32.TryParse(Console.ReadLine(), out decisao);

            if (!NumeroValido || decisao >= opcoes.Count || decisao < 0)
            {
                Console.WriteLine("Voce nao  digitou uma opcao valida!!, Digite novamente");
            }
            else
            {
                inputValido = true;
            }

        } while (!inputValido);


        int passoSelecionado = passos[decisao];
        return passoSelecionado;
    }

    private void Batalha(Personagem p1, String nomeMonstro)
    {
        var p2 = monstro.ObterMonstro(nomeMonstro);
        batalha.Turno(p1, p2);

        if (p1.Vida <= 0)
            GameOver($"Game over! {p1.Nome} foi morto pelo {p2.Nome}.");
    }

    public void GameOver(string mensagem)
    {
        _storyTeller.Speak(mensagem);
        Environment.Exit(0);
    }
}




