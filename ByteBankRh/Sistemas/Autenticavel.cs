using System;
using ByteBankRh.Funcionarios;

namespace ByteBankRh.Sistemas
{
    public abstract class Autenticavel : Funcionario
    {
        public string Senha { get; set; }

        public Autenticavel(double salario, string cpf) : base(salario, cpf)
        {
        }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
