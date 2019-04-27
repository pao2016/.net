using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
  public  class MachupEntityModel
    {
        /// <summary>
        /// represents one team in the Matchup 
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// represents the score for this particular team 
        /// </summary>
        public double score { get; set; }
        /// <summary>
        /// represents the Matchup that this team came from as the winner 
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

    
    }
}
