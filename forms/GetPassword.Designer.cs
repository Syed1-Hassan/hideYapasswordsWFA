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
            this.UseEmailButton = new System.Windows.Forms.Button();
            this.UseEncryptPassButton = new System.Windows.Forms.Button();
            this.UseEmailText = new System.Windows.Forms.TextBox();
            this.UseEncryptPassText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UseEmailButton
            // 
            this.UseEmailButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UseEmailButton.ForeColor = System.Drawing.Color.Black;
            this.UseEmailButton.Location = new System.Drawing.Point(385, 71);
            this.UseEmailButton.Name = "UseEmailButton";
            this.UseEmailButton.Size = new System.Drawing.Size(108, 22);
            this.UseEmailButton.TabIndex = 1;
            this.UseEmailButton.Text = "Use Email";
            this.UseEmailButton.UseVisualStyleBackColor = false;
            // 
            // UseEncryptPassButton
            // 
            this.UseEncryptPassButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UseEncryptPassButton.ForeColor = System.Drawing.Color.Black;
            this.UseEncryptPassButton.Location = new System.Drawing.Point(385, 215);
            this.UseEncryptPassButton.Name = "UseEncryptPassButton";
            this.UseEncryptPassButton.Size = new System.Drawing.Size(108, 22);
            this.UseEncryptPassButton.TabIndex = 2;
            this.UseEncryptPassButton.Text = "Use Encrypted Key";
            this.UseEncryptPassButton.UseVisualStyleBackColor = false;
            // 
            // UseEmailText
            // 
            this.UseEmailText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UseEmailText.CausesValidation = false;
            this.UseEmailText.Cursor = System.Windows.Forms.Cursors.Default;
            this.UseEmailText.Enabled = false;
            this.UseEmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseEmailText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UseEmailText.Location = new System.Drawing.Point(12, 24);
            this.UseEmailText.Multiline = true;
            this.UseEmailText.Name = "UseEmailText";
            this.UseEmailText.ReadOnly = true;
            this.UseEmailText.Size = new System.Drawing.Size(170, 35);
            this.UseEmailText.TabIndex = 3;
            this.UseEmailText.TabStop = false;
            this.UseEmailText.Text = "Get password via entering Email";
            // 
            // UseEncryptPassText
            // 
            this.UseEncryptPassText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UseEncryptPassText.CausesValidation = false;
            this.UseEncryptPassText.Cursor = System.Windows.Forms.Cursors.Default;
            this.UseEncryptPassText.Enabled = false;
            this.UseEncryptPassText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseEncryptPassText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UseEncryptPassText.Location = new System.Drawing.Point(12, 164);
            this.UseEncryptPassText.Multiline = true;
            this.UseEncryptPassText.Name = "UseEncryptPassText";
            this.UseEncryptPassText.ReadOnly = true;
            this.UseEncryptPassText.Size = new System.Drawing.Size(170, 34);
            this.UseEncryptPassText.TabIndex = 4;
            this.UseEncryptPassText.TabStop = false;
            this.UseEncryptPassText.Text = "Get Password via Pasting Encrypted Key in the text file";
            // 
            // Get_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 372);
            this.Controls.Add(this.UseEncryptPassText);
            this.Controls.Add(this.UseEmailText);
            this.Controls.Add(this.UseEncryptPassButton);
            this.Controls.Add(this.UseEmailButton);
            this.Name = "Get_Password";
            this.Text = "Get_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UseEmailButton;
        private System.Windows.Forms.Button UseEncryptPassButton;
        private System.Windows.Forms.TextBox UseEmailText;
        private System.Windows.Forms.TextBox UseEncryptPassText;
    }
}