using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    class Airplane
    {
        // Variables
        private string id;
        private string typeAirplane;
        private int businessClassSeats;
        private int economyClassSeats;
        private List<Role> roles;

        // Properties
        private int countPassengers;
        private int countPiots;
        private int countAttendants;
        // Default constructor
        public Airplane()
        {

        }

        // Constructor
        public Airplane(int id, string typeAirplane, int businessClassSeats, int economyClassSeats)
        {
            // Format the ID for the plane to 4 digit
            this.Id = String.Format("{0:0000}", id);

            this.TypeAirplane = typeAirplane;
            this.BusinessClassSeats = businessClassSeats;
            this.EconomyClassSeats = economyClassSeats;

            this.Roles = new List<Role>();
            this.CountPassengers = 0;
            this.CountAttendants = 0;
            this.CountPiots = 0;
        }

        // Getters and Setters
        public string Id { get => id; set => id = value; }
        public string TypeAirplane { get => typeAirplane; set => typeAirplane = value; }
        public int BusinessClassSeats { get => businessClassSeats; set => businessClassSeats = value * 2; }
        public int EconomyClassSeats { get => economyClassSeats; set => economyClassSeats = value * 3; }
        public int CountPassengers { get => countPassengers; set => countPassengers = value; }
        public int CountPiots { get => countPiots; set => countPiots = value; }
        public int CountAttendants { get => countAttendants; set => countAttendants = value; }
        internal List<Role> Roles { get => roles; set => roles = value; }

        // Methods

        /// <summary>
        /// Check if the attendance is correct
        /// </summary>
        /// <returns> boolean True/False </returns>
        public bool CanAirplaneTakeOff()
        {
            if(this.CountPiots >= 2 && this.countAttendants == 5)
            {
                return true;
            }

            return false;
        }


        /// <summary>
        /// Add a passenger in the Airplane
        /// </summary>
        /// <param name="r"></param>
        public bool AddInAirplane(Role r)
        {
            // Check if the role is a Pilot
            if (r is Pilot && this.CountPiots < 4)
            {
                // Add this role in the list
                this.roles.Add(r);

                // Increment the pilots count
                this.CountPiots += 1;

                return true;
            }
            // Check if the role is a Passenger
            else if (r is Passenger)
            {
                // Check if there is enough space for the economy class
                if (this.EconomyClassSeats >= 0)
                {
                    // Add a passenger in the plane
                    this.CountPassengers += 1;
                    this.EconomyClassSeats -= 1;

                    return true;
                }
                // Else add it to the business class
                else if (this.BusinessClassSeats >= 0)
                {
                    // Add a passenger in the plane
                    this.countPassengers += 1;
                    this.BusinessClassSeats -= 1;

                    return true;
                }

                // By defualt there is no space
                return false;
            }
            else if (r is Attendant && this.CountAttendants < 6)
            {
                // Add this role in the list
                this.roles.Add(r);

                // Increment the pilots count
                this.CountAttendants += 1;

                return true;
            }
           
            // Not found Role
            return false;
        }

    }
}
