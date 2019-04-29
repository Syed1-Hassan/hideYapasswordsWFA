using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace hideYApasswordsWFA.forms
{
    public partial class email_and_key_text_file : Form
    {
        
        public email_and_key_text_file()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\encryptedCode.txt";
            StreamReader filetxt = new StreamReader(filename);
            string text = filetxt.ReadToEnd();
            this.richTextBox1.Text = text;
            filetxt.Close();
        }
    }
}
