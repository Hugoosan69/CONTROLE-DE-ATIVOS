using System;
using System.Data;
using System.Data.SqlClient;

namespace CATI
{
    internal class ConnectionManager
    {
        private readonly string _connectionString;

        // Construtor da classe para inicializar a string de conexão
        public ConnectionManager()
        {
            _connectionString = @"Data Source=.\CATI;Initial Catalog=CATI;User Id=sa;Password=256389;"; // Use configuração segura!
        }

        // Método para obter uma conexão aberta
        public SqlConnection GetOpenConnection()
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            try
            {
                connection.Open(); // Tenta abrir a conexão
                Console.WriteLine("Conexão efetuada com sucesso!");
                return connection; // Retorna a conexão aberta
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
                throw; // Relança a exceção para ser tratada em outro nível
            }
        }

        // Método para fechar a conexão
        public void CloseConnection(SqlConnection connection)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                try
                {
                    connection.Close(); // Fecha a conexão
                    Console.WriteLine("Conexão fechada com sucesso!");
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Erro ao fechar a conexão: {ex.Message}");
                    throw; // Relança a exceção para ser tratada
                }
            }
        }
    }
}
