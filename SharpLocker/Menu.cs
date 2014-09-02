using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpLocker
{
    public partial class Menu : Form
    {

        private static string[] descriptionArray = {"testing", "hi", "wtf", "madoka", "ano", "tsutsukakushi", "devin", "alex", "devin"};
        private static string[] passwordArray = {"purposes", "chezzy", "shit", "magica", "hana", "tsukiko", "is gay", "is cool", "is racist"};

        public Menu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.SharpLocker_Icon;
            this.Text = Program.programName;
            columnHeaderDescription.TextAlign = HorizontalAlignment.Right;
            buttonEdit.Enabled = false;
            buttonRemove.Enabled = false;

            if (!File.Exists(Program.descriptionPath) || !File.Exists(Program.passwordsPath)) {
                // Show dialog to create a new first entry.
                // Don't forget to encrypt them before storing them in the array.
                NewSetup newSetup = new NewSetup();
                newSetup.ShowDialog();
                newSetup.Close();
                newSetup.Dispose();
                // Encrypt passed variables here.
            }
            LoadCredentials();
            
        }

        private void LoadCredentials()
        {
            // Load descriptions and passwords from file.
            string[] dLines = File.ReadAllLines(Program.descriptionPath);
            string[] pLines = File.ReadAllLines(Program.passwordsPath);

            // Decrypting descriptions and passwords from file.
            for (int i = 0; i <= (dLines.Length); i++) {
                dLines[i] = Keys.Decrypt(dLines[i]);
                pLines[i] = Keys.Decrypt(dLines[i]);
            }

            // Loading the decrypted descriptions and passwords into the listview
            for (int i = 0; i <= (dLines.Length - 1); i++) {
                var descriptionList = new ListViewItem();
                descriptionList.Text = descriptionArray[i];
                descriptionList.SubItems.Add(passwordArray[i]);
                listViewList.Items.Add(descriptionList);
            }
        }

        private void changeMasterPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword();
            change.ShowDialog();
            change.Close();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string line1 = Program.programName + " " + "by " + Program.programAuthor + " " + "(" + Program.currentVersion + ")";
            string line2 = Program.programName + " " + "is a program designed to easily store your passwords. It stores your credentials, encrypted, with keys and hashes that are unique for everyone. No hash and dual-key combinations are the same.";
            string line3 = "Coded in the C# programming language. Copyright " + "\u00A9 " + Program.currentYear + " " + Program.programAuthor + " (Independent).";
            MessageBox.Show(line1 + "\r\n" + "\r\n" + line2 + "\r\n" + "\r\n" + line3, "About " + Program.programName);
        }

        private void listViewList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewList.SelectedItems.Count < 1) {
                buttonEdit.Enabled = false;
                buttonRemove.Enabled = false;
            }
            else {
                buttonEdit.Enabled = true;
                buttonRemove.Enabled = true;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Do you really want to delete the password for \"" + listViewList.SelectedItems[0].Text + "\"?", "Really delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.No) {
                return;
            }
            int itemIndex = Array.FindIndex(descriptionArray, row => row.Contains(listViewList.SelectedItems[0].Text));
            var foos = new List<String>(descriptionArray);
            foos.RemoveAt(itemIndex);
            descriptionArray = foos.ToArray();
            MessageBox.Show("New array: ");
            for (int i = 0; i <= (descriptionArray.Length - 1); i++) {
                MessageBox.Show("Text: " + descriptionArray[i] + " | Index: " + i);
            }
        }

        public void RefreshList()
        {
            // This method will refresh the list view after changes.
            listViewList.Items.Clear();
            LoadCredentials();
        }

    }
}
