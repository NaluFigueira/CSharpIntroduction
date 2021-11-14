using System;
using ByteBankRh.Funcionarios;

namespace ByteBankRh.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
