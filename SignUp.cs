using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace secret_thoughts
{
    public partial class SignUp : Form
    {

        public SignUp()
        {
            InitializeComponent();
         
        }

        private void Form2_Load(object sender, EventArgs e)
        {
         
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string usernames = UserSignUpbx.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string conpass = ConfirmPasswordBx.Text;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void passwordbx_TextChanged(object sender, EventArgs e)
        {
            string passwords = PasswordSignUPbx.Text; 

        }

        public void button2_Click(object sender, EventArgs e)
        {
            if(PasswordSignUPbx.Text == ConfirmPasswordBx.Text)
            {
                string UserSign = UserSignUpbx.Text;
                string PassSign = PasswordSignUPbx.Text;              
             
                Login login = new Login();
               login.users.Add(UserSign, PassSign);
                this.Hide();
                login.Show();


            }
            else
            {
               
                lblpassErr.Visible = true;
            }
              

        }


        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogInOrSignUp home = new LogInOrSignUp();
            this.Hide();
            home.Show();    
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PasswordSignUPbx.PasswordChar = '\0';
                ConfirmPasswordBx.PasswordChar = '\0';
            }
            else
            {
                PasswordSignUPbx.PasswordChar = '•';
                ConfirmPasswordBx.PasswordChar = '•';
            }
        }
    }
}

