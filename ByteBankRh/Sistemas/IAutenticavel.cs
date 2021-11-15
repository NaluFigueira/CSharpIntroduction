using System;
namespace ByteBankRh.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
