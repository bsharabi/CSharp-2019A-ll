using System;
namespace task_class
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private Address address_n;

        public Address Address_n
        {
            get { return address_n; }
            set { address_n = value; }
        }
        public void getInfo()
        {
            Console.WriteLine($"The name is {Name} The adrdress is country : {address_n.Country}, city : {address_n.City}, street : {address_n.Street}, number : {address_n.NumberOfHome}");
        }
      
    }
}
