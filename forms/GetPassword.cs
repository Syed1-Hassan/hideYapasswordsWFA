using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using hideYApasswordsWFA.classes;
using System.Windows.Forms;

namespace hideYaPasswordWFA
{
    public partial class GetPassword : Form
    {
        passcode _passcodeObj=new passcode();
        PassSecurity _PassSecObj = new PassSecurity();
        public GetPassword()
        {
            InitializeComponent();
        }
       
        private void GetPassword_Load(object sender, EventArgs e)
        {
            string filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\encryptedCode.txt";

            if (File.Exists(filename) && _passcodeObj.checkPasscodeTxtBox.Length == 3)
            {
                string decryptedPasscode = _PassSecObj.decryptPasscode(_PassSecObj.fetchPasscodeFromDirectory(filename));
                if (decryptedPasscode != _passcodeObj.checkPasscodeTxtBox)
                {
                    MessageBox.Show("Invalid Passcode", "Program will END");
                    Environment.Exit(1);
                }
            }
        }

        private void UseEmailButton_Click(object sender, EventArgs e)
        {
           
        }

        
    }
}
