using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Bagage_Afhandeling
{
    public partial class PassengerSignUP : Form
    {
        public PassengerSignUP()
        {
            InitializeComponent();
        }

      

        private void PassengerID_TextChanged(object sender, EventArgs e)
        {
            // focus on the Passenger ID textbox when the form opens
            PassengerIDTextBox.Focus();
            string passengerID = PassengerIDTextBox.Text;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(PassengerIDTextBox.Text, out id))
            {
                var passenger = Program.schiphol.Passengers.FirstOrDefault(p => p.Passenger_ID == id);

                if (passenger != null)
                {
                    FirstNameTextBox.Text = passenger.FirstName;
                    LastNameTextBox.Text = passenger.LastName;
                    EmailTextBox.Text = passenger.Email;
                    PhoneTextBox.Text = passenger.PhoneNumber.ToString();
                    FlightNumberTextBox.Text = passenger.FlightNumber;
                }
                else
                {
                    MessageBox.Show("Passenger not found. No booking with this ID. The application will now close.");
                    System.Windows.Forms.Application.Exit(); // Fully qualify 'Application' to resolve ambiguity  
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Passenger ID number.");
            }
        }

        private void NewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            int id;
            // Try to parse the entered Passenger ID  
            if (int.TryParse(PassengerIDTextBox.Text, out id))
            {
                // Find the passenger by ID  
                var passenger = Program.schiphol.Passengers.FirstOrDefault(p => p.Passenger_ID == id);

                if (passenger != null)
                {
                    // Save the password (fields are already validated before this step)  
                    passenger.Password = PasswordTextBox.Text;

                    MessageBox.Show("Sign up successful!");

                    // Create an instance of PassengerForm and pass both Airport and Passenger  
                    PassengerForm passengerForm = new PassengerForm(Program.schiphol, passenger);
                    passengerForm.Show();

                    // Hide this form  
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Passenger not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Passenger ID.");
            }
        }

        private void buttonConfirmData_Click(object sender, EventArgs e)
        {
            // Enable the password creation fields and the Sign up button
            PasswordTextBox.Enabled = true;
            ConfirmPasswordTextBox.Enabled = true;
            buttonSignUp.Enabled = true;

            // focus on the first password textbox
            PasswordTextBox.Focus();
        }

        private void PassengerSignUP_Load(object sender, EventArgs e)
        {
            // Set focus to the Passenger ID textbox when the form loads
            PassengerIDTextBox.Focus();




        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

