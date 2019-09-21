using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nankivell_MIS4200.Models
{
    public class Episode
    {
        public int episodeId { get; set; }
        public string episodeTitle { get; set; }
        public int Season { get; set; }
        public ICollection<Adventure> Adventure { get; set; }


    }
}