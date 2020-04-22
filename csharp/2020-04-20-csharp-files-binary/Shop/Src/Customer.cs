using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Customer 
    {
        // Variables
        private string id;
        private string name;
        private string email;

        // Getters and Setters
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Id { get => id; set => id = value; }

        // Default constructor
        public Customer()
        {
        
        }

        public Customer(string id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.Email = null;
        }

        public Customer(string id, string name, string email)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
        }

        /// 
        /// This method returns information for the Customer.
        /// 
        public override string ToString()
        {
            return $"{this.Name}, {this.Email}";
        }

    }
}
