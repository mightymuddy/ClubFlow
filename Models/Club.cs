using Vereinsportal.Interfaces;



namespace ClubFlow.Models
{
    public class Club : IClub
    {
        public enum ClubStatus
        {
            notlisted = 0,
            listed = 1,
            hidden = 2,
        }
        public int ClubId { get; set; }
        public string Name { get; set; }
        public string Description { get ; set; }
        public int LocationId { get; set; }
        public DateTime BirthDay { get; set ; }
        public DateTime EntryDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }

    }
}
