using ClubFlow.Interfaces;
using System.Collections.ObjectModel;

namespace ClubFlow.Models
{
    internal class MusicRegister : IDataRegister
    {
        string _name;
        Collection<string> _media; 
        public string Type => GetType().Name;

        public string Name => _name;
        Collection<string> IDataRegister.Media => _media;
    }
}