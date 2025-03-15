using System.Collections.ObjectModel;

namespace Vereinsportal.Components
{
    internal class MusicRegister : IDataRegister
    {
        string _name;
        Collection<string> _media; 
        public string Type => this.GetType().Name;

        public string Name => _name;
        Collection<string> IDataRegister.Media => _media;
    }
}