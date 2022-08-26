using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.ChainOfResponsibility.Requisicao
{
    public class EnfileiradorRequisicoes
    {
        public Requisicao Requisicao { get; set; }
        public Conta Conta { get; set; }

        public EnfileiradorRequisicoes(Requisicao requisicao, Conta conta)
        {
            Requisicao = requisicao;
            Conta = conta;
        }

        public void ProcessarRequisicao()
        {
            var processadorCSV = new CSV();
            var processadorXML = new XML();
            var processadorPorcento = new Porcento();

            processadorCSV.Proximo = processadorXML;
            processadorXML.Proximo = processadorPorcento;

            var formatoExportado = processadorCSV.Processa(Requisicao, Conta);

            Console.WriteLine(formatoExportado);
        }
    }
}
