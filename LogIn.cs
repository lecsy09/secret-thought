using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using secret_thoughts;
using static secret_thoughts.SignUp;

namespace secret_thoughts
{
    public partial class Login : Form
    {
      
        public Login()
        {
            InitializeComponent();
           
        }
        public IDictionary <string, string> users = new Dictionary<string, string>();

        public string PassLog { get; private set; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string UserLog = UserLoginbx.Text;
        }
        private void PasswordLoginbx_TextChanged(object sender, EventArgs e)
        {
            string PassLog = PasswordLoginbx.Text;
        }
        private void done_Click(object sender, EventArgs e)
        {
            string UserLog = UserLoginbx.Text;
            string PassLog = PasswordLoginbx.Text;
            foreach (KeyValuePair<string, string> kvp in users)
            {
                if(kvp.Key == UserLog && kvp.Value == PassLog)
                {
                    MessageBox.Show("Log-in Successfully");
                    UserInformationInput inputProf = new UserInformationInput();
                    this.Hide();
                    inputProf.Show();
                }
                else if(kvp.Key != UserLog || kvp.Value != PassLog)
                {
                    lblPassUserNot.Visible = true;
                }
                else if (kvp.Key != UserLog && kvp.Value != PassLog)
                {
                    lblNotExist.Visible = true;
                }
            }
            lblNotExist.Visible = true;

        }

      
       

        private void back_Click(object sender, EventArgs e)
        {
            LogInOrSignUp main = new LogInOrSignUp();
            this.Hide();
            main.Show();    
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PasswordLoginbx.PasswordChar = '\0';
            }
            else
            {
                PasswordLoginbx.PasswordChar = '•';
            }
        }
    }
}
