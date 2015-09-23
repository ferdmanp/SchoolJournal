using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoolJournal.Models
{
    public class Grade
    {
        public int GradeId { get; set; }

        public int GradeNum { get; set; }
        public string GradeLetter { get; set; }

        //public virtual ICollection<Student> Students;

    }
}