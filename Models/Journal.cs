using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Journal_DataAttributes.Models
{
    public class Journal
    {
        [Key]
        [Display(Name ="Journal Number")]
        public int JournalNumber { get; set; }

        [StringLength(300, MinimumLength = 3)]
        public string Title { get; set; }

        [StringLength(1000, MinimumLength = 10)]
        public string Content { get; set; }

        [ForeignKey("UserNumber")]
        public User User { get; set; }

        
        public int UserNumber { get; set; }
    }
}
