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
    public partial class Login : Form
    {

        public static bool goodLogin = false;

        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.SharpLocker_Icon;
            this.Text = Program.programName + " " + "-" + " " + "Login";
            buttonLogin.Enabled = false;
            textBoxInput.PasswordChar = '\u25CF';
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxInput.Text)) {
                buttonLogin.Enabled = false;
                return;
            }
            buttonLogin.Enabled = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if ((Keys.Encrypt(textBoxInput.Text) == Keys.EncryptedPass) && (textBoxInput.Text == Keys.Decrypt(Keys.EncryptedPass))) {
                goodLogin = true;
                MessageBox.Show("Master password entered successfully. Welcome back!", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                this.Dispose();
            }
            else {
                textBoxInput.Text = String.Empty;
                MessageBox.Show("Incorrect password. Try again.", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void buttonView_MouseDown(object sender, EventArgs e)
        {
            textBoxInput.PasswordChar = '\0';
        }
        private void buttonView_MouseUp(object sender, EventArgs e)
        {
            textBoxInput.PasswordChar = '\u25CF';
        }
    }
}
