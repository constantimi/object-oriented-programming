using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace logic.DeliverablesApp
{

    public class Deliverable
    {
        // Variables
        private int id;    //the unique id of a deliverable
        private int weight; //the weight (in grams) of this deliverable
        private Person iperson;
        // Constructor
        public Deliverable(int id, int weight, Person person)
        {
            this.id = id;
            this.weight = weight;
            this.iperson = person;
        }

        // Getters and Setters
        public int ID { get { return this.id; } }
        public int Weight { get { return this.weight; } }
        public Person Iperson { get => iperson; set => iperson = value; }

        // Virtual method
        public override string ToString()
        {
            return "Id: " + Convert.ToString(this.id) + ", weight: " + Convert.ToString(this.weight) + ", should be delivered at: " +
                this.Iperson.Name + " - " + this.Iperson.Street + "  " + this.Iperson.Housenumber + " - " + this.Iperson.Postalcode + "  " + this.Iperson.City;
        }

    }
}

