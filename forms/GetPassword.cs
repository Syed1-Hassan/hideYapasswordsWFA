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
using hideYApasswordsWFA.forms;

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
            
        }

        private void UseEmailButton_Click(object sender, EventArgs e)
        {
            _passcodeObj.ShowDialog();
            if (_passcodeObj.IspasscodeRight==true)
            {
                 getPasswordFrmEmail _getpassfrmEmailObj = new getPasswordFrmEmail();
                 _getpassfrmEmailObj.Show();
            }
        }

        private void opnTxtFileButton_Click(object sender, EventArgs e)
        {
            string filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\encryptedCode.txt";

            System.IO.FileInfo fileObj = new System.IO.FileInfo(filename);
            fileObj.Attributes = System.IO.FileAttributes.ReadOnly;
            System.Diagnostics.Process.Start(fileObj.FullName);

        }

        private void UseEncryptPassButton_Click(object sender, EventArgs e)
        {
            _passcodeObj.ShowDialog();
            if (_passcodeObj.IspasscodeRight == true)
            {
                getPassFrmPassword _getpassFrmPasswordObj = new getPassFrmPassword();
                _getpassFrmPasswordObj.Show();
            }
        }

       

        
    }
}
