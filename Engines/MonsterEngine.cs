using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

public class MonsterEngine {

    private List<Monstro> _monstros { get; set; }

    public MonsterEngine()
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";"
        };

        using (var reader = new StreamReader(Directory.GetCurrentDirectory() + "/Csv/Monstros.csv"))
        using (var csv = new CsvReader(reader, config))
        {
            _monstros = csv.GetRecords<Monstro>().ToList() ;
        }
    }

    public Monstro ObterMonstro(string nome)
    {
        // Linq
        var monstro = _monstros.Where(m => m.Nome == nome).FirstOrDefault();

        if(monstro == null) return new Monstro();

        var monstroCopy = new Monstro(monstro);
        return monstroCopy;
    }

    public Monstro AranhaGigante() {
        var AranhaGigante = new Monstro
        {
        Nome = "Aranha Gigante",
        Vida = 26,
        Armadura = 14,
        Ataque = 5,
        AtaqueCritico = 10,
        };
        return AranhaGigante;
    }
     public Monstro Bandido() {
        var Bandido = new Monstro
        {
        Nome = "Bandido Marcarrubra",
        Vida = 16,
        Armadura = 14,
        Ataque = 4,
        AtaqueCritico = 8,
        };
        return Bandido;
    }
    public Monstro Bugbear() {
        var bugbear = new Monstro
        {
        Nome = "Bugbear",
        Vida = 27,
        Armadura =   16,
        Ataque = 4,
        AtaqueCritico = 8,
        };
        return bugbear;
    }

    public Monstro CranioEmChamas() {
        var cranioEmChamas = new Monstro
        {
        Nome = "Cranio Em Chamas",
        Vida = 40,
        Armadura =   13,
        Ataque = 5,
        AtaqueCritico = 10,
        };
        return cranioEmChamas;
    }

    

    public Monstro Cultista() {
        var cultista = new Monstro
        {
        Nome = "Cultista",
        Vida = 9,
        Armadura =   12,
        Ataque = 4,
        AtaqueCritico = 8,
        };
        return cultista;
    }

    public Monstro Doppelganger() {
        var doppelganger = new Monstro
        {
        Nome = "Doppelganger",
        Vida = 52,
        Armadura =   14,
        Ataque = 6,
        AtaqueCritico = 12,
        };
        return doppelganger;
    }
   public Monstro DragaoVerde() {
        var dragaoVerde = new Monstro
        {
        Nome = "Dragao Verde Jovem",
        Vida = 136,
        Armadura = 18,
        Ataque = 7,
        AtaqueCritico = 14,
        };
        return dragaoVerde;
    }

     public Monstro Esqueleto() {
        var Esqueleto = new Monstro{
        Nome = "Esqueleto",
        Vida = 13,
        Armadura = 13,
        Ataque = 4,
        AtaqueCritico = 8,
        };
        return Esqueleto;
    }

     public Monstro Carnical() {
        var carnical = new Monstro{
        Nome = "Carniçal",
        Vida = 22,
        Armadura = 12,
        Ataque = 3,
        AtaqueCritico = 6,
        };
        return carnical;
    }
    public Monstro Goblin() {
        var goblin = new Monstro {
            Nome = "Goblin",
            Vida = 10,
            Armadura = 0,
            Ataque = 0,
            AtaqueCritico = 2,
            Xp = 100,
        };

        return goblin;
    }

      public Monstro Gosma() {
        var Gosma = new Monstro{
        Nome = "Gosma Ocre",
        Vida = 45,
        Armadura = 8,
        Ataque = 4,
        AtaqueCritico = 8,
        };
        return Gosma;
    }
 public Monstro Robgoblin() {
        var robgoblin = new Monstro{
        Nome = "Robgoblin",
        Vida = 11,
        Armadura = 18,
        Ataque = 3,
        AtaqueCritico = 6,
        };
        return robgoblin;
    }
    public Monstro Lobo() {
        var lobo = new Monstro{
        Nome = "Lobo",
        Vida = 11,
        Armadura =   13,
        Ataque = 4,
        AtaqueCritico = 10,
        };
        return lobo;
    }
    public Monstro MagoMaligno() {
        var magoMaligno = new Monstro{
        Nome = "Mago Maligno",
        Vida = 22,
        Armadura = 12,
        Ataque = 3,
        AtaqueCritico = 6,
        };
        return magoMaligno;
    }
    public Monstro Mormesk() {
        var mormesk = new Monstro{
        Nome = "Mormesk a Aparição",
        Vida = 45,
        Armadura =   13,
        Ataque = 5,
        AtaqueCritico = 10,
        };
        return mormesk;
    }
    public Monstro Nezzar() {
        var nezzar = new Monstro{
        Nome = "Nezzar, o Aranha Negra",
        Vida = 27,
        Armadura =   11,
        Ataque = 6,
        AtaqueCritico = 12,
        };
        return nezzar;
    }
    public Monstro Nothic() {
        var nothic = new Monstro{
        Nome = "Nothic",
        Vida = 45,
        Armadura =   15,
        Ataque = 4,
        AtaqueCritico = 8,
        };
        return nothic;
    }

    public Monstro Ogro() {
        var ogro = new Monstro{
        Nome = "Ogro",
        Vida = 59,
        Armadura =   11,
        Ataque = 10,
        AtaqueCritico = 20,
        };
        return ogro;
    }
     public Monstro Orc() {
        var orc = new Monstro{
        Nome = "Orc",
        Vida = 15,
        Armadura =  13,
        Ataque = 5,
        AtaqueCritico = 10,
        };
        return orc;
    }

 public Monstro Plebeu() {
        var plebeu = new Monstro{
        Nome = "Plebeu",
        Vida = 4,
        Armadura =   10,
        Ataque = 2,
        AtaqueCritico = 4,
        };
        return plebeu;
    }
public Monstro RamosSecos() {
        var ramosSecos = new Monstro{
        Nome = "Ramos Secos",
        Vida = 4,
        Armadura =   10,
        Ataque = 2,
        AtaqueCritico = 4,
        };
        return ramosSecos;
    }
    public Monstro Sildar() {
        var sildar = new Monstro{
        Nome = "Sildar Hallwinter",
        Vida = 58,
        Armadura =   12,
        Ataque = 4,
        AtaqueCritico = 8,
        };
        return sildar;
    }

    public Monstro Stirge() {
        var stirge = new Monstro{
        Nome = "Stirge",
        Vida = 2,
        Armadura =   14,
        Ataque = 5,
        AtaqueCritico = 10,
        };
        return stirge;
    }
  
    public Monstro UrsoCoruja() {
        var ursoCoruja = new Monstro{
        Nome = "Urso Coruja",
        Vida = 2,
        Armadura =   14,
        Ataque = 7,
        AtaqueCritico = 14,
        };
        return ursoCoruja;
    }

    public Monstro Zumbi() {
        var zumbi = new Monstro{
        Nome = "Zumbi",
        Vida = 22,
        Armadura =   8,
        Ataque = 3,
        AtaqueCritico = 6,
        };
        return zumbi;
    }
public Monstro Ganon() {
        var ganon = new Monstro{
        Nome = "Ganon",
        Vida = 290,
        Armadura =  19,
        Ataque = 16,
        AtaqueCritico = 32,
        Xp = 100,
        };
        return ganon;
    }
}