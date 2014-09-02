using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpLocker
{
    public partial class NewSetup : Form
    {
        public static string firstDescription;
        public static string firstPassword;

        public NewSetup()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void NewSetup_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.SharpLocker_Icon;
            this.Text = Program.programName;
            textBoxPassword.PasswordChar = '\u25CF';
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDescription.Text) || string.IsNullOrEmpty(textBoxPassword.Text)) {
                MessageBox.Show("You're missing something.", "Missing field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            firstDescription = textBoxDescription.Text;
            firstPassword = textBoxPassword.Text;
            // Close
        }

        private void buttonToggle_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar == '\u25CF') {
                textBoxPassword.PasswordChar = '\0';
            }
            else {
                textBoxPassword.PasswordChar = '\u25CF';
            }
        }
    }
}
