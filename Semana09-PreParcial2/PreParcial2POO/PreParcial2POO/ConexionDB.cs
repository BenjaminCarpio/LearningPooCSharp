using System.Data;
using Npgsql;
namespace PreParcial2POO
{
    public static class ConexionDB
        {
            private static string host = "localhost",
                database = "PocoTools",
                userID = "postgres",
                pasword = "uca";

            private static string sConecction =
                $"Server={host};Port=5432;User Id={userID};Password={pasword};Database={database};";
            //"sslmode=Require;Trust Server Certificate=true";

            public static DataTable ExecuteQuery(string query)
            {
                NpgsqlConnection connection = new NpgsqlConnection(sConecction);
                DataSet ds = new DataSet();

                connection.Open();

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
                da.Fill(ds);
                

                connection.Close();

                return ds.Tables[0];
            }

            public static void ExecuteNonQuery(string act)
            {
                NpgsqlConnection connection = new NpgsqlConnection(sConecction);

                connection.Open();

                NpgsqlCommand command = new NpgsqlCommand(act, connection);
                command.ExecuteNonQuery(); 

                connection.Close(); 
            }
    }
}
