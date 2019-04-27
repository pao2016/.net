using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
  public  class TourmamentModel
    {
        public string TournamentName { get; set; }
        public decimal EntityFree { get; set; }
        public List<TeamModel> EnteredTeam { get; set; } = new List<TeamModel>();
        public List<PrizeModel> Prices { get; set; } = new List<PrizeModel>();
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

    }
}
