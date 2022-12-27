using System;
using System.Collections.Generic;

namespace Labb3AnropNy.Models
{
    public partial class StudentGrade
    {
        public int StudentGradeId { get; set; }
        public int? FkStudId { get; set; }
        public int? FkGradeId { get; set; }

        public virtual Grade? FkGrade { get; set; }
        public virtual Student? FkStud { get; set; }
    }
}
