using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.ListaExerciciosTestes.Exercicios
{
    internal class FiltroString
    {
        private int _tamanhoMin;
        private List<string> _filtro;

        internal List<string> Filtro
        {
            get { return _filtro; }
            set { _filtro = value; }
        }

        public FiltroString(int tamanho)
        {
            _tamanhoMin = tamanho;
        }

        public void Filtragem(List<string> input)
        {
            _filtro = new List<string>();
            foreach (var str in input)
            {
                if (str.Length >= _tamanhoMin)
                {
                    _filtro.Add(str);
                }
            }
        }

        internal string ExibirItemLista(int posicao)
        {
            return _filtro[posicao-1];
        }
    }
}
