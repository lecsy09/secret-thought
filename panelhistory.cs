using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secret_thoughts
{
    public partial class panelhistory : UserControl
    {
         
        public panelhistory()
        {
            InitializeComponent();
        }
       public void Display(Tuple<string,string,string>Data)
        {
            lbltitle.Text = Data.Item1;
            lbldate.Text = Data.Item2;
            messageReadBox.Text = Data.Item3;
            
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void messageReadBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void panelhistory_Load(object sender, EventArgs e)
        {
            
        }
       

        private void Delete_Click_1(object sender, EventArgs e)
        {
            HistoryStorage.RemoveItem(lbltitle.Text, lbldate.Text, messageReadBox.Text);
            History._history.HistoryContainer.Controls.Clear();
            for (int i = 0; i < HistoryStorage.UserDiary.Count; i++)
            {
                panelhistory ph = new panelhistory();
                ph.Display(HistoryStorage.UserDiary[i]);
                History._history.HistoryContainer.Controls.Add(ph);
            }
        }
    }
}
