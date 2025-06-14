using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagage_Afhandeling
{
    public class Airport
    {
        public List<Employee> Employees;
        public List<Scanner> Scanners;
        public List<Plane> Planes;
        public List<Passenger> Passengers;
        public List<Baggage> Baggages; 


        
        public Airport()
        {
            Employees = new List<Employee>();
            Scanners = new List<Scanner>();
            Planes = new List<Plane>();
            Passengers = new List<Passenger>();
            Baggages = new List<Baggage>();
        }



        
        public Baggage GetBaggageById(string baggageId)
        {
            if (Baggages == null)
                return null;

            return Baggages.Find(b => b.Baggage_ID == baggageId);
        }
    }
}
