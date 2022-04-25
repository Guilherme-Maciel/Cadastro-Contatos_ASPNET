using contactSystem.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Dapper;
using Microsoft.AspNetCore.Mvc;

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
                    Name = contato.Name, Email = contato.Email, Number = contato.Number});
            }
        }
        public ContatoModels Get(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var SqlStatement = "SELECT * FROM Contato WHERE id = @Id";
                return connection.QueryFirstOrDefault<ContatoModels>(SqlStatement, new { Id = id });
            }
        }

        public IEnumerable<ContatoModels> Alter(ContatoModels contato)
        {
            ContatoModels contatoDB = Get(contato.Id);
            if (contatoDB == null) throw new System.Exception("Houve um erro na atualização do contato");

            contatoDB.Name = contato.Name;
            contatoDB.Email = contato.Email;
            contatoDB.Number = contato.Number;

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var SqlStatement = $"UPDATE Contato SET name='{ contatoDB.Name }', email='{contatoDB.Email}', number='{contatoDB.Number}' WHERE id={contatoDB.Id}";
                return connection.Query<ContatoModels>(SqlStatement);
            }
        }

        public IEnumerable<ContatoModels> Delete(int id)
        {
            ContatoModels contatoDB = Get(id);
            if (contatoDB == null) throw new System.Exception("Houve um erro na deleção do contato");

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var SqlStatement = "DELETE FROM Contato WHERE id = @Id";
                return connection.Query<ContatoModels>(SqlStatement, new { Id = id });
            }
        }
    }
}
