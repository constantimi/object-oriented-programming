using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace logic.DeliverablesApp
{
    public class Transport
    {
        // Instances
        private List<Deliverable> myDeliverables;

        // Constructor
        public Transport()
        {
            this.myDeliverables = new List<Deliverable>();
        }

        // Getters and Setters
        public List<Deliverable> Deliverables { get { return this.myDeliverables; } }

        public void LoadDeliverablesFromFile(String filename)
        {
            StreamReader sr = null;
            try
            {
                int id;
                int weight;
                int housenr;
                String name;
                String street;
                String postalcode;
                String city;

                sr = new StreamReader(new FileStream(filename, FileMode.Open, FileAccess.Read));

                String s = sr.ReadLine();

                while (s != null)
                {
                    id = Convert.ToInt32(s);
                    weight = Convert.ToInt32(sr.ReadLine());
                    name = sr.ReadLine();
                    street = sr.ReadLine();
                    housenr = Convert.ToInt32(sr.ReadLine());
                    postalcode = sr.ReadLine();
                    city = sr.ReadLine();

                    // Add new Person
                    this.myDeliverables.Add(new Deliverable(id, weight, new Person(name, street, housenr, postalcode, city)));

                    s = sr.ReadLine(); s = sr.ReadLine();
                }

            }
            catch (IOException)
            {
                throw new Exception($"Error: Can't read the file : {filename}");
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

        public void AddDeliverable(Deliverable d)
        {
            if (FindDeliverable(d.ID) == null)
            {
                myDeliverables.Add(d);
            }
            else
            {
                throw new Exception("Be aware: nothing is added!!!");
            }
        }

        public Deliverable FindDeliverable(int id)
        {
            foreach (Deliverable d in this.myDeliverables)
            {
                if (d.ID == id)
                {
                    return d;
                }
            }
            return null;
        }

        public Deliverable FindHeaviestDeliverable()
        {
            if (this.myDeliverables.Count == 0)
                throw new Exception("There is no heaviest deliverable in an empty transport!");

            Deliverable heaviest = this.myDeliverables[0];

            foreach (Deliverable d in this.myDeliverables)
            {
                if (d.Weight >= heaviest.Weight)
                {
                    heaviest = d;
                }
            }

            return heaviest;
        }

        /// <summary>
        /// SortByAddress sorts the elements of the deliverables-list "alfabetically by cityname, then by street; then by increasing house-number".
        /// So elements with the same cityname, but a different street, are sorted alfabetically by street.
        /// Elements with the same city and street, are sorted by increasing house-number. 
        /// </summary>
        public void SortByAddress()
        {
            // Not implemented yet
        }

    }
}
