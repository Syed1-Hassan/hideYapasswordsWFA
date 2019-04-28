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
    public partial class getPassFrmPassword : Form
    {
        public getPassFrmPassword()
        {
            InitializeComponent();
        }

        private void GetPassFrmPasswordBtn_Click(object sender, EventArgs e)
        {
            decrypt _decryptObj = new decrypt();
            string filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\encryptedCode.txt";

            if ((File.Exists(filename)) && GetpassFrmHiddenPassTextbox.Text != "")
            {
                string originalPassword= _decryptObj.funcDecrypt(GetpassFrmHiddenPassTextbox.Text);
                MessageBox.Show(originalPassword,"Your orignal password is :" );
            }
          
        }
    }
}
