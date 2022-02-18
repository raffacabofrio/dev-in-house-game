public class ItemEngine {

    public void Maca(Personagem heroi){
        
        heroi.Vida = heroi.Vida + 5;
        Mensagem($"{heroi.Nome} consome uma maça, restaurando 5 pontos de vida. Vida autal: {heroi.Vida}");
        
    }

    public void PocaodeCura(Personagem heroi){
        
        heroi.Vida = heroi.Vida + 30;
        Mensagem($"{heroi.Nome} consome uma poção de cura, restaurando 30 pontos de vida. Vida autal: {heroi.Vida}");
        

    }

    public void Armadilha(Personagem heroi){

        heroi.Vida = heroi.Vida - 7;
        Mensagem($"{heroi.Nome} encontrou uma armadilha no caminho, recebendo 7 pontos de dano. Vida autal: {heroi.Vida}");
        
    }

    public void SimpleSword(Personagem heroi){

        heroi.Ataque = heroi.Ataque + 1;
        Mensagem($"{heroi.Nome} encontrou uma espada simples, recebendo mais 1 pontos de ataque.");
        
    }

    public void GerudosSword(Personagem heroi){

        heroi.Ataque = heroi.Ataque + 3;
        Mensagem($"{heroi.Nome} encontrou uma espada flamejante, recebendo mais 3 pontos de ataque.");
        
    }

    public void MasterSword(Personagem heroi){

        heroi.Ataque = heroi.Ataque + 7;
        Mensagem($"{heroi.Nome} encontrou a Master Sword, recebendo mais 7 pontos de ataque.");
       
    }

    public void SimpleShield(Personagem heroi){

        heroi.Armadura = heroi.Armadura + 1;
        Mensagem($"{heroi.Nome} encontrou um escudo simples, recebendo mais 3 pontos de armadura.");
       
    }

    public void GerudosShield(Personagem heroi){

        heroi.Armadura = heroi.Armadura + 3;
        Mensagem($"{heroi.Nome} encontrou um escudo de Gerudo, recebendo mais 3 pontos de armadura.");
       
    }

    public void HyrulianShield(Personagem heroi){

        heroi.Armadura = heroi.Armadura + 7;
        Mensagem($"{heroi.Nome} encontrou o Hyrulian Shield, recebendo mais 7 pontos de armadura.");
       
    }

    public void Helmet(Personagem heroi){

        heroi.Armadura = heroi.Armadura + 2;
        Mensagem($"{heroi.Nome} encontrou um elmo, recebendo mais 2 pontos de armadura.");
        
    }

    public void Mensagem(String mensagem){
        Console.WriteLine(mensagem);
        Console.WriteLine("Pressione 'Entrer' para continuar...");
        Console.ReadKey();
    }  
}

