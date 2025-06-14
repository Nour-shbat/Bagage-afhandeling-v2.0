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
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxEnterID.Text == "")
            {
                MessageBox.Show("U moet eerst een ID invullen.");
                return;
            }
            string EnterredPW = textBoxPassWord.Text;
            if (int.TryParse(textBoxEnterID.Text, out int EnterredID))
            {
                foreach (var Employee in Program.schiphol.Employees)
                {
                    if (Employee.Employee_ID == EnterredID && Employee.PassWord == EnterredPW)
                    {
                        textBoxFirstName.Clear();
                        textBoxFirstName.Text = Employee.FirstName;
                        textBoxLastName.Clear();
                        textBoxLastName.Text = Employee.LastName;
                        textBoxRole.Clear();
                        textBoxRole.Text = Employee.Role;
                        textBoxEmployeeID.Clear();
                        textBoxEmployeeID.Text = Employee.Employee_ID.ToString();

                        textBoxEnterID.Clear();
                        textBoxPassWord.Clear();
                        ButtonVisible(true);
                        return;
                    }
                }
                MessageBox.Show("Wachtwoord of ID is onjuist");
            }
            else
            {
                MessageBox.Show("Wachtwoord of ID is onjuist");
            }
            textBoxEnterID.Clear();
            textBoxPassWord.Clear();
        }


        //Acties voor de medewerker
        private void buttonSeeStatus_Click(object sender, EventArgs e)
        {

        }

        private void buttonCheckin_Click(object sender, EventArgs e)
        {

        }

        private void buttonStatusChange_Click(object sender, EventArgs e)
        {

        }

        private void buttonChangeCorrectPlane_Click(object sender, EventArgs e)
        {

        }

        //Eigen methodes
        public void ButtonVisible(bool visible)
        {
            buttonSeeStatus.Visible = visible;
            buttonCheckin.Visible = visible;
            buttonStatusChange.Visible = visible;
            buttonChangeCorrectPlane.Visible = visible;
        }

        private void textBoxEnterID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}