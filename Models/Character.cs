using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nankivell_MIS4200.Models
{
    public class Character
    {
        public int characterId { get; set; }
        public string characterName { get; set; }
        public string roleInFamily { get; set; }
        public string description { get; set; }
        public ICollection<Adventure> Adventure { get; set; }

    }
}