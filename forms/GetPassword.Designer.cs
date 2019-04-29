namespace hideYaPasswordWFA
{
    partial class GetPassword
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
            this.opnTxtFileButton = new System.Windows.Forms.Button();
            this.opnfileTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UseEncryptPassButton
            // 
            this.UseEncryptPassButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UseEncryptPassButton.ForeColor = System.Drawing.Color.Black;
            this.UseEncryptPassButton.Location = new System.Drawing.Point(279, 158);
            this.UseEncryptPassButton.Name = "UseEncryptPassButton";
            this.UseEncryptPassButton.Size = new System.Drawing.Size(108, 34);
            this.UseEncryptPassButton.TabIndex = 2;
            this.UseEncryptPassButton.Text = "Use Key";
            this.UseEncryptPassButton.UseVisualStyleBackColor = false;
            this.UseEncryptPassButton.Click += new System.EventHandler(this.UseEncryptPassButton_Click);
            // 
            // getPassEmailTxt
            // 
            this.getPassEmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.getPassEmailTxt.CausesValidation = false;
            this.getPassEmailTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.getPassEmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getPassEmailTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.getPassEmailTxt.Location = new System.Drawing.Point(35, 58);
            this.getPassEmailTxt.Multiline = true;
            this.getPassEmailTxt.Name = "getPassEmailTxt";
            this.getPassEmailTxt.ReadOnly = true;
            this.getPassEmailTxt.Size = new System.Drawing.Size(170, 35);
            this.getPassEmailTxt.TabIndex = 3;
            this.getPassEmailTxt.TabStop = false;
            this.getPassEmailTxt.Text = "Get the RECENTLY added password via Entering Email";
            // 
            // getPassEncKeyTxt
            // 
            this.getPassEncKeyTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.getPassEncKeyTxt.CausesValidation = false;
            this.getPassEncKeyTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.getPassEncKeyTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getPassEncKeyTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.getPassEncKeyTxt.Location = new System.Drawing.Point(35, 158);
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
            this.UseEmailButton.Location = new System.Drawing.Point(279, 58);
            this.UseEmailButton.Name = "UseEmailButton";
            this.UseEmailButton.Size = new System.Drawing.Size(108, 35);
            this.UseEmailButton.TabIndex = 1;
            this.UseEmailButton.Text = "Use Email";
            this.UseEmailButton.UseVisualStyleBackColor = false;
            this.UseEmailButton.Click += new System.EventHandler(this.UseEmailButton_Click);
            // 
            // opnTxtFileButton
            // 
            this.opnTxtFileButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.opnTxtFileButton.ForeColor = System.Drawing.Color.Black;
            this.opnTxtFileButton.Location = new System.Drawing.Point(279, 280);
            this.opnTxtFileButton.Name = "opnTxtFileButton";
            this.opnTxtFileButton.Size = new System.Drawing.Size(108, 34);
            this.opnTxtFileButton.TabIndex = 5;
            this.opnTxtFileButton.Text = "Open Text File";
            this.opnTxtFileButton.UseVisualStyleBackColor = false;
            this.opnTxtFileButton.Click += new System.EventHandler(this.opnTxtFileButton_Click);
            // 
            // opnfileTxt
            // 
            this.opnfileTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.opnfileTxt.CausesValidation = false;
            this.opnfileTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.opnfileTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opnfileTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.opnfileTxt.Location = new System.Drawing.Point(35, 280);
            this.opnfileTxt.Multiline = true;
            this.opnfileTxt.Name = "opnfileTxt";
            this.opnfileTxt.ReadOnly = true;
            this.opnfileTxt.Size = new System.Drawing.Size(170, 34);
            this.opnfileTxt.TabIndex = 6;
            this.opnfileTxt.TabStop = false;
            this.opnfileTxt.Text = "Open Hidden Passwords Text File";
            // 
            // GetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.opnfileTxt);
            this.Controls.Add(this.opnTxtFileButton);
            this.Controls.Add(this.getPassEncKeyTxt);
            this.Controls.Add(this.getPassEmailTxt);
            this.Controls.Add(this.UseEncryptPassButton);
            this.Controls.Add(this.UseEmailButton);
            this.MaximizeBox = false;
            this.Name = "GetPassword";
            this.Text = "Get Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UseEncryptPassButton;
        private System.Windows.Forms.TextBox getPassEmailTxt;
        private System.Windows.Forms.TextBox getPassEncKeyTxt;
        private System.Windows.Forms.Button UseEmailButton;
        private System.Windows.Forms.Button opnTxtFileButton;
        private System.Windows.Forms.TextBox opnfileTxt;
    }
}