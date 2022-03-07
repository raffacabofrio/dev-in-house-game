using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FlowEngineTeste
{
    private dynamic _lines;
    private GameStoryTeller _storyTeller = new GameStoryTeller();
    private Personagem heroi;
    private BattleEngine batalha;
    private MonsterEngine monstro;

    public FlowEngineTeste()
    {
        var arquivo = new Arquivo("./Csv/Aventuras/O templo do Dragão das Névoas.csv");
        _lines = arquivo.LerArquivo();
        heroi = new Personagem
        {
            Nome = "andre",
            Vida = 50,
            Armadura = 5,
            Ataque = 100,
            AtaqueCritico = 10,
        };
        batalha = new BattleEngine();
        monstro = new MonsterEngine();
    }

    public void ContaHistoria(int ponteiro, List<int> ponteirosIgnoraveis)
    {
        for (int i = ponteiro; i < _lines.Count; i++)
        {
            if (!ponteirosIgnoraveis.Contains(i))
            {
                var acao = _lines[i][1];
                var param1 = _lines[i][2];
                var param2 = _lines[i][3];

                if (acao == "ESTORIA")
                    _storyTeller.Speak(param1);
                else if (acao == "DECISAO")
                    Decisao(param1);
                else if (acao == "BATALHA")
                {
                    Turno(heroi, param1);
                }
                else if (acao == "GAMEOVER")
                {
                    _storyTeller.Speak(param1);
                    Environment.Exit(0);
                }
            }
        }
        // acaba com o loop, acredito que a criação do loop aconteceu pq as chamadas das funçoes ficavam em pilha.
        Environment.Exit(0);
    }

    private void Decisao(string param1)
    {
        string[] paramVetor = param1.Split(",");
        List<int> ponteiros = new List<int>();
        List<string> opcoes = new List<string>();
        var decisao = 1;
        bool inputValido2 = false;


        // defini os ponteiros e as opcoes
        foreach (string param in paramVetor)
        {
            var vetor2 = param.Split(":");
            ponteiros.Add(int.Parse(vetor2[0]) - 1);
            opcoes.Add(vetor2[1]);
        }

        do
        {

            int x = 0;
            foreach (string opcao in opcoes)
            {
                Console.WriteLine($"{opcao} [{x}]");
                x++;
            }

            var NumeroValido = Int32.TryParse(Console.ReadLine(), out decisao);

            if (!NumeroValido || decisao >= opcoes.Count)
            {
                Console.WriteLine("Voce nao  digitou uma opcao valida!!, Digite novamente");
            }
            else
            {
                inputValido2 = true;
            }

        } while (!inputValido2);


        int ponteiro = ponteiros[decisao];

        // retira da lista o ponteiro escolhido
        ponteiros.Remove(ponteiro);

        ContaHistoria(ponteiro, ponteiros);
    }

    private void Turno(Personagem p1, String nomeMonstro)
    {
        Turno2(p1, nomeMonstro);
        GC.Collect(); // força o destruidor ser chamado.
        Thread.Sleep(1000); // dá um pouco de tempo do GC fazer o trampo dele.
    }

    private void Turno2(Personagem p1, String nomeMonstro)
    {
        var p2 = monstro.ObterMonstro(nomeMonstro);
        batalha.Turno(p1, p2);
    }
}




