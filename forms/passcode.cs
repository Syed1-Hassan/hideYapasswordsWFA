using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hideYaPasswordWFA
{
    public partial class passcode : Form
    {
        private TextBox passcodeTxtBox;
        private TextBox enterPassTxt;
    
        public passcode()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.enterPassTxt = new System.Windows.Forms.TextBox();
            this.passcodeTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enterPassTxt
            // 
            this.enterPassTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enterPassTxt.CausesValidation = false;
            this.enterPassTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.enterPassTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterPassTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enterPassTxt.Location = new System.Drawing.Point(50, 84);
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
            this.passcodeTxtBox.Location = new System.Drawing.Point(50, 177);
            this.passcodeTxtBox.Name = "passcodeTxtBox";
            this.passcodeTxtBox.PasswordChar = '*';
            this.passcodeTxtBox.Size = new System.Drawing.Size(130, 20);
            this.passcodeTxtBox.TabIndex = 6;
            // 
            // passcode
            // 
            this.ClientSize = new System.Drawing.Size(234, 361);
            this.Controls.Add(this.passcodeTxtBox);
            this.Controls.Add(this.enterPassTxt);
            this.Name = "passcode";
            this.Text = "Enter Passcode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
    }
}
