using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Bagage_Afhandeling
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void buttonGoToSignUP_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();
            // Open the Sign Up form
            var signUpForm = new PassengerSignUP();
            signUpForm.Show();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            // Try to parse the entered Passenger ID
            if (int.TryParse(textBoxPassengerID.Text, out int id))
            {
                // Find the passenger by ID
                var passenger = Program.schiphol.Passengers.FirstOrDefault(p => p.Passenger_ID == id);

                if (passenger != null)
                {
                    // Check if the password matches
                    if (!string.IsNullOrEmpty(passenger.Password) && passenger.Password == textBoxPassword.Text)
                    {
                        // Successful login: open the main passenger form
                        this.Hide();
                        var mainForm = new PassengerForm(Program.schiphol, passenger);
                        mainForm.Show();
                    }
                    else
                    {
                        // Incorrect password
                        MessageBox.Show("Incorrect password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxPassword.Clear();
                    }
                }
                else
                {
                    // Passenger not found
                    MessageBox.Show("Passenger not found. Please check the Passenger ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxPassword.Clear();
                }
            }
            else
            {
                // Not a valid number
                MessageBox.Show("Please enter a valid numeric Passenger ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassengerID.Clear();
                textBoxPassword.Clear();
            }
        }

        // 
        private void textBoxPassword_TextChanged(object sender, EventArgs e) { }

        private void SignIn_Load(object sender, EventArgs e) { }
    }
}
