using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bagage_Afhandeling
{
    internal static class Program
    {
        public static Airport schiphol = new Airport();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
             

            //Alle scanners op het vliegveld
            Scanner checkInScanner = new Scanner("Check-In", "Check-in desk 1");
            Scanner securityScanner = new Scanner("Security Check", "Security Checkpoint");
            Scanner sortingScanner = new Scanner("Sorting process", "Baggage Sorting Area");
            Scanner magazineEntryScanner = new Scanner("Magazine Entry", "Magazine Entrance");
            Scanner magazineExitScanner = new Scanner("Magazine Exit", "Magazine Exit to Tarmac");
            Scanner preLoadingScanner = new Scanner("Pre-Loading", "Plane loading area");
            Scanner planeLoadingScanner = new Scanner("Plane Loading", "Plane Cargo Door");
            Scanner arrivalScanner = new Scanner("Arrival Sorting", "Arrival Sorting Area");
            Scanner beltScanner = new Scanner("Pickup Belt feeder", "Baggage Pickup Belt");
            Program.schiphol.Scanners.Add(checkInScanner); schiphol.Scanners.Add(securityScanner); schiphol.Scanners.Add(sortingScanner); 
            Program.schiphol.Scanners.Add(magazineEntryScanner); schiphol.Scanners.Add(magazineExitScanner);schiphol.Scanners.Add(preLoadingScanner);
            Program.schiphol.Scanners.Add(planeLoadingScanner); schiphol.Scanners.Add(arrivalScanner); schiphol.Scanners.Add(beltScanner);


            //Huidige vluchten
            Plane plane1 = new Plane("KL", 2301, "Schiphol", "London", new DateTime(2025, 6, 10, 8, 30, 0), new DateTime(2025, 6, 10, 9, 30, 0));
            Plane plane2 = new Plane("LH", 3402, "Schiphol", "Frankfurt", new DateTime(2025, 6, 11, 7, 0, 0), new DateTime(2025, 6, 11, 8, 30, 0));
            Plane plane3 = new Plane("BA", 1203, "Schiphol", "London", new DateTime(2025, 6, 12, 10, 15, 0), new DateTime(2025, 6, 12, 11, 15, 0));
            Plane plane4 = new Plane("AF", 4504, "Schiphol", "Paris", new DateTime(2025, 6, 13, 12, 45, 0), new DateTime(2025, 6, 13, 14, 15, 0));
            Plane plane5 = new Plane("DL", 5605, "Schiphol", "New York", new DateTime(2025, 6, 14, 15, 0, 0), new DateTime(2025, 6, 14, 23, 0, 0));

            Plane plane6 = new Plane("UA", 6706, "Chicago", "Schiphol", new DateTime(2025, 6, 15, 17, 30, 0), new DateTime(2025, 6, 16, 8, 0, 0));
            Plane plane7 = new Plane("EK", 7807, "Dubai", "Schiphol", new DateTime(2025, 6, 16, 20, 0, 0), new DateTime(2025, 6, 17, 2, 0, 0));
            Plane plane8 = new Plane("QF", 8908, "Sydney", "Schiphol", new DateTime(2025, 6, 17, 22, 0, 0), new DateTime(2025, 6, 18, 14, 0, 0));
            Plane plane9 = new Plane("SU", 9109, "Moscow", "Schiphol", new DateTime(2025, 6, 18, 6, 0, 0), new DateTime(2025, 6, 18, 9, 0, 0));
            Plane plane10 = new Plane("IB", 1010, "Madrid", "Schiphol", new DateTime(2025, 6, 19, 11, 0, 0), new DateTime(2025, 6, 19, 13, 30, 0));
            Program.schiphol.Planes.Add(plane1); schiphol.Planes.Add(plane2); schiphol.Planes.Add(plane3);
            Program.schiphol.Planes.Add(plane4); schiphol.Planes.Add(plane5); schiphol.Planes.Add(plane6);
            Program.schiphol.Planes.Add(plane7); schiphol.Planes.Add(plane8); schiphol.Planes.Add(plane9); schiphol.Planes.Add(plane10);

            //Employees
            Employee Ralph = new Employee(1001, "Ralph123!", "Ralph", "Lauren", "Flight-Attendant");
            Employee Anna = new Employee(1002, "Anna123!", "Anna", "Smith", "Baggage Handler");
            Employee John = new Employee(1003, "John123!", "John", "Doe", "Security Officer");
            Employee Maria = new Employee(1004, "Maria123!", "Maria", "Garcia", "Check-in Agent");
            Employee Ahmed = new Employee(1005, "Ahmed123!", "Ahmed", "Khan", "Magazine Supervisor");
            Program.schiphol.Employees.Add(Ralph); schiphol.Employees.Add(Anna); schiphol.Employees.Add(John);
            Program.schiphol.Employees.Add(Maria); schiphol.Employees.Add(Ahmed);

            //Passengers
            Passenger FirstPassenger = new Passenger(1111, schiphol.Planes[0].FlightNumber, "Koen", "Verhalle", "Koenverhalle@gmail.com", 0612292496);
            Passenger SecondPassenger = new Passenger(1112, schiphol.Planes[1].FlightNumber, "Emma", "Johnson", "emma.johnson@gmail.com", 0612345678);
            Passenger ThirdPassenger = new Passenger(1113, schiphol.Planes[2].FlightNumber, "Liam", "Williams", "liam.williams@gmail.com", 0612345679);
            Passenger FourthPassenger = new Passenger(1114, schiphol.Planes[3].FlightNumber, "Olivia", "Brown", "olivia.brown@gmail.com", 0612345680);
            Passenger FifthPassenger = new Passenger(1115, schiphol.Planes[4].FlightNumber, "Noah", "Jones", "noah.jones@gmail.com", 0612345681);

            Program.schiphol.Passengers.Add(FirstPassenger); schiphol.Passengers.Add(SecondPassenger); schiphol.Passengers.Add(ThirdPassenger);
            Program.schiphol.Passengers.Add(FourthPassenger); schiphol.Passengers.Add(FifthPassenger);


            // add Baggages to the Passenger in your
            Baggage baggage1 = new Baggage(FirstPassenger.FlightNumber, FirstPassenger.Passenger_ID, 1);
            Baggage baggage2 = new Baggage(SecondPassenger.FlightNumber, SecondPassenger.Passenger_ID, 1);
            Baggage baggage3 = new Baggage(ThirdPassenger.FlightNumber, ThirdPassenger.Passenger_ID, 1);
            Baggage baggage4 = new Baggage(FourthPassenger.FlightNumber, FourthPassenger.Passenger_ID, 1);
            Baggage baggage5 = new Baggage(FifthPassenger.FlightNumber, FifthPassenger.Passenger_ID, 1);
            FirstPassenger.AddBaggage(baggage1);
            SecondPassenger.AddBaggage(baggage2);
            ThirdPassenger.AddBaggage(baggage3);
            FourthPassenger.AddBaggage(baggage4);
            FifthPassenger.AddBaggage(baggage5);


            
            baggage1.StatusNotifications.Add(new Status("Schiphol", "Check-in desk 1", "Check-In"));
            baggage1.StatusNotifications.Add(new Status("Schiphol", "Security Checkpoint", "Security Check"));





            //Baggage 'inchecken' via de scanner aan de incheckbalie
            //Baggage baggage1 = checkInScanner.CheckInBaggage(checkInScanner, FirstPassenger);
            //Baggage baggage2 = checkInScanner.CheckInBaggage(checkInScanner, SecondPassenger);
            //Baggage baggage3 = checkInScanner.CheckInBaggage(checkInScanner, ThirdPassenger);
            //Baggage baggage4 = checkInScanner.CheckInBaggage(checkInScanner, FourthPassenger);
            //Baggage baggage5 = checkInScanner.CheckInBaggage(checkInScanner, FifthPassenger);
            //schiphol.Baggages.Add(baggage1); schiphol.Baggages.Add(baggage2); schiphol.Baggages.Add(baggage3);
            //schiphol.Baggages.Add(baggage4); schiphol.Baggages.Add(baggage5);




            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignIn());

           
        }
    }
}
