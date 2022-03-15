using System.ComponentModel.DataAnnotations;

namespace Journal_DataAttributes.Models
{
    public class Comment
    {
        [Key]
        public int CommentId {get; set;}

        public string Title {get; set;}

        public string CommentContent {get; set;}

     
        
    }
}
