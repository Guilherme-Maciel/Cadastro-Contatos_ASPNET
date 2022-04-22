using contactSystem.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Dapper;

namespace contactSystem.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly string _connectionString;

        public ContatoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IEnumerable<ContatoModels> GetAll()
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var SqlStatement = "SELECT * FROM Contato";
                return connection.Query<ContatoModels>(SqlStatement);
            }
        }

        public IEnumerable<ContatoModels> Add(ContatoModels contato)
        {
            //Insert de Dados
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var SqlStatement = "INSERT INTO Contato (name, email, number) VALUES (@Name, @Email, @Number)";
                return connection.Query<ContatoModels>(SqlStatement ,new { 
                    Name = contato.Name, Email = contato.Email, Number = contato.Cel});
            }
        }


    }
}
