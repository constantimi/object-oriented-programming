using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompanyApp.Logic
{
    public class Developer
    {
        public int Id { get; private set; }
        private string name;
        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                { throw new ArgumentException("Invalid name"); }
                
                this.name = value;
            }
        }

        public Developer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public override string ToString()
        {
            return $"{Id:0000} - {name}";
        }
    }
}
