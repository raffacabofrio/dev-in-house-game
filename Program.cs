

//var fluxo = new FlowEngine();
//fluxo.Historia();

// to do.. criar uma classe para itens de cenario, EXEMPLO: ARMADILHAS





// Exemplo leitura de CSV
/*var aventuras = new List<Aventura>();

//var pathCsv = Directory.GetCurrentDirectory() + "/Aventuras/Ruinas Perdidas de Phandelver.csv";
var pathCsv = Directory.GetCurrentDirectory() + "/Itens/TextTemplate1.csv";
var lines = File.ReadAllLines(pathCsv);

foreach (var line in lines)
{
    var colunas = line.Split(",");
    *//*aventuras.Add(new Aventura
    {
        Id = colunas[0],
        Acao = colunas[1],
        Param1 = colunas[2],
        Param2 = colunas[3]
    });*//*
    Console.WriteLine(colunas[0]);
}

*//*
foreach (var aventura in aventuras)
{
    Console.WriteLine(aventura.Id + " ... " + aventura.Acao + " ... " + aventura.Param1 + " ... " + aventura.Param2);
}*//*

public class Aventura
{
    public string? Id { get; set; }
    public string? Acao { get; set; }
    public string? Param1 { get; set; }
    public string? Param2 { get; set; }
}*/
/*Arquivo arq = new Arquivo("./Aventuras/Ruinas Perdidas de Phandelver.csv");
List<List<string>> lista = new List<List<string>>();
lista = arq.LerArquivo();

foreach (var line in lista)
{
    Console.WriteLine(line[2]);
}*/

//var heroi = new Personagem
/*{
    Nome = "andre",
    Vida = 50,
    Armadura = 5,
    Ataque = 5,
    AtaqueCritico = 10,
};*/
//var itemEngine = new ItemEngine();
//itemEngine.PegaItem("Maca", heroi);
//Console.WriteLine(item);






