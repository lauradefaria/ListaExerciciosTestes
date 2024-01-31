using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.ListaExerciciosTestes.Exercicios
{
    internal class BatataQuente
    {
        private int _numeroMaximo;
        private Random _random = new Random();
        private List<string> _nomes = new List<string>();
        private string _vencedor;

        internal string Vencedor
        {
            get { return _vencedor; }
            set { _vencedor = value;}
        }

        public BatataQuente(List<string> nomeLista)
        {
            _nomes = nomeLista;
        }

        public void Jogo(int quantidadeJogadores)
        {
            Console.Clear();

            if (quantidadeJogadores <= 1)
            {
                throw new ArgumentException("Não há jogadores sufucientes para jogar");
            }


            _numeroMaximo = _random.Next(1, (quantidadeJogadores*5) + 1);

            Queue<int> fila = new Queue<int>();
            for (int i = 1; i <= quantidadeJogadores; i++)
            {
                fila.Enqueue(i);
            }

            while (fila.Count > 1)
            {
                int jogadas = _random.Next(1, _numeroMaximo + 1);

                for (int i = 0; i < jogadas; i++)
                {
                    int jogadorAtual = fila.Dequeue();
                    fila.Enqueue(jogadorAtual);
                }

                int jogadorPerdeu = fila.Dequeue();
                Console.WriteLine($"Jogador {jogadorPerdeu} explodiu. Jogadores restantes: {string.Join(", ", fila)}");

                jogadas = _random.Next(1, _numeroMaximo + 1);
            }

            _vencedor = _nomes[(fila.Dequeue() - 1)];
        }
    }
}
