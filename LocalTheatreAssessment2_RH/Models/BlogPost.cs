using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LocalTheatreAssessment2_RH.Models
{
    public class BlogPost
    {
        [Key]
        [Required]
        public int PostID { get; set; }
        public String PostTitle { get; set; }
        [DataType(DataType.MultilineText)]
        public String PostText { get; set; }
        public DateTime PostDate { get; set; }
        public String Author { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}