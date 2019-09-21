using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nankivell_MIS4200.Models
{
    public class Adventure
    {

        public int adventureId { get; set; }
        public string aPlot { get; set; }
        public string bPlot { get; set; }
        public int characterId { get; set; }
        public virtual Character Character { get; set; }
        public int episodeId { get; set; }
        public virtual Episode Episode { get; set; }

    }
}