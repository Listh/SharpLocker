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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.SharpLocker_Icon;
            this.Text = Program.programName + " " + "-" + " " + "Master Password Change";

            textBoxConfirmCurrentPass.PasswordChar = '\u25CF';
            textBoxNewPass1.PasswordChar = '\u25CF';
            textBoxNewPass2.PasswordChar = '\u25CF';
            textBoxNewPass1.Enabled = false;
            textBoxNewPass2.Enabled = false;
            buttonChange.Enabled = false;
        }

        private void buttonConfirmCurrentPass_Click(object sender, EventArgs e)
        {
            if (Keys.Encrypt(textBoxConfirmCurrentPass.Text) != Keys.EncryptedPass) {
                textBoxConfirmCurrentPass.Text = String.Empty;
                MessageBox.Show("The password you entered was incorrect. Did you mistype something?", "Incorrect password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            buttonConfirmCurrentPass.Text = "Looks good!";
            buttonConfirmCurrentPass.Enabled = false;
            buttonChange.Enabled = true;
            textBoxConfirmCurrentPass.Enabled = false;
            textBoxNewPass1.Enabled = true;
            textBoxNewPass2.Enabled = true;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (textBoxNewPass1.Text != textBoxNewPass2.Text) {
                MessageBox.Show("The two passwords didn't match. Did you mistype something?", "Passwords don't match", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNewPass2.Text = String.Empty;
                textBoxNewPass1.Text = String.Empty;
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to change your master password?", "Confirm change", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.No) {
                textBoxNewPass2.Text = String.Empty;
                textBoxNewPass1.Text = String.Empty;
                return;
            }
            Program.WriteMasterLock(Keys.PasswordHash, Keys.SaltKey, Keys.VIKey, Keys.Encrypt(textBoxNewPass1.Text));
            Program.LoadKeys();
            this.Close();
            this.Dispose();
        }

        private void buttonView_MouseDown(object sender, EventArgs e)
        {
            if (textBoxConfirmCurrentPass.Enabled == true)
                textBoxConfirmCurrentPass.PasswordChar = '\0';
            textBoxNewPass1.PasswordChar = '\0';
            textBoxNewPass2.PasswordChar = '\0';
        }

        private void buttonView_MouseUp(object sender, EventArgs e)
        {
            if (textBoxConfirmCurrentPass.Enabled == true)
                textBoxConfirmCurrentPass.PasswordChar = '\u25CF';
            textBoxNewPass1.PasswordChar = '\u25CF';
            textBoxNewPass2.PasswordChar = '\u25CF';
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
