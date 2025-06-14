using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagage_Afhandeling
{
    public class Baggage
    {
        // Baggage_ID is a unique identifier for the baggage, which is a combination of FlightNumber, Passenger_ID, and BaggageCode
        public string Baggage_ID { get; private set; }
        public string FlightNumber { get; private set; }
        public int Passenger_ID { get; private set; }
        public int BaggageCode { get; private set; }
        public string QRCode { get; private set; }
        public bool IsLost { get; private set; }
        public List<Status> StatusNotifications { get; set; } = new List<Status>();

        public Baggage(string flightNumber, int passenger_ID, int baggageCode)
        {
            FlightNumber = flightNumber;
            Passenger_ID = passenger_ID;
            BaggageCode = baggageCode;
            Baggage_ID = $"{FlightNumber}-{Passenger_ID}-{BaggageCode}";
            QRCode = "QR" + Baggage_ID;
            IsLost = false;

        }
        public void SetBaggageIDFromPassengerID(string flightNumber, int passenger_ID, int baggageCode)
        {
            FlightNumber = flightNumber;
            Passenger_ID = passenger_ID;
            BaggageCode = baggageCode;
            Baggage_ID = $"{FlightNumber}-{Passenger_ID}-{BaggageCode}";
            QRCode = "QR" + Baggage_ID;
        }



    }
}

