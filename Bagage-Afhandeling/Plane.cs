using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagage_Afhandeling
{
    public class Plane
    {
        public string AirlineCode { get; private set; }
        public int FlightCode { get; private set; }
        public string FlightNumber { get; private set; }
        public string DepartureAirport { get; private set; }
        public string ArrivalAirport { get; private set; }
        public DateTime DepartureTime { get; private set; }
        public DateTime ArrivalTime { get; private set; }
        public List<Baggage> Baggages { get; private set; } = new List<Baggage>();

        public Plane(string airlineCode, int flightCode, string departureAirport, string arrivalAirport, DateTime departureTime, DateTime arrivalTime)
        {
            AirlineCode = airlineCode;
            FlightCode = flightCode;
            FlightNumber = AirlineCode + FlightCode;
            DepartureAirport = departureAirport;
            ArrivalAirport = arrivalAirport;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
        }
        //public void AddBaggage(Baggage baggage)
        //{
        //    Baggages.Add(baggage);
        //}
    }
}