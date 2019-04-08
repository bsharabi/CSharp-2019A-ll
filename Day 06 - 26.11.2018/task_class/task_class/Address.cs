using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_class
{
    class Address
    {
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        private string street;

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        private int numberOfHome ;
        public int NumberOfHome
        {
            get { return numberOfHome; }
            set { numberOfHome = value; }
        }

        public Address(string country, string city, string street, int numberOfHome)
        {
            NumberOfHome = numberOfHome;
            Street = street;
            Country = country;
            City = city;
        }
        public Address()
        {
        }
        public void getInfo()
        {
            Console.WriteLine($"The adrdress is country :{country}, city : {city},street :{street}, number :{numberOfHome}");
        }
    }
}
