using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompanyApp.Logic
{
    public abstract class CompanyBase
    {
        // Variables
        private int id;
        private string title;
        private DateTime dueTimestamp;
        private string description;
        private Priority priority;
        private List<Developer> assignedDevelopers;

        // Constructor
        public CompanyBase(int id, string title, string description, DateTime dueTimestamp, Priority priority)
        {
            this.id = id;
            this.title = title;
            this.dueTimestamp = dueTimestamp;
            this.description = description;
            this.priority = priority;
            this.assignedDevelopers = new List<Developer>();
        }

        // Getters and Setters
        public int Id { get => id; set => id = value; }

        public string Title
        {
            get { return this.title; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                { throw new ArgumentException("Invalid title"); }

                this.title = value;
            }
        }

        public string Description { get => description; set => description = value; }
        
        public DateTime DueTimestamp
        {
            get { return this.dueTimestamp; }
            set
            {
                if (value < DateTime.Now)
                { throw new ArgumentException("Date and time cannot be in the past"); }

                this.dueTimestamp = value;
            }
        }

        public Priority Priority { get => priority; set => priority = value; }
        public List<Developer> AssignedDevelopers { get => assignedDevelopers; set => assignedDevelopers = value; }

        // Inheritance method
        public virtual Developer[] GetAssignedDevelopers()
        {
            return this.AssignedDevelopers.ToArray();
        }

        // Abstract methods
        public abstract void AssignDeveloper(Developer d);

        public abstract void RemoveDeveloper(Developer d);

    }
}
