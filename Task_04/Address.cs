using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class Address
    {
        int index;
        string country;
        string city;
        string house;
        string apartment;

        public int Index { get { return index; } set { index = value; } }
        public string Country { get { return country; } set { country = value; } }
        public string City { get { return city; } set { city = value; } }
        public string House { get { return house; } set { house = value; } }
        public string Apartment { get { return apartment; } set { apartment = value; } }
    }
}
