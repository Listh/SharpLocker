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
    public partial class SetupForm : Form
    {

        private static string input1;
        private static string input2;

        public SetupForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void SetupForm_Load(object sender, EventArgs e)
        {
            // load necessary resources, materials, set variables, etc.
            this.Icon = Properties.Resources.SharpLocker_Icon;
            this.Text = Program.programName + " " + "Setup";

            labelIntro.Text = "Hi! Welcome to SharpLocker, the simple password manager!" + Environment.NewLine + "To begin, please input your desired master password." + Environment.NewLine + "This will be required to view all your passwords, so keep it safe!";

            textBoxInput2.Enabled = false;
            buttonNext1.Enabled = false;
            buttonNext2.Enabled = false;

            // set textbox password characters
            textBoxInput1.PasswordChar = '\u25CF';
            textBoxInput2.PasswordChar = '\u25CF';
        }

        private void textBoxInput1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxInput1.Text)) {
                buttonNext1.Enabled = false;
                return;
            }
            buttonNext1.Enabled = true;
        }

        private void buttonView1_MouseDown(object sender, EventArgs e)
        {
            textBoxInput1.PasswordChar = '\0';
        }
        private void buttonView1_MouseUp(object sender, EventArgs e)
        {
            textBoxInput1.PasswordChar = '\u25CF';
        }

        private void buttonNext1_Click(object sender, EventArgs e)
        {
            input1 = textBoxInput1.Text;
            buttonNext1.Enabled = false;
            buttonNext2.Enabled = true;
            textBoxInput1.Enabled = false;
            buttonView1.Enabled = false;
            textBoxInput2.Enabled = true;
        }

        private void Reset(bool resetGlobals)
        {
            textBoxInput1.Enabled = true;
            textBoxInput1.Focus();
            textBoxInput1.Text = String.Empty;
            buttonNext1.Enabled = false;
            buttonNext2.Enabled = false;
            buttonView1.Enabled = true;
            textBoxInput2.Text = String.Empty;
            textBoxInput2.Enabled = false;
            if (resetGlobals) {
                input1 = String.Empty;
                input2 = String.Empty;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset(true);
        }

        private void buttonNext2_Click(object sender, EventArgs e)
        {
            input2 = textBoxInput2.Text;
            if (input1 != input2) {
                Reset(true);
                MessageBox.Show("The two passwords did not match." + " " + " Please try again.", "Incorrect confirmation.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Reset(false);
            SetEncryption();
            MessageBox.Show("Your master password has been set. Please remember it! You can also change it in the Options menu.", "Master password set.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            this.Dispose();
        }

        public static void SetEncryption()
        {
            Random rnd = new Random();
            // PasswordHash: I guess could be anything.
            Keys.PasswordHash = DateTime.Now.ToString("MMddyyyy");
            // SaltKey: Probably anything.
            Keys.SaltKey = "$@|_t{" + Environment.MachineName + "}|<3Y{" + (rnd.Next(1, 1337)) + "}" + "|RandomValues{" + (rnd.Next(1, 1337) * rnd.Next(1, 1337)).ToString() + "}";
            // VIKey: 16 values, hexadecimal characters. Start with an @ sign. The alphabetical characters can be either upper or lower case.
            // Available characters: 22
            // ABCDEFabcdef1234567890
            Keys.VIKey = "@"; // Start with @.
            Random virnd = new Random();
            for (int i = 2; i <= 16; i++) {
                int append = rnd.Next(0, 23);
                switch (append) {
                    #region super huge switch block
                    case 0:
                        Keys.VIKey += "a";
                        break;
                    case 1:
                        Keys.VIKey += "b";
                        break;
                    case 2:
                        Keys.VIKey += "c";
                        break;
                    case 3:
                        Keys.VIKey += "d";
                        break;
                    case 4:
                        Keys.VIKey += "e";
                        break;
                    case 5:
                        Keys.VIKey += "f";
                        break;
                    case 6:
                        Keys.VIKey += "A";
                        break;
                    case 7:
                        Keys.VIKey += "B";
                        break;
                    case 8:
                        Keys.VIKey += "C";
                        break;
                    case 9:
                        Keys.VIKey += "D";
                        break;
                    case 10:
                        Keys.VIKey += "E";
                        break;
                    case 11:
                        Keys.VIKey += "F";
                        break;
                    case 12:
                        Keys.VIKey += "0";
                        break;
                    case 13:
                        Keys.VIKey += "1";
                        break;
                    case 14:
                        Keys.VIKey += "2";
                        break;
                    case 15:
                        Keys.VIKey += "3";
                        break;
                    case 16:
                        Keys.VIKey += "4";
                        break;
                    case 17:
                        Keys.VIKey += "5";
                        break;
                    case 18:
                        Keys.VIKey += "6";
                        break;
                    case 19:
                        Keys.VIKey += "7";
                        break;
                    case 20:
                        Keys.VIKey += "8";
                        break;
                    case 21:
                        Keys.VIKey += "9";
                        break;
                    default:
                        Keys.VIKey += "0";
                        break;
                    #endregion
                }
            }
            // Keys.VIKey = "@1B2c3D4e5F6g7H8";
            Keys.EncryptedPass = Keys.Encrypt(input1);

            // save these to master lock file
            string[] saveMasterLock = {Keys.PasswordHash, Keys.SaltKey, Keys.VIKey, Keys.EncryptedPass};
            File.WriteAllLines(Program.masterLockPath, saveMasterLock);
        }

    }
}
