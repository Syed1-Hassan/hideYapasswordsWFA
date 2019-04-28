using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using hideYApasswordsWFA.classes;

namespace hideYApasswordsWFA.forms
{
    public partial class getPasswordFrmEmail : Form
    {
        public getPasswordFrmEmail()
        {
            InitializeComponent();
        }

        private void GetPassFrmEmailBtn_Click(object sender, EventArgs e)
        {
            PassSecurity _passSecObj = new PassSecurity();
            decrypt _decryptObj = new decrypt();
            string filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\encryptedCode.txt";
            if (!(File.Exists(filename)) && getPassFrmEmailTxtbox.Text != "")
            {
               string fetchedPasswordFrmDir= _passSecObj.fetchPasswordFromDirectory(filename, getPassFrmEmailTxtbox.Text);
                string originalPassword = _decryptObj.funcDecrypt(fetchedPasswordFrmDir);
                MessageBox.Show("Your orignal password is :", originalPassword);
            }
        }

  



        

       
    }
}
