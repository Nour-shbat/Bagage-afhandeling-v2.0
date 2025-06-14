using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bagage_Afhandeling
{
    public class Scanner
    {
        public string Function { get; private set; }
        public string ScannerName { get; private set; }
        public string AirportName { get; private set; }
        public List<Baggage> ScannedBaggages { get; private set; } = new List<Baggage>();


        public Scanner(string function, string scannerName)
        {
            Function = function;
            ScannerName = scannerName;
        }


        public void CheckCorrectPlane() { }

        //updatestatus naar scanner en niet status
        public void ScanCode(Baggage baggage, Scanner scanner)
        {
            Status newStatus = new Status(scanner.AirportName, scanner.ScannerName, scanner.Function);
            baggage.StatusNotifications.Add(newStatus);

            scanner.ScannedBaggages.Add(baggage);
            newStatus.SendNotification(newStatus);//baggage.Passenger_ID om notificatie naar de juiste persoon te sturen
        }

        public void CheckInBaggage(Scanner scanner, Passenger passenger)
        {
            //Hierin wordt een nieuw baggage object aangemaakt en gekoppeld aan de passagier

            //randomID voor baggage (kans op dubbele ID)
            //Random randomcode = new Random();
            //int baggageCode = randomCode.Next(2000, 100000); niet nodig omdat baggage code 1/2 of 3 is(aantal bagagge stukken)

            string flightNumber = passenger.FlightNumber;
            int passenger_ID = passenger.Passenger_ID;
            int baggageCode = passenger.Baggages.Count + 1;

            //string QrCode = "QR" + baggage_ID; niet nodig omdat QR de waarde krijgt van QR + Baggage_ID in constructor

            Baggage newBaggage = new Baggage(flightNumber, passenger_ID, baggageCode);
            //baggage toevoegen aan de passagier
            passenger.AddBaggage(newBaggage);
            scanner.ScanCode(newBaggage, scanner);
        }

        public void UpdateStatus() { }// nog wel nodig??(ScanCode)
    }
}
