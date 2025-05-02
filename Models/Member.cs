using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubFlow.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }
        public string MemberFirstName { get; set; } = string.Empty;
        public string? MemberLastName { get; set; } = string.Empty ;
        [Required]
        public string MemberEmail { get; set; }
        public string? MemberPhone { get; set; }
        public string? MemberMobile { get; set; }
        public double MemberShipPayment { get; set; }
        public int MemberLocation { get; set; }
        [ForeignKey("FKUserId")]
        public User user { get; set; } = null!;
        [Required]
        [ForeignKey("FKCulbId")]
        public Club club { get; set; } = null!;


    }
}
