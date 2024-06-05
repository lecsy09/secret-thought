using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace secret_thoughts
{
    public partial class NoteEditor : Form
    {
        
        

        private List<(string FirstName, string MiddleName, string LastName, string Address, string Email, string Birthday, string DisplayName)> userInputLists;
    
       
        public NoteEditor(List<(string FirstName, string MiddleName, string LastName, string Address, string Email, string Birthday, string DisplayName)> userInputLists) 
        {
            InitializeComponent();
            
            this.userInputLists = userInputLists;
         
          

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your work has been saved.");
            string title = titlebx.Text;
            string notes = messageBx.Text;
            string today = dateNote.Value.ToString("MMMM d, yyyy");
            

            HistoryStorage.NoteEditor_AddedToUserDiary(title, today, notes);    


        }


      

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            messageBx.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            messageBx.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            messageBx.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            messageBx.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            messageBx.Paste();
        }

        private void titlebx_TextChanged(object sender, EventArgs e)
        {    
        }

        public void backToProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalProfile prof = new PersonalProfile(userInputLists);  
            this.Hide();
            prof.Show();
        }

        private void messageBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
          
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            messageBx.SelectAll();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            messageBx.Clear();
            titlebx.Clear();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
