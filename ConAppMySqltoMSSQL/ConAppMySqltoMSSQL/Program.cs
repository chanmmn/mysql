using ConAppMySqltoMSSQL.Models;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

namespace ConAppMySqltoMSSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable();
            Console.WriteLine("Hello, Start");
            dt = ReadMySQL();
            ReadRowActor(dt);
            Console.WriteLine("Hello, End");
        }

        public static DataTable ReadMySQL()
        {
            string connectionString = "server=localhost;database=poc;uid=root;password=password;convert zero datetime=True";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            //string query = "SELECT * FROM collections WHERE collect_date < '2023-03-01' AND collect_date > '2023-01-01' ORDER BY collect_date DESC";
            string query = "SELECT * FROM actor";
            MySqlCommand command = new MySqlCommand(query, connection);
            DataTable dataTable = new DataTable();
            using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
            {
                dataAdapter.Fill(dataTable);
            }
            connection.Close();
            return dataTable;
        }

        public static void ReadRowActor(DataTable dataTable)
        {
            int count = 0;
            MyActor myactor = new MyActor();
            foreach (DataRow row in dataTable.Rows)
            {
                myactor.ActorId = row.Field<uint>("actor_id");
                myactor.FirstName = row.Field<string>("first_name");
                myactor.LastName = row.Field<string>("last_name");
                if (!row.Field<DateTime?>("last_update").Equals(null))
                {
                    myactor.LastUpdate = row.Field<DateTime>("last_update");                    
                }
                InsertActor(myactor);
                count++;                
                Console.Write(count);
            }
            Console.WriteLine();
        }

        public static void InsertActor(MyActor myactor)
        {
            PocContext context = new PocContext();
            Actor actor = new Actor();
            actor.ActorId = myactor.ActorId; 
            actor.FirstName = myactor.FirstName; 
            actor.LastName = myactor.LastName;
            if (myactor.LastUpdate < DateTime.Parse("1900-01-01"))
            {
                actor.LastUpdate = DateTime.Parse("1900-01-01");
            }
            else
            {
                actor.LastUpdate = DateTime.Parse(myactor.LastUpdate.ToString("yyyy-MM-dd"));
            }
            context.Actors.Add(actor);
            context.SaveChanges();
        }
        public static void TestEF()
        {
            PocContext pocContext = new PocContext();
            Actor actor = new Actor();
            actor.ActorId = 1;
            actor.FirstName = "Chan";
            actor.LastName = "MM";
            pocContext.Actors.Add(actor);
            pocContext.SaveChanges();
        }
    }
}