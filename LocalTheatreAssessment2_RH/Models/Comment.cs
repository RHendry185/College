using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LocalTheatreAssessment2_RH.Models
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public int PostID { get; set; }
        [DataType(DataType.MultilineText)]
        public String CommentText { get; set; }
        public DateTime CommentDate { get; set; }
        public String Author { get; set; }
    }
}