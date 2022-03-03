using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Arquivo
{
    private string _arquivoUrl;
    private List<List<string>> _lines = new List<List<string>>();

    public Arquivo(string arquivo)
    {
        _arquivoUrl = arquivo;
    }

    public List<List<string>> LerArquivo()
    {
        var pathCsv = Directory.GetCurrentDirectory() + _arquivoUrl;
        var lines = File.ReadAllLines(pathCsv);
        int firstLine = 1;
        foreach (var line in lines)
        {
            if (firstLine == 1)
            {
                firstLine += 1;
                continue;
            }
            firstLine += 1;
            var colunas = line.Split(";");
            _lines.Add(colunas.ToList());
        }
        return _lines;
    }
}

