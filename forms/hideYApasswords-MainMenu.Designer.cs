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
            this.get_Password = new System.Windows.Forms.TabPage();
            this.useEmailLbl = new System.Windows.Forms.Label();
            this.useKeyLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.set_Password = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lableEnterEmail = new System.Windows.Forms.Label();
            this.lableEnterPassword = new System.Windows.Forms.Label();
            this.savePsswrdBTN = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.UseKeyBTN = new System.Windows.Forms.Button();
            this.UseEmailBTN = new System.Windows.Forms.Button();
            this.showPasswordBTN = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            NoteLbl = new System.Windows.Forms.Label();
            mainMenu = new System.Windows.Forms.TabControl();
            this.get_Password.SuspendLayout();
            this.set_Password.SuspendLayout();
            mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // get_Password
            // 
            this.get_Password.Controls.Add(this.richTextBox1);
            this.get_Password.Controls.Add(this.showPasswordBTN);
            this.get_Password.Controls.Add(this.UseEmailBTN);
            this.get_Password.Controls.Add(this.UseKeyBTN);
            this.get_Password.Controls.Add(this.textBox4);
            this.get_Password.Controls.Add(this.textBox2);
            this.get_Password.Controls.Add(this.label1);
            this.get_Password.Controls.Add(NoteLbl);
            this.get_Password.Controls.Add(this.useKeyLbl);
            this.get_Password.Controls.Add(this.useEmailLbl);
            this.get_Password.Location = new System.Drawing.Point(4, 22);
            this.get_Password.Name = "get_Password";
            this.get_Password.Padding = new System.Windows.Forms.Padding(3);
            this.get_Password.Size = new System.Drawing.Size(602, 389);
            this.get_Password.TabIndex = 1;
            this.get_Password.Text = "Get password";
            this.get_Password.UseVisualStyleBackColor = true;
            this.get_Password.Click += new System.EventHandler(this.get_Password_Click);
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
            this.useEmailLbl.Click += new System.EventHandler(this.useEmailLbl_Click);
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
            // set_Password
            // 
            this.set_Password.Controls.Add(this.savePsswrdBTN);
            this.set_Password.Controls.Add(this.lableEnterPassword);
            this.set_Password.Controls.Add(this.lableEnterEmail);
            this.set_Password.Controls.Add(this.textBox3);
            this.set_Password.Controls.Add(this.textBox1);
            this.set_Password.Location = new System.Drawing.Point(4, 22);
            this.set_Password.Name = "set_Password";
            this.set_Password.Padding = new System.Windows.Forms.Padding(3);
            this.set_Password.Size = new System.Drawing.Size(602, 389);
            this.set_Password.TabIndex = 0;
            this.set_Password.Text = "Set password";
            this.set_Password.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(299, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(299, 204);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 2;
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
            // savePsswrdBTN
            // 
            this.savePsswrdBTN.Location = new System.Drawing.Point(409, 273);
            this.savePsswrdBTN.Name = "savePsswrdBTN";
            this.savePsswrdBTN.Size = new System.Drawing.Size(86, 36);
            this.savePsswrdBTN.TabIndex = 6;
            this.savePsswrdBTN.Text = "Save";
            this.savePsswrdBTN.UseVisualStyleBackColor = true;
            // 
            // mainMenu
            // 
            mainMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            mainMenu.Controls.Add(this.set_Password);
            mainMenu.Controls.Add(this.get_Password);
            mainMenu.Location = new System.Drawing.Point(12, 12);
            mainMenu.Name = "mainMenu";
            mainMenu.SelectedIndex = 0;
            mainMenu.Size = new System.Drawing.Size(610, 415);
            mainMenu.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(222, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(222, 150);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 20);
            this.textBox4.TabIndex = 10;
            // 
            // UseKeyBTN
            // 
            this.UseKeyBTN.Location = new System.Drawing.Point(444, 149);
            this.UseKeyBTN.Name = "UseKeyBTN";
            this.UseKeyBTN.Size = new System.Drawing.Size(121, 20);
            this.UseKeyBTN.TabIndex = 11;
            this.UseKeyBTN.Text = "Show Password";
            this.UseKeyBTN.UseVisualStyleBackColor = true;
            this.UseKeyBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // UseEmailBTN
            // 
            this.UseEmailBTN.Location = new System.Drawing.Point(444, 79);
            this.UseEmailBTN.Name = "UseEmailBTN";
            this.UseEmailBTN.Size = new System.Drawing.Size(121, 20);
            this.UseEmailBTN.TabIndex = 12;
            this.UseEmailBTN.Text = "Show Password";
            this.UseEmailBTN.UseVisualStyleBackColor = true;
            // 
            // showPasswordBTN
            // 
            this.showPasswordBTN.Location = new System.Drawing.Point(237, 199);
            this.showPasswordBTN.Name = "showPasswordBTN";
            this.showPasswordBTN.Size = new System.Drawing.Size(121, 39);
            this.showPasswordBTN.TabIndex = 13;
            this.showPasswordBTN.Text = "Show Hidden Password File";
            this.showPasswordBTN.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(40, 244);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(525, 123);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // hideYApasswords_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(mainMenu);
            this.Name = "hideYApasswords_MainMenu";
            this.Text = "hideYApasswords_MainMenu";
            this.get_Password.ResumeLayout(false);
            this.get_Password.PerformLayout();
            this.set_Password.ResumeLayout(false);
            this.set_Password.PerformLayout();
            mainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage get_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label useKeyLbl;
        private System.Windows.Forms.Label useEmailLbl;
        private System.Windows.Forms.TabPage set_Password;
        private System.Windows.Forms.Button savePsswrdBTN;
        private System.Windows.Forms.Label lableEnterPassword;
        private System.Windows.Forms.Label lableEnterEmail;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button UseEmailBTN;
        private System.Windows.Forms.Button UseKeyBTN;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button showPasswordBTN;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}