using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class AccountDetails : EntityBase
    {
        //Porperties
        [ForeignKey("Account")] //shared Pk
        public int AccountDetailsId { get; set; }

        [Required, MaxLength(30)]
        public string Name { get; set; }

        [Required, MaxLength(30)]
        public string Surname { get; set; }

        [Required, EmailAddress, MaxLength(30)]
        public string Email { get; set; }
    }
}
