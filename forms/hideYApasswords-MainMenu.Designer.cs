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
            System.Windows.Forms.TabControl mainMenu;
            this.set_Password = new System.Windows.Forms.TabPage();
            this.get_Password = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            mainMenu = new System.Windows.Forms.TabControl();
            mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            mainMenu.Controls.Add(this.set_Password);
            mainMenu.Controls.Add(this.get_Password);
            mainMenu.Controls.Add(this.tabPage3);
            mainMenu.Location = new System.Drawing.Point(12, 12);
            mainMenu.Name = "mainMenu";
            mainMenu.SelectedIndex = 0;
            mainMenu.Size = new System.Drawing.Size(610, 415);
            mainMenu.TabIndex = 0;
            // 
            // set_Password
            // 
            this.set_Password.Location = new System.Drawing.Point(4, 22);
            this.set_Password.Name = "set_Password";
            this.set_Password.Padding = new System.Windows.Forms.Padding(3);
            this.set_Password.Size = new System.Drawing.Size(602, 389);
            this.set_Password.TabIndex = 0;
            this.set_Password.Text = "Set password";
            this.set_Password.UseVisualStyleBackColor = true;
            // 
            // get_Password
            // 
            this.get_Password.Location = new System.Drawing.Point(4, 22);
            this.get_Password.Name = "get_Password";
            this.get_Password.Padding = new System.Windows.Forms.Padding(3);
            this.get_Password.Size = new System.Drawing.Size(602, 389);
            this.get_Password.TabIndex = 1;
            this.get_Password.Text = "Get password";
            this.get_Password.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(602, 389);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // hideYApasswords_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(mainMenu);
            this.Name = "hideYApasswords_MainMenu";
            this.Text = "hideYApasswords_MainMenu";
            mainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage set_Password;
        private System.Windows.Forms.TabPage get_Password;
        private System.Windows.Forms.TabPage tabPage3;
    }
}