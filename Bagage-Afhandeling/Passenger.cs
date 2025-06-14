using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagage_Afhandeling
{
    public class Passenger
    {
        public int Passenger_ID { get; private set; }
        public string Password { get;  set; }
        public string FlightNumber { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public int PhoneNumber { get; private set; }
        public List<Plane> Planes { get; private set; } = new List<Plane>();
        public List<Baggage> Baggages { get; private set; } = new List<Baggage>();
        

        public Passenger(int passengerId, string flightNumber, string firstName, string lastName, string email, int phoneNumber)
        {
            Passenger_ID = passengerId;
            FlightNumber = flightNumber;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }
         // Add a method to safely set the password
    public void SetPassword(string newPassword)
    {
        // Optionally: Add password validation or hashing here
        Password = newPassword;
    }

        //Handig of niet?
        //public void AddPlanes(Plane plane)
        //{
        //    Planes.Add(plane);
        //}

        public void GetBagageStatus() { }

        public void ReportLostBaggage() { }

        public void PickupBaggage() { }
        public void AddBaggage(Baggage baggage)
        {
            Baggages.Add(baggage);
        }

    }
}
