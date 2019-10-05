using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nankivell_MIS4200.Models
{

    public class Episode
    {
        public int episodeId { get; set; }
        [Display (Name = "Episode title")]
        public string episodeTitle { get; set; }
        [Display(Name = "Episode number")]
        public int episodeNumber { get; set; }
        [Display(Name = "Season episode resides in")]
        public int Season { get; set; }
        public ICollection<Adventure> Adventure { get; set; }


    }
}