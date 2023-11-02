namespace AppGui
{
    partial class SettingMenu
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
            this.lotOutBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.bookTicketBtn = new System.Windows.Forms.Button();
            this.viewScheduleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lotOutBtn
            // 
            this.lotOutBtn.Location = new System.Drawing.Point(0, 338);
            this.lotOutBtn.Name = "lotOutBtn";
            this.lotOutBtn.Size = new System.Drawing.Size(116, 109);
            this.lotOutBtn.TabIndex = 0;
            this.lotOutBtn.Text = "Logout";
            this.lotOutBtn.UseVisualStyleBackColor = true;
            this.lotOutBtn.Click += new System.EventHandler(this.lotOutBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Location = new System.Drawing.Point(0, 226);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(116, 106);
            this.settingsBtn.TabIndex = 1;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // bookTicketBtn
            // 
            this.bookTicketBtn.Location = new System.Drawing.Point(0, 5);
            this.bookTicketBtn.Name = "bookTicketBtn";
            this.bookTicketBtn.Size = new System.Drawing.Size(116, 99);
            this.bookTicketBtn.TabIndex = 2;
            this.bookTicketBtn.Text = "Book Tickets";
            this.bookTicketBtn.UseVisualStyleBackColor = true;
            this.bookTicketBtn.Click += new System.EventHandler(this.bookTicketBtn_Click);
            // 
            // viewScheduleBtn
            // 
            this.viewScheduleBtn.Location = new System.Drawing.Point(0, 110);
            this.viewScheduleBtn.Name = "viewScheduleBtn";
            this.viewScheduleBtn.Size = new System.Drawing.Size(116, 110);
            this.viewScheduleBtn.TabIndex = 3;
            this.viewScheduleBtn.Text = "View Schedule";
            this.viewScheduleBtn.UseVisualStyleBackColor = true;
            this.viewScheduleBtn.Click += new System.EventHandler(this.viewScheduleBtn_Click);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewScheduleBtn);
            this.Controls.Add(this.bookTicketBtn);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.lotOutBtn);
            this.Name = "Booking";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lotOutBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button bookTicketBtn;
        private System.Windows.Forms.Button viewScheduleBtn;
    }
}