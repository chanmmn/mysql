using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ConAppMySql
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dataTable = new DataTable();
            dataTable = ReadMySQL();
            ReadRowCountry(dataTable);
        }

        public static DataTable ReadMySQL()
        {
            string connectionString = "server=localhost;database=world;uid=root;password=123456";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM country";
            MySqlCommand command = new MySqlCommand(query, connection);
            DataTable dataTable = new DataTable();
            using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
            {
                dataAdapter.Fill(dataTable);
            }            
            connection.Close();
            return dataTable;
        }

        public static void ReadRowCountry(DataTable dataTable)
        {
            Country country = new Country();
            foreach (DataRow row in dataTable.Rows)
            {
                if (row.Field<int?>("Capital").Equals(null))
                { country.Capital = 0; }
                else
                {
                    country.Capital = row.Field<int?>("Capital");
                }
                country.Name = row.Field<string>("Name");
                // Test Data 
                Console.WriteLine("{0} {1}", country.Capital, country.Name);
            }
        }
    }
}
