namespace AppGui
{
    partial class Login
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
            this.AccountBtn = new System.Windows.Forms.Button();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.displayIncorrect = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccountBtn
            // 
            this.AccountBtn.Location = new System.Drawing.Point(370, 271);
            this.AccountBtn.Name = "AccountBtn";
            this.AccountBtn.Size = new System.Drawing.Size(75, 23);
            this.AccountBtn.TabIndex = 1;
            this.AccountBtn.Text = "Create Account";
            this.AccountBtn.UseVisualStyleBackColor = true;
            this.AccountBtn.Click += new System.EventHandler(this.AccountBtn_Click);
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(354, 55);
            this.emailTextbox.Multiline = true;
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(116, 39);
            this.emailTextbox.TabIndex = 2;
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(354, 100);
            this.passTextBox.Multiline = true;
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(116, 41);
            this.passTextBox.TabIndex = 3;
            // 
            // displayIncorrect
            // 
            this.displayIncorrect.Location = new System.Drawing.Point(354, 162);
            this.displayIncorrect.Name = "displayIncorrect";
            this.displayIncorrect.Size = new System.Drawing.Size(100, 20);
            this.displayIncorrect.TabIndex = 4;
            this.displayIncorrect.TextChanged += new System.EventHandler(this.displayIncorrect_TextChanged);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(370, 223);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.displayIncorrect);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.AccountBtn);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AccountBtn;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox displayIncorrect;
        private System.Windows.Forms.Button loginBtn;
    }
}

