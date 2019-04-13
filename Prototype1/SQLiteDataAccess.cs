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
using System.Windows.Forms;

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

        public static void ResetAllStats()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<Player>("select * from Players", new DynamicParameters());
                List<Player> outputPlayers = output.ToList();

                try
                {
                    foreach (Player p in outputPlayers)
                    {
                        p.RankName = "-";
                        p.TotalScore = 0;
                        p.TalkativeScore = 0;
                        p.ShoutScore = 0;
                        p.QuietScore = 0;
                        p.SwearCount = 0;
                        p.MannersCount = 0;
                        SQLiteDataAccess.SavePlayer(p);
                    }
                    MessageBox.Show("Reset Player Stats", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Couldn't reset player stats", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void ResetSinglePlayerStats(int id)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                Player p = connection.Query<Player>(@"SELECT * FROM Players WHERE Id = @id", new { id }).FirstOrDefault();

                try
                {
                    p.RankName = "-";
                    p.TotalScore = 0;
                    p.TalkativeScore = 0;
                    p.ShoutScore = 0;
                    p.QuietScore = 0;
                    p.SwearCount = 0;
                    p.MannersCount = 0;
                    SavePlayer(p);
                    MessageBox.Show("Reset Player Stats", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Couldn't reset player stats", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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
