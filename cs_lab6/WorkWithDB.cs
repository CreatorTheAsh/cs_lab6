using System;
using System.Data.SqlClient;

namespace cs_lab6
{
    class WorkWithDB:ToiShop
    {
        void Check_connection(string DB)
        {
            string connectionString = @DB + ";Initial Catalog=usersdb;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // Открываем подключение
                connection.Open();
                Console.WriteLine("Подключение открыто");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // закрываем подключение
                connection.Close();
                Console.WriteLine("Подключение закрыто...");
            }
        }
        
        public void Command(string DB, string request)
        {
            string connectionString = @DB+";Initial Catalog=usersdb;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = request;
                command.Connection = connection;
            }
        }
    }
}
