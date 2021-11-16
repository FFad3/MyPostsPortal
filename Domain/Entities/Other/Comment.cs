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
        [Required]
        public int PostId { get; set; }
        public Post Post { get; set; }
        [Required]
        public int AccountId { get; set; }
        [Required,MaxLength(30)]
        public string AccountUsername { get; set; }
        public Account Account { get; set; }
    }
}
