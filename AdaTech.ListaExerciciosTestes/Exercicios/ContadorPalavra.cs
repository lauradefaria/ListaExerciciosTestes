using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdaTech.ListaExerciciosTestes.Exercicios
{
    internal class ContadorPalavra
    {
        private Dictionary<string, int> _frequencia = new Dictionary<string, int>();
        
        internal void AnaliseTextual(string texto)
        {
            Console.Clear();
            string[] palavras = texto.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string palavra in palavras)
            {
                string palavraMinuscula = palavra.ToLower();

                if (_frequencia.ContainsKey(palavra))
                {
                    _frequencia[palavra]++;
                }
                else
                {
                    _frequencia[palavra] = 1;
                }
            }
        }
        internal Dictionary<string, int> ExibirFrequencia()
        {
            return _frequencia;
        }
    }
}
