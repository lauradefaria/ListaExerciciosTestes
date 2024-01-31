using AdaTech.ListaExerciciosTestes.Exercicios;

namespace AdaTech.ListaExerciciosTestes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine("\t\tLista de Exercícios - Módulo 4\n");
                Console.WriteLine("1 - Filtro de String\n2 - Expressão Balanceada\n3 - Batata Quente\n4 - Frequência de palavra\n\nQ - SAIR DO PROGRAMA\n");
                Console.Write("Digite a opção: ");
                string chave = Console.ReadLine();

                switch (chave)
                {
                    case "1":
                        Exercicio1();
                        break;
                    case "2":
                        Exercicio2();
                        break;
                    case "3":
                        Exercicio3();
                        break;
                    case "4":
                        Exercicio4();
                        break;
                    case "q":
                        flag = false;
                        break;
                    default:
                        break;
                }
            }

            return;
        }
        static void Exercicio1()
        {
            int tamanho = 10;
            FiltroString filtro = new FiltroString(tamanho);

            List<string> input = new List<string>{
              "Idiossincrasia",
              "Ambivalente",
              "Quimérica",
              "Perpendicular",
              "Efêmero",
              "Pletora",
              "Obnubilado",
              "Xilografia",
              "Quixote",
              "Inefável"
            };

            Console.Clear();
            filtro.Filtragem(input);
            Console.WriteLine($"Palavras que possuem {tamanho} ou mais caracteres.");

            int posicao = filtro.Filtro.Count();

            while (posicao > 0)
            {
                Console.WriteLine(filtro.ExibirItemLista(posicao));
                posicao--;
            }

            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
            return;
        }
        static void Exercicio2()
        {
            Console.Clear();
            BalancearExpressao expressao = new BalancearExpressao();
            Console.Write("Digite uma expressão matemática: ");
            string exp = Console.ReadLine();

            if (expressao.ExpressaoBalanceada(exp))
            {
                Console.WriteLine($"\nA Expressão {exp} está balanceada!");
            }
            else
            {
                Console.WriteLine($"\nA Expressão {exp} não está balanceada!");
            }

            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
            return;
        }
        static void Exercicio3()
        {
            int quantidadeJogadores, aux = 1;
            List<string> listaJogadores = new List<string>();

            do
            {
                Console.Clear();
                Console.Write("Insira a quantidade de Jogadores: ");
            } while (!int.TryParse(Console.ReadLine(), out quantidadeJogadores));

            while(aux <= quantidadeJogadores)
            {
                Console.Clear();
                Console.Write($"Insira o nome do Jogador N° {aux}: ");
                listaJogadores.Add(Console.ReadLine());
                aux++;
            }

            BatataQuente batata = new BatataQuente(listaJogadores);
            batata.Jogo(quantidadeJogadores);
            Console.WriteLine($"\nO vencedor foi {batata.Vencedor}!");

            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
            return;

        }
        static void Exercicio4()
        {
            ContadorPalavra contador = new ContadorPalavra();

            Console.Write("Digite um texto: ");
            string texto = Console.ReadLine();
            contador.AnaliseTextual(texto);

            Console.Clear();
            Console.WriteLine("\t\tFrequência das Palavras\n");
            foreach (var palavra in contador.ExibirFrequencia())
            {
                Console.WriteLine($"Palavra '{palavra.Key}': {palavra.Value} vez(es)");
            }

            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
            return;
        }
    }
}
