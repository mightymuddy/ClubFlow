using System.Runtime.CompilerServices;
using Vereinsportal.Interfaces;

namespace Vereinsportal.Components
{
    public class User : IUser
    {
        private string _firstname;
        private string _lastname;
        private string _username;
        private string _email;
        private string _password;
        private string? _phone;
        private bool _emailVerified;
        private bool _passwordVerified;
        private string? _age;
        private string? _birthday;
        private string? _gender;
        private ILocation? _address;


        internal User setFirstName(string firstName) { _firstname = firstName; return this; }
        internal User setLastName(string lastName) { _lastname = lastName; return this; }
        internal User setUserName(string username) { _username = username; return this; }
        internal User setEmail(string mail) { _email = mail; return this; }
        internal User setPassword(string password) { _password = password; return this; }
        internal User setPhone(string phone) { _phone = phone; return this; }
        internal User setEmailVerified(bool verified) { _emailVerified = verified; return this; }
        internal User setPasswordVerified(bool passwordVerified) { _passwordVerified = passwordVerified; return this; }
        internal User setAge(string age) { _age = age; return this; }
        internal User setBirthday(string birthday) { _birthday = birthday; return this; }
        internal User setGender(string gender) { _gender = gender; return this; }
        internal User setAddress(ILocation address) { _address = address; return this; }

        string IUser.UserName()
        {
            return _username;
        }

        string? IUser.UserAddress()
        {
            return _address.getAddress();
        }

        string? IUser.UserGender()
        {
            return _gender;
        }

        string? IUser.UserPhone()
        {
            return _phone;
        }

        string IUser.UserEmail()
        {
            return _email;
        }

        public User(string firstname, string lastname, string username, string email, string password)
        {
            if (firstname != null && lastname != null && username != null && email != null && password != null)
            {
                setFirstName(firstname).
                setLastName(lastname).
                setUserName(username).
                setEmail(email).
                setPassword(password);
            }
        }


    }
}
