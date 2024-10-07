using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menagelec.Entities
{
    public class Client : AbstractEntity
    {
        private readonly int _id;
        private string _civility;
        private string _lastName;
        private string _name;
        private string _email;
        private string _phone;
        private int _postalCode;
        private string _city;
        private string _address;

        public int getId() { return this._id; }
        

        public string getCivility() { return this._civility; }
        public Client setCivility(string civility)
        {
            this._civility = civility;
            return this;
        }

        public string getLastName() { return this._lastName;}
        public Client setLastName(string lastName)
        {
            this._lastName = lastName;
            return this;
        }

        public string getName() { return this._name;}
        public Client setName(string name)
        {
            this._name = name;
            return this;
        }

        public string getEmail() { return this._email;}
        public Client setEmail(string email)
        {
            this._email = email;
            return this;
        }

        public string getPhone() { return this._phone;}
        public Client setPhone(string phone)
        {
            this._phone = phone;
            return this;
        }

        public int getPostalCode() { return this._postalCode;}
        public Client setPostalCode(int postalCode)
        {
            this._postalCode = postalCode;
            return this;
        }

        public string getCity() { return this._city;}
        public Client setCity(string city)
        {
            this._city = city;
            return this;
        }

        public string getAddress() { return this._address;}
        public Client setAddress(string address)
        { 
            this._address = address;
            return this;
        }
    }
}