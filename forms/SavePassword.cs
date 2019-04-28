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

namespace hideYaPasswordWFA
{
    public partial class SavePassword : Form
    {
        hideYApasswords _hideYApassObj = new hideYApasswords();
        
        public SavePassword()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {           
            string filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\encryptedCode.txt";
            if (emailTextbox.Text != "" && passwordTextbox.Text != "")
            {
                encrypt _encryptObj = new encrypt();
                _encryptObj.saveEncrypt(emailTextbox.Text, _encryptObj.funcEncrypt(passwordTextbox.Text), filename);
                this.Close();
            }
            else
            {
                MessageBox.Show("invalid data entry", "Program will exit");
                Environment.Exit(1);
            }
        }
       
    }
}
