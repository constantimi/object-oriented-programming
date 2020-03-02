using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    class Administration
    {
        // Variables
        private List<Person> personList;

        // Defualt constructor
        public Administration()
        {
            this.PersonList = new List<Person>();
        }

        // Methods
        public void AddPerson(Person p)
        {
            this.PersonList.Add(p);
        }

        // Getters and Setters
        public List<Person> PersonList { get => personList; set => personList = value; }

        public Person GetPerson(int pcn)
        {
            foreach (Person p in PersonList)
            {
                if (p.Pcn == pcn)
                {
                    return p;
                }
            }

            return null;
        }

        public List<Person> GetPersonsByParialPCN(int parPcn)
        {
            List<Person> lPerson = new List<Person>();

            foreach (Person p in PersonList)
            {
                if (Convert.ToString(p.Pcn).Contains(Convert.ToString(parPcn)) == true)
                {
                    lPerson.Add(p);
                }
            }
            return lPerson;
        }

        /// <summary>
        /// Get list with persons
        /// </summary>
        /// <returns></returns>
        public List<Person> GetPersons()
        {
            return this.PersonList;
        }

    }
}
