using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Comment : EntityBase
    {
        //Properties
        public int CommentId { get; set; } //PK

        [ForeignKey("Post")]
        public int PostId { get; set; }
        [ForeignKey("Account")]
        public int AccountId { get; set; }

        [Required, MaxLength(100)]
        public string Text { get; set; }
        [Required,MaxLength(30)]
        public string AccountUsername { get; set; }

        public virtual Account Account { get; set; }
        public virtual Post Post { get; set; }
    }
}
