using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Arquivo
{
    private string _arquivoUrl;
    public Arquivo(string arquivo)
    {
        _arquivoUrl = arquivo;
    }
    public void LerArquivo()
    {
        // Exemplo leitura de CSV
        //var aventuras = new List<Aventura>();

        var pathCsv = Directory.GetCurrentDirectory() + "/Itens/Lista1.csv";
        var lines = File.ReadAllLines(pathCsv);

        foreach (var line in lines)
        {

            var colunas = line.Split(";");

            /* aventuras.Add(new Aventura
             {
                 Id = colunas[0],
                 Acao = colunas[1],
                 Param1 = colunas[2],
                 Param2 = colunas[3]
             });*/
        }
    }
}

