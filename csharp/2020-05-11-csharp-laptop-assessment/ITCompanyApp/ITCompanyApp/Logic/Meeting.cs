using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompanyApp.Logic
{
    public class Meeting : CompanyBase
    {
        public Meeting(int id, string title, string description, DateTime dueDate, Priority priority) : base(id, title, description, dueDate, priority)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.DueTimestamp = dueDate;
            this.Priority = priority;
        }

        // Inheritance method
        public override Developer[] GetAssignedDevelopers()
        {
            if (this.AssignedDevelopers.Count < 2)
            { throw new InvalidOperationException("A meeting must always be at least be 2 developers"); }

            return this.AssignedDevelopers.ToArray();
        }

        // Abstract methods
        public override void AssignDeveloper(Developer d)
        {
            if (this.AssignedDevelopers.Contains(d))
            { throw new ArgumentException("Supplied developer is already assigned"); }

            this.AssignedDevelopers.Add(d);
        }

        public override void RemoveDeveloper(Developer d)
        {
            if (!this.AssignedDevelopers.Contains(d))
            { throw new ArgumentException("Unknown developer supplied"); }

            this.AssignedDevelopers.Remove(d);
        }
    }
}
