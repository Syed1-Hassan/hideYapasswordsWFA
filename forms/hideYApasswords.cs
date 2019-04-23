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
    public partial class hideYApasswords : Form
    {
        private Button GetPasswordButton;
        private TextBox UseEmailText;
        private TextBox textBox1;
        private Button SavePasswordButton;
    
        public hideYApasswords()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.GetPasswordButton = new System.Windows.Forms.Button();
            this.SavePasswordButton = new System.Windows.Forms.Button();
            this.UseEmailText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GetPasswordButton
            // 
            this.GetPasswordButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GetPasswordButton.ForeColor = System.Drawing.Color.Black;
            this.GetPasswordButton.Location = new System.Drawing.Point(262, 221);
            this.GetPasswordButton.Name = "GetPasswordButton";
            this.GetPasswordButton.Size = new System.Drawing.Size(100, 35);
            this.GetPasswordButton.TabIndex = 1;
            this.GetPasswordButton.Text = "Get Password";
            this.GetPasswordButton.UseVisualStyleBackColor = false;
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
            // 
            // UseEmailText
            // 
            this.UseEmailText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UseEmailText.CausesValidation = false;
            this.UseEmailText.Cursor = System.Windows.Forms.Cursors.Default;
            this.UseEmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseEmailText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UseEmailText.Location = new System.Drawing.Point(25, 74);
            this.UseEmailText.Multiline = true;
            this.UseEmailText.Name = "UseEmailText";
            this.UseEmailText.ReadOnly = true;
            this.UseEmailText.Size = new System.Drawing.Size(170, 35);
            this.UseEmailText.TabIndex = 4;
            this.UseEmailText.TabStop = false;
            this.UseEmailText.Text = "To Save Password click Save Password";
            this.UseEmailText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UseEmailText.TextChanged += new System.EventHandler(this.UseEmailText_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.CausesValidation = false;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(25, 221);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(170, 35);
            this.textBox1.TabIndex = 5;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "To Get Hidden Password click Get Password";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hideYApasswords
            // 
            this.AccessibleName = "";
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.UseEmailText);
            this.Controls.Add(this.SavePasswordButton);
            this.Controls.Add(this.GetPasswordButton);
            this.MaximizeBox = false;
            this.Name = "hideYApasswords";
            this.Text = "hideYapasswords";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void UseEmailText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
