using System;
using System.Data;

namespace DesignPatterns.Factory
{
    public class ConnectionFactory
    {

        public IDbConnection GetConnection()
        {
            IDbConnection conexao = new SqlConnection();
            conexao.ConnectionString = "User Id=root;Password=;Server=localhost;Database=banco";
            conexao.Open();

            return conexao;
        }
    }
}
