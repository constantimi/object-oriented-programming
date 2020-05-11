using System;
using System.Collections.Generic;

namespace ITCompanyApp.Logic
{
    public class ToDo : CompanyBase
    {
        public ToDo(int id, string title, string description, DateTime dueDate, Priority priority) : base(id, title, description, dueDate, priority)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.DueTimestamp = dueDate;
            this.Priority = priority;            
        }

        public override void AssignDeveloper(Developer d)
        {
            if (this.AssignedDevelopers.Contains(d))
            { throw new ArgumentException("Supplied developer is already assigned"); }
            if (this.AssignedDevelopers.Count == 3)
            { throw new InvalidOperationException("A to-do cannot have more than 3 developers assigned to it"); }

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
