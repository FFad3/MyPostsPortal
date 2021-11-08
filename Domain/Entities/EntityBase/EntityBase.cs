using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class EntityBase
    {
        [Required]
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}
