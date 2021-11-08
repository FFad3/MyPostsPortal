using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class PostContent : EntityBase
    {
        //Properties
        [ForeignKey("Post")]
        public int PostContentId { get; set; } //PK

        [Required, MaxLength(30)]
        public string Title { get; set; }

        [Required, MaxLength(400)]
        public string Text { get; set; }

        public string? Image { get; set; }

        //Navigation Properties
        public virtual Post Post { get; set; }
    }
}
