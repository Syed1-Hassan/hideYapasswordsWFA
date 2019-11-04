using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hideYApasswordsWFA.classes;
using System.IO;

namespace hideYApasswordWFA
{
    public partial class hideYApasswords_MainMenu : Form
    {
        public hideYApasswords_MainMenu()
        {
            InitializeComponent();
        }

        private void UseKeyBTN_Click(object sender, EventArgs e)
        {
            decrypt _decryptObj = new decrypt();
            string filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\encryptedCode.txt";

            if ((File.Exists(filename)) && PswrdfrmKeyTxtBox.Text != "")
            {
                string originalPassword = _decryptObj.funcDecrypt(PswrdfrmKeyTxtBox.Text);
                MessageBox.Show(originalPassword, "Your orignal password is :");
            }
        }

        private void UseEmailBTN_Click(object sender, EventArgs e)
        {
            PassSecurity _passSecObj = new PassSecurity();
            decrypt _decryptObj = new decrypt();
            string filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\encryptedCode.txt";
            if ((File.Exists(filename)) && PswrdfrmEmailTxtBox.Text != "")
            {
                string fetchedPasswordFrmDir = _passSecObj.fetchPasswordFromDirectory(filename, PswrdfrmEmailTxtBox.Text);
                string originalPassword = _decryptObj.funcDecrypt(fetchedPasswordFrmDir);
                MessageBox.Show(originalPassword, "Your orignal password is :");
            }
        }

        private void showPasswordBTN_Click(object sender, EventArgs e)
        {
            string filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\encryptedCode.txt";
            StreamReader filetxt = new StreamReader(filename);
            string text = filetxt.ReadToEnd();
            this.FilerichTxtBox.Text = text;
            filetxt.Close();
        }


        private void savePsswrdBTN_Click_1(object sender, EventArgs e)
        {
            string filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\encryptedCode.txt";
            if (txtBoxEnterEmail.Text != "" && txtBoxEnterPswrd.Text != "")
            {
                encrypt _encryptObj = new encrypt();
                _encryptObj.saveEncrypt(txtBoxEnterEmail.Text, _encryptObj.funcEncrypt(txtBoxEnterPswrd.Text), filename);
                txtBoxEnterEmail.Text = "";
                txtBoxEnterPswrd.Text = "";

            }
            else
            {
                MessageBox.Show("invalid data entry", "Program will exit");
                Environment.Exit(1);
            }
        }
    }
}
