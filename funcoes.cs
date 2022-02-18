namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {

            void Caminho(int fluxo)
            {

                void Direita()
                {
                    Console.WriteLine("Voce escolheu ir para a direita");
                }
                void Esquerda()
                {
                    Console.WriteLine("Voce escolheu ir para a esquerda");
                }
                void FlorestaMaligna()
                {
                    Console.WriteLine("Voce escolheu ir pra floresta maligna");
                }
                void MarBaltico()
                {
                    Console.WriteLine("Voce escolheu ir pra o Mar Baltico");
                }
                switch (fluxo)
                {
                    case 0:
                        Esquerda();
                        break;
                    case 1:
                        Direita();
                        break;
                    case 2:
                        FlorestaMaligna();
                        break;
                    case 3:
                        MarBaltico();
                        break;
                }
            }
            void Fluxo(Personagem heroi)

            {
                Console.WriteLine($"Bem vindo Ao jogo {heroi.Nome}");
                Console.ReadKey();
                var decisao = 3;
                bool inputValido2 = false;
                List<string> caminhos = new List<string> { "Esquerda", "Direita", "Floresta Maligna", "Mar Baltico" };
                do
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine($"O que voce deseja fazer {heroi.Nome} ? ");
                    int x = 0;
                    foreach (string opcoes in caminhos)
                    {
                        Console.WriteLine($"{opcoes} [{x}]");
                        x++;
                    }
                    var NumeroValido = Int32.TryParse(Console.ReadLine(), out decisao);
                    if (!NumeroValido || decisao >= caminhos.Count)
                    {
                        Console.WriteLine("Voce nao  digitou uma opcao valida!!, Digite novamente");
                    }
                    else
                    {
                        inputValido2 = true;
                    }
                } while (!inputValido2);
                Caminho(decisao);
            }
            // Fluxo(heroi);
        }
    }
}