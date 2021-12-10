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

        public int EncontrarIndiceConta(ContaCorrente conta)
        {
            for (int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente contaAtual = _contas[i];
                if (contaAtual.Equals(conta))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Remover(ContaCorrente conta)
        {
            int indiceConta = EncontrarIndiceConta(conta);

            if (indiceConta == -1)
            {
                throw new Exception("Não foi possível encontrar essa conta.");
            }

            for (int i = indiceConta; i < _proximaPosicao - 1; i++)
            {
                _contas[i] = _contas[i + 1];
            }

            _proximaPosicao--;
            _contas[_proximaPosicao] = null;
        }

        private void VerificaCapacidade(int tamanhoNecessario)
        {
            if (_contas.Length >= tamanhoNecessario)
            {
                return;
            }

            ContaCorrente[] novoArray =
                new ContaCorrente[tamanhoNecessario];

            Array.Copy(
                sourceArray: _contas,
                destinationArray: novoArray,
                length: _contas.Length
            );

            _contas = novoArray;
        }

        public void EscreverListaNaTela()
        {
            Console.WriteLine("--------------");
            for (int i = 0; i < _proximaPosicao; i++)
            {
                Console.WriteLine($"Lista[{i}] = {_contas[i]}");
            }
        }
    }
}
