using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompanyApp.Logic
{
    public class Company
    {
        private List<CompanyBase> tasks;
        private List<Developer> developers;

        public Company()
        {
            this.tasks = new List<CompanyBase>();
            this.developers = new List<Developer>();
        }

        public CompanyBase AddToDo(int id, string title, string description, DateTime dueTimestamp, Priority priority)
        {
            if (this.GetCompanyBase(id) != null)
            { throw new InvalidOperationException("To do with the same id already exists"); }

            CompanyBase t = new ToDo(id, title, description, dueTimestamp, priority);
            this.tasks.Add(t);

            return t;
        }
        public CompanyBase AddMeeting(int id, string title, string description, DateTime dueTimestamp, Priority priority)
        {
            if (this.GetCompanyBase(id) != null)
            { throw new InvalidOperationException("To do with the same id already exists"); }

            CompanyBase t = new Meeting(id, title, description, dueTimestamp, priority);
            this.tasks.Add(t);

            return t;
        }
        public CompanyBase GetCompanyBase(int id)
        {
            foreach (CompanyBase t in this.tasks)
            {
                if(t.Id == id)
                { return t; }
            }
            return null;
        }
        public CompanyBase[] GetCompanyBases()
        {
            return this.tasks.ToArray();
        }

        // Get CompanyBasesByPriority
        public CompanyBase[] GetCompanyBasesByPriority(Priority priority)
        {
            List<CompanyBase> priorityCompanyBases = new List<CompanyBase>();
            
            foreach (CompanyBase task in this.tasks)
            {
                if(task.Priority == priority)
                {
                    priorityCompanyBases.Add(task);
                }
            }
            return priorityCompanyBases.ToArray();
        }

        // Get Sorted and ByPriority
        public CompanyBase[] GetCompanyBasesSorted(Priority priority)
        {
            // Sort by ACS
            List<CompanyBase> sortedList = GetCompanyBasesByPriority(priority).OfType<CompanyBase>().OrderBy(c => c.Title).OrderBy(c => c.DueTimestamp).ToList();

            return sortedList.ToArray();
        }

        public Developer AddDeveloper(int id, string name)
        {
            if (this.GetDeveloper(id) != null)
            { throw new InvalidOperationException("Developer with the same id already exists"); }
            Developer d = new Developer(id, name);
            this.developers.Add(d);

            return d;
        }
        public Developer GetDeveloper(int id)
        {
            foreach (Developer d in this.developers)
            {
                if (d.Id == id)
                { return d; }
            }

            return null;
        }
        public Developer[] GetDevelopers()
        {
            return this.developers.ToArray();
        }
    }
}
