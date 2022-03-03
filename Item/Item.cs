using System;

public class Item2
{
    private string _name;
    private string _description;
    private int _pontos;


    public string Name { get => _name; private set => _name = value; }
    public string Description { get => _description; private set => _description = value; }
    public int Pontos { get => _pontos; private set => _pontos = value; }

    public Item2(string Name, string Description, int Pontos)
    {
        Name = Name;
        Description = Description;
        Pontos = Pontos;

    }


}
