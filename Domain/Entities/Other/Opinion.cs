using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Opinion : EntityBase
    {
        //Properties
        public int OpinionId { get; set; }

        [Required]
        public bool IsLike { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set; }
        [ForeignKey("Account")]
        public int AccountId { get; set; }

        //Navigation Properties
        public virtual Account Account { get; set; }
        public virtual Post Post { get; set; }
    }
}
