using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Journal_DataAttributes.Models
{
    public class Comment
    {

        [Key]
        public int CommentNumber {get; set;}

        [Display(Name = "Title")]
        [StringLength(30)]
        public string Title {get; set;}

        [Display(Name = "CommentContent")]
        [StringLength(100)]
        public string CommentContent {get; set;}

        [ForeignKey("UserNumber")]
        public int JournalNumber { get; set; }





    }
}
