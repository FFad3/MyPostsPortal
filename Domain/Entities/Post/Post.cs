using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Post : EntityBase
    {
        //Properties
        public int PostId { get; set; } //PK

        [Required]
        public int AccountId { get; set; } //FK
        public Account Account { get; set; }

        [Required]
        public virtual PostContent Content { get; set; }

        public List<Comment> Comments { get; set; }

        public List<Opinion> Opinions { get; set; }
    }
}