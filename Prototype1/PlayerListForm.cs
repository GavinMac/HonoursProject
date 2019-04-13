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
    public partial class PlayerListForm : Form
    {

        List<Player> playerList = new List<Player>();

        public Player SelectedPlayer { get; set; } = new Player();

        public PlayerListForm()
        {
            InitializeComponent();
            LoadPlayersIntoList();
            btnOpenPlayer.Enabled = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPlayersIntoList();
        }

        private void LoadPlayersIntoList()
        {
            playerList = SQLiteDataAccess.LoadPlayers();

            if (playerList != null)
            {
                List<Player> SortedList = playerList.OrderBy(p => p.Username).ToList();
                PlayerListBox.DataSource = SortedList;
                PlayerListBox.DisplayMember = "Username";
            }
            else
            {
                MessageBox.Show("There are no players to load, create one by going to 'File > New Player'", "No Players Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOpenPlayer_Click(object sender, EventArgs e)
        {
            if (PlayerListBox.SelectedItem != null)
            {
                //int itemIndex = PlayerListBox.SelectedIndex;
                //SelectedPlayer = playerList[itemIndex];
                SelectedPlayer = (Player)PlayerListBox.SelectedItem;
            }
            else
            {
                MessageBox.Show("No player has been selected. Please highlight a player then press open", "No Selection Made", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void PlayerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOpenPlayer.Enabled = true;
        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            int itemIndex = PlayerListBox.SelectedIndex;
            SelectedPlayer = playerList[itemIndex];
            SQLiteDataAccess.DeletePlayer(SelectedPlayer);
            LoadPlayersIntoList();
        }
    }
}
