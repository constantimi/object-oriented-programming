using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapAssignment
{
    public class Item
    {
        private ServiceType _type;
        private string _name;

        public Item(string name, ServiceType type)
        {
            this.Type = type;
            this.Name = name;
        }

        public ServiceType Type { get => _type; set => _type = value; }
        public string Name { get => _name; set => _name = value; }

        public override string ToString()
        {
            return $"{this.Name} for {this.Type}";
        }
    }
}
