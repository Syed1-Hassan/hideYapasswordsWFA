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
using hideYApasswordsWFA.classes;
namespace hideYaPasswordWFA
{
    public partial class passcode : Form
    {
       
        PassSecurity _PassSecObj = new PassSecurity();
        public bool IspasscodeRight = false;
        public string checkPasscodeTxtBox;
        private TextBox passcodeTxtBox;
        private Button enterPasscodeButton;
        private TextBox enterPassTxt;
    
        public passcode()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.enterPassTxt = new System.Windows.Forms.TextBox();
            this.passcodeTxtBox = new System.Windows.Forms.TextBox();
            this.enterPasscodeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterPassTxt
            // 
            this.enterPassTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enterPassTxt.CausesValidation = false;
            this.enterPassTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.enterPassTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterPassTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enterPassTxt.Location = new System.Drawing.Point(50, 41);
            this.enterPassTxt.Multiline = true;
            this.enterPassTxt.Name = "enterPassTxt";
            this.enterPassTxt.ReadOnly = true;
            this.enterPassTxt.Size = new System.Drawing.Size(130, 41);
            this.enterPassTxt.TabIndex = 5;
            this.enterPassTxt.TabStop = false;
            this.enterPassTxt.Text = "Enter 3 Digit Passcode";
            this.enterPassTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passcodeTxtBox
            // 
            this.passcodeTxtBox.Location = new System.Drawing.Point(70, 135);
            this.passcodeTxtBox.Name = "passcodeTxtBox";
            this.passcodeTxtBox.PasswordChar = '*';
            this.passcodeTxtBox.Size = new System.Drawing.Size(88, 20);
            this.passcodeTxtBox.TabIndex = 6;
            // 
            // enterPasscodeButton
            // 
            this.enterPasscodeButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.enterPasscodeButton.ForeColor = System.Drawing.Color.Black;
            this.enterPasscodeButton.Location = new System.Drawing.Point(80, 190);
            this.enterPasscodeButton.Name = "enterPasscodeButton";
            this.enterPasscodeButton.Size = new System.Drawing.Size(62, 25);
            this.enterPasscodeButton.TabIndex = 7;
            this.enterPasscodeButton.Text = "Enter";
            this.enterPasscodeButton.UseVisualStyleBackColor = false;
            this.enterPasscodeButton.Click += new System.EventHandler(this.enterPasscodeButton_Click);
            // 
            // passcode
            // 
            this.ClientSize = new System.Drawing.Size(234, 361);
            this.Controls.Add(this.enterPasscodeButton);
            this.Controls.Add(this.passcodeTxtBox);
            this.Controls.Add(this.enterPassTxt);
            this.MaximizeBox = false;
            this.Name = "passcode";
            this.Text = "Enter Passcode";
            this.Load += new System.EventHandler(this.passcode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }        
        private void enterPasscodeButton_Click(object sender, EventArgs e)
        {
            string filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\encryptedCode.txt";
            checkPasscodeTxtBox = passcodeTxtBox.Text;
           

            if (!(File.Exists(filename)) && checkPasscodeTxtBox != "" && checkPasscodeTxtBox.Length == 3)
            {
                _PassSecObj.savePasscode(checkPasscodeTxtBox, filename);
            }
            else if (File.Exists(filename) == true && this.passcodeTxtBox.Text.Length == 3)
            {
                string decryptedPasscode = _PassSecObj.decryptPasscode(_PassSecObj.fetchPasscodeFromDirectory(filename));
                if (decryptedPasscode != this.checkPasscodeTxtBox)
                {
                    MessageBox.Show("Invalid Passcode", "Program will END");
                    Environment.Exit(1);
                }
                else
                    IspasscodeRight = true;
            }
            else
            {
                MessageBox.Show("Invalid Passcode", "Program will END");
                Environment.Exit(1);
            }
            this.Close();
                       
          }

        private void passcode_Load(object sender, EventArgs e)
        {
            string filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\encryptedCode.txt";

        }

        

     

     

        
        

        

        
    }
}
