using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineDachbord.Interface.ConnectionDB
{
    internal class ConnectionDBManger
    {
      using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace MachineDashboard.Interface.ConnectionDB
    {
        internal class ConnectionDBManager
        {
            private ConnectionDBManager connection;
            private string connectionString;

            public ConnectionDBManager()
            {
                // Chaîne de connexion à la base de données
                string connectionString = "server=127.0.0.1;port=3306;database=dbmachienmanger4;uid=root;pwd=yourpassword;";
                connection = new ConnectionDBManager(connectionString);
            }

            public ConnectionDBManager(string connectionString)
            {
                this.connectionString = connectionString;
            }

            public void OpenConnection()
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        Console.WriteLine("Connexion réussie à la base de données.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur lors de la connexion à la base de données: " + ex.Message);
                }
            }

            public void CloseConnection()
            {
                try
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                        Console.WriteLine("Connexion fermée.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur lors de la fermeture de la connexion: " + ex.Message);
                }
            }

            public void GetAllMachines()
            {
                string query = "SELECT * FROM machine";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                try
                {
                    OpenConnection();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["idMachine"]}, Date: {reader["Data_température"]}, Température: {reader["temperature"]}");
                    }
                    reader.Close();
                    CloseConnection();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur lors de la récupération des données: " + ex.Message);
                }
            }
        }
    }
}
}
