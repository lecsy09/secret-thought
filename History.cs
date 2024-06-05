using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace secret_thoughts
{
    
    public partial class History : Form
    {
        
        private List<(string FirstName, string MiddleName, string LastName, string Address, string Email, string Birthday, string DisplayName)> userInputLists;
        public static History _history;
        public History(List<(string FirstName, string MiddleName, string LastName, string Address, string Email, string Birthday, string DisplayName)> userInputLists)
        {
            InitializeComponent();
            this.userInputLists = userInputLists;
                
        }
        private void History_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < HistoryStorage.UserDiary.Count; i++)
            {
                panelhistory ph = new panelhistory();
                ph.Display(HistoryStorage.UserDiary[i]);
                HistoryContainer.Controls.Add(ph);
            }
        }
       
        private void BackToProfile_Click(object sender, EventArgs e)
        {
            PersonalProfile back =new PersonalProfile(userInputLists);
            back.Show();
            this.Hide();

        }
        private void HistoryContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
