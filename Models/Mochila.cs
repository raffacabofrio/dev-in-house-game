using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Mochila
{
    private List<dynamic> _mochilaList = new List<dynamic>();

    public void AdicionarItem(dynamic item)
    {
        if (_mochilaList.Count() <= 5)
        {
            _mochilaList.Add(item);
        }
        else
        {
            Console.WriteLine("Voce chegou ao limite de itens permitidos");
        }
    }
    public void ListarItens()
    {
        int indice = 0;
        foreach (dynamic item in _mochilaList)
        {
            Console.WriteLine($"[{indice + 1}]{item}");
            indice++;
        }
    }

    public dynamic RetornarItem(int n_item)
    {
        return _mochilaList[n_item - 1];
    }

    public string ExcluirItem(int n_item)
    {
        bool resultado = _mochilaList.Remove(n_item - 1);
        if (resultado)
        {
            return "O item foi excluido com sucesso";
        }
        return "Houve um erro ao excluir o item, talvez ele nao exista";
    }
}
