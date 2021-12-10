using System;
namespace ByteBank.SistemaAgencia
{
    public class Lista<T>
    {
        private T[] _itens;
        public int _proximaPosicao;

        public Lista(int tamanhoInicial = 5)
        {
            _itens = new T[tamanhoInicial];
            _proximaPosicao = 0;
        }

        public void Adicionar(T item)
        {
            VerificaCapacidade(_proximaPosicao + 1);

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public void AdicionarVarios(params T[] itens)
        {
            foreach (T item in itens)
            {
                Adicionar(item);
            }
        }

        public int GetIndiceitem(T item)
        {
            for (int i = 0; i < _proximaPosicao; i++)
            {
                T itemAtual = _itens[i];
                if (itemAtual.Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Remover(T item)
        {
            int indiceitem = GetIndiceitem(item);

            if (indiceitem == -1)
            {
                throw new Exception("Não foi possível encontrar essa item.");
            }

            for (int i = indiceitem; i < _proximaPosicao - 1; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _proximaPosicao--;
            _itens[_proximaPosicao] = default(T);
        }

        private void VerificaCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            T[] novoArray =
                new T[tamanhoNecessario];

            Array.Copy(
                sourceArray: _itens,
                destinationArray: novoArray,
                length: _itens.Length
            );

            _itens = novoArray;
        }

        public void EscreverListaNaTela()
        {
            Console.WriteLine("--------------");
            for (int i = 0; i < _proximaPosicao; i++)
            {
                Console.WriteLine($"Lista[{i}] = {_itens[i]}");
            }
        }

        public T GetitemPeloIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException("Índice inválido.");
            }
            return _itens[indice];
        }

        public T this[int indice]
        {
            get
            {
                return GetitemPeloIndice(indice);
            }
        }
    }
}
