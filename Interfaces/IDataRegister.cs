using System.Collections.ObjectModel;

namespace ClubFlow.Interfaces
{
    public interface IDataRegister
    {
        string Type { get; }
        string Name { get; }
    
        Collection<string> Media { get; }

    }
}