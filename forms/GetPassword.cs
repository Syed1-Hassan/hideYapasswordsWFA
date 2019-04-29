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
        email_and_key_text_file txtfileObj = new email_and_key_text_file();
        public GetPassword()
        {
            InitializeComponent();
        }
       
        private void UseEmailButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Only the recently added password would be shown so only type the most recent email you saved", "Warning !");
            _passcodeObj.ShowDialog();
            if (_passcodeObj.IspasscodeRight==true)
            {
                 getPasswordFrmEmail _getpassfrmEmailObj = new getPasswordFrmEmail();
                 _getpassfrmEmailObj.Show();
            }
        }

        private void opnTxtFileButton_Click(object sender, EventArgs e)
        {
            _passcodeObj.ShowDialog();
            if (_passcodeObj.IspasscodeRight == true)
            {
                txtfileObj.Show();

            }
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
