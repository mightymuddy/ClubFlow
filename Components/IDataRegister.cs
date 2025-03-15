using System.Collections.ObjectModel;

namespace Vereinsportal.Components
{
    public interface IDataRegister
    {
        string Type { get; }
        string Name { get; }
    
        Collection<string> Media { get; }

    }
}