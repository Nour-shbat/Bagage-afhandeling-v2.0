using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bagage_Afhandeling
{
  
    public partial class PassengerForm : Form
    {
        private Airport schiphol; // This will hold the reference

        private Passenger currentPassenger; // This will hold the current passenger information

        // Constructor that takes an Airport object and the current Passenger object
        public PassengerForm(Airport airport, Passenger passenger)
        {
            InitializeComponent();
            this.schiphol = airport;
            this.currentPassenger = passenger;
            this.BaggageList.SelectedIndexChanged += new System.EventHandler(this.BaggageList_SelectedIndexChanged);

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void PassengerForm_Load(object sender, EventArgs e)
        {
            BaggageList.Items.Clear(); // Clear the list before populating it
            // Populate the baggage list with the current passenger's baggage
            foreach (var baggage in currentPassenger.Baggages)
            {
                BaggageList.Items.Add(baggage); 
            }
            // Make sure the Load event is correctly wired up
            this.Load += new System.EventHandler(this.PassengerForm_Load);
            MessageBox.Show($"Baggages: {currentPassenger.Baggages.Count}");



        }

        private void ConfirmID_Click(object sender, EventArgs e)

        {
        }
 
        private void StatusList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void BaggageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear previous statuses
            StatusList.Items.Clear();

            // Get selected baggage ID
            if (BaggageList.SelectedItem == null)
                return;

            string selectedBaggageId = BaggageList.SelectedItem.ToString();
            // Find the baggage object
            var baggage = currentPassenger.Baggages.FirstOrDefault(b => b.Baggage_ID == selectedBaggageId);

            if (baggage != null && baggage.StatusNotifications != null)
            {
                foreach (var status in baggage.StatusNotifications)
                {
                    // Customize the format as needed
                    string statusInfo = $"{status.Time:G}: {status.StatusType} at {status.ScannerName}";
                    StatusList.Items.Add(statusInfo);
                }
                // Optional: If there are no statuses, you may want to inform the user
                if (baggage.StatusNotifications.Count == 0)
                {
                    StatusList.Items.Add("No status updates for this baggage yet.");
                }
            }
            else
            {
                StatusList.Items.Add("Could not find status information for this baggage.");
            }
        }



    }
}
