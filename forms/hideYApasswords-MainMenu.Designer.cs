namespace hideYApasswordWFA
{
    partial class hideYApasswords_MainMenu
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
            System.Windows.Forms.Label NoteLbl;
            System.Windows.Forms.TabControl mainMenu;
            this.set_Password = new System.Windows.Forms.TabPage();
            this.savePsswrdBTN = new System.Windows.Forms.Button();
            this.lableEnterPassword = new System.Windows.Forms.Label();
            this.lableEnterEmail = new System.Windows.Forms.Label();
            this.txtBoxEnterPswrd = new System.Windows.Forms.TextBox();
            this.txtBoxEnterEmail = new System.Windows.Forms.TextBox();
            this.Show_Password = new System.Windows.Forms.TabPage();
            this.FilerichTxtBox = new System.Windows.Forms.RichTextBox();
            this.showPasswordBTN = new System.Windows.Forms.Button();
            this.UseEmailBTN = new System.Windows.Forms.Button();
            this.UseKeyBTN = new System.Windows.Forms.Button();
            this.PswrdfrmKeyTxtBox = new System.Windows.Forms.TextBox();
            this.PswrdfrmEmailTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.useKeyLbl = new System.Windows.Forms.Label();
            this.useEmailLbl = new System.Windows.Forms.Label();
            NoteLbl = new System.Windows.Forms.Label();
            mainMenu = new System.Windows.Forms.TabControl();
            mainMenu.SuspendLayout();
            this.set_Password.SuspendLayout();
            this.Show_Password.SuspendLayout();
            this.SuspendLayout();
            // 
            // NoteLbl
            // 
            NoteLbl.AutoSize = true;
            NoteLbl.CausesValidation = false;
            NoteLbl.Enabled = false;
            NoteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            NoteLbl.Location = new System.Drawing.Point(26, 29);
            NoteLbl.Name = "NoteLbl";
            NoteLbl.Size = new System.Drawing.Size(43, 13);
            NoteLbl.TabIndex = 7;
            NoteLbl.Text = "NOTE :";
            // 
            // mainMenu
            // 
            mainMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            mainMenu.Controls.Add(this.set_Password);
            mainMenu.Controls.Add(this.Show_Password);
            mainMenu.Location = new System.Drawing.Point(12, 12);
            mainMenu.Name = "mainMenu";
            mainMenu.SelectedIndex = 0;
            mainMenu.Size = new System.Drawing.Size(610, 415);
            mainMenu.TabIndex = 0;
            // 
            // set_Password
            // 
            this.set_Password.Controls.Add(this.savePsswrdBTN);
            this.set_Password.Controls.Add(this.lableEnterPassword);
            this.set_Password.Controls.Add(this.lableEnterEmail);
            this.set_Password.Controls.Add(this.txtBoxEnterPswrd);
            this.set_Password.Controls.Add(this.txtBoxEnterEmail);
            this.set_Password.Location = new System.Drawing.Point(4, 22);
            this.set_Password.Name = "set_Password";
            this.set_Password.Padding = new System.Windows.Forms.Padding(3);
            this.set_Password.Size = new System.Drawing.Size(602, 389);
            this.set_Password.TabIndex = 0;
            this.set_Password.Text = "Set password";
            this.set_Password.UseVisualStyleBackColor = true;
            // 
            // savePsswrdBTN
            // 
            this.savePsswrdBTN.Location = new System.Drawing.Point(409, 273);
            this.savePsswrdBTN.Name = "savePsswrdBTN";
            this.savePsswrdBTN.Size = new System.Drawing.Size(86, 36);
            this.savePsswrdBTN.TabIndex = 6;
            this.savePsswrdBTN.Text = "Save";
            this.savePsswrdBTN.UseVisualStyleBackColor = true;
            this.savePsswrdBTN.Click += new System.EventHandler(this.savePsswrdBTN_Click_1);
            // 
            // lableEnterPassword
            // 
            this.lableEnterPassword.AutoSize = true;
            this.lableEnterPassword.CausesValidation = false;
            this.lableEnterPassword.Enabled = false;
            this.lableEnterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableEnterPassword.Location = new System.Drawing.Point(75, 204);
            this.lableEnterPassword.Name = "lableEnterPassword";
            this.lableEnterPassword.Size = new System.Drawing.Size(121, 20);
            this.lableEnterPassword.TabIndex = 5;
            this.lableEnterPassword.Text = "Enter Password";
            // 
            // lableEnterEmail
            // 
            this.lableEnterEmail.AutoSize = true;
            this.lableEnterEmail.CausesValidation = false;
            this.lableEnterEmail.Enabled = false;
            this.lableEnterEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableEnterEmail.Location = new System.Drawing.Point(75, 79);
            this.lableEnterEmail.Name = "lableEnterEmail";
            this.lableEnterEmail.Size = new System.Drawing.Size(91, 20);
            this.lableEnterEmail.TabIndex = 4;
            this.lableEnterEmail.Text = "Enter Email";
            // 
            // txtBoxEnterPswrd
            // 
            this.txtBoxEnterPswrd.Location = new System.Drawing.Point(299, 204);
            this.txtBoxEnterPswrd.Name = "txtBoxEnterPswrd";
            this.txtBoxEnterPswrd.Size = new System.Drawing.Size(150, 20);
            this.txtBoxEnterPswrd.TabIndex = 2;
            // 
            // txtBoxEnterEmail
            // 
            this.txtBoxEnterEmail.Location = new System.Drawing.Point(299, 79);
            this.txtBoxEnterEmail.Name = "txtBoxEnterEmail";
            this.txtBoxEnterEmail.Size = new System.Drawing.Size(150, 20);
            this.txtBoxEnterEmail.TabIndex = 0;
            // 
            // Show_Password
            // 
            this.Show_Password.Controls.Add(this.FilerichTxtBox);
            this.Show_Password.Controls.Add(this.showPasswordBTN);
            this.Show_Password.Controls.Add(this.UseEmailBTN);
            this.Show_Password.Controls.Add(this.UseKeyBTN);
            this.Show_Password.Controls.Add(this.PswrdfrmKeyTxtBox);
            this.Show_Password.Controls.Add(this.PswrdfrmEmailTxtBox);
            this.Show_Password.Controls.Add(this.label1);
            this.Show_Password.Controls.Add(NoteLbl);
            this.Show_Password.Controls.Add(this.useKeyLbl);
            this.Show_Password.Controls.Add(this.useEmailLbl);
            this.Show_Password.Location = new System.Drawing.Point(4, 22);
            this.Show_Password.Name = "Show_Password";
            this.Show_Password.Padding = new System.Windows.Forms.Padding(3);
            this.Show_Password.Size = new System.Drawing.Size(602, 389);
            this.Show_Password.TabIndex = 1;
            this.Show_Password.Text = "Show password";
            this.Show_Password.UseVisualStyleBackColor = true;
            // 
            // FilerichTxtBox
            // 
            this.FilerichTxtBox.Location = new System.Drawing.Point(40, 244);
            this.FilerichTxtBox.Name = "FilerichTxtBox";
            this.FilerichTxtBox.Size = new System.Drawing.Size(525, 123);
            this.FilerichTxtBox.TabIndex = 14;
            this.FilerichTxtBox.Text = "";
            // 
            // showPasswordBTN
            // 
            this.showPasswordBTN.Location = new System.Drawing.Point(237, 199);
            this.showPasswordBTN.Name = "showPasswordBTN";
            this.showPasswordBTN.Size = new System.Drawing.Size(121, 39);
            this.showPasswordBTN.TabIndex = 13;
            this.showPasswordBTN.Text = "Show Hidden Password File";
            this.showPasswordBTN.UseVisualStyleBackColor = true;
            this.showPasswordBTN.Click += new System.EventHandler(this.showPasswordBTN_Click);
            // 
            // UseEmailBTN
            // 
            this.UseEmailBTN.Location = new System.Drawing.Point(444, 79);
            this.UseEmailBTN.Name = "UseEmailBTN";
            this.UseEmailBTN.Size = new System.Drawing.Size(121, 20);
            this.UseEmailBTN.TabIndex = 12;
            this.UseEmailBTN.Text = "Show Password";
            this.UseEmailBTN.UseVisualStyleBackColor = true;
            this.UseEmailBTN.Click += new System.EventHandler(this.UseEmailBTN_Click);
            // 
            // UseKeyBTN
            // 
            this.UseKeyBTN.Location = new System.Drawing.Point(444, 149);
            this.UseKeyBTN.Name = "UseKeyBTN";
            this.UseKeyBTN.Size = new System.Drawing.Size(121, 20);
            this.UseKeyBTN.TabIndex = 11;
            this.UseKeyBTN.Text = "Show Password";
            this.UseKeyBTN.UseVisualStyleBackColor = true;
            this.UseKeyBTN.Click += new System.EventHandler(this.UseKeyBTN_Click);
            // 
            // PswrdfrmKeyTxtBox
            // 
            this.PswrdfrmKeyTxtBox.Location = new System.Drawing.Point(222, 150);
            this.PswrdfrmKeyTxtBox.Name = "PswrdfrmKeyTxtBox";
            this.PswrdfrmKeyTxtBox.Size = new System.Drawing.Size(150, 20);
            this.PswrdfrmKeyTxtBox.TabIndex = 10;
            // 
            // PswrdfrmEmailTxtBox
            // 
            this.PswrdfrmEmailTxtBox.Location = new System.Drawing.Point(222, 80);
            this.PswrdfrmEmailTxtBox.Name = "PswrdfrmEmailTxtBox";
            this.PswrdfrmEmailTxtBox.Size = new System.Drawing.Size(150, 20);
            this.PswrdfrmEmailTxtBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Only recently added email will work if you don\'t remeber the last email you saved" +
    " please use key from the text file.";
            // 
            // useKeyLbl
            // 
            this.useKeyLbl.AutoSize = true;
            this.useKeyLbl.CausesValidation = false;
            this.useKeyLbl.Enabled = false;
            this.useKeyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useKeyLbl.Location = new System.Drawing.Point(25, 150);
            this.useKeyLbl.Name = "useKeyLbl";
            this.useKeyLbl.Size = new System.Drawing.Size(68, 20);
            this.useKeyLbl.TabIndex = 6;
            this.useKeyLbl.Text = "Use Key";
            // 
            // useEmailLbl
            // 
            this.useEmailLbl.AutoSize = true;
            this.useEmailLbl.CausesValidation = false;
            this.useEmailLbl.Enabled = false;
            this.useEmailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useEmailLbl.Location = new System.Drawing.Point(25, 80);
            this.useEmailLbl.Name = "useEmailLbl";
            this.useEmailLbl.Size = new System.Drawing.Size(116, 20);
            this.useEmailLbl.TabIndex = 5;
            this.useEmailLbl.Text = "Use Last Email";
            // 
            // hideYApasswords_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(mainMenu);
            this.Name = "hideYApasswords_MainMenu";
            this.Text = "hideYApasswords_MainMenu";
            mainMenu.ResumeLayout(false);
            this.set_Password.ResumeLayout(false);
            this.set_Password.PerformLayout();
            this.Show_Password.ResumeLayout(false);
            this.Show_Password.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Show_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label useKeyLbl;
        private System.Windows.Forms.Label useEmailLbl;
        private System.Windows.Forms.TabPage set_Password;
        private System.Windows.Forms.Button savePsswrdBTN;
        private System.Windows.Forms.Label lableEnterPassword;
        private System.Windows.Forms.Label lableEnterEmail;
        private System.Windows.Forms.TextBox txtBoxEnterPswrd;
        private System.Windows.Forms.TextBox txtBoxEnterEmail;
        private System.Windows.Forms.TextBox PswrdfrmEmailTxtBox;
        private System.Windows.Forms.Button UseEmailBTN;
        private System.Windows.Forms.Button UseKeyBTN;
        private System.Windows.Forms.TextBox PswrdfrmKeyTxtBox;
        private System.Windows.Forms.Button showPasswordBTN;
        private System.Windows.Forms.RichTextBox FilerichTxtBox;
    }
}