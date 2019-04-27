using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
   public class TeamModel
    {
        public List<PersonModel> TemMember { get; set; } = new List<PersonModel>();

        public string TeamName { get; set; }

    }
}
