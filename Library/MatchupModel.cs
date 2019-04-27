using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
   public class MatchupModel
    {
        public List<MachupEntityModel> Entries { get; set; } = new List<MachupEntityModel>();
        public TeamModel winner { get; set; }
        public int MachupRound { get; set; }
    }
}
