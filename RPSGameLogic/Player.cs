using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGameLogic
{
    public class Player
    {
        public int Score { get; set; }
        public GameStrategy Choice { get; set; }
    }
}
