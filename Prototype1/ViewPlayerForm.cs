using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//////////////////////
// Gavin Macleod    //
//////////////////////
// S1715408         //
// Honours Project  //
// BSc Computing    //
//////////////////////
namespace Prototype1
{
    public partial class ViewPlayerForm : Form
    {
        private Player CurrentPlayer = new Player();

        public ViewPlayerForm(Player player)
        {
            InitializeComponent();
            CurrentPlayer = player;

            txtBoxEditName.Text = CurrentPlayer.Username;
            lblRank.Text = CurrentPlayer.RankName;

            RefreshListView();
            
        }

        /// <summary>
        /// Randomizes a the current player's scores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRandomize_Click(object sender, EventArgs e)
        {
            Player updatedPlayer = RandomizePlayerScores(CurrentPlayer);
            SQLiteDataAccess.SavePlayer(updatedPlayer);
            RefreshListView();
        }

        /// <summary>
        /// Gets a list of rank details from the input player
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        private List<string> GetPlayerRankDetails(Player player)
        {
            Dictionary<string, string> detailsList = new Dictionary<string, string>();
            List<string> returnList = new List<string>();

            foreach (var i in player.GetType().GetProperties())
            {
                returnList.Add(i.Name + ": " + i.GetValue(player).ToString());
            }
            return returnList;
        }

        /// <summary>
        /// Randomizes input player scores and returns the player
        /// </summary>
        /// <param name="player"></param>
        /// <returns>Player with random scores</returns>
        private Player RandomizePlayerScores(Player player)
        {       
            Random rnd = new Random();

            player.MannersCount = rnd.Next(0, 200);
            player.QuietScore = rnd.Next(0, 200);
            player.ShoutScore = rnd.Next(0, 200);
            player.SwearCount = rnd.Next(0, 200);
            player.TalkativeScore = rnd.Next(0, 200);       

            return player;
        }


        /// <summary>
        /// Refreshes the list with player details from database
        /// </summary>
        private void RefreshListView()
        {
            List<string> RankDetails = GetPlayerRankDetails(CurrentPlayer);
            lstViewPlayerRankDetails.Clear();
            foreach (var i in RankDetails)
            {
                ListViewItem item = new ListViewItem(i);
                lstViewPlayerRankDetails.Items.Add(item);
            }
        }

        private void btnResetStats_Click(object sender, EventArgs e)
        {
            SQLiteDataAccess.ResetSinglePlayerStats(CurrentPlayer.Id);
            RefreshListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrentPlayer.Username = txtBoxEditName.Text;
            SQLiteDataAccess.SavePlayer(CurrentPlayer);
        }
    }
}
