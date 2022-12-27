using System;
using System.Collections.Generic;

namespace Labb3AnropNy.Models
{
    public partial class EmploOther
    {
        public int EmploId { get; set; }
        public string Position { get; set; } = null!;
        public string Fname { get; set; } = null!;
        public string Lname { get; set; } = null!;
    }
}
