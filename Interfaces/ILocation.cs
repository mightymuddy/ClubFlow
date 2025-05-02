namespace Vereinsportal.Interfaces
{
    public interface ILocation
    {
        public int LocationId { get; set; }
        public string getAddress();
    }
}
