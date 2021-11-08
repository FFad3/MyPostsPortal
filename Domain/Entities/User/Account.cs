using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Account : EntityBase
    {
        //Properties
        public int AccountId { get; set; } //PK

        [Required, MaxLength(30)]
        public string Username { get; set; }

        [Required, MaxLength(30)]
        public string Login { get; set; }

        [Required, MaxLength(30)]
        public string Password { get; set; }

        [Required]
        public AccountDetails Details { get; set; }

        public List<Post>? Posts { get; set; } = new();

        public List<Comment>? Comments { get; set; } = new();

        public List<Opinion>? Opinions { get; set; } = new();
    }
}
