using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//////////////////////
// Gavin Macleod    //
//////////////////////
// S1715408         //
// Honours Project  //
// BSc Computing    //
//////////////////////
namespace Prototype1
{
    public class RankCalculator
    {
        public Player Player { get; set; }
        private RecognitionResult SpeechInput { get; set; }
        public SpeechRecognitionEngine RecEngine = new SpeechRecognitionEngine();

        //Set HasSets of strings from swear words and mannerly words JSON files
        private HashSet<string> swearWords = JsonConvert.DeserializeObject<HashSet<string>>(File.ReadAllText(Directory.GetCurrentDirectory() + @"\WordLibrary\badwords.json"));
        private HashSet<string> mannersWords = JsonConvert.DeserializeObject<HashSet<string>>(File.ReadAllText(Directory.GetCurrentDirectory() + @"\WordLibrary\manners.json"));       

        
        public RankCalculator(Player player, RecognitionResult speechInput, SpeechRecognitionEngine recEngine)
        {
            Player = player;
            SpeechInput = speechInput;
            recEngine = RecEngine;
        }

        public async Task CalculateRank()
        {
            Player.TalkativeScore = Player.TalkativeScore + SpeechInput.Words.Count;

            await Task.Run(() => RunChecker());
            SetRankName();
            UpdatePlayerInDb();
        }

        private void RunChecker()
        {
            CheckWords();
            //CheckVolume();
            CalculateTotalScore();
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
                        Player.SwearCount = Player.SwearCount + 2;
                        Player.MannersCount = Player.MannersCount - 1;
                    }
                    else if (mannersWords.Contains(word.Text.ToLower()))
                    {
                        Player.MannersCount = Player.MannersCount + 2;
                        Player.SwearCount = Player.SwearCount - 1;
                    }
                }
            }
        }

        /// <summary>
        /// Calculates the total score for a player
        /// </summary>
        private void CalculateTotalScore()
        {
            if(SpeechInput.Confidence >= 0.5)
            {
                int TS = Player.TalkativeScore;
                int SS = Player.ShoutScore;
                int QS = Player.QuietScore;
                int SC = Player.SwearCount;
                int MC = Player.MannersCount;

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
                
            }           
            

        }


        /// <summary>
        /// Sets the players RankName based on their total score, if their TotalScore reaches a ranks threshold.
        /// </summary>
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

        //Allows the player in this context to be saved when this is called.
        private void UpdatePlayerInDb()
        {            
            SQLiteDataAccess.SavePlayer(Player);
        }

    }
}
