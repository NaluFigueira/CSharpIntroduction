using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{

    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _contas;
        public int _proximaPosicao;

        public ListaDeContaCorrente(int tamanhoInicial = 5)
        {
            _contas = new ContaCorrente[tamanhoInicial];
            _proximaPosicao = 0;
        }

        public void Adicionar(ContaCorrente conta)
        {
            VerificaCapacidade(_proximaPosicao + 1);

            _contas[_proximaPosicao] = conta;
            _proximaPosicao++;
        }

        private void VerificaCapacidade(int tamanhoNecessario)
        {
            if (_contas.Length >= tamanhoNecessario)
            {
                return;
            }

            ContaCorrente[] novoArray =
                new ContaCorrente[tamanhoNecessario];

            for (int indice = 0; indice < _contas.Length; indice++)
            {
                novoArray[indice] = _contas[indice];
            }

            Array.Copy(
                sourceArray: _contas,
                destinationArray: novoArray,
                length: _contas.Length
            );

            _contas = novoArray;
        }
    }
}
