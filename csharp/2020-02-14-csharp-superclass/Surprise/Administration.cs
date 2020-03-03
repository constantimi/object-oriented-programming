using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surprise
{
    class Administration
    {
        // Variables
        private List<Person> personList;
        private List<Student> studentsList;
        private List<Teacher> teachersList;
        
        // Defualt constructor
        public Administration()
        {
            this.personList = new List<Person>();
            this.studentsList = new List<Student>();
            this.teachersList = new List<Teacher>();
        }

        // Methods
        public void AddPerson(Person p)
        {
            this.personList.Add(p);
        }
        
        public void AddStudent(Student s)
        {
            this.studentsList.Add(s);
        }

        public void AddTeacher(Teacher t)
        {
            this.teachersList.Add(t);
        }

        // Getters 
        public Person GetPerson(int pcn)
        {
            foreach (Person p in personList)
            {
                if(p.Pcn == pcn)
                {
                    return p;
                }
            }

            return null;
        }

        public Student GetStudent(int pcn)
        {
            foreach (Student s in studentsList)
            {
                if (s.Pcn == pcn)
                {
                    return s;
                }
            }

            return null;
        }

        public Teacher GetTeacher(int pcn)
        {
            foreach (Teacher t in teachersList)
            {
                if (t.Pcn == pcn)
                {
                    return t;
                }
            }

            return null;
        }

        public List<Person> GetPersons()
        {
            return this.personList;
        }

        public List<Student> GetStudents()
        {
            return this.studentsList;
        }

        public List<Teacher> GetTeachers()
        {
            return this.teachersList;
        }
    }
}
