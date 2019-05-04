using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form2 : Form
    {
        private User user;
        private ListNotes listNotes;
        private WebClient client = new WebClient();
        private FontDialog fontDialog = new FontDialog();
        private ColorDialog colorDialog = new ColorDialog();
        private int index;      //i use index so when update the list 

        public Form2(User user)
        {
            InitializeComponent();
            this.user = user;               //Get the user data from the first Form
            downloadNoteByUserID();         //Download All the users' Notes
            noteSideBar.SelectedIndex = 0;  //Start up with default select index 0
        }

        private void aboytToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /*
         * Show the note on text box when note is selected
         * */
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = noteSideBar.SelectedIndex;
            //get the note from listNotes and put it in riche text box using note id
            noteTextBox.Rtf = listNotes.notes[index].note;
        }

        #region Menu Strip


        //side bar strip menu
        private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            update(); //update befor crete new note
            NameValueCollection noteInfo = new NameValueCollection();
            string id = user.Id.ToString();
            noteInfo.Add("id", id);
            noteInfo.Add("request", "newNote");
            byte[] responseArray = client.UploadValues("http://syiner.com/C/functions.php", "POST", noteInfo);
            String responseString = Encoding.Default.GetString(responseArray);
            listNotes = JsonConvert.DeserializeObject<ListNotes>(responseString);
            updateNodeSideBar();
            this.Enabled = true;
        }
        private void newNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            update(); //update befor crete new note
            NameValueCollection noteInfo = new NameValueCollection();
            string id = user.Id.ToString();
            noteInfo.Add("id", id);
            noteInfo.Add("request", "newNote");
            byte[] responseArray = client.UploadValues("http://syiner.com/C/functions.php", "POST", noteInfo);
            String responseString = Encoding.Default.GetString(responseArray);
            listNotes = JsonConvert.DeserializeObject<ListNotes>(responseString);
            updateNodeSideBar();
            this.Enabled = true;
        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            update(); //update befor crete new note
            NameValueCollection noteInfo = new NameValueCollection();
            string note_id = Convert.ToString(listNotes.notes[noteSideBar.SelectedIndex].note_id);
            string user_id = user.Id.ToString();
            noteInfo.Add("note_id", note_id);
            noteInfo.Add("user_id", user_id);
            noteInfo.Add("request", "deletNote");
            byte[] responseArray = client.UploadValues("http://syiner.com/C/functions.php", "POST", noteInfo);
            String responseString = Encoding.Default.GetString(responseArray);
            listNotes = JsonConvert.DeserializeObject<ListNotes>(responseString);
            index--;
            updateNodeSideBar();
            this.Enabled = true;
        }

        //renaem
        private void changeNoteTittleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string value = listNotes.notes[noteSideBar.SelectedIndex].note_title;
            if (InputBox("Rename", "New title name:", ref value) == DialogResult.OK)
            {
                listNotes.notes[noteSideBar.SelectedIndex].note_title = value;
                updateNodeSideBar();
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                noteTextBox.SelectionFont = fontDialog.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                noteTextBox.SelectionColor = colorDialog.Color;
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noteTextBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noteTextBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noteTextBox.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noteTextBox.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noteTextBox.Redo();
        }

        private void viewRTFCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rtfCode = String.Empty;
            rtfCode = noteTextBox.SelectedRtf;
        }

        #endregion

        /*
         * Update Note in ListNotes when Text changed
         * */
        private void noteTextBox_TextChanged(object sender, EventArgs e)
        {
            listNotes.notes[noteSideBar.SelectedIndex].note = noteTextBox.Rtf; //update the current note
        }



        /*
         * Update the note and download it and save it in database
         * */
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            update();
            this.Enabled = true;
        }

        private void update()
        {
            string json = JsonConvert.SerializeObject(listNotes);
            NameValueCollection noteInfo = new NameValueCollection();
            string id = user.Id.ToString();
            noteInfo.Add("id", id);
            noteInfo.Add("json", json);
            noteInfo.Add("request", "update");

            byte[] responseArray = client.UploadValues("http://syiner.com/C/functions.php", "POST", noteInfo);
            String responseString = Encoding.Default.GetString(responseArray);
            listNotes = JsonConvert.DeserializeObject<ListNotes>(responseString);
            updateNodeSideBar();
        }

        private void downloadNoteByUserID()
        {
            this.Enabled = false;
            NameValueCollection userInfo = new NameValueCollection();
            string id = user.Id.ToString();
            userInfo.Add("id", id);
            userInfo.Add("request", "get");
            byte[] responseArray = client.UploadValues("http://syiner.com/C/functions.php", "POST", userInfo);
            String responseString = Encoding.Default.GetString(responseArray);
            listNotes = JsonConvert.DeserializeObject<ListNotes>(responseString);
            updateNodeSideBar();
            this.Enabled = true;
        }

        /*
         * Funcation to update the Note Side Bar when a new Note has been added or Deletie
         * */
        private void updateNodeSideBar()
        {
            noteSideBar.Items.Clear();
            for (int i = 0; i < listNotes.notes.Count(); i++)
            {
                String note = listNotes.notes[i].ToString();
                noteSideBar.Items.Add(note);
            }
            noteSideBar.SelectedIndex = index;
        }


        /*
         * Dialog with input prameter
         * */
        private static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

    }
}
