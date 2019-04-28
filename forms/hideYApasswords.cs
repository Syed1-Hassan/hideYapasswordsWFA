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
namespace hideYaPasswordWFA
{
    public partial class hideYApasswords : Form
    {
        private Button GetPasswordButton;
        private TextBox savePassTxt;
        private TextBox getPassTxt;
        private Button SavePasswordButton;
    
        public hideYApasswords()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.GetPasswordButton = new System.Windows.Forms.Button();
            this.SavePasswordButton = new System.Windows.Forms.Button();
            this.savePassTxt = new System.Windows.Forms.TextBox();
            this.getPassTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GetPasswordButton
            // 
            this.GetPasswordButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GetPasswordButton.ForeColor = System.Drawing.Color.Black;
            this.GetPasswordButton.Location = new System.Drawing.Point(272, 221);
            this.GetPasswordButton.Name = "GetPasswordButton";
            this.GetPasswordButton.Size = new System.Drawing.Size(100, 35);
            this.GetPasswordButton.TabIndex = 1;
            this.GetPasswordButton.Text = "Get Password";
            this.GetPasswordButton.UseVisualStyleBackColor = false;
            this.GetPasswordButton.Click += new System.EventHandler(this.GetPasswordButton_Click);
            // 
            // SavePasswordButton
            // 
            this.SavePasswordButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SavePasswordButton.ForeColor = System.Drawing.Color.Black;
            this.SavePasswordButton.Location = new System.Drawing.Point(272, 74);
            this.SavePasswordButton.Name = "SavePasswordButton";
            this.SavePasswordButton.Size = new System.Drawing.Size(100, 35);
            this.SavePasswordButton.TabIndex = 0;
            this.SavePasswordButton.Text = "Save Password";
            this.SavePasswordButton.UseVisualStyleBackColor = false;
            this.SavePasswordButton.Click += new System.EventHandler(this.SavePasswordButton_Click);
            // 
            // savePassTxt
            // 
            this.savePassTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.savePassTxt.CausesValidation = false;
            this.savePassTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.savePassTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePassTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.savePassTxt.Location = new System.Drawing.Point(25, 74);
            this.savePassTxt.Multiline = true;
            this.savePassTxt.Name = "savePassTxt";
            this.savePassTxt.ReadOnly = true;
            this.savePassTxt.Size = new System.Drawing.Size(170, 35);
            this.savePassTxt.TabIndex = 4;
            this.savePassTxt.TabStop = false;
            this.savePassTxt.Text = "To Save Password click Save Password";
            this.savePassTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // getPassTxt
            // 
            this.getPassTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.getPassTxt.CausesValidation = false;
            this.getPassTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.getPassTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getPassTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.getPassTxt.HideSelection = false;
            this.getPassTxt.Location = new System.Drawing.Point(25, 221);
            this.getPassTxt.Multiline = true;
            this.getPassTxt.Name = "getPassTxt";
            this.getPassTxt.ReadOnly = true;
            this.getPassTxt.Size = new System.Drawing.Size(170, 35);
            this.getPassTxt.TabIndex = 5;
            this.getPassTxt.TabStop = false;
            this.getPassTxt.Text = "To Get Hidden Password click Get Password";
            this.getPassTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hideYApasswords
            // 
            this.AccessibleName = "";
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.getPassTxt);
            this.Controls.Add(this.savePassTxt);
            this.Controls.Add(this.SavePasswordButton);
            this.Controls.Add(this.GetPasswordButton);
            this.MaximizeBox = false;
            this.Name = "hideYApasswords";
            this.Text = "hideYapasswords";
            this.Load += new System.EventHandler(this.hideYApasswords_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SavePasswordButton_Click(object sender, EventArgs e)
        {
            SavePassword _savPassObj = new SavePassword();
            _savPassObj.Show();
        }

        private void GetPasswordButton_Click(object sender, EventArgs e)
        {
            GetPassword _getPassObj = new GetPassword();
            _getPassObj.ShowDialog();
        }

        private void hideYApasswords_Load(object sender, EventArgs e)
        {
            string filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\encryptedCode.txt";

            if (File.Exists(filename) == false)
            {
                MessageBox.Show("First Save 3 Digit Passcode");
                passcode _passObj = new passcode();
                _passObj.ShowDialog();
                return;        
            }
        }

      
    }
}
