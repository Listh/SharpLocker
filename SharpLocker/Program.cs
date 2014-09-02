using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpLocker
{
    static class Program
    {
        public static string programName = "SharpLocker";
        public static string programAuthor = "Listh";
        public static string programAuthorEmail = "listhsama@gmail.com";
        public static string currentYear = DateTime.Now.ToString("yyyy");
        public static string currentVersion = "v0.1";
        public static string currentDirectory = Directory.GetCurrentDirectory();
        public static string roamingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\" + programName;

        public static string masterLockPath = roamingDirectory + @"\masterLock"; // contains hashes and keys
        public static int masterLockValues = 4; // number of values in master lock path, change this when necessary
        public static string settingsPath = currentDirectory + @"\config.cfg";
        public static string descriptionPath = currentDirectory + @"\descriptions.sl";
        public static string passwordsPath = currentDirectory + @"\passwords.sl";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // if roamingDirectory doesn't exist, we need to create it
            if (!Directory.Exists(roamingDirectory)) {
                Directory.CreateDirectory(roamingDirectory);
            }
            // if master lock file does not exist, we need to set up
            if (!File.Exists(masterLockPath)) {
                Application.Run(new SetupForm());
            }
            if (!File.Exists(masterLockPath)) {
                MessageBox.Show("Hash and key values not detected. Please close this program and re-open.", "Hashes not found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Environment.Exit(0);
                Application.Exit();
            }
            LoadKeys();
            // Login
            Application.Run(new Login());
            // Checking for good login
            if (!Login.goodLogin) {
                Environment.Exit(0);
                Application.Exit();
            }
            if (Login.goodLogin) {
                Application.Run(new Menu());
            }
        }

        public static void WriteMasterLock(string pwhash, string saltkey, string vikey, string encryptedpass)
        {
            string[] writeLines = {pwhash, saltkey, vikey, encryptedpass};
            File.WriteAllLines(masterLockPath, writeLines);
        }

        public static void LoadKeys()
        {
            string[] loadMasterLock = File.ReadAllLines(masterLockPath);
            // check if amount of values is correct
            if (loadMasterLock.Length != masterLockValues) {
                DialogResult choice = MessageBox.Show("There is something wrong with your master password / keys file. You can fix this by deleting it and resetting your master password. Though, all of your stored passwords will be lost as a result. Do you want to perform this action?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (choice == DialogResult.Yes) {
                    File.Delete(masterLockPath);
                    MessageBox.Show("Your master password and keys / hashes have been deleted. You may now close and re-open SharpLocker.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Environment.Exit(0);
                    Application.Exit();
                }
                if (choice == DialogResult.No) {
                    DialogResult result = MessageBox.Show("Your master password and keys / hashes have not been deleted. However, as a result, saved credentials may not be decoded and displayed properly. Continue?", "Continue with operation?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No) {
                        Environment.Exit(0);
                        Application.Exit();
                    }
                }
            }
            Keys.PasswordHash = loadMasterLock[0];
            Keys.SaltKey = loadMasterLock[1];
            Keys.VIKey = loadMasterLock[2];
            Keys.EncryptedPass = loadMasterLock[3];
        }
    }
}
