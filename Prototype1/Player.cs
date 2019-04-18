using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//////////////////////
// Gavin Macleod    //
//////////////////////
// S1715408         //
// Honours Project  //
// BSc Computing    //
//////////////////////
namespace Prototype1
{
    public class Player
    {

        public int Id { get; set; }
        public string Username { get; set; }
        public string RankName { get; set; }

        public int TotalScore { get; set; }

        public int TalkativeScore { get; set; }
        public int ShoutScore { get; set; }
        public int QuietScore { get; set; }

        public int SwearCount { get; set; }
        public int MannersCount { get; set; }

    }
}
