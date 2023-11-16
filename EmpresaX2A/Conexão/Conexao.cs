using EmpresaX2A;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace EmpresaX2A.Configuracao
{
    class Conexao
    {
        private string _servidor = "localhost";
        private string _porta = "3306";
        private string _usuario = "root";
        private string _senha = "An4Di3go1!";
        private string _bancoDadosNome = "bd_empresa2xa_modelofisico";

        private MySqlConnection connection;
        private MySqlCommand command;

        public Conexao()
        {
            try
            {
                connection = new MySqlConnection($"server = {_servidor}; database = {_bancoDadosNome}; port = {_porta}; user = {_usuario}, password = {_senha}");
                connection.Open();
            }

            catch(Exception e) { throw e; }
        }

        public MySqlCommand Comando(string comando)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = comando;

                return command;
            }

            catch(Exception e) { throw e; }
        }
    }
}
