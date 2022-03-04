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
    //private List<string> _linesEstoria = new List<string>();
    private List<int> escolhasPonteiro = new List<int>();
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
    }

    public void ContaHistoria(int ponteiro)
    {
        for (int i = ponteiro; i < _lines.Count; i++)
        {
            if (_lines[i][1] == "ESTORIA")
            {
                _storyTeller.Speak(_lines[i][2]);
            }
            else if (_lines[i][1] == "DECISAO")
            {
                escolhasPonteiro.Add(int.Parse(_lines[i][3])); // nao
                escolhasPonteiro.Add(int.Parse(_lines[i][2])); // sim
                Escolha(heroi, "nao", "sim");
            }
        }
    }
    public void Escolha(Personagem heroi, string opcao_1, string opcao_2)
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

        if (decisao == 1)
        {
            ContaHistoria(escolhasPonteiro[decisao - 1]);
        }
        else
        {
            Console.WriteLine("erro");
        }
        //return decisao;

    }
}

