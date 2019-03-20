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
    public partial class NewPlayerForm : Form
    {
        public NewPlayerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNewPlayer_Click(object sender, EventArgs e)
        {
            Player newPlayer = new Player()
            {
                Username = txtUsername.Text,
                RankName = "-",
                TotalScore = 0,
                TalkativeScore = 0,
                ShoutScore = 0,
                QuietScore = 0,
                SwearCount = 0,
                MannersCount = 0
                
            };

            if (string.IsNullOrEmpty(newPlayer.Username))
            {
                MessageBox.Show("You must enter a player name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {               
                SQLiteDataAccess.NewPlayer(newPlayer);
                Close();
            }    
            
        }

    }
}
