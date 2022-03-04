public class ItemEngine
{
    private List<List<string>> _itensLista = new List<List<string>>();
    private StoryTellerEngine _storyTeller = new GameStoryTeller();
    private Personagem _heroi;

   

    /*Ao construir a classe ItemEngine, o metodo Carregar arquivos vai ser acionado */
    public ItemEngine()
    {
        CarregarItens();
    }

    // Seleciona o item e atribui suas propriedades ao heroi 
    public bool PegaItem(string item)
    {
        // modificar isso para usar com o linq
        foreach (var line in _itensLista)
        {
            if (line[1].Trim() == item)
            {
                Item itemDesejado = new Item(int.Parse(line[0]), line[1], line[2], line[3], int.Parse(line[4]), line[5]);
                switch (itemDesejado.Atributo)
                {
                    case "ataque":
                        _heroi.Ataque += itemDesejado.Pontos;
                        _storyTeller.Speak($"{_heroi.Nome} {itemDesejado.Mensagem}");
                        break;

                    case "defesa":
                        _heroi.Armadura += itemDesejado.Pontos;
                        _storyTeller.Speak($"{_heroi.Nome} {itemDesejado.Mensagem}");
                        break;

                    case "vida":
                        _heroi.Vida += itemDesejado.Pontos;
                        _storyTeller.Speak($"{_heroi.Nome} {itemDesejado.Mensagem}");
                        break;

                    default:
                        Console.WriteLine("n sei o que dizer");
                        break;
                }
                return true;
            }
        }
        throw new Exception("O Item desejado nao existe no arquivo");

    }

    // Carrega os itens do arquivo csv
    private void CarregarItens()
    {
        Console.WriteLine("Carregando arquivos!");
        Arquivo arquivoReader = new Arquivo("./Csv/Itens.csv");
        _itensLista = arquivoReader.LerArquivo();
    }

    public void SelecionarHeroi(Personagem heroi)
    {
        _heroi = heroi;
    }



    // METODOS ANTIGOS, TALVEZ APAGAR DEPOIS
    /*public void Maca(Personagem heroi)
   {

       heroi.Vida = heroi.Vida + 5;
       Mensagem($"{heroi.Nome} consome uma maça, restaurando 5 pontos de vida. Vida autal: {heroi.Vida}");

   }

   public void PocaodeCura(Personagem heroi)
   {

       heroi.Vida = heroi.Vida + 30;
       Mensagem($"{heroi.Nome} consome uma poção de cura, restaurando 30 pontos de vida. Vida autal: {heroi.Vida}");

   }

   public void Armadilha(Personagem heroi)
   {

       heroi.Vida = heroi.Vida - 7;
       Mensagem($"{heroi.Nome} encontrou uma armadilha no caminho, recebendo 7 pontos de dano. Vida autal: {heroi.Vida}");

   }

   public void SimpleSword(Personagem heroi)
   {

       heroi.Ataque = heroi.Ataque + 1;
       Mensagem($"{heroi.Nome} encontrou uma espada simples, recebendo mais 1 pontos de ataque.");

   }

   public void GerudosSword(Personagem heroi)
   {

       heroi.Ataque = heroi.Ataque + 3;
       Mensagem($"{heroi.Nome} encontrou uma espada flamejante, recebendo mais 3 pontos de ataque.");

   }

   public void MasterSword(Personagem heroi)
   {

       heroi.Ataque = heroi.Ataque + 7;
       Mensagem($"{heroi.Nome} encontrou a Master Sword, recebendo mais 7 pontos de ataque.");

   }

   public void SimpleShield(Personagem heroi)
   {

       heroi.Armadura = heroi.Armadura + 1;
       Mensagem($"{heroi.Nome} encontrou um escudo simples, recebendo mais 3 pontos de armadura.");

   }

   public void GerudosShield(Personagem heroi)
   {

       heroi.Armadura = heroi.Armadura + 3;
       Mensagem($"{heroi.Nome} encontrou um escudo de Gerudo, recebendo mais 3 pontos de armadura.");

   }

   public void HyrulianShield(Personagem heroi)
   {

       heroi.Armadura = heroi.Armadura + 7;
       Mensagem($"{heroi.Nome} encontrou o Hyrulian Shield, recebendo mais 7 pontos de armadura.");

   }

   public void Helmet(Personagem heroi)
   {

       heroi.Armadura = heroi.Armadura + 2;
       Mensagem($"{heroi.Nome} encontrou um elmo, recebendo mais 2 pontos de armadura.");

   }*/

    /*public void Mensagem(String mensagem)
    {
        Console.WriteLine(mensagem);
        Console.WriteLine("Pressione 'Entrer' para continuar...");
        Console.ReadKey();
    }*/

}

