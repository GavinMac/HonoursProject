using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype1
{
    class SQLiteDataAccess
    {

        /// <summary>
        /// Database connection
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private static string LoadConnectionString(string id = "DbConnection")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }


        /// <summary>
        /// Loads all players in database into a list
        /// </summary>
        /// <returns></returns>
        public static List<Player> LoadPlayers()
        {
            using(IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<Player>("select * from Players", new DynamicParameters());

                return output.ToList();
            }

        }

        public static Player GetPlayeById(int id)
        {
            string idString = id.ToString();
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                Player resultPlayer = connection.Query<Player>(@"SELECT * FROM Players WHERE Id = @id", new { id }).FirstOrDefault();

                return resultPlayer;
            }
        }

        /// <summary>
        /// Creates a new player in the database
        /// </summary>
        /// <param name="player"></param>
        public static void NewPlayer(Player player)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();
                connection.Insert(player);
                connection.Close();
            }
        }

        /// <summary>
        /// Updates player in the database
        /// </summary>
        /// <param name="player"></param>
        public static void SavePlayer(Player player)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                //connection.Execute("UPDATE Players SET Id = @Id", player);
                connection.Open();
                connection.Update(player);
            }
        }

        /// <summary>
        /// Delete selected player from database
        /// </summary>
        /// <param name="player"></param>
        public static void DeletePlayer(Player player)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("DELETE FROM Players WHERE Id = @Id", player);        
            }
        }







    }
}
