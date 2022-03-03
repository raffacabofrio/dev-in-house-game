using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Item
{
    private string _nome;
    private string _description;
    private int _pontos;
    private string _mensagem;
    private string _atributo;
    private int _id;


    public string Nome { get => _nome; private set => _nome = value; }
    public string Description { get => _description; private set => _description = value; }
    public int Pontos { get => _pontos; private set => _pontos = value; }
    public string Mensagem { get => _mensagem; set => _mensagem = value; }
    public string Atributo { get => _atributo; set => _atributo = value; }
    public int Id { get => _id; set => _id = value; }

    //public string ataque;


    public Item(int id, string nome, string descricao, string mensagem, int pontos, string atributo)
    {
        Id = id;
        Nome = nome;
        Description = descricao;
        Mensagem = mensagem;
        Pontos = pontos;
        Atributo = atributo.ToLower().Trim();
    }

}
