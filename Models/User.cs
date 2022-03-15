using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Journal_DataAttributes.Models
{
    public class User
    {

        [Key]
        [Display(Name ="User Number")]
        public int UserNumber { get; set; }

        [Display(Name = "User Name")]
        public string UserName {get; set; }

        [ForeignKey("JournalNumber")]
        public ICollection<Journal> Journals { get; set; }

        [ForeignKey("CommentId")]
        public ICollection<Comment> Comments { get; set; }



        public User()
        {
            Journals = new HashSet<Journal>();
            Comments = new HashSet<Comment>();  
        }
    }
}
