using System.Runtime.CompilerServices;
using Vereinsportal.Components;
using static Vereinsportal.Components.Club;

namespace Vereinsportal.Interfaces
{
    public interface IClub
    {
        public Club setName(string name);
        public Club setDescription(string description);
        public Club setAddress(ILocation location);
        public Club setBirthday(string birthday);
        public Club setEntryDate(string entryDate);
        public Club setBillingData(string billingData);
        public Club setTaxID(string taxID);
        public Club setRegistryNumber(string registryNumber);
        public Club setRegistryCourt(string registryCourt);
        public Club setManagementBoard(string managementBoard);
        public Club setMSTV(string mstv);
        public Club setEmail(string email);
        public Club setPhone(string phone);
        public Club setMobile(string mobile);
        public Club setStatus(ClubStatus status);

        public string getName();
        public string getPhone();
        public string getMobile();
        public string getEmail();
        public string getDescription();
        public string getAddress();
        public string getBirthday();
        public string getEntryDate();
        public string getBillingData();
        public string getTaxID();
        public string getRegistryNumber();
        public string getRegistryCourt();
        public string getManagementBoard();
        public ClubStatus getStatus();

    }
}
