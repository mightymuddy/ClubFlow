using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using Vereinsportal.Interfaces;

namespace Vereinsportal.Components
{
    public class Location : ILocation
    {
        private string _city;
        private EN_Country _country;
        private string _region;
        private string _street;
        private string _zip;
        private string _plz;
        private string _state;
        private Collection<string> _address;


        public enum EN_Country
        {
            EN = 1,
            DE = 2
        }

        public Location(string street, string city, string zip, EN_Country country)
        {
            _address = new Collection<string>();
            Street = street;
            City = city;
            ZIP = zip;
            Country = country;
        }

        internal Location setRegion(string region) { _region = region; return this; }

        public string getAddress()
        {
            string output = "";
            foreach (string val in _address)
            {
                output += val + "\n";
            }
            return output;
        }

        internal string City
        {
            get => _city;
            set
            {
                _city = value;
                _address.Add(value);
            }
        }
        internal EN_Country Country
        {
            get => _country;
            set
            {
                _country = value;
                _address.Add(value.ToString());
            }
        }
        internal string Region
        {
            get => _region;
            set
            {
                _region = value;
                _address.Add(value);
            }
        }
        internal string Street
        {
            get => _street;
            set
            {
                _street = value;
                _address.Add(value);
            }
        }
        internal string ZIP
        {
            get => _zip;
            set
            {
                _zip = value;
                _address.Add(value);
            }
        }
        internal string PLZ
        {
            get => _plz;
            set
            {
                _plz = value;
                _address.Add(value);
            }
        }

        internal string State
        {
            get => _state;
            set
            {
                _state = value;
                _address.Add(value);
            }
        }




    }
}
