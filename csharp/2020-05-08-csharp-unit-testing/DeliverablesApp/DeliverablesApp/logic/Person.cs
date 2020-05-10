using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic.DeliverablesApp
{
    public class Person
    {
        // Variables
        private String name;
        private String street;
        private int housenumber;
        private String postalcode;
        private String city;

        // Constructor
        public Person(string name, string street, int housenumber, string postalcode, string city) 
        {
            this.Name = name;
            this.Street = street;
            this.Housenumber = housenumber;
            this.Postalcode = postalcode;
            this.City = city;
        }

        // Getters and Setters
        public string Name { get => name; set => name = value; }
        public string Street { get => street; set => street = value; }
        public int Housenumber { get => housenumber; set => housenumber = value; }
        public string Postalcode { get => postalcode; set => postalcode = value; }
        public string City { get => city; set => city = value; }

    }
}