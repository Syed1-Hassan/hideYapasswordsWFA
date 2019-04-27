namespace hideYApasswordsWFA.forms
{
    partial class getPasswordFrmEmail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.getPassFrmEmailTxt = new System.Windows.Forms.TextBox();
            this.getPassFrmEmailTxtbox = new System.Windows.Forms.TextBox();
            this.GetPassFrmPasswordBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getPassFrmEmailTxt
            // 
            this.getPassFrmEmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.getPassFrmEmailTxt.CausesValidation = false;
            this.getPassFrmEmailTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.getPassFrmEmailTxt.Enabled = false;
            this.getPassFrmEmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getPassFrmEmailTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.getPassFrmEmailTxt.Location = new System.Drawing.Point(20, 15);
            this.getPassFrmEmailTxt.Multiline = true;
            this.getPassFrmEmailTxt.Name = "getPassFrmEmailTxt";
            this.getPassFrmEmailTxt.ReadOnly = true;
            this.getPassFrmEmailTxt.Size = new System.Drawing.Size(119, 16);
            this.getPassFrmEmailTxt.TabIndex = 4;
            this.getPassFrmEmailTxt.TabStop = false;
            this.getPassFrmEmailTxt.Text = "Enter Email Adress";
            // 
            // getPassFrmEmailTxtbox
            // 
            this.getPassFrmEmailTxtbox.Location = new System.Drawing.Point(155, 15);
            this.getPassFrmEmailTxtbox.Name = "getPassFrmEmailTxtbox";
            this.getPassFrmEmailTxtbox.Size = new System.Drawing.Size(200, 20);
            this.getPassFrmEmailTxtbox.TabIndex = 5;
            // 
            // GetPassFrmPasswordBtn
            // 
            this.GetPassFrmPasswordBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GetPassFrmPasswordBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetPassFrmPasswordBtn.ForeColor = System.Drawing.Color.Black;
            this.GetPassFrmPasswordBtn.Location = new System.Drawing.Point(355, 41);
            this.GetPassFrmPasswordBtn.Name = "GetPassFrmPasswordBtn";
            this.GetPassFrmPasswordBtn.Size = new System.Drawing.Size(67, 23);
            this.GetPassFrmPasswordBtn.TabIndex = 9;
            this.GetPassFrmPasswordBtn.Text = "Enter";
            this.GetPassFrmPasswordBtn.UseVisualStyleBackColor = false;
            // 
            // getPasswordFrmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 76);
            this.Controls.Add(this.GetPassFrmPasswordBtn);
            this.Controls.Add(this.getPassFrmEmailTxtbox);
            this.Controls.Add(this.getPassFrmEmailTxt);
            this.Name = "getPasswordFrmEmail";
            this.Text = "Get Password From Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox getPassFrmEmailTxt;
        private System.Windows.Forms.TextBox getPassFrmEmailTxtbox;
        private System.Windows.Forms.Button GetPassFrmPasswordBtn;
    }
}