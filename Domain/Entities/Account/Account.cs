using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Account : EntityBase
    {
        //Properties
        public int AccountId { get; set; } //PK

        [Required, MaxLength(30)]
        public string Username { get; set; }

        [Required, MaxLength(32)]
        public string Login { get; set; }

        [Required, MaxLength(32)]
        public string Password { get; set; }    

        [Required]
        public AccountDetails Details { get; set; }

        public List<Post>? Posts { get; set; }

        public List<Comment>? Comments { get; set; }

        public List<Opinion>? Opinions { get; set; }
    }
}
//TODO: Lear about Login and Registration full usage