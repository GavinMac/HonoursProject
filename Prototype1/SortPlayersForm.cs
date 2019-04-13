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
    public partial class SortPlayersForm : Form
    {

        List<Player> playerList = new List<Player>();
        public Player SelectedPlayer { get; set; } = new Player();

        public SortPlayersForm()
        {
            InitializeComponent();
            LoadPlayersIntoList();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            SortPlayersByRank();
        }

        private void LoadPlayersIntoList()
        {
            playerList = SQLiteDataAccess.LoadPlayers();

            if (playerList != null)
            {
                AllPlayersListBox.DataSource = playerList;
                AllPlayersListBox.DisplayMember = "Username";
            }
            else
            {
                MessageBox.Show("There are no players to load, create one by going to 'File > New Player'", "No Players Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SortPlayersByRank()
        {
            foreach(Player p in playerList)
            {
                switch (p.RankName)
                {
                    case null :
                        lstBoxNeutral.Items.Add(p);
                        break;
                    case "-":
                        lstBoxNeutral.Items.Add(p);
                        break;
                    case "Lawful Good":
                        lstBoxLawfulGood.Items.Add(p);
                        break;

                    case "Lawful Neutral":
                        lstBoxLawfulNeutral.Items.Add(p);
                        break;

                    case "Neutral":
                        lstBoxNeutral.Items.Add(p);
                        break;

                    case "Chaotic Neutral":
                        lstBoxChaoticNeutral.Items.Add(p);
                        break;

                    case "Chaotic Evil":
                        lstBoxChaoticEvil.Items.Add(p);
                        break;
                }
            }
        }

        private void lstBoxChaoticEvil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstBoxChaoticEvil.SelectedItem != null)
            {
                SelectedPlayer = (Player)lstBoxChaoticEvil.SelectedItem;
            }          
        }

        private void lstBoxChaoticNeutral_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxChaoticNeutral.SelectedItem != null)
            {
                SelectedPlayer = (Player)lstBoxChaoticNeutral.SelectedItem;
            }
        }

        private void lstBoxNeutral_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxNeutral.SelectedItem != null)
            {
                SelectedPlayer = (Player)lstBoxNeutral.SelectedItem;
            }
        }

        private void lstBoxLawfulNeutral_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxLawfulNeutral.SelectedItem != null)
            {
                SelectedPlayer = (Player)lstBoxLawfulNeutral.SelectedItem;
            }
        }

        private void lstBoxLawfulGood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxLawfulGood.SelectedItem != null)
            {
                SelectedPlayer = (Player)lstBoxLawfulGood.SelectedItem;
            }
        }

        private void AllPlayersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AllPlayersListBox.SelectedItem != null)
            {
                SelectedPlayer = (Player)AllPlayersListBox.SelectedItem;
            }
        }

        private void ClearListSelections()
        {
            lstBoxNeutral.ClearSelected();
            lstBoxLawfulNeutral.ClearSelected();
            lstBoxLawfulGood.ClearSelected();
            lstBoxChaoticNeutral.ClearSelected();
            lstBoxChaoticEvil.ClearSelected();
            AllPlayersListBox.ClearSelected();
        }

        private void btnOpenPlayer_Click(object sender, EventArgs e)
        {
            ViewPlayerForm viewPlayerForm = new ViewPlayerForm(SelectedPlayer);
            viewPlayerForm.Show();
        }
    }
}
