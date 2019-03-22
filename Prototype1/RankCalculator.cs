using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;

namespace Prototype1
{
    public class RankCalculator
    {
        public Player Player { get; set; }
        private RecognitionResult SpeechInput { get; set; }
        private float Volume { get; set; }

        private HashSet<string> swearWords = JsonConvert.DeserializeObject<HashSet<string>>(File.ReadAllText(Directory.GetCurrentDirectory() + @"\WordLibrary\badwords.json"));
        private HashSet<string> mannersWords = JsonConvert.DeserializeObject<HashSet<string>>(File.ReadAllText(Directory.GetCurrentDirectory() + @"\WordLibrary\manners.json"));


        public RankCalculator(Player player, RecognitionResult speechInput, float volume)
        {
            Player = player;
            SpeechInput = speechInput;
            Volume = volume;
        }

        public async Task CalculateRank()
        {
            Player.TalkativeScore = Player.TalkativeScore + SpeechInput.Words.Count;

            await Task.Run(() => CheckVolume());
            await Task.Run(() => CheckWords());

        }

        /// <summary>
        /// Check input speech text for manners or swears, only if the speech recognition is confident it was the uttered phrase.
        /// </summary>
        /// <returns></returns>
        private void CheckWords()
        {
            if (SpeechInput.Confidence > 0.5)
            {
                foreach (RecognizedWordUnit word in SpeechInput.Words)
                {
                    if (swearWords.Contains(word.Text))
                    {
                        Player.SwearCount = Player.SwearCount + 1;
                    }
                    else if (mannersWords.Contains(word.Text))
                    {
                        Player.MannersCount = Player.MannersCount + 1;
                    }
                }
            }
        }

        /// <summary>
        /// Check the input volume from the user input to determine shouting/being quiet.
        /// </summary>
        /// <returns></returns>
        private void CheckVolume()
        {
            if (Volume > 30)
            {
                Player.ShoutScore = Player.ShoutScore + (int)Math.Round(Volume)/2;
            }
            else if (Volume <= 2)
            {
                Player.QuietScore = Player.QuietScore + (int)Math.Round(Volume);
            }
        }

        private void CalculateTotalScore()
        {

            if(Player.ShoutScore > Player.QuietScore)
            {
                Player.TotalScore = Player.TotalScore - Player.ShoutScore;
            }
            else if (Player.ShoutScore < Player.QuietScore)
            {
                Player.TotalScore = Player.TotalScore + Player.QuietScore;
            }
            else if(Player.SwearCount > Player.MannersCount)
            {
                Player.TotalScore = Player.TotalScore - Player.SwearCount;
            }
            else if (Player.SwearCount < Player.MannersCount)
            {
                Player.TotalScore = Player.TotalScore + Player.MannersCount;
            }
        }

    }
}
