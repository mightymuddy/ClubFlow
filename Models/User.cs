using ClubFlow.Interfaces;
using Microsoft.Build.Framework;

namespace ClubFlow.Models
{
    public class User : IUser
    {

        //[Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string UserName {  get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public bool PasswordConfirmed { get; set; }
        [Required]
        public bool EmailConfirmed { get; set; }
        [Required]
        public bool Authorized { get; set; }

        public User()
        {
         
        }


    }
}
