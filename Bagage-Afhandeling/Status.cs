using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bagage_Afhandeling
{
    public class Status
    {
        public string AirportName { get; private set; }
        public string ScannerName { get; private set; }

        public DateTime Time { get; private set; }

        public string StatusType { get; private set; }
        public object Description { get; internal set; }

        public Status(string airportName, string scannerName, string function)
        {
            AirportName = airportName;
            ScannerName = scannerName;
            Time = DateTime.Now;
            StatusType = function;
        }

        public void SendNotification(Status status)
        {
            MessageBox.Show($"Uw baggage ging om {status.Time} door de {status.StatusType} op {status.AirportName} en bevindt zich op {status.ScannerName}.");
        }
    }
}
