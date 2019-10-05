using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nankivell_MIS4200.Models
{
    public class Adventure
    {

        public int adventureId { get; set; }
        [Display(Name = "Character actions in episode")]
        public string aPlot { get; set; }
        [Display(Name = "Character Name")]
        public int characterId { get; set; }
        public virtual Character Character { get; set; }
        [Display(Name = "Episode featured in")]
        public int episodeId { get; set; }
        public virtual Episode Episode { get; set; }

    }
}