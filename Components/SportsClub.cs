using Vereinsportal.Interfaces;

namespace Vereinsportal.Components
{
    public class SportsClub : IClub
    {
        Club _club;
        public string getAddress() => _club.getAddress();
        public string getBillingData() => _club.getBillingData();
        public string getBirthday() => _club.getBirthday();
        public string getDescription() => _club.getDescription();
        public string getEmail() => _club.getEmail();
        public string getEntryDate() => _club.getEntryDate();
        public string getManagementBoard() => _club.getManagementBoard();
        public string getMobile() => _club.getMobile();
        public string getName() => _club.getName();
        public string getPhone() => _club.getPhone();      
        public string getRegistryCourt() => _club.getRegistryCourt();
        public string getRegistryNumber() => _club.getRegistryNumber();
        public Club.ClubStatus getStatus() => _club.getStatus();
        public string getTaxID() => _club.getTaxID();
        public Club setAddress(ILocation address) {_club.setAddress(address); return _club; }
        public Club setBillingData(string billingData) { _club.setBillingData(billingData); return _club; }
        public Club setBirthday(string birthday) {  _club.setBirthday(birthday); return _club; }
        public Club setDescription(string description) { _club.setDescription(description); return _club; }
        public Club setEmail(string email) { _club.setEmail(email); return _club; }
        public Club setEntryDate(string entryDate) {_club.setEntryDate(entryDate); return _club; }
        public Club setManagementBoard(string managementBoard) { _club.setManagementBoard(managementBoard); return _club; }
        public Club setMobile(string mobile) { _club.setMobile(mobile); return _club; }
        public Club setMSTV(string product) {  _club.setMSTV(product); return _club; }
        public Club setName(string name) { _club.setName(name); return _club; }
        public Club setPhone(string phone) { _club.setPhone(phone); return _club; }
        public Club setRegistryCourt(string registryCourt) { _club.setRegistryCourt(registryCourt); return _club; }
        public Club setRegistryNumber(string registryNumber) { _club.setRegistryNumber(registryNumber); return _club; }
        public Club setStatus(Club.ClubStatus status) { _club.setStatus(status); return _club; }
        public Club setTaxID(string taxID) { _club.setTaxID(taxID); return _club; }
    }
}
