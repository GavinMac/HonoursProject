using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Prototype1
{
    public class RankCalculator
    {
        public Player Player { get; set; }
        private RecognitionResult SpeechInput { get; set; }
        private float Volume { get; set; }
        public SpeechRecognitionEngine RecEngine = new SpeechRecognitionEngine();

        //Set HasSets of strings from swear words and mannerly words JSON files
        private HashSet<string> swearWords = JsonConvert.DeserializeObject<HashSet<string>>(File.ReadAllText(Directory.GetCurrentDirectory() + @"\WordLibrary\badwords.json"));
        private HashSet<string> mannersWords = JsonConvert.DeserializeObject<HashSet<string>>(File.ReadAllText(Directory.GetCurrentDirectory() + @"\WordLibrary\manners.json"));       

        
        public RankCalculator(Player player, RecognitionResult speechInput, float volume, SpeechRecognitionEngine recEngine)
        {
            Player = player;
            SpeechInput = speechInput;
            Volume = volume;
            recEngine = RecEngine;
        }

        public async Task CalculateRank()
        {
            Player.TalkativeScore = Player.TalkativeScore + SpeechInput.Words.Count;

            await Task.Run(() => RunChecker());
            CalculateTotalScore();
            UpdatePlayerInDb();
        }

        private void RunChecker()
        {
            CheckWords();
            //CheckVolume();
            SetRankName();
        }

        /// <summary>
        /// Check input speech text for manners or swears, only if the speech recognition is confident it was the uttered phrase.
        /// </summary>
        /// <returns></returns>
        private void CheckWords()
        {             
            if (SpeechInput.Confidence > 0.3)
            {
                foreach (RecognizedWordUnit word in SpeechInput.Words)
                {
                    if (swearWords.Contains(word.Text.ToLower()))
                    {
                        Player.SwearCount = Player.SwearCount + 1;
                        Player.MannersCount = Player.MannersCount - 1;
                    }
                    else if (mannersWords.Contains(word.Text.ToLower()))
                    {
                        Player.MannersCount = Player.MannersCount + 1;
                        Player.SwearCount = Player.SwearCount - 1;
                    }
                }
            }
        }

        ///// <summary>
        ///// Check the input volume from the user input to determine shouting/being quiet.
        ///// </summary>
        ///// <returns></returns>
        //private void CheckVolume()
        //{
        //    if (Volume > 30)
        //    {
        //        Player.ShoutScore = Player.ShoutScore + (int)Math.Round(Volume);
        //    }
        //    else if (Volume <= 2)
        //    {
        //        Player.QuietScore = Player.QuietScore + (int)Math.Round(Volume);
        //    }
        //    else
        //    {
        //        Player.TalkativeScore = Player.TalkativeScore + (int)Math.Round(Volume);
        //    }
        //}

        private void CalculateTotalScore()
        {
            if(SpeechInput.Confidence >= 0.5)
            {
                int TS = Player.TalkativeScore;
                int SS = Player.ShoutScore;
                int QS = Player.QuietScore;
                int SC = Player.SwearCount;
                int MC = Player.MannersCount;

                int diff_SSQS = Math.Abs(SS - QS); //Difference between ShoutScore and QuietScore
                int diff_QSSS = Math.Abs(QS - SS); //Difference between Quietcore and ShoutScore

                int diff_SCMC = Math.Abs(SC - MC); //Difference between SwearCount and MannersCount
                int diff_MCSC = Math.Abs(MC - SC); //Difference between MannersCount and SwearCount

                int loudnessModifier = 0;
                int wordChoiceModifier = 0;

                if (SS > QS) //If they shout more than they are quiet
                {
                    loudnessModifier = SS / 2;
                    Player.TotalScore = Player.TotalScore - loudnessModifier;
                }
                else if (QS > SS) //If they are quiet more than they shout
                {
                    loudnessModifier = QS / 2;
                    Player.TotalScore = Player.TotalScore + loudnessModifier;
                }

                if (SC > MC) //If they swear more than being mannerly
                {
                    wordChoiceModifier = SC / 2;
                    Player.TotalScore = Player.TotalScore - wordChoiceModifier;
                }
                else if (MC > SC) //If they are mannerly more than they swear
                {
                    wordChoiceModifier = MC / 2;
                    Player.TotalScore = Player.TotalScore + wordChoiceModifier;
                }

                Console.WriteLine("loudnessModifier: " + loudnessModifier + "\nwordChoiceModifier: " + wordChoiceModifier);

                
            }           
            

        }

        private void SetRankName()
        {

            if (Player.TotalScore == 0)
            {
                Player.RankName = "Neutral";
            }
            else if (Player.TotalScore >= 50 && Player.TotalScore < 200)
            {
                Player.RankName = "Lawful Neutral";
            }
            else if (Player.TotalScore >= 200)
            { 
                Player.RankName = "Lawful Good";
            }
            else if (Player.TotalScore <= -50 && Player.TotalScore > -200)
            {
                Player.RankName = "Chaotic Neutral";
            }
            else if (Player.TotalScore <= -200)
            {
                Player.RankName = "Chaotic Evil";
            }                 

        }

        private void UpdatePlayerInDb()
        {
            //Player rank details will be updated and saved straight into the database as they speak.
            SQLiteDataAccess.SavePlayer(Player);
        }

    }
}
