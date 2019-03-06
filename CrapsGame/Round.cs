using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrapsGame
{
    public class Round
    {
        public int RoundID { get; set; }

        public string RoundResult { get; set; }

        public int RoundTotal { get; set; }

        public int RoundPoint { get; set; }

        public string PlayerID { get; set; }

        // used for displaying round information into the MainForm History List Box
        public string FullRound
        {
            get
            {
                return "Total: " + RoundTotal + " Point: " + RoundPoint + " Result: " + RoundResult;
            }
        }
    }
}
