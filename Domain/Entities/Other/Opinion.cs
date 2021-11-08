using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Other
{
    public class Opinion : EntityBase
    {
        //Properties
        public int OpinionId { get; set; }

        [Required]
        public bool isLike { get; set; }

        //Navigation Properties
        public int PostId { get; set; }
        public Post Post { get; set; }

        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
