using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype1
{
    public partial class ViewPlayerForm : Form
    {
        private Player CurrentPlayer = new Player();
        private SQLiteDataAccess = new SQLiteDataAccess();

        public ViewPlayerForm(Player player)
        {
            InitializeComponent();
            CurrentPlayer = player;

            lblUsername.Text = CurrentPlayer.Username;
            lblRank.Text = CurrentPlayer.RankName;

            List<string> RankDetails = GetPlayerRankDetails(CurrentPlayer);

            foreach (var i in RankDetails)
            {
                ListViewItem item = new ListViewItem(i);
                lstViewPlayerRankDetails.Items.Add(item);
            }

        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {

            Player updatedPlayer = RandomScoresPlayer();

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


        private Player RandomScoresPlayer()
        {
            Player tempPlayer = new Player();


            return tempPlayer;
        }



    }
}
