using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Comment : EntityBase
    {
        //Properties
        public int CommentId { get; set; } //PK

        [Required, MaxLength(100)]
        public string Text { get; set; }
        //Navigation Properties
        public int PostId { get; set; }
        public Post Post { get; set; }

        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
