

var heroi = new Personagem{
    Nome = "Link",
    Vida = 100,
    Armadura = 5,
    Ataque = 5,
};

var goblim = new Personagem{
    Nome = "Goblim",
    Vida = 10,
    Armadura = 0,
    Ataque = 0,
};



Fluxo(heroi);
void Fluxo(Personagem heroi)

{
    Console.WriteLine($"Bem vindo Ao jogo {heroi.Nome}");
    Console.ReadKey();
        // 1 esquerda
        // 0 direita
        var decisao = 3; 
        bool inputValido2 = false;
        do 
        {
            Console.WriteLine($"O que voce deseja fazer: {heroi.Nome}");
            Console.WriteLine("Suas opcoes sao ir para esquerda[1] e direita[0]");
            var result = Int32.TryParse(Console.ReadLine(), out decisao);
            if(!inputValido2 && decisao > 1 ){
                Console.WriteLine("Voce nao  digitou uma opcao valida!!, Digite novamente");
            }    
            else {
                inputValido2 = true;
            }
        }while(!inputValido2);

        
        if(decisao == 1) {
            Console.WriteLine("Voce escolheu ir para a esquerda");
        }
        else if(decisao == 0){
            Console.WriteLine("Voce escolheu ir para a direita");

        }
    }
    // Console.ReadKey();



public class Personagem {
    public string Nome { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }
    public int Armadura { get; set; }

}

