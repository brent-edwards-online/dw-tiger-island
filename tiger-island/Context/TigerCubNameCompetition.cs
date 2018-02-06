using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tiger_island.Context
{
    public class TigerCubNameCompetition
    {
        public int ID { get; set; }
        public string NameSuggestion1 { get; set; }
        public string NameSuggestion2 { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PostCode { get; set; }
        public string StayInformed { get; set; }

    }
}