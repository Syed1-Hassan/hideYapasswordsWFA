namespace hideYaPasswordWFA
{
    partial class Get_Password
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
            this.UseEncryptPassButton = new System.Windows.Forms.Button();
            this.getPassEmailTxt = new System.Windows.Forms.TextBox();
            this.getPassEncKeyTxt = new System.Windows.Forms.TextBox();
            this.UseEmailButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UseEncryptPassButton
            // 
            this.UseEncryptPassButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UseEncryptPassButton.ForeColor = System.Drawing.Color.Black;
            this.UseEncryptPassButton.Location = new System.Drawing.Point(279, 231);
            this.UseEncryptPassButton.Name = "UseEncryptPassButton";
            this.UseEncryptPassButton.Size = new System.Drawing.Size(108, 34);
            this.UseEncryptPassButton.TabIndex = 2;
            this.UseEncryptPassButton.Text = "Use Encrypted Key";
            this.UseEncryptPassButton.UseVisualStyleBackColor = false;
            // 
            // getPassEmailTxt
            // 
            this.getPassEmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.getPassEmailTxt.CausesValidation = false;
            this.getPassEmailTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.getPassEmailTxt.Enabled = false;
            this.getPassEmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getPassEmailTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.getPassEmailTxt.Location = new System.Drawing.Point(35, 75);
            this.getPassEmailTxt.Multiline = true;
            this.getPassEmailTxt.Name = "getPassEmailTxt";
            this.getPassEmailTxt.ReadOnly = true;
            this.getPassEmailTxt.Size = new System.Drawing.Size(170, 35);
            this.getPassEmailTxt.TabIndex = 3;
            this.getPassEmailTxt.TabStop = false;
            this.getPassEmailTxt.Text = "Get password via Entering Email";
            // 
            // getPassEncKeyTxt
            // 
            this.getPassEncKeyTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.getPassEncKeyTxt.CausesValidation = false;
            this.getPassEncKeyTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.getPassEncKeyTxt.Enabled = false;
            this.getPassEncKeyTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getPassEncKeyTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.getPassEncKeyTxt.Location = new System.Drawing.Point(35, 231);
            this.getPassEncKeyTxt.Multiline = true;
            this.getPassEncKeyTxt.Name = "getPassEncKeyTxt";
            this.getPassEncKeyTxt.ReadOnly = true;
            this.getPassEncKeyTxt.Size = new System.Drawing.Size(170, 34);
            this.getPassEncKeyTxt.TabIndex = 4;
            this.getPassEncKeyTxt.TabStop = false;
            this.getPassEncKeyTxt.Text = "Get Password via Pasting Encrypted Key in the text file";
            // 
            // UseEmailButton
            // 
            this.UseEmailButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UseEmailButton.ForeColor = System.Drawing.Color.Black;
            this.UseEmailButton.Location = new System.Drawing.Point(279, 75);
            this.UseEmailButton.Name = "UseEmailButton";
            this.UseEmailButton.Size = new System.Drawing.Size(108, 35);
            this.UseEmailButton.TabIndex = 1;
            this.UseEmailButton.Text = "Use Email";
            this.UseEmailButton.UseVisualStyleBackColor = false;
            // 
            // Get_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.getPassEncKeyTxt);
            this.Controls.Add(this.getPassEmailTxt);
            this.Controls.Add(this.UseEncryptPassButton);
            this.Controls.Add(this.UseEmailButton);
            this.MaximizeBox = false;
            this.Name = "Get_Password";
            this.Text = "Get_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UseEncryptPassButton;
        private System.Windows.Forms.TextBox getPassEmailTxt;
        private System.Windows.Forms.TextBox getPassEncKeyTxt;
        private System.Windows.Forms.Button UseEmailButton;
    }
}