using System;
using MySql.Data.MySqlClient;

class Program
{
    static void Main(string[] args)
    {
        string connectionString = "server=localhost;database=sakila;uid=root;password=password";
        string searchString = "JOE";

        MySqlCommand command1 = new MySqlCommand();
        MySqlConnection connection1 = new MySqlConnection(connectionString);
        connection1.Open();
        command1.Connection = connection1;

        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            MySqlCommand command = new MySqlCommand();
          
            command.Connection = connection;
            command.CommandText = @"
                SELECT c.TABLE_NAME, c.COLUMN_NAME
                FROM INFORMATION_SCHEMA.COLUMNS c
                INNER JOIN INFORMATION_SCHEMA.TABLES t ON c.TABLE_NAME = t.TABLE_NAME
                WHERE c.DATA_TYPE IN ('varchar', 'nvarchar')
                  AND t.TABLE_TYPE = 'BASE TABLE'
                  AND t.TABLE_SCHEMA = 'sakila'";

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string tableName = reader.GetString(0);
                string columnName = reader.GetString(1);

                command1.CommandText = $"SELECT * FROM {tableName} WHERE {columnName} LIKE '%{searchString}%'";
                try
                {
                    MySqlDataReader innerReader = command1.ExecuteReader();

                    while (innerReader.Read())
                    {
                        Console.WriteLine($"Found '{searchString}' in {tableName}.{columnName}");
                    }

                    innerReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR :");
                    Console.WriteLine(ex.Message);  
                }   
                
            }

            reader.Close();
        }
        connection1.Close();    
    }
}

