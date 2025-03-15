
using Vereinsportal.Interfaces;



namespace Vereinsportal.Components
{
    public class Club : IClub
    {
        public enum ClubStatus
        {
            notlisted = 0,
            listed = 1,
            hidden = 2,
        }

        private string _name;
        private string _description;
        private ILocation _address;
        private string _birthday;
        private string _entryDate;
        private string _billingData;
        private string _taxID;
        private string _registryNumber;
        private string _registryCourt;
        private string _managementBoard;
        private string _mstv;
        private string _email;
        private string _phone;
        private string _mobile;
        private ClubStatus _status;

        public Club setName(string name) { _name = name; return this; }
        public Club setDescription(string description) { _description = description; return this; }
        public Club setAddress(ILocation address) { _address = address; return this; }
        public Club setBirthday(string birthday) { _birthday = birthday; return this; }
        public Club setEntryDate(string entryDate) { _entryDate = entryDate; return this; }
        public Club setBillingData(string billingData) { _billingData = billingData; return this; }
        public Club setTaxID(string taxID) { _taxID = taxID; return this; }
        public Club setRegistryNumber(string registryNumber) { _registryNumber = registryNumber; return this; }
        public Club setRegistryCourt(string registryCourt) { _registryCourt = registryCourt; return this; }
        public Club setManagementBoard(string managementBoard) { _managementBoard = managementBoard; return this; }
        public Club setMSTV(string mstv) { _mstv = mstv; return this; }
        public Club setEmail(string email) { _email = email; return this; }
        public Club setPhone(string phone) { _phone = phone; return this; }
        public Club setMobile(string mobile) { _mobile = mobile; return this; }
        public Club setStatus(ClubStatus status) { _status = status; return this; }

        public string getName() => _name;
        public string getPhone() => _phone;
        public string getMobile() => _mobile;
        public string getEmail() => _email;
        public string getDescription() => _description;
        public string getAddress() => _address.getAddress();
        public string getBirthday() => _birthday;
        public string getEntryDate() => _entryDate;
        public string getBillingData() => _billingData;
        public string getTaxID() => _taxID;
        public string getRegistryNumber() => _registryNumber;
        public string getRegistryCourt() => _registryCourt;
        public string getManagementBoard() => _managementBoard;
        public ClubStatus getStatus() => _status;
     

    }
}
