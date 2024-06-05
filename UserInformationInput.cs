using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace secret_thoughts
{
    public partial class UserInformationInput : Form
    {
        private List<(string FirstName, string MiddleName, string LastName, string Address, string eMail, string Birthday, string displayName)> userInputLists = new List<(string, string,string,string,string,string,string)>();

        public DateTime birth;
        public UserInformationInput()
        {
            InitializeComponent();
      
        }
       
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
             
        }

        private void dnebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(displayNamebox.Text) ||
                string.IsNullOrWhiteSpace(firstnamebox.Text) ||
                string.IsNullOrWhiteSpace(surname.Text) ||
                string.IsNullOrWhiteSpace(emailbox.Text))
            {
                MessageBox.Show("Fill all the credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!emailbox.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Please enter a valid Gmail address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                string firstname = firstnamebox.Text;
                string middlename = middleinitialbox.Text;
                string lastname = surname.Text;
                string Email = emailbox.Text;
                string address = addressbox.Text;
                string DisplayName = displayNamebox.Text;
                string birthday = bdayTime.Value.ToString("MMMM d, yyyy");

             

                var userInput = (FirstName: firstname, MiddleName: middlename, LastName: lastname, Address: address, eMail: Email, Birthday: birthday, displayName: DisplayName);
                userInputLists.Add(userInput);
                PersonalProfile form = new PersonalProfile(userInputLists);
                form.Show();
                this.Hide();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void sur_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void locbx_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            bdayTime.CustomFormat = "MMMM d, yyyy";
            bdayTime.Font = new Font("Segoe Script", 12, FontStyle.Bold);
        }
    }
}
