using System;
using ByteBankRh.Sistemas;

namespace ByteBankRh
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return Senha == senha; 
        }
    }
}
