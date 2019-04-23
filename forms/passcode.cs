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
        private TextBox emailTextbox;
        private TextBox UseEmailText;
    
        public passcode()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.UseEmailText = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UseEmailText
            // 
            this.UseEmailText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UseEmailText.CausesValidation = false;
            this.UseEmailText.Cursor = System.Windows.Forms.Cursors.Default;
            this.UseEmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseEmailText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UseEmailText.Location = new System.Drawing.Point(50, 84);
            this.UseEmailText.Multiline = true;
            this.UseEmailText.Name = "UseEmailText";
            this.UseEmailText.ReadOnly = true;
            this.UseEmailText.Size = new System.Drawing.Size(130, 41);
            this.UseEmailText.TabIndex = 5;
            this.UseEmailText.TabStop = false;
            this.UseEmailText.Text = "Enter 3 Digit Passcode";
            this.UseEmailText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(50, 177);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.PasswordChar = '*';
            this.emailTextbox.Size = new System.Drawing.Size(130, 20);
            this.emailTextbox.TabIndex = 6;
            // 
            // passcode
            // 
            this.ClientSize = new System.Drawing.Size(234, 361);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.UseEmailText);
            this.Name = "passcode";
            this.Text = "Enter Passcode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
    }
}
