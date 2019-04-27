namespace hideYApasswordsWFA.forms
{
    partial class getPassFrmPassword
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
            this.EnterPasswordtxt = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.GetPassFrmPasswordBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterPasswordtxt
            // 
            this.EnterPasswordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterPasswordtxt.CausesValidation = false;
            this.EnterPasswordtxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.EnterPasswordtxt.Enabled = false;
            this.EnterPasswordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterPasswordtxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EnterPasswordtxt.Location = new System.Drawing.Point(20, 15);
            this.EnterPasswordtxt.Multiline = true;
            this.EnterPasswordtxt.Name = "EnterPasswordtxt";
            this.EnterPasswordtxt.ReadOnly = true;
            this.EnterPasswordtxt.Size = new System.Drawing.Size(119, 16);
            this.EnterPasswordtxt.TabIndex = 6;
            this.EnterPasswordtxt.TabStop = false;
            this.EnterPasswordtxt.Text = "Enter Password";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(155, 15);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(200, 20);
            this.passwordTextbox.TabIndex = 7;
            // 
            // GetPassFrmPasswordBtn
            // 
            this.GetPassFrmPasswordBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GetPassFrmPasswordBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetPassFrmPasswordBtn.ForeColor = System.Drawing.Color.Black;
            this.GetPassFrmPasswordBtn.Location = new System.Drawing.Point(355, 41);
            this.GetPassFrmPasswordBtn.Name = "GetPassFrmPasswordBtn";
            this.GetPassFrmPasswordBtn.Size = new System.Drawing.Size(67, 23);
            this.GetPassFrmPasswordBtn.TabIndex = 8;
            this.GetPassFrmPasswordBtn.Text = "Enter";
            this.GetPassFrmPasswordBtn.UseVisualStyleBackColor = false;
            // 
            // getPassFrmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 76);
            this.Controls.Add(this.GetPassFrmPasswordBtn);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.EnterPasswordtxt);
            this.Name = "getPassFrmPassword";
            this.Text = "Get Password From Hidden Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnterPasswordtxt;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button GetPassFrmPasswordBtn;
    }
}