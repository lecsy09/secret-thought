using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace secret_thoughts
{
    public partial class PersonalProfile : Form
    {

        private List<(string FirstName, string MiddleName, string LastName, string Address, string eMail, string Birthday, string displayName)> userInputLists;

        public PersonalProfile(List<(string Firstname, string MiddleName, string LastName, string Address, string eMail, string Birthday, string displayName)> userInputLists)
        {
            InitializeComponent();
             this.userInputLists = userInputLists;
        }
 
        
        private void Form4_Load(object sender, EventArgs e)
        {    
                var userInput = userInputLists[0];
                lblAddress.Text = userInput.Address;
                lblBirthday.Text = userInput.Birthday;
                lblDisplayName.Text = userInput.displayName;
                lblEmail.Text = userInput.eMail;
            if(!string.IsNullOrWhiteSpace(userInput.MiddleName))
            {
                lblName.Text = $"{userInput.FirstName} {userInput.MiddleName}. {userInput.LastName}";
            }
            else
            {
                lblName.Text = $"{userInput.FirstName} {userInput.LastName}";
            }

            
        }
      
        
        private void button4_Click(object sender, EventArgs e)
        {
            LogInOrSignUp main = new LogInOrSignUp();
            this.Hide();
            main.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            NoteEditor note = new NoteEditor(userInputLists);
            this.Hide();
            note.Show();
        }

        public void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }


        private void hisbtn_Click(object sender, EventArgs e)
        {
            
            History history = new History(userInputLists);
            History._history = history;
            this.Hide();
            history.Show();

        }

      

        public void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void lblAdd_Click(object sender, EventArgs e)
        {

        }

       public void lblName_Click(object sender, EventArgs e)
        {

        }
        
        public void lblEmail_Click(object sender, EventArgs e)
        {
        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblBirthday_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
