

//var fluxo = new FlowEngine();
//fluxo.Historia();


// Exemplo leitura de CSV
var aventuras = new List<Aventura>();

var pathCsv = Directory.GetCurrentDirectory() + "/Aventuras/Ruinas Perdidas de Phandelver.csv";
var lines = File.ReadAllLines(pathCsv);
            
foreach (var line in lines)
{
    var colunas = line.Split(",");
    aventuras.Add(new Aventura
    {
        Id = colunas[0],
        Acao = colunas[1],
        Param1 = colunas[2],
        Param2 = colunas[3]
    });
}


foreach (var aventura in aventuras)
{
    Console.WriteLine(aventura.Id + " ... " + aventura.Acao + " ... " + aventura.Param1 + " ... " + aventura.Param2);
}

public class Aventura
{
    public string? Id { get; set; }
    public string? Acao { get; set; }
    public string? Param1 { get; set; }
    public string? Param2 { get; set; }
}