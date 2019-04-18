using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using Newtonsoft.Json;
using System.IO;
using NAudio.CoreAudioApi;
using NAudio;
using NAudio.Wave;
//////////////////////
// Gavin Macleod    //
//////////////////////
// S1715408         //
// Honours Project  //
// BSc Computing    //
//////////////////////
namespace Prototype1
{
    public partial class MainForm : Form
    {

        public SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        private Player CurrentWorkingPlayer = new Player();

        public MainForm()
        {
            InitializeComponent();
            MMDeviceEnumerator deviceEnumerator = new MMDeviceEnumerator();
            var devices = deviceEnumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            deviceComboBox.Items.AddRange(devices.ToArray());


            ///// Speech recognition setup /////          
            Grammar grammar = new DictationGrammar();
            recEngine.LoadGrammarAsync(grammar);

            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += RecEngine_SpeechRecognized;

        }

        //Enable mic and start speech recognition if a device is chosen.
        private void btnEnableMic_Click(object sender, EventArgs e)
        {

            if (deviceComboBox != null)
            {
                recEngine.RecognizeAsync(RecognizeMode.Multiple);
                btnDisableMic.Enabled = true;
                btnEnableMic.Enabled = false;
                timer.Enabled = true;
                timer.Start();
                RunOnce.SetTimer();
            }
            else
            {
                MessageBox.Show("Please select a mic from the drop down selection box above.", "No Device Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Disable mic
        private void btnDisableMic_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            btnDisableMic.Enabled = false;
            btnEnableMic.Enabled = true;
            timer.Enabled = false;
        }

        /// <summary>
        /// Speech recognized event handler - when speech is detectd, this method will run.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if(CurrentWorkingPlayer != null)
            {
                logTextBox.Text += e.Result.Text + " ";
                var device = GetSelectedDevice();
                float volume = device.AudioMeterInformation.MasterPeakValue * 100;
                RankCalculator rankCalc = new RankCalculator(CurrentWorkingPlayer, e.Result, recEngine);
                Task.Run(() => rankCalc.CalculateRank());
                RefreshUi(CurrentWorkingPlayer);
            }
            else
            {
                MessageBox.Show("There is currently no player loaded into the current working player. Please open a player in 'File > Open Player'", "No Player Open", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        
        //Create New Player
        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPlayerForm newPlayerForm = new NewPlayerForm();
            newPlayerForm.ShowDialog();
        }

        //Show player list
        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortPlayersForm sortPlayersForm = new SortPlayersForm();
            sortPlayersForm.ShowDialog();
        }


        //Open a player from player list form, then set the current player in this (MainForm) to selected player.
        private void openPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerListForm playerListForm = new PlayerListForm();
            if (playerListForm.ShowDialog() == DialogResult.OK)
            {
                Player currentPlayer = new Player();
                currentPlayer = playerListForm.SelectedPlayer;              
                SetCurrentPlayer(currentPlayer);
                logTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Failed to open the selected player.", "Failed to Load Player", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Sets the selected player to the current working player and sets player info on the main form.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="RankDetails"></param>
        private void SetCurrentPlayer(Player player)
        {
            CurrentWorkingPlayer = player;
            UserRankListView.Clear();
            UsernameLabel.Text = player.Username;
            RankNameLabel.Text = player.RankName;
            RefreshUi(player);
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
                returnList.Add(i.Name + ": "+ i.GetValue(player).ToString());
            }
            return returnList;
        }

        /// <summary>
        /// Timer tick to set volume meter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            if (deviceComboBox.SelectedItem != null)
            {
                var device = GetSelectedDevice();
                float volume = device.AudioMeterInformation.MasterPeakValue * 100;              
                volumeMeter.Amplitude = volume;
                if (volume >= 50)
                {
                    RunOnce.CheckVolumesOnce(CurrentWorkingPlayer, volume);
                    volumeMeter.ForeColor = Color.Red;
                }
                else if (volume >= 5) {
                    volumeMeter.ForeColor = Color.FromArgb(0, 192, 0);
                }                   
                else
                {
                    RunOnce.CheckVolumesOnce(CurrentWorkingPlayer, volume);
                    volumeMeter.ForeColor = Color.White;
                }
            }
        }

        /// <summary>
        /// Gets the current selected device from the combo box
        /// </summary>
        /// <returns></returns>
        private MMDevice GetSelectedDevice()
        {
            MMDevice device = (MMDevice)deviceComboBox.SelectedItem;
            return device;
        }

        private void RefreshUi(Player player)
        {
            Player refreshPlayer = SQLiteDataAccess.GetPlayeById(CurrentWorkingPlayer.Id);
            UserRankListView.Clear();
            List<string> RankDetails = GetPlayerRankDetails(refreshPlayer);
            RankNameLabel.Text = refreshPlayer.RankName;

            foreach (var i in RankDetails)
            {
                ListViewItem item = new ListViewItem(i);
                UserRankListView.Items.Add(item);
            }
        }


        //Close form
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
