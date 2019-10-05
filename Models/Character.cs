using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nankivell_MIS4200.Models
{
    public class Character
    {
        public int characterId { get; set; }
        [Display(Name = "Characters name")]
        public string characterName { get; set; }
        [Display(Name = "Role within the show")]
        public string roleInFamily { get; set; }
        [Display(Name = "Episode description")]
        public string description { get; set; }
        public ICollection<Adventure> Adventure { get; set; }

    }
}